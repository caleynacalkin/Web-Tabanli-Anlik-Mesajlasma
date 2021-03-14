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
    public partial class frmHesapBilgilerim : Form
    {
        public frmHesapBilgilerim()
        {
            InitializeComponent();
        }





        SqlConnection baglanti = new SqlConnection("Data Source=EBRU\\SQLEXPRESS;Initial Catalog=MSG;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader oku;
        veritabani cagir = new veritabani();






        public int AktarılanID;
        private void frmHesapBilgilerim_Load(object sender, EventArgs e)
        {
            KisiBilgileriniGetir(AktarılanID);

            txtAd.Enabled = false;
            txtSoyad.Enabled = false;
            txtKad.Enabled = false;
            txtTel.Enabled = false;
            txtEposta.Enabled = false;
            txtSifre.Enabled = false;

            txtSifreTekrar.Enabled = false;
            txtSifreTekrar.Visible = false;
            lblSifreTekrar.Visible = false;

            btnKayit.Visible = false;  
                 
        }
        






        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }










        bool move;
        int mouse_x;
        int mouse_y;
        private void frmHesapBilgilerim_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void frmHesapBilgilerim_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void frmHesapBilgilerim_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }










        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            txtAd.Enabled = true;
            txtSoyad.Enabled = true;
            txtKad.Enabled = true;
            txtTel.Enabled = true;
            txtEposta.Enabled = true;
            txtSifre.Enabled = true;

            txtSifreTekrar.Visible = true;    
            txtSifreTekrar.Enabled = true;
            lblSifreTekrar.Visible = true;

            btnKayit.Visible = true;
        }









        private void btnKayit_Click(object sender, EventArgs e)
        {

            if (txtAd.Text=="" || txtSoyad.Text=="" || txtKad.Text=="" || txtTel.Text == "(   )    -" || txtEposta.Text=="" || txtSifre.Text=="" || txtSifreTekrar.Text=="")
            {
                MessageBox.Show("Lütfen alanları doldurun!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtSifre.Text == txtSifreTekrar.Text)
                {

                    cagir.KullaniciGuncelleme(AktarılanID,txtAd.Text,txtSoyad.Text,txtKad.Text,txtTel.Text,txtEposta.Text,txtSifreTekrar.Text);
                    MessageBox.Show("Güncellendi");
                    KisiBilgileriniGetir(AktarılanID);

                    txtAd.Enabled = false;
                    txtSoyad.Enabled = false;
                    txtKad.Enabled = false;
                    txtTel.Enabled = false;
                    txtEposta.Enabled = false;
                    txtSifre.Enabled = false;
                    txtSifreTekrar.Enabled = false;
                    txtSifreTekrar.Visible = false;
                    lblSifreTekrar.Visible = false;
                    btnKayit.Visible = false;
                }
                else
                {
                    MessageBox.Show("Girilen şifreler uyuşmamaktadır!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }






        private void KisiBilgileriniGetir(int gelenid)
        {

            txtAd.Text = "";
            txtSoyad.Text = "";
            txtKad.Text = "";
            txtTel.Text = "";
            txtEposta.Text = "";
            txtSifre.Text = "";
            txtSifreTekrar.Text = "";


            baglanti.Close();
            baglanti.Open();
            komut = new SqlCommand("Select * from Kisiler where id='" + gelenid + "'", baglanti);
            
            oku = komut.ExecuteReader();
            if (oku.Read() == true)
            {
                txtAd.Text = oku["ad"].ToString().Trim();
                txtSoyad.Text = oku["soyad"].ToString().Trim();
                txtKad.Text = oku["kullanici_ad"].ToString().Trim();
                txtTel.Text = oku["tel"].ToString();
                txtEposta.Text = oku["eposta"].ToString().Trim();
                txtSifre.Text = oku["sifre"].ToString().Trim();
            }
            else
            {
                MessageBox.Show("Bilgiler aktarılırken bir sorun oldu!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }





        private void txtSifre_MouseEnter(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }
    }
}
