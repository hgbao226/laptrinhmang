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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long value1, value2;
            long value1_mid;
            if (!long.TryParse(textBox1.Text, out value1) || !long.TryParse(textBox2.Text, out value2))
            {
                MessageBox.Show("Gia tri khong hop le");
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }
            if (long.TryParse(textBox1.Text, out value1) || long.TryParse(textBox2.Text, out value2))
            {
                if (value1 < 0)
                {
                    MessageBox.Show("Gia tri khong hop le");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    return;
                }
            }
            value1_mid = value1;
            long ans1 = 1, ans2 = 1, ans3 = 0, ans4 = 0, ans5 = 0;
            for (long i = 1; i <= value1; i++)
            {
                ans1 = ans1 * i;
                ans3 = ans3 + i;
            }

            for (long i = 1; i <= value2; i++)
            {
                ans2 = ans2 * i;
                ans4 = ans4 + i;
                ans5 = ans5 + value1;
                value1 = value1 * value1_mid;
            }
            textBox3.Text = ans1.ToString();
            textBox4.Text = ans2.ToString();
            textBox5.Text = ans3.ToString();
            textBox6.Text = ans4.ToString();
            textBox7.Text = ans5.ToString();
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
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = false;
                button1.PerformClick();
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = false;
                button1.PerformClick();
            }
        }
    }
}
