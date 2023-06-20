namespace Lab_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_send = new Button();
            textBox_from = new TextBox();
            textBox_to = new TextBox();
            textBox_pass = new TextBox();
            textBox_subject = new TextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button_send
            // 
            button_send.Location = new Point(12, 13);
            button_send.Name = "button_send";
            button_send.Size = new Size(75, 72);
            button_send.TabIndex = 0;
            button_send.Text = "SEND";
            button_send.UseVisualStyleBackColor = true;
            button_send.Click += button_send_Click_1;
            // 
            // textBox_from
            // 
            textBox_from.Location = new Point(188, 13);
            textBox_from.Name = "textBox_from";
            textBox_from.Size = new Size(226, 23);
            textBox_from.TabIndex = 1;
            // 
            // textBox_to
            // 
            textBox_to.Location = new Point(188, 62);
            textBox_to.Name = "textBox_to";
            textBox_to.Size = new Size(226, 23);
            textBox_to.TabIndex = 2;
            // 
            // textBox_pass
            // 
            textBox_pass.Location = new Point(595, 12);
            textBox_pass.Name = "textBox_pass";
            textBox_pass.Size = new Size(193, 23);
            textBox_pass.TabIndex = 3;
            // 
            // textBox_subject
            // 
            textBox_subject.Location = new Point(188, 145);
            textBox_subject.Name = "textBox_subject";
            textBox_subject.Size = new Size(600, 23);
            textBox_subject.TabIndex = 4;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(188, 174);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(600, 264);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 15);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 65);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 7;
            label2.Text = "To:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(529, 16);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 8;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 153);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 9;
            label4.Text = "Subject";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(148, 177);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 10;
            label5.Text = "Body";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox_subject);
            Controls.Add(textBox_pass);
            Controls.Add(textBox_to);
            Controls.Add(textBox_from);
            Controls.Add(button_send);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_send;
        private TextBox textBox_from;
        private TextBox textBox_to;
        private TextBox textBox_pass;
        private TextBox textBox_subject;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}