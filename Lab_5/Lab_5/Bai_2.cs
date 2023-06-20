using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit;
using MimeKit;
using MailKit.Security;

namespace Lab_5
{
    public partial class Bai_2 : Form
    {
        public Bai_2()
        {
            InitializeComponent();
        }
        private void Bai_2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Dispose the form to free up resources
            this.Dispose();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            using (var client = new ImapClient())
            {
                try
                {
                    client.Connect("nhom5.nt106", 993, SecureSocketOptions.SslOnConnect);
                    client.Authenticate(email, password);
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);
                    listView1.Items.Clear();
                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);
                        var name = new ListViewItem(message.Subject);

                        var from = new ListViewItem.ListViewSubItem(name, message.From.ToString());
                        name.SubItems.Add(from);

                        var date = new ListViewItem.ListViewSubItem(name, message.Date.Date.ToString());
                        name.SubItems.Add(date);

                        listView1.Items.Add(name);
                    }
                    client.Disconnect(true);
                    MessageBox.Show("Emails retrieved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving emails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
