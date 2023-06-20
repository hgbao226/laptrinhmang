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
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            using (var client = new ImapClient())
            {
                client.Connect("imap.example.com", 993, true);
                client.Authenticate(email, password);

                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                // Lấy số lượng email tổng cộng và số lượng email mới
                int totalEmails = inbox.Count;
                int newEmails = inbox.Search(SearchOptions.All, SearchQuery.NotSeen).Count;

                lblTotal.Text = $"Total: {totalEmails}";
                lblRecent.Text = $"Recent: {newEmails}";

                listView1.Items.Clear();

                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);

                    var item = new ListViewItem(message.Subject);
                    item.SubItems.Add(message.From.ToString());
                    item.SubItems.Add(message.Date.Date.ToString());

                    listView1.Items.Add(item);
                }

                client.Disconnect(true);
            }
        }
    }
}
