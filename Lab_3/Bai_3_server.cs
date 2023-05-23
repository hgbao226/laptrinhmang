using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.WebSockets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_3
{
    public partial class Bai_3_server : Form
    {
        public Bai_3_server()
        {
            InitializeComponent();
        }

        int port = 8080;
        string ipAddress = "127.0.0.1";

        // sử dụng sync và await để tránh UI bị event click chiếm đóng
        private async void listen_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Parse(ipAddress), port);
            listener.Start();

            while (true)
            {
                TcpClient tcpClient = await listener.AcceptTcpClientAsync();
                listView.Items.Add("Connected\n");
                await Task.Run(() => HandleClient(tcpClient)).ConfigureAwait(false);
            }
        }

        private void HandleClient(TcpClient tcpClient)
        {
            NetworkStream nwStream = tcpClient.GetStream();

            byte[] buffer = new byte[tcpClient.ReceiveBufferSize];
            int bytesRead;

            while ((bytesRead = nwStream.Read(buffer, 0, tcpClient.ReceiveBufferSize)) > 0)
            {
                string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                listView.Invoke((Action)(() => listView.Items.Add(dataReceived)));
            }

            tcpClient.Close();
        }

        private void Bai_3_server_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Bai_3 bai3 = Bai_3.GetInstance();
            bai3.Show();
        }
    }
}
