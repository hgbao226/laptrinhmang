namespace Lab_3
{
    partial class Bai_1
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
            udp_client = new Button();
            udp_server = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // udp_client
            // 
            udp_client.Location = new Point(12, 38);
            udp_client.Name = "udp_client";
            udp_client.Size = new Size(75, 23);
            udp_client.TabIndex = 0;
            udp_client.Text = "UDP Client";
            udp_client.UseVisualStyleBackColor = true;
            udp_client.Click += button1_Click;
            // 
            // udp_server
            // 
            udp_server.Location = new Point(224, 38);
            udp_server.Name = "udp_server";
            udp_server.Size = new Size(75, 23);
            udp_server.TabIndex = 1;
            udp_server.Text = "UDP Server";
            udp_server.UseVisualStyleBackColor = true;
            udp_server.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 2;
            label1.Text = "Select function";
            // 
            // Bai_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 75);
            Controls.Add(label1);
            Controls.Add(udp_server);
            Controls.Add(udp_client);
            MaximizeBox = false;
            Name = "Bai_1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bai_1";
            FormClosed += Bai_1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button udp_client;
        private Button udp_server;
        private Label label1;
    }
}