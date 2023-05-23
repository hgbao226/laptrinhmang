namespace Lab_3
{
    public partial class Bai_3 : Form
    {
        public Bai_3()
        {
            InitializeComponent();
        }

        private static Bai_3? instance;

        public static Bai_3 GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Bai_3();
            }
            return instance;
        }

        private void Bai_3_FormClosed(object sender, FormClosedEventArgs e)
        {
            // giải phóng toàn bộ tài nguyên đang đc sử dụng bởi Bài 3
            this.Dispose();
            Lab_3 lab_3 = Lab_3.GetInstance();
            lab_3.Show();
        }

        private void tcp_server_Click(object sender, EventArgs e)
        {
            Bai_3_server bai_3_server = new Bai_3_server();
            bai_3_server.Show();
            this.Dispose();
        }

        private void tcp_client_Click(object sender, EventArgs e)
        {
            Bai_3_client bai_3_client = new Bai_3_client();
            bai_3_client.Show();
            this.Dispose();
        }
    }
}
