using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace P2PClientFormsGui {
    [Serializable]
    class Peer : ISerializable {
        public string name { get; set; }
        public string ip { get; set; }
        public string id { get; set; }
        public string os { get; set; }
        public Socket Socket { get; set; }
        public Peer() {

        }

        public Peer(SerializationInfo info, StreamingContext context) {
            name = info.GetString("p_name");
            ip = info.GetString("p_ip");
            id = info.GetString("p_id");
            os = info.GetString("p_os");
        }

        public Peer(string _name, string _ip, string _id, string _os) {
            name = _name;
            ip = _ip;
            id = _id;
            os = _os;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context) {
            info.AddValue("p_name", name);
            info.AddValue("p_id", id);
            info.AddValue("p_ip", ip);
            info.AddValue("p_os", os);
        }
    }
}
