namespace Lab_3
{
    partial class Bai_4
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
            tcp_server.Location = new Point(0, 27);
            tcp_server.Name = "tcp_server";
            tcp_server.Size = new Size(423, 29);
            tcp_server.TabIndex = 0;
            tcp_server.Text = "SERVER";
            tcp_server.UseVisualStyleBackColor = true;
            tcp_server.Click += tcp_server_Click;
            // 
            // tcp_client
            // 
            tcp_client.Location = new Point(0, 74);
            tcp_client.Name = "tcp_client";
            tcp_client.Size = new Size(423, 29);
            tcp_client.TabIndex = 1;
            tcp_client.Text = "CLIENT";
            tcp_client.UseVisualStyleBackColor = true;
            tcp_client.Click += tcp_client_Click;
            // 
            // Bai_4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 115);
            Controls.Add(tcp_client);
            Controls.Add(tcp_server);
            Name = "Bai_4";
            Text = "Bai_4";
            FormClosed += Bai_4_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button tcp_server;
        private Button tcp_client;
    }
}