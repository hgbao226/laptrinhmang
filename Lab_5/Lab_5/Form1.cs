using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button_send_Click_1(object sender, EventArgs e)
        {
            string mailfrom = textBox_from.Text.Trim();
            string mailto = textBox_to.Text.Trim();
            string password = textBox_pass.Text.Trim();
            var basicCredential = new NetworkCredential(mailfrom, password);

            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            using (MailMessage message = new MailMessage())
            {
                MailAddress fromAddress = new MailAddress(mailfrom);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = basicCredential;

                message.From = fromAddress;
                message.Subject = textBox_subject.Text.Trim();
                message.IsBodyHtml = true;
                message.Body = richTextBox1.Text;
                message.To.Add(mailto);

                try
                {
                    smtpClient.Send(message);
                    MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while sending the email: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Dispose the form to free up resources
            this.Dispose();
        }
    }
}
