using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Bai_3_client : Form
    {
        public Bai_3_client()
        {
            InitializeComponent();
        }

        // cổng port, địa chỉ IP sẽ gửi tin nhắn tới, nội dung tin nhắn
        int port = 8080;
        string ipAddress = "127.0.0.1";
        string textToSend = "Tao có khiên\n";

        private void send_mess_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient();

            if (!client.Connected)
            {
                client.Connect(ipAddress, port);
            }

            NetworkStream stream = client.GetStream();
            byte[] byteToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);
            stream.Write(byteToSend, 0, byteToSend.Length);
            stream.Close();
            client.Close(); // Close the connection after sending data
        }

        private void Bai_3_client_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Bai_3 bai3 = Bai_3.GetInstance();
            bai3.Show();
        }
    }
}
