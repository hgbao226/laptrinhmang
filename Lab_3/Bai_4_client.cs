using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_3
{
    public partial class Bai_4_client : Form
    {
        private TcpClient tcpClient;
        private Byte[] data;
        private NetworkStream ns;


        public Bai_4_client()
        {
            InitializeComponent();
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                tcpClient = new TcpClient();
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 8080);
                tcpClient.Connect(ipEndPoint);

                ns = tcpClient.GetStream(); // Gán giá trị cho biến ns
            }
            
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            if(ns != null)
            {
                data = System.Text.Encoding.ASCII.GetBytes("quit\n");
                ns.Write(data, 0, data.Length);
                ns.Close();
                tcpClient.Close();
            }
            this.Close();
        }
        private void send_mess_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string message = messTextBox.Text;
            string textToSend = $"{name}: {message}\n";
            data = System.Text.Encoding.ASCII.GetBytes(textToSend);
            ns.Write(data, 0, data.Length);
        }
        private void Bai_4_client_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Bai_4 bai4 = Bai_4.GetInstance();
            bai4.Show();
        }
    }
}
