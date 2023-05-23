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
        private Byte[]? data;
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
                Task.Run(ReceiveDataFromServer);
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
                if(data != null) {
                    data = System.Text.Encoding.ASCII.GetBytes("quit\n");
                    ns.Write(data, 0, data.Length);
                }
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
            if(data != null)
            {
                data = System.Text.Encoding.ASCII.GetBytes(textToSend);
                ns.Write(data, 0, data.Length);
            }
        }
        private void Bai_4_client_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Bai_4 bai4 = Bai_4.GetInstance();
            bai4.Show();
        }
        private async Task ReceiveDataFromServer()
        {
            byte[] recvBuffer = new byte[1024];
            while (true)
            {
                int bytesRead = await ns.ReadAsync(recvBuffer, 0, recvBuffer.Length);
                if (bytesRead > 0)
                {
                    string receivedText = Encoding.ASCII.GetString(recvBuffer, 0, bytesRead);
                    // Gọi phương thức Broadcast để hiển thị tin nhắn trên ListView
                    Broadcast(receivedText);
                }
            }
        }
        private void Broadcast(string text)
        {
            listView.Invoke((MethodInvoker)delegate {
                listView.Items.Add(text);
            });
        }
    }
}
