using System.Data;
using System.Xml;

namespace Lab_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The Eval.Execute method evaluates the string passed as a parameter and returns its resulting value.
        private double EvaluateExpression(string expression)
        {
            if (expression.Contains("/0"))
            {
                throw new DivideByZeroException();
            }
            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expression, ""));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get stream of input, output file
            StreamReader inputFile = new StreamReader("C:\\Users\\hgbao\\OneDrive\\Máy tính\\uit\\nam2_hk2\\Lap_Trinh_Mang\\thuc-hanh\\Lab_2\\Lab_2\\Lab_2_3\\input.txt");
            string content = inputFile.ReadToEnd();
            // Put text to richtextbox
            richTextBox1.Text = content;
            // Put readpoint back to start of stream
            inputFile.BaseStream.Seek(0, SeekOrigin.Begin);
            using (StreamWriter outputFile = new StreamWriter("C:\\Users\\hgbao\\OneDrive\\Máy tính\\uit\\nam2_hk2\\Lap_Trinh_Mang\\thuc-hanh\\Lab_2\\Lab_2\\Lab_2_3\\output.txt"))
            try
            {
                // Read line by line
                string line;
                while ((line = inputFile.ReadLine()) != null)
                {
                    // Get rid of whitespace
                    line = line.Replace(" ", "");
                    try
                    {
                        double result = EvaluateExpression(line);
                        outputFile.WriteLine("{0}={1}",line,result);
                    }
                    catch
                    {
                        outputFile.WriteLine("Invalid input");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid");
            }
        }
    }
}