using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Msg
{
    public partial class frmKayit : Form
    {
        public frmKayit()
        {
            InitializeComponent();
        }



        veritabani cagir = new veritabani();
        private void frmKayit_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
            txtSifreTekrari.PasswordChar = '*';
        }





        private void btnKayit_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = "";
            if (txtAd.Text=="" || txtSoyad.Text=="" || txtKAd.Text=="" || txtTel.Text== "(   )    -" || txtEposta.Text=="" || txtSifre.Text=="" || txtSifreTekrari.Text=="")
            {
                MessageBox.Show("Lütfen boş alanları doldurun !", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               cagir.YeniKullaniciEkleme(txtAd.Text.Trim(),txtSoyad.Text.Trim().ToUpper(),txtKAd.Text.Trim(),txtTel.Text,txtEposta.Text.Trim(),txtSifreTekrari.Text.Trim()); 
                DialogResult secenek= MessageBox.Show("Kaydınız tamamlandı oturum açma ekranına dönmek istermisiniz?", "Bilgilendirme Penceresi",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    this.Dispose();
                    frmMessenger frm =new frmMessenger();
                    frm.ShowDialog();                    
                 }
                else if(secenek==DialogResult.No)
                {               
                }
                txtAd.Text = "";
                txtSoyad.Text = "";
                txtKAd.Text = "";
                txtTel.Text = "";
                txtEposta.Text = "";
                txtSifre.Text = "";
                txtSifreTekrari.Text = "";
            }
        }








        private void txtSifreTekrari_Leave(object sender, EventArgs e)
        {
            lblMesaj.Text = "";
            if (txtSifre.Text == txtSifreTekrari.Text)
            {
                lblMesaj.Text = "";
            }
            else
            {
                lblMesaj.Text = "Şifreler uyuşmamakta !";
            }
            lblMesaj.Text = "";
        }






        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }







        bool move;
        int mouse_x;
        int mouse_y;
        private void frmKayit_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void frmKayit_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void frmKayit_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
    }
}
