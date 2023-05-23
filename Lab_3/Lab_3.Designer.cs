namespace Lab_3
{
    partial class Lab_3
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
            bai_1 = new Button();
            bai_2 = new Button();
            bai_3 = new Button();
            bai_4 = new Button();
            SuspendLayout();
            // 
            // bai_1
            // 
            bai_1.Location = new Point(12, 12);
            bai_1.Name = "bai_1";
            bai_1.Size = new Size(75, 23);
            bai_1.TabIndex = 0;
            bai_1.Text = "Bài 1";
            bai_1.UseVisualStyleBackColor = true;
            bai_1.Click += button1_Click;
            // 
            // bai_2
            // 
            bai_2.Location = new Point(148, 12);
            bai_2.Name = "bai_2";
            bai_2.Size = new Size(75, 23);
            bai_2.TabIndex = 1;
            bai_2.Text = "Bài 2";
            bai_2.UseVisualStyleBackColor = true;
            bai_2.Click += button2_Click;
            // 
            // bai_3
            // 
            bai_3.Location = new Point(12, 157);
            bai_3.Name = "bai_3";
            bai_3.Size = new Size(75, 23);
            bai_3.TabIndex = 2;
            bai_3.Text = "Bài 3";
            bai_3.UseVisualStyleBackColor = true;
            bai_3.Click += button3_Click;
            // 
            // bai_4
            // 
            bai_4.Location = new Point(148, 157);
            bai_4.Name = "bai_4";
            bai_4.Size = new Size(75, 23);
            bai_4.TabIndex = 3;
            bai_4.Text = "Bài 4";
            bai_4.UseVisualStyleBackColor = true;
            bai_4.Click += button4_Click;
            // 
            // Lab_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 192);
            Controls.Add(bai_4);
            Controls.Add(bai_3);
            Controls.Add(bai_2);
            Controls.Add(bai_1);
            MaximizeBox = false;
            Name = "Lab_3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LAB 4";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button bai_1;
        private Button bai_2;
        private Button bai_3;
        private Button bai_4;
    }
}