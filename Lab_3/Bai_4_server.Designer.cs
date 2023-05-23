namespace Lab_3
{
    partial class Bai_4_server
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
            columnHeader1 = new ColumnHeader();
            SuspendLayout();
            // 
            // listView
            // 
            listView.AllowDrop = true;
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView.FullRowSelect = true;
            listView.HeaderStyle = ColumnHeaderStyle.None;
            listView.Location = new Point(12, 64);
            listView.MultiSelect = false;
            listView.Name = "listView";
            listView.Size = new Size(776, 374);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // listen
            // 
            listen.Location = new Point(669, 12);
            listen.Name = "listen";
            listen.Size = new Size(119, 46);
            listen.TabIndex = 1;
            listen.Text = "Listen";
            listen.UseVisualStyleBackColor = true;
            listen.Click += listen_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 700;
            // 
            // Bai_4_server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listen);
            Controls.Add(listView);
            Name = "Bai_4_server";
            Text = "Bai_4_server";
            FormClosed += Bai_4_server_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView;
        private Button listen;
        private ColumnHeader columnHeader1;
    }
}