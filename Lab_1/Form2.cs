using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace Lab_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(textBox1.Text, out value))
            {
                if (value < 0 || value > 9)
                {
                    MessageBox.Show("Gia tri khong hop le");
                    textBox1.Text = "";
                    return;
                }
            }
            else
            {
                MessageBox.Show("Gia tri khong hop le");
                textBox1.Text = "";
                return;
            }
            switch (value)
            {
                case 0:
                    textBox2.Text = "Khong";
                    break;
                case 1:
                    textBox2.Text = "Mot";
                    break;
                case 2:
                    textBox2.Text = "Hai";
                    break;
                case 3:
                    textBox2.Text = "Ba";
                    break;
                case 4:
                    textBox2.Text = "Bon";
                    break;
                case 5:
                    textBox2.Text = "Nam";
                    break;
                case 6:
                    textBox2.Text = "Sau";
                    break;
                case 7:
                    textBox2.Text = "Bay";
                    break;
                case 8:
                    textBox2.Text = "Tam";
                    break;
                case 9:
                    textBox2.Text = "Chin";
                    break;
            }
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
    }
}
