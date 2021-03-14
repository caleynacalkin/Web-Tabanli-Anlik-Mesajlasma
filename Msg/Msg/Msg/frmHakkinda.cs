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
    public partial class frmHakkinda : Form
    {
        public frmHakkinda()
        {
            InitializeComponent();
        }




        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }




        private void frmHakkinda_Load(object sender, EventArgs e)
        {
            lblVersion.Text = string.Format("Version: {0}", Application.ProductVersion);
        }







        bool move;
        int mouse_x;
        int mouse_y;
        private void frmHakkinda_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void frmHakkinda_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void frmHakkinda_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
    }
}
