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
    public partial class frmKullaniciEkleDuzenle : Form
    {
        
        public frmKullaniciEkleDuzenle()
        {
            InitializeComponent();
            
        }
        veritabani cagir = new veritabani();

        public static string gidenAd=" ",gidenSoyad=" ",gidenTel=" ";

        

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtAd.Text==null || txtSoyad.Text== "(   )    -" || txtTel.Text==null)
            {
                MessageBox.Show("Lütfen boş alanları doldurun !", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int s = cagir.RehberKayitEkleKontrol(txtAd.Text, txtSoyad.Text, txtTel.Text);
                if (s == 1)
                {
                    gidenAd = txtAd.Text;
                    gidenSoyad = txtSoyad.Text;
                    gidenTel = txtTel.Text;                    
                }
                else
                {
                    gidenAd = null;
                    gidenSoyad = null;
                    gidenTel = null;
                }              
            }
        }





        bool move;
        int mouse_x;
        int mouse_y;
        private void frmKullaniciEkleDuzenle_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void frmKullaniciEkleDuzenle_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void frmKullaniciEkleDuzenle_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
    }
}
