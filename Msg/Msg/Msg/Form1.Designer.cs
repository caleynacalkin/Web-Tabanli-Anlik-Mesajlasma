namespace Msg
{
    partial class frmMessenger
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessenger));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTwitter = new System.Windows.Forms.Button();
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.btnGmail = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnFacebook = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.linkParolamiUnuttum = new System.Windows.Forms.LinkLabel();
            this.btnOturumAc = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.linkYeniBirHesap = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.messengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBilgilerim = new System.Windows.Forms.Button();
            this.txtArananKisi = new System.Windows.Forms.TextBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRehber = new System.Windows.Forms.ListBox();
            this.btnKaldir = new System.Windows.Forms.Button();
            this.btnEkleDuzenle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnTwitter);
            this.panel1.Controls.Add(this.btnGmail);
            this.panel1.Controls.Add(this.btnFacebook);
            this.panel1.Controls.Add(this.linkParolamiUnuttum);
            this.panel1.Controls.Add(this.btnOturumAc);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.txtKullaniciAd);
            this.panel1.Controls.Add(this.linkYeniBirHesap);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 420);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Msg.Properties.Resources.iconfinder_Discussion_2921796__1_;
            this.pictureBox1.Location = new System.Drawing.Point(99, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnTwitter
            // 
            this.btnTwitter.ImageKey = "Twitter-An-oluşturma.png";
            this.btnTwitter.ImageList = this.ımageList3;
            this.btnTwitter.Location = new System.Drawing.Point(159, 365);
            this.btnTwitter.Name = "btnTwitter";
            this.btnTwitter.Size = new System.Drawing.Size(28, 26);
            this.btnTwitter.TabIndex = 8;
            this.btnTwitter.UseVisualStyleBackColor = true;
            this.btnTwitter.Click += new System.EventHandler(this.btnTwitter_Click);
            // 
            // ımageList3
            // 
            this.ımageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList3.ImageStream")));
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList3.Images.SetKeyName(0, "Twitter-An-oluşturma.png");
            // 
            // btnGmail
            // 
            this.btnGmail.ImageKey = "gmail.png";
            this.btnGmail.ImageList = this.ımageList2;
            this.btnGmail.Location = new System.Drawing.Point(125, 365);
            this.btnGmail.Name = "btnGmail";
            this.btnGmail.Size = new System.Drawing.Size(28, 26);
            this.btnGmail.TabIndex = 7;
            this.btnGmail.UseVisualStyleBackColor = true;
            this.btnGmail.Click += new System.EventHandler(this.btnGmail_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "gmail.png");
            // 
            // btnFacebook
            // 
            this.btnFacebook.ImageKey = "ffffffffffffffffffffffmedia-marketing-facebook-computer-icons-website-s-icon-face" +
    "book-rectangle-logo-social-media.jpg";
            this.btnFacebook.ImageList = this.ımageList1;
            this.btnFacebook.Location = new System.Drawing.Point(91, 365);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Size = new System.Drawing.Size(28, 26);
            this.btnFacebook.TabIndex = 6;
            this.btnFacebook.UseVisualStyleBackColor = true;
            this.btnFacebook.Click += new System.EventHandler(this.btnFacebook_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ffffffffffffffffffffffmedia-marketing-facebook-computer-icons-website-s-icon-face" +
        "book-rectangle-logo-social-media.jpg");
            // 
            // linkParolamiUnuttum
            // 
            this.linkParolamiUnuttum.AutoSize = true;
            this.linkParolamiUnuttum.Location = new System.Drawing.Point(79, 297);
            this.linkParolamiUnuttum.Name = "linkParolamiUnuttum";
            this.linkParolamiUnuttum.Size = new System.Drawing.Size(113, 13);
            this.linkParolamiUnuttum.TabIndex = 0;
            this.linkParolamiUnuttum.TabStop = true;
            this.linkParolamiUnuttum.Text = "🔒︎Parolanı mı unuttun?";
            // 
            // btnOturumAc
            // 
            this.btnOturumAc.BackColor = System.Drawing.Color.LightYellow;
            this.btnOturumAc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOturumAc.Location = new System.Drawing.Point(41, 229);
            this.btnOturumAc.Name = "btnOturumAc";
            this.btnOturumAc.Size = new System.Drawing.Size(199, 30);
            this.btnOturumAc.TabIndex = 3;
            this.btnOturumAc.Text = "Oturum aç";
            this.btnOturumAc.UseVisualStyleBackColor = false;
            this.btnOturumAc.Click += new System.EventHandler(this.btnOturumAc_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSifre.Location = new System.Drawing.Point(41, 195);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(199, 28);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.Text = "Password";
            this.txtSifre.Enter += new System.EventHandler(this.txtSifre_Enter);
            this.txtSifre.Leave += new System.EventHandler(this.txtSifre_Leave);
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAd.ForeColor = System.Drawing.Color.Gray;
            this.txtKullaniciAd.Location = new System.Drawing.Point(41, 162);
            this.txtKullaniciAd.Multiline = true;
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(199, 28);
            this.txtKullaniciAd.TabIndex = 0;
            this.txtKullaniciAd.Text = "Username";
            this.txtKullaniciAd.TextChanged += new System.EventHandler(this.txtTelefonNumarasi_TextChanged);
            this.txtKullaniciAd.Enter += new System.EventHandler(this.txtKullaniciAd_Enter);
            this.txtKullaniciAd.Leave += new System.EventHandler(this.txtKullaniciAd_Leave);
            // 
            // linkYeniBirHesap
            // 
            this.linkYeniBirHesap.AutoSize = true;
            this.linkYeniBirHesap.Location = new System.Drawing.Point(79, 326);
            this.linkYeniBirHesap.Name = "linkYeniBirHesap";
            this.linkYeniBirHesap.Size = new System.Drawing.Size(120, 13);
            this.linkYeniBirHesap.TabIndex = 5;
            this.linkYeniBirHesap.TabStop = true;
            this.linkYeniBirHesap.Text = "Yeni bir hesap edinin ☺";
            this.linkYeniBirHesap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkYeniBirHesap_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FloralWhite;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messengerToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.iletişimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(294, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // messengerToolStripMenuItem
            // 
            this.messengerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.messengerToolStripMenuItem.Name = "messengerToolStripMenuItem";
            this.messengerToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.messengerToolStripMenuItem.Text = "Messenger";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            this.iletişimToolStripMenuItem.Click += new System.EventHandler(this.iletişimToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.panel2.Controls.Add(this.btnBilgilerim);
            this.panel2.Controls.Add(this.txtArananKisi);
            this.panel2.Controls.Add(this.btnGeri);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbRehber);
            this.panel2.Controls.Add(this.btnKaldir);
            this.panel2.Controls.Add(this.btnEkleDuzenle);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 420);
            this.panel2.TabIndex = 10;
            // 
            // btnBilgilerim
            // 
            this.btnBilgilerim.BackColor = System.Drawing.Color.Wheat;
            this.btnBilgilerim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBilgilerim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgilerim.Location = new System.Drawing.Point(20, 390);
            this.btnBilgilerim.Name = "btnBilgilerim";
            this.btnBilgilerim.Size = new System.Drawing.Size(252, 27);
            this.btnBilgilerim.TabIndex = 6;
            this.btnBilgilerim.Text = "Hesap Bilgilerim";
            this.btnBilgilerim.UseVisualStyleBackColor = false;
            this.btnBilgilerim.Click += new System.EventHandler(this.btnBilgilerim_Click);
            // 
            // txtArananKisi
            // 
            this.txtArananKisi.BackColor = System.Drawing.Color.FloralWhite;
            this.txtArananKisi.ForeColor = System.Drawing.Color.Gray;
            this.txtArananKisi.Location = new System.Drawing.Point(20, 49);
            this.txtArananKisi.Name = "txtArananKisi";
            this.txtArananKisi.Size = new System.Drawing.Size(143, 20);
            this.txtArananKisi.TabIndex = 5;
            this.txtArananKisi.Text = "Kişi bul..";
            this.txtArananKisi.Enter += new System.EventHandler(this.txtArananKisi_Enter);
            this.txtArananKisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArananKisi_KeyPress);
            this.txtArananKisi.Leave += new System.EventHandler(this.txtArananKisi_Leave);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGeri.Location = new System.Drawing.Point(244, 13);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(28, 26);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kullanıcılar....";
            // 
            // lbRehber
            // 
            this.lbRehber.BackColor = System.Drawing.Color.FloralWhite;
            this.lbRehber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRehber.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbRehber.FormattingEnabled = true;
            this.lbRehber.Location = new System.Drawing.Point(20, 100);
            this.lbRehber.Name = "lbRehber";
            this.lbRehber.Size = new System.Drawing.Size(252, 288);
            this.lbRehber.TabIndex = 2;
            this.lbRehber.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbRehber_MouseDoubleClick);
            // 
            // btnKaldir
            // 
            this.btnKaldir.BackColor = System.Drawing.Color.Wheat;
            this.btnKaldir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaldir.Location = new System.Drawing.Point(107, 6);
            this.btnKaldir.Name = "btnKaldir";
            this.btnKaldir.Size = new System.Drawing.Size(56, 41);
            this.btnKaldir.TabIndex = 1;
            this.btnKaldir.Text = "Kaldır";
            this.btnKaldir.UseVisualStyleBackColor = false;
            this.btnKaldir.Click += new System.EventHandler(this.btnKaldir_Click_1);
            // 
            // btnEkleDuzenle
            // 
            this.btnEkleDuzenle.BackColor = System.Drawing.Color.Wheat;
            this.btnEkleDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkleDuzenle.Location = new System.Drawing.Point(20, 6);
            this.btnEkleDuzenle.Name = "btnEkleDuzenle";
            this.btnEkleDuzenle.Size = new System.Drawing.Size(85, 41);
            this.btnEkleDuzenle.TabIndex = 0;
            this.btnEkleDuzenle.Text = "Kişi Ekle";
            this.btnEkleDuzenle.UseVisualStyleBackColor = false;
            this.btnEkleDuzenle.Click += new System.EventHandler(this.btnEkleDuzenle_Click_1);
            // 
            // frmMessenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 451);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMessenger";
            this.Text = "Messenger";
            this.Load += new System.EventHandler(this.frmMessenger_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMessenger_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMessenger_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMessenger_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTwitter;
        private System.Windows.Forms.Button btnGmail;
        private System.Windows.Forms.Button btnFacebook;
        private System.Windows.Forms.LinkLabel linkParolamiUnuttum;
        private System.Windows.Forms.Button btnOturumAc;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.LinkLabel linkYeniBirHesap;
        private System.Windows.Forms.ImageList ımageList3;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem messengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKaldir;
        private System.Windows.Forms.Button btnEkleDuzenle;
        private System.Windows.Forms.ListBox lbRehber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.TextBox txtArananKisi;
        private System.Windows.Forms.Button btnBilgilerim;
    }
}

