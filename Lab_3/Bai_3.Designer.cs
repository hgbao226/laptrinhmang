namespace Lab_3
{
    partial class Bai_3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tcp_server = new Button();
            tcp_client = new Button();
            SuspendLayout();
            // 
            // tcp_server
            // 
            tcp_server.Location = new Point(12, 24);
            tcp_server.Name = "tcp_server";
            tcp_server.Size = new Size(453, 23);
            tcp_server.TabIndex = 0;
            tcp_server.Text = "Open TCP Server";
            tcp_server.UseVisualStyleBackColor = true;
            tcp_server.Click += tcp_server_Click;
            // 
            // tcp_client
            // 
            tcp_client.Location = new Point(12, 73);
            tcp_client.Name = "tcp_client";
            tcp_client.Size = new Size(453, 23);
            tcp_client.TabIndex = 1;
            tcp_client.Text = "Open TCP Client";
            tcp_client.UseVisualStyleBackColor = true;
            tcp_client.Click += tcp_client_Click;
            // 
            // Bai_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 117);
            Controls.Add(tcp_client);
            Controls.Add(tcp_server);
            Name = "Bai_3";
            Text = "Bai_3";
            FormClosed += Bai_3_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button tcp_server;
        private Button tcp_client;
    }
}