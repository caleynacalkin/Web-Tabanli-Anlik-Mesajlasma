using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Msg
{
    public partial class frmMessenger : Form
    {
        public frmMessenger()
        {
            InitializeComponent();
        }





        SqlConnection baglanti= new SqlConnection("Data Source=EBRU\\SQLEXPRESS;Initial Catalog=MSG;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader oku;
        veritabani cagir = new veritabani();






        
        private void frmMessenger_Load(object sender, EventArgs e)
        {
                panel2.Visible = false;
                panel1.Visible = true;
                lbRehber.DisplayMember = "Görüntüle";
                lbRehber.ValueMember = "TelefonNumara";                             
        }

        



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }





        private void linkYeniBirHesap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKayit frm = new frmKayit();
            frm.ShowDialog();
        }
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmHakkinda frm = new frmHakkinda())
            {
                frm.ShowDialog();
            }
        }



    


        public int sayi;
        private void btnOturumAc_Click(object sender, EventArgs e)
        {       
            if(txtKullaniciAd.Text=="" || txtSifre.Text == "")
            {
                MessageBox.Show("Lütfen Telefon Numaranızı, Ad ve Soyad bilgilerinizi giriniz.");
            }
            else
            {
                sayi=cagir.Giris(txtKullaniciAd.Text.Trim(), txtSifre.Text.Trim());
                if (sayi==0)
                {                                     
                    panel1.Visible = true;
                    panel2.Visible = false;
                    txtKullaniciAd.Text = "";
                    txtSifre.Text = "";
                }
                else
                {
                    //sayi giriş yapan kişinin id si
                    panel1.Visible = false;
                    panel2.Visible = true;
                    KullaniciListe(sayi);
                }        
            }
        }






        private void btnEkleDuzenle_Click_1(object sender, EventArgs e)
        {
            frmKullaniciEkleDuzenle frm = new frmKullaniciEkleDuzenle();
            frm.ShowDialog();

            if (frmKullaniciEkleDuzenle.gidenAd == null & frmKullaniciEkleDuzenle.gidenSoyad == null & frmKullaniciEkleDuzenle.gidenTel == null)
            {
            }
            else
            {
                int ID = cagir.idbul();
                cagir.RehberdekiKaydıTabloyaEkleme();
                lbRehber.Items.Add(frmKullaniciEkleDuzenle.gidenAd.ToString().Trim() + " " + frmKullaniciEkleDuzenle.gidenSoyad.ToString().Trim() + "    " + frmKullaniciEkleDuzenle.gidenTel.ToString());       
            }            
        }






        private void txtTelefonNumarasi_TextChanged(object sender, EventArgs e)
        {
           
        }
       




        static string secilen;
        private void btnKaldir_Click_1(object sender, EventArgs e)
        {
            int secim = lbRehber.SelectedIndex;
            if (secim != -1)
            {
                secilen = lbRehber.SelectedItem.ToString();
                secilen = secilen.Substring((secilen.Length - 14));
                cagir.RehberdeSecilenKaydiSil(secilen);
                lbRehber.Items.RemoveAt(secim);
            }
            else
            {
                MessageBox.Show("Seçim Yapın!");
            }
        }




        private void KullaniciListe(int gelenid)
        {
            lbRehber.Items.Clear();
            baglanti.Close();
            baglanti.Open();
            komut = new SqlCommand("Select ad,soyad,tel From Kisiler where id IN(Select kisi_id From Rehber where kullanici_id='" + gelenid + "')", baglanti);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lbRehber.Items.Add(oku["ad"].ToString().Trim() + " " + oku["soyad"].ToString().Trim() + "     " + oku["tel"].ToString());
            }
            baglanti.Close();
        }






        private void btnTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitter.com/");
        }
        private void btnGmail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gmail.com/");
        }
        private void btnFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/groups/844919452964858/");
        }








        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmİletisim frm = new frmİletisim();
            frm.ShowDialog();     
        }






        private void btnGeri_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            txtKullaniciAd.Text = "";
            txtSifre.Text = "";
        }





        //Form Border özelliği kapalı olduğu için Bu kısımda Form açıldığı zaman mouse ile hareket ettirme 
        bool move;
        int mouse_x;
        int mouse_y;
        private void frmMessenger_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void frmMessenger_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void frmMessenger_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }           
        }





        // txtKullaniciAd Texbox enter içine tıklayınca ve çıkınca yapacağı olaylar
        private void txtKullaniciAd_Enter(object sender, EventArgs e)
        {
            if (txtKullaniciAd.Text=="Username")
            {
                txtKullaniciAd.Text = "";
                txtKullaniciAd.ForeColor = Color.Black;
            }
        }
        private void txtKullaniciAd_Leave(object sender, EventArgs e)
        {
            if (txtKullaniciAd.Text=="")
            {
                txtKullaniciAd.Text = "Username";
                txtKullaniciAd.ForeColor = Color.Gray;               
            }
        }






        // txtSifre Texbox enter içine tıklayınca ve çıkınca yapacağı olaylar
        private void txtSifre_Enter(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Password")
            {
                txtSifre.Text = "";
                txtSifre.ForeColor = Color.Black;
                txtSifre.PasswordChar = '*';
            }
        }

        char? none = null;
        private void txtSifre_Leave(object sender, EventArgs e)
        {
            if (txtSifre.Text == "")
            {
                txtSifre.Text = "Password";
                txtSifre.ForeColor = Color.Gray;
                txtSifre.PasswordChar = Convert.ToChar(none);
            }
        }







        // txtArananKisi Texbox enter içine tıklayınca ve çıkınca yapacağı olaylar
        private void txtArananKisi_Enter(object sender, EventArgs e)
        {
            if (txtArananKisi.Text == "Kişi bul..")
            {
                txtArananKisi.Text = "";
                txtArananKisi.ForeColor = Color.Black;
            }
        }

        private void txtArananKisi_Leave(object sender, EventArgs e)
        {
            if (txtArananKisi.Text == "")
            {
                txtArananKisi.Text = "Kişi bul..";
                txtArananKisi.ForeColor = Color.Gray;
            }
        }





   

        // txtArananKisi den yazdıkça arama yapar
        private void txtArananKisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < lbRehber.Items.Count; i++)
            {
                if (lbRehber.Items[i].ToString().ToLower().Contains(txtArananKisi.Text.ToLower()))
                {
                    lbRehber.SetSelected(i, true);
                }
            }
        }







        //Bu kısımda Listboxtan seçilen kişinin chat sayfasını açtırdık
        public string AktarılanTel;
        private void lbRehber_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AktarılanTel = lbRehber.SelectedItem.ToString();
            AktarılanTel = AktarılanTel.Substring((AktarılanTel.Length - 14));
            string kisi = cagir.ChatSayfasiİsimGetirme(AktarılanTel);
            FrmChat frm = new FrmChat();
            frm.lblKullanici.Text ="Alıcı: "+kisi;
            frm.Show();

        }



        //Giriş yapan kullanıcının ID si ile birlikte bilgilerini göreceği sayfaya yönlendirir  
        private void btnBilgilerim_Click(object sender, EventArgs e)
        {
            frmHesapBilgilerim frm = new frmHesapBilgilerim();
            frm.AktarılanID = sayi;
            frm.Show();
        }
    }
    }

