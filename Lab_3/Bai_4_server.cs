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

namespace Lab_3
{
    public partial class Bai_4_server : Form
    {
        private NetworkStream networkStream;
        private List<Socket> clientSockets;

        public Bai_4_server()
        {
            InitializeComponent();
            clientSockets = new List<Socket>();
        }

        private void listen_Click(object sender, EventArgs e)
        {
            // Xử lý lỗi InvalidOperationException
            CheckForIllegalCrossThreadCalls = false;
            Task.Run(() => StartListening());
        }

        void StartListening()
        {
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork,
                                                SocketType.Stream,
                                                  ProtocolType.Tcp);
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listView.Items.Add("Server running on 127.0.0.1:8080");
            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(10); // Giới hạn số lượng kết nối đồng thời

            while (true)
            {
                Socket clientSocket = listenerSocket.Accept();
                clientSockets.Add(clientSocket);

                Task.Run(() => HandleClient(clientSocket));
            }
        }

        void HandleClient(Socket clientSocket)
        {
            int bytesReceived;
            byte[] recvBuffer = new byte[1024]; // Kích thước buffer

            string clientInfo = "New client connected from: " + clientSocket.RemoteEndPoint.ToString();
            listView.Items.Add(new ListViewItem(clientInfo));

            while (true)
            {
                StringBuilder textBuilder = new StringBuilder();
                string text = "";

                do
                {
                    bytesReceived = clientSocket.Receive(recvBuffer);
                    textBuilder.Append(Encoding.ASCII.GetString(recvBuffer, 0, bytesReceived));
                    text = textBuilder.ToString();
                } while (!text.EndsWith("\n"));

                listView.Items.Add(new ListViewItem(text));

                // Xử lý dữ liệu từ client
                // ...

                if (text.Trim() == "quit") // Điều kiện thoát vòng lặp nếu client gửi "quit"
                {
                    break;
                }
            }

            clientSocket.Close();
            clientSockets.Remove(clientSocket);
        }


        private void Bai_4_server_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var clientSocket in clientSockets)
            {
                clientSocket.Close();
            }
            this.Dispose();
            Bai_4 bai4 = Bai_4.GetInstance();
            bai4.Show();
        }
    }
}
