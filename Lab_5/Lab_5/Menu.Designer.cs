namespace Lab_5
{
    partial class Menu
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
            btnBai_1 = new Button();
            btnBai_2 = new Button();
            SuspendLayout();
            // 
            // btnBai_1
            // 
            btnBai_1.Location = new Point(312, 98);
            btnBai_1.Name = "btnBai_1";
            btnBai_1.Size = new Size(94, 29);
            btnBai_1.TabIndex = 0;
            btnBai_1.Text = "Bài 1";
            btnBai_1.UseVisualStyleBackColor = true;
            btnBai_1.Click += btnBai_1_Click;
            // 
            // btnBai_2
            // 
            btnBai_2.Location = new Point(312, 261);
            btnBai_2.Name = "btnBai_2";
            btnBai_2.Size = new Size(94, 29);
            btnBai_2.TabIndex = 1;
            btnBai_2.Text = "Bài 2";
            btnBai_2.UseVisualStyleBackColor = true;
            btnBai_2.Click += btnBai_2_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBai_2);
            Controls.Add(btnBai_1);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBai_1;
        private Button btnBai_2;
    }
}