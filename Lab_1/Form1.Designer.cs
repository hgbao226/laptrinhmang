namespace Lab_1
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox6 = new TextBox();
            find = new Button();
            delete = new Button();
            exit = new Button();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AcceptsTab = true;
            textBox1.Location = new Point(105, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = " ";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(383, 112);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox6
            // 
            textBox6.Location = new Point(650, 112);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 6;
            // 
            // find
            // 
            find.Location = new Point(136, 206);
            find.Name = "find";
            find.Size = new Size(94, 29);
            find.TabIndex = 10;
            find.Text = "Tìm";
            find.UseVisualStyleBackColor = true;
            find.Click += button1_Click;
            // 
            // delete
            // 
            delete.Location = new Point(363, 206);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 11;
            delete.Text = "Xoá";
            delete.UseVisualStyleBackColor = true;
            delete.Click += button2_Click;
            // 
            // exit
            // 
            exit.Location = new Point(583, 206);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 12;
            exit.Text = "Thoát";
            exit.UseVisualStyleBackColor = true;
            exit.Click += button3_Click;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(604, 293);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 27);
            textBox9.TabIndex = 15;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(209, 293);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(125, 27);
            textBox10.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 296);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 17;
            label1.Text = "Số lớn nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(510, 296);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 18;
            label2.Text = "Số nhỏ nhất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 115);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 19;
            label3.Text = "Số thứ nhất";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(301, 115);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 20;
            label4.Text = "Số thứ hai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(571, 115);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 21;
            label5.Text = "Số thứ ba";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(exit);
            Controls.Add(delete);
            Controls.Add(find);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox3;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox6;
        private Button find;
        private Button delete;
        private Button exit;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}