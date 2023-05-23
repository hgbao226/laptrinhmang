namespace Lab_3
{
    public partial class Bai_1 : Form
    {
        public Bai_1()
        {
            InitializeComponent();
        }

        private static Bai_1? instance;

        public static Bai_1 GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Bai_1();
            }
            return instance;
        }

        private void Bai_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // giải phóng toàn bộ tài nguyên đang đc sử dụng bởi Bài 1
            this.Dispose();
            Lab_3 form1 = Lab_3.GetInstance();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai_1_client bai_1_client = new Bai_1_client();
            bai_1_client.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai_1_server bai_1_server = new Bai_1_server();
            bai_1_server.Show();
            this.Dispose();
        }
    }
}
