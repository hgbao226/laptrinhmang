namespace Lab_5
{
    partial class Bai_2
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
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            listView1 = new ListView();
            Email = new ColumnHeader();
            From = new ColumnHeader();
            ThoiGian = new ColumnHeader();
            lblTotal = new Label();
            lblRecent = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 37);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 84);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(127, 34);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(366, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(127, 84);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(366, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(625, 52);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Email, From, ThoiGian });
            listView1.Location = new Point(62, 160);
            listView1.Name = "listView1";
            listView1.Size = new Size(687, 256);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Email
            // 
            Email.Text = "Email";
            Email.Width = 200;
            // 
            // From
            // 
            From.Width = 100;
            // 
            // ThoiGian
            // 
            ThoiGian.Text = "Thời gian";
            ThoiGian.Width = 100;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(53, 128);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 20);
            lblTotal.TabIndex = 6;
            // 
            // lblRecent
            // 
            lblRecent.AutoSize = true;
            lblRecent.Location = new Point(249, 128);
            lblRecent.Name = "lblRecent";
            lblRecent.Size = new Size(0, 20);
            lblRecent.TabIndex = 7;
            // 
            // Bai_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRecent);
            Controls.Add(lblTotal);
            Controls.Add(listView1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai_2";
            Text = "Bai_2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private ListView listView1;
        private ColumnHeader Email;
        private ColumnHeader From;
        private ColumnHeader ThoiGian;
        private Label lblTotal;
        private Label lblRecent;
    }
}