using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Msg
{
    public partial class FrmChat : Form
    {
        public FrmChat()
        {
            InitializeComponent();
        }


        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;



        private void FrmChat_Load(object sender, EventArgs e)
        {

            // Soket kurduk
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);



            // Kullanıcının IP adresini aldık
            textLocalIp.Text = GetLocalIP();
            textRemoteIp.Text = GetLocalIP();

        }










        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "192.0.0.1";
        }











        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;


                // byte[]  string e dönüştürülüyor
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);


                // Mesajı listboxa ekledik
                lbMesaj.Items.Add("Friend : " + receivedMessage);



                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }           
        }













        private void btnBagla_Click(object sender, EventArgs e)
        {
            //Socket bağlayıcı
            epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), Convert.ToInt32(textLocalPort.Text));
            sck.Bind(epLocal);

            //IP bağlantısını yaptık
            epRemote = new IPEndPoint(IPAddress.Parse(textRemoteIp.Text), Convert.ToInt32(textRemotePort.Text));
            sck.Connect(epRemote);


            //Belirli bir bağlantı portunu dinletiyoruz
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }









        private void btnGonder_Click(object sender, EventArgs e)
        {
            // string mesajı byte dönüştürdük
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(txtMesaj.Text);


            // Şifreli mesaj gönderme
            sck.Send(sendingMessage);


            // listboxa mesajı ekledik
            lbMesaj.Items.Add("Me : "+txtMesaj.Text);
            txtMesaj.Text = "";
        }











        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }





     







        bool move;
        int mouse_x;
        int mouse_y;
        private void FrmChat_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void FrmChat_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }      
        private void FrmChat_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }










        private void textLocalPort_Enter(object sender, EventArgs e)
        {
            if (textLocalPort.Text == "Port Numaram")
            {
                textLocalPort.Text = "";
                textLocalPort.ForeColor = Color.Black;
            }
        }
        private void textLocalPort_Leave(object sender, EventArgs e)
        {
            if (textLocalPort.Text == "")
            {
                textLocalPort.Text = "Port Numaram";
                textLocalPort.ForeColor = Color.Gray;
            }
        }











        private void textRemotePort_Enter(object sender, EventArgs e)
        {
            if (textRemotePort.Text == "Alıcı Port Numarası")
            {
                textRemotePort.Text = "";
                textRemotePort.ForeColor = Color.Black;
            }
        }
        private void textRemotePort_Leave(object sender, EventArgs e)
        {
            if (textRemotePort.Text == "")
            {
                textRemotePort.Text = "Alıcı Port Numarası";
                textRemotePort.ForeColor = Color.Gray;
            }
        }









        private void txtMesaj_Enter(object sender, EventArgs e)
        {
            if (txtMesaj.Text == "Mesajınızı buraya yazın....")
            {
                txtMesaj.Text = "";
                txtMesaj.ForeColor = Color.Black;
            }
        }
        private void txtMesaj_Leave(object sender, EventArgs e)
        {
            if (txtMesaj.Text == "")
            {
                txtMesaj.Text = "Mesajınızı buraya yazın....";
                txtMesaj.ForeColor = Color.Gray;
            }
        }

        







        private void textLocalIp_Enter(object sender, EventArgs e)
        {
            if (textLocalIp.Text == "IP Adresim")
            {
                textLocalIp.Text = "";
                textLocalIp.ForeColor = Color.Black;
            }
        }
        private void textLocalIp_Leave(object sender, EventArgs e)
        {
            if (textLocalIp.Text == "")
            {
                textLocalIp.Text = "IP Adresim";
                textLocalIp.ForeColor = Color.Gray;
            }
        }

        









        private void textRemoteIp_Enter(object sender, EventArgs e)
        {
            if (textRemoteIp.Text == "Alıcı IP")
            {
                textRemoteIp.Text = "";
                textRemoteIp.ForeColor = Color.Black;
            }
        }
        private void textRemoteIp_Leave(object sender, EventArgs e)
        {
            if (textRemoteIp.Text == "")
            {
                textRemoteIp.Text = "Alıcı IP";
                textRemoteIp.ForeColor = Color.Gray;
            }
        }

    }
}
