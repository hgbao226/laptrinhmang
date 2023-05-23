using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_3
{
    public partial class Bai_1_server : Form
    {
        public Bai_1_server()
        {
            InitializeComponent();
        }

        private void Bai_1_server_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Bai_1 bai1 = Bai_1.GetInstance();
            bai1.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int port = int.Parse(textBox1.Text);
                UdpClient udpClient = new UdpClient(port);

                while (true)
                {
                    UdpReceiveResult result = await udpClient.ReceiveAsync();
                    byte[] receive_data = result.Buffer;
                    string message = Encoding.UTF8.GetString(receive_data);
                    richTextBox1.Text = message;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
