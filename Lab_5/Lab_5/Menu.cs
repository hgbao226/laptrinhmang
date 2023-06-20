using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// MenuForm.cs
namespace Lab_5
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnBai_1_Click(object sender, EventArgs e)
        {
            // Hide the menu form
            this.Hide();

            // Create and show Form1
            Form1 form1 = new Form1();
            form1.Closed += (s, args) => this.Show();
            form1.Show();
        }

        private void btnBai_2_Click(object sender, EventArgs e)
        {
            // Hide the menu form
            this.Hide();

            // Create and show Form2
            Bai_2 bai_2 = new Bai_2();
            bai_2.Closed += (s, args) => this.Show();
            bai_2.Show();
        }
    }
}
