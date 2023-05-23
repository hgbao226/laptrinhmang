using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Bai_1_client : Form
    {
        public Bai_1_client()
        {
            InitializeComponent();
        }

        private void Bai_1_client_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Bai_1 bai1 = Bai_1.GetInstance();
            bai1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UdpClient udpClient = new UdpClient();

                // lấy thông tin cần thiết //
                string ipAddress = textBox1.Text;
                int port = int.Parse(textBox2.Text);
                string message = richTextBox1.Text;
                //*************************//

                byte[] data = Encoding.UTF8.GetBytes(message);
                udpClient.Send(data, data.Length, ipAddress, port);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
