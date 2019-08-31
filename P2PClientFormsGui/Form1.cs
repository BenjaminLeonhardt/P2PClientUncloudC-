using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace P2PClientFormsGui {
    public partial class ClientForm : Form {
        public ClientForm() {
            InitializeComponent();
            myDelegate = new AddListItem(AddListItemMethod);
            peersListe.FullRowSelect = true;
        }
        public delegate void AddListItem();
        public AddListItem myDelegate;
        private void AddListItemMethod() {
            peersListe.Items.Clear();
            foreach (Peer item in Peers) {
                ListViewItem newItem = new ListViewItem(item.id);
                newItem.SubItems.Add(item.name);
                newItem.SubItems.Add(item.ip);
                newItem.SubItems.Add("Windows 10");

                peersListe.Items.Add(newItem);
            }
        }

        bool mitServerVerbunden = false;
        public Socket socket;
        string IpAdresse;
        List<Peer> Peers = new List<Peer>();
        Server server;
        IPEndPoint localEndPointServer;
        private void verbindenButton_Click(object sender, EventArgs e) {

            string HostName = Dns.GetHostName();

            IPHostEntry hostInfo = Dns.GetHostEntry(HostName);
            IpAdresse = hostInfo.AddressList[hostInfo.AddressList.Length - 1].ToString();

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            if (localEndPointServer == null) {
                localEndPointServer = new IPEndPoint(IPAddress.Any, int.Parse(ServerPortText.Text) + 1);
                server = new Server(10, 1024);
                server.Init();
                server.Start(localEndPointServer);
            }
            

            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse(ServerIPText.Text), int.Parse(ServerPortText.Text));
            try {
                socket.Connect(localEndPoint);
            } catch (Exception ex) {
                Console.Write(ex);
            }

            if (!mitServerVerbunden) {
                ThreadStart start = new ThreadStart(sendThreadMethod);
                Thread SendThread = new Thread(start);
                SendThread.IsBackground = true;
                SendThread.Start();

                ThreadStart start2 = new ThreadStart(listenThreadMethod);
                Thread listenThread = new Thread(start2);
                listenThread.IsBackground = true;
                listenThread.Start();
            }


            connectionText.Text = "Verbunden mit " + ServerIPText.Text + ":" + ServerPortText.Text;
            connectionText.ForeColor = Color.Green;
            verbindenButton.Enabled = false;

        }

        public void sendThreadMethod() {
            try {
                mitServerVerbunden = true;
                string text = "beg{" + "1"+":"+nameTextBox.Text + ":" + IpAdresse + "\n"+"}end";
                byte[] data = Encoding.ASCII.GetBytes(text);
                while (true) {
                    try {
                        //Console.WriteLine("Gesendet");
                        socket.Send(data);
                        Thread.Sleep(1000);
                    } catch (Exception ex) {
                        mitServerVerbunden = false;
                        Console.WriteLine(ex.ToString());
                        socket.Close();
                        socket.Dispose();
                        try {
                            Invoke((MethodInvoker)delegate {
                                connectionText.Text = "Disconnected";
                                connectionText.ForeColor = Color.Red;
                                verbindenButton.Enabled = true;
                            });
                        } catch (Exception exception) {
                            Console.WriteLine(exception.ToString());
                        }
                        sendThreadMethod();
                        break;
                    }
                }
            } finally {
                Console.WriteLine("finally send thread");
                mitServerVerbunden = false;
                socket.Close();
                socket.Dispose();
                Invoke((MethodInvoker)delegate {
                    connectionText.Text = "Disconnected";
                    connectionText.ForeColor = Color.Red;
                    verbindenButton.Enabled = true;
                });
                sendThreadMethod();
            }    
        }


        public void listenThreadMethod() {
            try {
                mitServerVerbunden = true;
                
                byte[] data = new byte[socket.ReceiveBufferSize];
                while (true) {
                    try {
                        socket.Receive(data);

                        string tmpString = Encoding.ASCII.GetString(data);
                        Console.WriteLine("Empfangen: "+tmpString);
                        int beginMessage = -1;
                        int endMessage = -1;
                        int laengeMessage = -1;
                        for (int i = 0; i < tmpString.Length; i++) {
                            if (tmpString[i] == 'b' && tmpString[i + 1] == 'e' && tmpString[i + 2] == 'g' && tmpString[i + 3] == '{') {
                                beginMessage = i + 4;
                            }
                        }
                        for (int i = 0; i < tmpString.Length; i++) {
                            if (tmpString[i] == '}' && tmpString[i + 1] == 'e' && tmpString[i + 2] == 'n' && tmpString[i + 3] == 'd') {
                                endMessage = i;
                            }
                        }
                        laengeMessage = endMessage - beginMessage;

                        if (!(beginMessage <= -1 || endMessage <= -1 || laengeMessage <= -1)) {
                            tmpString = tmpString.Substring(beginMessage, laengeMessage);

                            int peersCount = 0;
                            for (int i = 0; i < tmpString.Length; i++) {
                                if (tmpString[i] == '\n') {
                                    peersCount++;
                                }
                                if (tmpString[i] == '\0') {
                                    break;
                                }
                            }
                            string[] tmpStringArray = new string[peersCount];
                            int indexOfLine = 0;
                            int chunck = 0;
                            int j = 0;
                            tmpStringArray[j++] = tmpString.Substring(0, tmpString.IndexOf('\n', chunck));
                            for (int i = 0; i < tmpString.Length; i++) {
                                chunck = tmpString.IndexOf('\n', indexOfLine);
                                if (j >= tmpStringArray.Length) {
                                    break;
                                }
                                tmpStringArray[j++] = tmpString.Substring(chunck + 1, tmpString.IndexOf('\n', chunck)-1);
                            }
                            for (int i = 0; i < tmpStringArray.Length; i++) {
                                string id = "";
                                string name = "";
                                string ip = "";
                                try {
                                    int indexOfName = tmpStringArray[i].IndexOf(':', 2) - 2;
                                    id = tmpStringArray[i].Substring(0, indexOfName - 2);
                                    name = tmpStringArray[i].Substring(2, indexOfName);
                                    int begin = tmpStringArray[i].IndexOf(':', indexOfName + 1) + 1;
                                    int tmp = tmpStringArray[i].Length - 1;
                                    int length = (tmp) - (begin);
                                    ip = tmpStringArray[i].Substring(begin, length);
                                } catch (Exception exce) {
                                    Console.WriteLine(exce.ToString());
                                }
                                Peers.Clear();
                                if (!ip.Equals(IpAdresse)) {
                                    bool gefunden = false;
                                    foreach (Peer item in Peers) {
                                        if (item.ip.Equals(ip)) {
                                            gefunden = true;
                                        }
                                    }
                                    if (!gefunden) {
                                        Peer peer = new Peer();
                                        peer.name = name;
                                        peer.ip = ip;
                                        peer.id = id;
                                        peer.os = "";
                                        Peers.Add(peer);
                                        Invoke(myDelegate);
                                    }
                                }
                            }
                        }   
                        Thread.Sleep(1000);
                    } catch (Exception ex) {
                        mitServerVerbunden = false;
                        Console.WriteLine(ex.ToString());
                        socket.Close();
                        socket.Dispose();

                        Invoke((MethodInvoker)delegate {
                            connectionText.Text = "Disconnected";
                            connectionText.ForeColor = Color.Red;
                            verbindenButton.Enabled = true;
                        });
                        break;
                    }
                }
            } finally {
                Console.WriteLine("finally");
                mitServerVerbunden = false;
                socket.Close();
                socket.Dispose();
                Invoke((MethodInvoker)delegate {
                    connectionText.Text = "Disconnected";
                    connectionText.ForeColor = Color.Red;
                    verbindenButton.Enabled = true;
                });
            }
        }

        private void button1_Click(object sender, EventArgs e) {

            System.Windows.Forms.FolderBrowserDialog objDialog = new FolderBrowserDialog();
            objDialog.Description = "Beschreibung";
            objDialog.SelectedPath = @"C:\";       // Vorgabe Pfad (und danach der gewählte Pfad)
            DialogResult objResult = objDialog.ShowDialog(this);
            if (objResult == DialogResult.OK)
                pfadTextBox.Text = objDialog.SelectedPath;
    

            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = "c:\\";
            //openFileDialog.Filter = "(*.*)|*.*";
            //openFileDialog.RestoreDirectory = true;
            //if (openFileDialog.ShowDialog() == DialogResult.OK) {
            //    //Get the path of specified file
            //    pfadTextBox.Text = openFileDialog.FileName;


            //}
        }
    }
}
