using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Bai_4 : Form
    {
        public Bai_4()
        {
            InitializeComponent();
        }

        private static Bai_4? instance;

        public static Bai_4 GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Bai_4();
            }
            return instance;
        }
        private void Bai_4_FormClosed(object sender, FormClosedEventArgs e)
        {
            // giải phóng toàn bộ tài nguyên đang đc sử dụng bởi Bài 3
            this.Dispose();
            Lab_3 lab_3 = Lab_3.GetInstance();
            lab_3.Show();
        }
        private void tcp_server_Click(object sender, EventArgs e)
        {
            Bai_4_server bai_4_server = new Bai_4_server();
            bai_4_server.Show();
            this.Dispose();
        }

        private void tcp_client_Click(object sender, EventArgs e)
        {
            Bai_4_client bai_4_client = new Bai_4_client();
            bai_4_client.Show();
            this.Dispose();
        }
    }
}
