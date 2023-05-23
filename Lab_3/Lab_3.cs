namespace Lab_3
{
    public partial class Lab_3 : Form
    {
        public Lab_3()
        {
            InitializeComponent();
        }

        //***********************************************//
        // đoạn code kiểm tra nếu đã có menu chạy sẵn rồi, nếu đã có thì sẽ hiện lại menu chứ ko tạo mới //
        private static Lab_3? instance;

        public static Lab_3 GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Lab_3();
            }
            return instance;
        }
        //***********************************************//

        // menu các bài tập
        private void button1_Click(object sender, EventArgs e)
        {
            Bai_1 bai_1 = new Bai_1();
            bai_1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai_2 bai_2 = new Bai_2();
            bai_2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai_3 bai_3 = new Bai_3();
            bai_3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai_4 bai_4 = new Bai_4();
            bai_4.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}