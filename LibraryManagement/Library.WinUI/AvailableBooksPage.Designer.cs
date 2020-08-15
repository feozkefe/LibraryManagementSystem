namespace Library.WinUI
{
    partial class AvailableBooksPage
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnbook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnstd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnstdno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columndate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columndays = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnbook,
            this.columnstd,
            this.columnstdno,
            this.columndate,
            this.columndays});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(23, 69);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(659, 287);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnbook
            // 
            this.columnbook.Text = "Book";
            this.columnbook.Width = 117;
            // 
            // columnstd
            // 
            this.columnstd.Text = "Student Name";
            this.columnstd.Width = 127;
            // 
            // columnstdno
            // 
            this.columnstdno.Text = "Student Number";
            this.columnstdno.Width = 152;
            // 
            // columndate
            // 
            this.columndate.Text = "Issue Date";
            this.columndate.Width = 141;
            // 
            // columndays
            // 
            this.columndays.Text = "Days";
            this.columndays.Width = 114;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Main Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel3.BackgroundImage = global::Library.WinUI.Properties.Resources.book;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 54);
            this.panel3.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(206, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 54);
            this.panel2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(85, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Worst Library Management System Ever";
            // 
            // AvailableBooksPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(708, 427);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "AvailableBooksPage";
            this.Text = "AvailableBooksPage";
            this.Load += new System.EventHandler(this.AvailableBooksPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnbook;
        private System.Windows.Forms.ColumnHeader columnstd;
        private System.Windows.Forms.ColumnHeader columnstdno;
        private System.Windows.Forms.ColumnHeader columndate;
        private System.Windows.Forms.ColumnHeader columndays;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}