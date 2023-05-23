namespace Lab_2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Check if the input is a number
                if (!int.TryParse(textBox1.Text, out int result))
                {
                    MessageBox.Show("Please enter a valid number.");
                    textBox1.Text = "";
                    return;
                }
                Form2 form2 = new Form2(result);
                form2.Show();
                this.Hide();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}