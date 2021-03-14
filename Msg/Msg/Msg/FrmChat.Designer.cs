namespace Msg
{
    partial class FrmChat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChat));
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.lbMesaj = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textLocalIp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textRemoteIp = new System.Windows.Forms.TextBox();
            this.textRemotePort = new System.Windows.Forms.TextBox();
            this.btnBagla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMesaj
            // 
            this.txtMesaj.BackColor = System.Drawing.Color.FloralWhite;
            this.txtMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMesaj.ForeColor = System.Drawing.Color.Gray;
            this.txtMesaj.Location = new System.Drawing.Point(36, 419);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMesaj.Size = new System.Drawing.Size(388, 41);
            this.txtMesaj.TabIndex = 0;
            this.txtMesaj.Text = "Mesajınızı buraya yazın....";
            this.txtMesaj.Enter += new System.EventHandler(this.txtMesaj_Enter);
            this.txtMesaj.Leave += new System.EventHandler(this.txtMesaj_Leave);
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.Wheat;
            this.btnGonder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGonder.Location = new System.Drawing.Point(427, 419);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(52, 41);
            this.btnGonder.TabIndex = 4;
            this.btnGonder.Text = "&Gönder";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Location = new System.Drawing.Point(36, 127);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(0, 17);
            this.lblKullanici.TabIndex = 5;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Transparent;
            this.btnKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKapat.BackgroundImage")));
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKapat.Location = new System.Drawing.Point(446, 17);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(24, 23);
            this.btnKapat.TabIndex = 6;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // lbMesaj
            // 
            this.lbMesaj.BackColor = System.Drawing.Color.Wheat;
            this.lbMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbMesaj.FormattingEnabled = true;
            this.lbMesaj.ItemHeight = 15;
            this.lbMesaj.Location = new System.Drawing.Point(36, 155);
            this.lbMesaj.Name = "lbMesaj";
            this.lbMesaj.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbMesaj.Size = new System.Drawing.Size(443, 259);
            this.lbMesaj.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textLocalPort);
            this.groupBox1.Controls.Add(this.textLocalIp);
            this.groupBox1.Location = new System.Drawing.Point(36, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 75);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ben";
            // 
            // textLocalPort
            // 
            this.textLocalPort.BackColor = System.Drawing.Color.FloralWhite;
            this.textLocalPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textLocalPort.ForeColor = System.Drawing.Color.Gray;
            this.textLocalPort.Location = new System.Drawing.Point(6, 41);
            this.textLocalPort.Multiline = true;
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(123, 23);
            this.textLocalPort.TabIndex = 10;
            this.textLocalPort.Text = "Port Numaram";
            this.textLocalPort.Enter += new System.EventHandler(this.textLocalPort_Enter);
            this.textLocalPort.Leave += new System.EventHandler(this.textLocalPort_Leave);
            // 
            // textLocalIp
            // 
            this.textLocalIp.BackColor = System.Drawing.Color.FloralWhite;
            this.textLocalIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textLocalIp.ForeColor = System.Drawing.Color.Gray;
            this.textLocalIp.Location = new System.Drawing.Point(6, 18);
            this.textLocalIp.Name = "textLocalIp";
            this.textLocalIp.Size = new System.Drawing.Size(123, 23);
            this.textLocalIp.TabIndex = 11;
            this.textLocalIp.Text = "IP Adresim";
            this.textLocalIp.Enter += new System.EventHandler(this.textLocalIp_Enter);
            this.textLocalIp.Leave += new System.EventHandler(this.textLocalIp_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textRemoteIp);
            this.groupBox2.Controls.Add(this.textRemotePort);
            this.groupBox2.Location = new System.Drawing.Point(177, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 75);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alıcı";
            // 
            // textRemoteIp
            // 
            this.textRemoteIp.BackColor = System.Drawing.Color.FloralWhite;
            this.textRemoteIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textRemoteIp.ForeColor = System.Drawing.Color.Gray;
            this.textRemoteIp.Location = new System.Drawing.Point(6, 18);
            this.textRemoteIp.Name = "textRemoteIp";
            this.textRemoteIp.Size = new System.Drawing.Size(123, 23);
            this.textRemoteIp.TabIndex = 12;
            this.textRemoteIp.Text = "Alıcı IP";
            this.textRemoteIp.Enter += new System.EventHandler(this.textRemoteIp_Enter);
            this.textRemoteIp.Leave += new System.EventHandler(this.textRemoteIp_Leave);
            // 
            // textRemotePort
            // 
            this.textRemotePort.BackColor = System.Drawing.Color.FloralWhite;
            this.textRemotePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textRemotePort.ForeColor = System.Drawing.Color.Gray;
            this.textRemotePort.Location = new System.Drawing.Point(6, 41);
            this.textRemotePort.Multiline = true;
            this.textRemotePort.Name = "textRemotePort";
            this.textRemotePort.Size = new System.Drawing.Size(123, 23);
            this.textRemotePort.TabIndex = 10;
            this.textRemotePort.Text = "Alıcı Port Numarası";
            this.textRemotePort.Enter += new System.EventHandler(this.textRemotePort_Enter);
            this.textRemotePort.Leave += new System.EventHandler(this.textRemotePort_Leave);
            // 
            // btnBagla
            // 
            this.btnBagla.BackColor = System.Drawing.Color.LightYellow;
            this.btnBagla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBagla.Location = new System.Drawing.Point(36, 86);
            this.btnBagla.Name = "btnBagla";
            this.btnBagla.Size = new System.Drawing.Size(282, 25);
            this.btnBagla.TabIndex = 10;
            this.btnBagla.Text = "Bağlantı kur";
            this.btnBagla.UseVisualStyleBackColor = false;
            this.btnBagla.Click += new System.EventHandler(this.btnBagla_Click);
            // 
            // FrmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(535, 509);
            this.Controls.Add(this.btnBagla);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbMesaj);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtMesaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmChat_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmChat_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmChat_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmChat_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Button btnKapat;
        public System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.ListBox lbMesaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.TextBox textRemotePort;
        private System.Windows.Forms.Button btnBagla;
        private System.Windows.Forms.TextBox textLocalIp;
        private System.Windows.Forms.TextBox textRemoteIp;
    }
}