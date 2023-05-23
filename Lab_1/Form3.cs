using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Chon don vi tien te";
            comboBox2.Text = "Chon don vi tien te";
        }

        public void button1_Click(object sender, EventArgs e)
        {
            double USD = 22772;
            double EUR = 28132;
            double GBP = 31538;
            double SGD = 17286;
            double JPY = 214;
            double VND = 1;
            double trunggian;
            double tygia;
            double value;
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long chon don vi tien te");
                return;
            }
            if (!double.TryParse(textBox1.Text, out value))
            {
                MessageBox.Show("Gia tri khong hop le");
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }
            if (double.TryParse(textBox1.Text, out value))
            {
                if (value < 0)
                {
                    MessageBox.Show("Gia tri khong hop le");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    return;
                }
            }

            switch (comboBox1.Text)
            {
                case "USD":
                    trunggian = value * USD;
                    tygia = USD;
                    break;
                case "EUR":
                    trunggian = value * EUR;
                    tygia = EUR;
                    break;
                case "GBP":
                    trunggian = value * GBP;
                    tygia = GBP;
                    break;
                case "SGD":
                    trunggian = value * SGD;
                    tygia = SGD;
                    break;
                case "JPY":
                    trunggian = value * JPY;
                    tygia = JPY;
                    break;
                case "VND":
                    trunggian = value * VND;
                    tygia = VND;
                    break;
                default:
                    trunggian = 0;
                    tygia = 0;
                    break;
            }
            switch (comboBox2.Text)
            {
                case "USD":
                    textBox2.Text = (trunggian / USD).ToString();
                    textBox3.Text = "1 " + comboBox1.Text + " = " + tygia / USD + " " + textBox2.Text;
                    break;
                case "EUR":
                    textBox2.Text = (trunggian / EUR).ToString();
                    textBox3.Text = "1 " + comboBox1.Text + " = " + tygia / EUR + " " + comboBox2.Text;
                    break;
                case "GBP":
                    textBox2.Text = (trunggian / GBP).ToString();
                    textBox3.Text = "1 " + comboBox1.Text + " = " + tygia / GBP + " " + comboBox2.Text;
                    break;
                case "SGD":
                    textBox2.Text = (trunggian / SGD).ToString();
                    textBox3.Text = "1 " + comboBox1.Text + " = " + tygia / SGD + " " + comboBox2.Text;
                    break;
                case "JPY":
                    textBox2.Text = (trunggian / JPY).ToString();
                    textBox3.Text = "1 " + comboBox1.Text + " = " + tygia / JPY + " " + comboBox2.Text;
                    break;
                case "VND":
                    textBox2.Text = (trunggian / VND).ToString();
                    textBox3.Text = "1 " + comboBox1.Text + " = " + tygia / VND + " " + comboBox2.Text;
                    break;
                default:
                    trunggian = 0;
                    break;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
