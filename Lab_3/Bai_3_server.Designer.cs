namespace Lab_3
{
    partial class Bai_3_server
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
            listen = new Button();
            SuspendLayout();
            // 
            // listView
            // 
            listView.BorderStyle = BorderStyle.FixedSingle;
            listView.Location = new Point(14, 55);
            listView.Margin = new Padding(3, 4, 3, 4);
            listView.Name = "listView";
            listView.Size = new Size(563, 529);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.List;
            // 
            // listen
            // 
            listen.Location = new Point(491, 16);
            listen.Margin = new Padding(3, 4, 3, 4);
            listen.Name = "listen";
            listen.Size = new Size(86, 31);
            listen.TabIndex = 1;
            listen.Text = "Listen";
            listen.UseVisualStyleBackColor = true;
            listen.Click += listen_Click;
            // 
            // Bai_3_server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 600);
            Controls.Add(listen);
            Controls.Add(listView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Bai_3_server";
            Text = "Bai_3_server";
            FormClosed += Bai_3_server_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView;
        private Button listen;
    }
}