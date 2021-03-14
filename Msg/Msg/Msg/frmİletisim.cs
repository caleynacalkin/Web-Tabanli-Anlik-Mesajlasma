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
    public partial class frmİletisim : Form
    {
        public frmİletisim()
        {
            InitializeComponent();
        }



        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void frmİletisim_Load(object sender, EventArgs e)
        {
            lblYazi.Text = "Telefon: (537)5265454" + "\n"+"Faks:+90-258-9998888";   
        }





        bool move;
        int mouse_x;
        int mouse_y;
        private void frmİletisim_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void frmİletisim_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void frmİletisim_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
    }
}
