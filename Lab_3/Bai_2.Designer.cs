namespace Lab_3
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
            button_listen = new Button();
            listViewCommand = new ListView();
            SuspendLayout();
            // 
            // button_listen
            // 
            button_listen.Location = new Point(313, 28);
            button_listen.Margin = new Padding(3, 2, 3, 2);
            button_listen.Name = "button_listen";
            button_listen.Size = new Size(82, 22);
            button_listen.TabIndex = 0;
            button_listen.Text = "Listen";
            button_listen.UseVisualStyleBackColor = true;
            button_listen.Click += StartListen;
            // 
            // listViewCommand
            // 
            listViewCommand.Alignment = ListViewAlignment.Default;
            listViewCommand.Location = new Point(33, 66);
            listViewCommand.Margin = new Padding(3, 2, 3, 2);
            listViewCommand.Name = "listViewCommand";
            listViewCommand.Size = new Size(362, 253);
            listViewCommand.TabIndex = 1;
            listViewCommand.UseCompatibleStateImageBehavior = false;
            listViewCommand.View = View.List;
            // 
            // Bai_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 338);
            Controls.Add(listViewCommand);
            Controls.Add(button_listen);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Bai_2";
            Text = "Bai_2";
            FormClosed += Bai_2_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button button_listen;
        private ListView listViewCommand;
    }
}