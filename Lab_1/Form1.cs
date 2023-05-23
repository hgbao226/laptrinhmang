namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create 3 vars, check 3 inputs
            int num1 = 0, num2 = 0, num3 = 0;
            if (!int.TryParse(textBox1.Text, out num1))
            {
                MessageBox.Show("Giá trị không hợp lệ");
                return;
            }
            if (!int.TryParse(textBox6.Text, out num2))
            {
                MessageBox.Show("Giá trị không hợp lệ");
                return;
            }
            if (!int.TryParse(textBox3.Text, out num3))
            {
                MessageBox.Show("Giá trị không hợp lệ");
                return;
            }
            //compare and answer
            int max = Math.Max(Math.Max(num1, num2), num3);
            int min = Math.Min(Math.Min(num1, num2), num3);
            textBox10.Text = max.ToString();
            textBox9.Text = min.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}