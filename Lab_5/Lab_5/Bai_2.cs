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
                    client.Connect("127.0.0.1", 143, SecureSocketOptions.None);
                    client.Authenticate(email, password);
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);
                    listView1.Items.Clear();
                    listView1.Columns.Add("Email", 200);
                    listView1.Columns.Add("From", 100);
                    listView1.Columns.Add("Thời gian", 100);
                    listView1.View = View.Details;
                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);
                        ListViewItem name = new ListViewItem(message.Subject);
                        ListViewItem.ListViewSubItem from = new
                        ListViewItem.ListViewSubItem(name, message.From.ToString());
                        name.SubItems.Add(from);
                        ListViewItem.ListViewSubItem date = new
                        ListViewItem.ListViewSubItem(name, message.Date.Date.ToString());
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
