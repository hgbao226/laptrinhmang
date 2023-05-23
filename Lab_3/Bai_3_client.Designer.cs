namespace Lab_3
{
    partial class Bai_3_client
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
            send_mess = new Button();
            SuspendLayout();
            // 
            // send_mess
            // 
            send_mess.Location = new Point(12, 13);
            send_mess.Name = "send_mess";
            send_mess.Size = new Size(359, 23);
            send_mess.TabIndex = 0;
            send_mess.Text = "Send message";
            send_mess.UseVisualStyleBackColor = true;
            send_mess.Click += send_mess_Click;
            // 
            // Bai_3_client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 49);
            Controls.Add(send_mess);
            Name = "Bai_3_client";
            Text = "Bai_3_client";
            FormClosed += Bai_3_client_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button send_mess;
    }
}