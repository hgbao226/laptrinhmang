namespace Lab_2_2
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();
                richTextBox1.Text = content;
                // Get file name //
                textBox1.Text = ofd.SafeFileName.ToString();
                // Get file URL //
                textBox2.Text = fs.Name.ToString();
                // Count number of character in a file //
                int charCount = content.Length;
                textBox5.Text = charCount.ToString();
                // Count number of line in a file
                int lineCount = 0;
                fs.Seek(0, SeekOrigin.Begin);
                while (sr.ReadLine() != null)
                {
                    lineCount++;
                }
                textBox3.Text = lineCount.ToString();
                // Count number of word in a file //
                string[] source = content.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                int wordCount = source.Count();
                textBox4.Text = wordCount.ToString();
                fs.Close();
            }
        }
    }
}