namespace P2PClientFormsGui {
    partial class ClientForm {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.peersListe = new System.Windows.Forms.ListView();
            this.IdCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IPCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OSCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.DateinameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroeßeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FortschrittCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connectionText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ServerIPText = new System.Windows.Forms.TextBox();
            this.ServerPortText = new System.Windows.Forms.TextBox();
            this.pfadTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.verbindenButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peersListe
            // 
            this.peersListe.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.peersListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdCol,
            this.NameCol,
            this.IPCol,
            this.OSCol});
            this.peersListe.Location = new System.Drawing.Point(12, 90);
            this.peersListe.MultiSelect = false;
            this.peersListe.Name = "peersListe";
            this.peersListe.Size = new System.Drawing.Size(404, 565);
            this.peersListe.TabIndex = 0;
            this.peersListe.UseCompatibleStateImageBehavior = false;
            this.peersListe.View = System.Windows.Forms.View.Details;
            // 
            // IdCol
            // 
            this.IdCol.Text = "Id";
            this.IdCol.Width = 100;
            // 
            // NameCol
            // 
            this.NameCol.Text = "Name";
            this.NameCol.Width = 100;
            // 
            // IPCol
            // 
            this.IPCol.Text = "IP";
            this.IPCol.Width = 100;
            // 
            // OSCol
            // 
            this.OSCol.Text = "OS";
            this.OSCol.Width = 100;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DateinameCol,
            this.GroeßeCol,
            this.FortschrittCol});
            this.listView2.Location = new System.Drawing.Point(422, 90);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(383, 565);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // DateinameCol
            // 
            this.DateinameCol.Text = "Name";
            this.DateinameCol.Width = 100;
            // 
            // GroeßeCol
            // 
            this.GroeßeCol.Text = "Größe";
            this.GroeßeCol.Width = 100;
            // 
            // FortschrittCol
            // 
            this.FortschrittCol.Text = "Fortschritt";
            this.FortschrittCol.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dateien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status:";
            // 
            // connectionText
            // 
            this.connectionText.AutoSize = true;
            this.connectionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionText.ForeColor = System.Drawing.Color.Red;
            this.connectionText.Location = new System.Drawing.Point(92, 9);
            this.connectionText.Name = "connectionText";
            this.connectionText.Size = new System.Drawing.Size(143, 25);
            this.connectionText.TabIndex = 5;
            this.connectionText.Text = "Disconnected";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 679);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Server IP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 708);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Server Port:";
            // 
            // ServerIPText
            // 
            this.ServerIPText.Location = new System.Drawing.Point(128, 678);
            this.ServerIPText.Name = "ServerIPText";
            this.ServerIPText.Size = new System.Drawing.Size(170, 20);
            this.ServerIPText.TabIndex = 8;
            this.ServerIPText.Text = "192.168.2.100";
            // 
            // ServerPortText
            // 
            this.ServerPortText.Location = new System.Drawing.Point(128, 708);
            this.ServerPortText.Name = "ServerPortText";
            this.ServerPortText.Size = new System.Drawing.Size(170, 20);
            this.ServerPortText.TabIndex = 9;
            this.ServerPortText.Text = "5000";
            // 
            // pfadTextBox
            // 
            this.pfadTextBox.Location = new System.Drawing.Point(549, 708);
            this.pfadTextBox.Name = "pfadTextBox";
            this.pfadTextBox.Size = new System.Drawing.Size(170, 20);
            this.pfadTextBox.TabIndex = 13;
            this.pfadTextBox.Text = "C:\\Users\\Ben\\Downloads";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(549, 678);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(170, 20);
            this.nameTextBox.TabIndex = 12;
            this.nameTextBox.Text = "Ben";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(414, 708);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Freigabe Ordner:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(414, 679);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(726, 706);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Öffnen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // verbindenButton
            // 
            this.verbindenButton.Location = new System.Drawing.Point(305, 707);
            this.verbindenButton.Name = "verbindenButton";
            this.verbindenButton.Size = new System.Drawing.Size(75, 23);
            this.verbindenButton.TabIndex = 15;
            this.verbindenButton.Text = "Verbinden";
            this.verbindenButton.UseVisualStyleBackColor = true;
            this.verbindenButton.Click += new System.EventHandler(this.verbindenButton_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(686, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Chat Fenster öffnen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 761);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.verbindenButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pfadTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ServerPortText);
            this.Controls.Add(this.ServerIPText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.connectionText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.peersListe);
            this.Name = "ClientForm";
            this.Text = "P2P Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView peersListe;
        private System.Windows.Forms.ColumnHeader IdCol;
        private System.Windows.Forms.ColumnHeader NameCol;
        private System.Windows.Forms.ColumnHeader IPCol;
        private System.Windows.Forms.ColumnHeader OSCol;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader DateinameCol;
        private System.Windows.Forms.ColumnHeader GroeßeCol;
        private System.Windows.Forms.ColumnHeader FortschrittCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label connectionText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ServerIPText;
        private System.Windows.Forms.TextBox ServerPortText;
        private System.Windows.Forms.TextBox pfadTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button verbindenButton;
        private System.Windows.Forms.Button button2;
    }
}

