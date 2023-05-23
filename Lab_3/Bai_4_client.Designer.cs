namespace Lab_3
{
    partial class Bai_4_client
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
            listView = new ListView();
            nameTextBox = new TextBox();
            messTextBox = new TextBox();
            send_mess = new Button();
            namelb = new Label();
            Messagelb = new Label();
            btnConnect = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // listView
            // 
            listView.Location = new Point(12, 12);
            listView.Name = "listView";
            listView.Size = new Size(776, 221);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.List;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(23, 299);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(125, 27);
            nameTextBox.TabIndex = 1;
            // 
            // messTextBox
            // 
            messTextBox.Location = new Point(23, 394);
            messTextBox.Name = "messTextBox";
            messTextBox.Size = new Size(616, 27);
            messTextBox.TabIndex = 2;
            // 
            // send_mess
            // 
            send_mess.Location = new Point(666, 392);
            send_mess.Name = "send_mess";
            send_mess.Size = new Size(94, 29);
            send_mess.TabIndex = 3;
            send_mess.Text = "Send";
            send_mess.UseVisualStyleBackColor = true;
            send_mess.Click += send_mess_Click;
            // 
            // namelb
            // 
            namelb.AutoSize = true;
            namelb.Location = new Point(23, 276);
            namelb.Name = "namelb";
            namelb.Size = new Size(85, 20);
            namelb.TabIndex = 4;
            namelb.Text = "Your Name:";
            // 
            // Messagelb
            // 
            Messagelb.AutoSize = true;
            Messagelb.Location = new Point(23, 371);
            Messagelb.Name = "Messagelb";
            Messagelb.Size = new Size(70, 20);
            Messagelb.TabIndex = 5;
            Messagelb.Text = "Message:";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(599, 239);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(189, 29);
            btnConnect.TabIndex = 6;
            btnConnect.Text = "Connect to Server";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(465, 239);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(94, 29);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // Bai_4_client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnQuit);
            Controls.Add(btnConnect);
            Controls.Add(Messagelb);
            Controls.Add(namelb);
            Controls.Add(send_mess);
            Controls.Add(messTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(listView);
            Name = "Bai_4_client";
            Text = "Bai_4_client";
            FormClosed += Bai_4_client_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView;
        private TextBox nameTextBox;
        private TextBox messTextBox;
        private Button send_mess;
        private Label namelb;
        private Label Messagelb;
        private Button btnConnect;
        private Button btnQuit;
    }
}