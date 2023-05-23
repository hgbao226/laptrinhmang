﻿using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Lab_3
{
    public partial class Bai_2 : Form
    {
        public Bai_2()
        {
            InitializeComponent();
        }

        void StartUnsafeThread()
        {
            int bytesReceived = 0;

            // Khởi tạo mảng byte nhận dữ liệu
            byte[] recv = new byte[1];

            // Tạo socket bên gởi
            Socket clientSocket;

            // Tạo socket bên nhận, socket này là socket lắng nghe các kết nối tới nó tại địa chỉ IP của máy và port 8080.Đây là 1 TCP / IP socket.
            // AddressFamily: trả về họ địa chỉ của địa chỉ IP hiện hành. Ở đây là địa chỉ Ipv4 nên chọn AddressFamily.InterNetwork
            // SocketType: kiểu kết nối socket, ở đây dùng luồng Stream để nhận dữ liệu
            // ProtocolType: sử dụng giao thức kết nối nào, ở đây sử dụng kết nối TCP
            // Ba tham số của hàm đi với nhau khi ta thực hiện kết nối TCP.
            Socket listenerSocket = new Socket(
            AddressFamily.InterNetwork,
            SocketType.Stream,
            ProtocolType.Tcp
            );

            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

            // Gán socket lắng nghe tới địa chỉ IP của máy và port 8080
            listenerSocket.Bind(ipepServer);

            // bắt đầu lắng nghe. Socket.Listen(int backlog) 
            // với backlog: là độ dài tối đa của hàng đợi các kết nối đang chờ xử lý
            listenerSocket.Listen(-1);

            //Đồng ý kết nối
            clientSocket = listenerSocket.Accept();

            //Nhận dữ liệu
            listViewCommand.Items.Add(new ListViewItem("New client connected"));
            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                } while (text[text.Length - 1] != '\n');
                listViewCommand.Items.Add(new ListViewItem(text));
            }
            listenerSocket.Close();
        }


        private void StartListen(object sender, EventArgs e)
        {
            //Xử lý lỗi InvalidOperationException
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }

        private void Bai_2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // giải phóng toàn bộ tài nguyên đang đc sử dụng bởi Bài 2
            this.Dispose();
            Lab_3 form1 = Lab_3.GetInstance();
            form1.Show();
        }
    }
}
