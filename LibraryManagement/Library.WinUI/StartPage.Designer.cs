namespace Library.WinUI
{
    partial class StartPage
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
            this.btnbooks = new System.Windows.Forms.Button();
            this.btnstudents = new System.Windows.Forms.Button();
            this.btnissue = new System.Windows.Forms.Button();
            this.btnreturn = new System.Windows.Forms.Button();
            this.btnavailable = new System.Windows.Forms.Button();
            this.btnstaff = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnbooks
            // 
            this.btnbooks.Location = new System.Drawing.Point(0, 6);
            this.btnbooks.Name = "btnbooks";
            this.btnbooks.Size = new System.Drawing.Size(203, 47);
            this.btnbooks.TabIndex = 0;
            this.btnbooks.Text = "Books";
            this.btnbooks.UseVisualStyleBackColor = true;
            this.btnbooks.Click += new System.EventHandler(this.btnbooks_Click);
            // 
            // btnstudents
            // 
            this.btnstudents.Location = new System.Drawing.Point(0, 66);
            this.btnstudents.Name = "btnstudents";
            this.btnstudents.Size = new System.Drawing.Size(203, 47);
            this.btnstudents.TabIndex = 0;
            this.btnstudents.Text = "Students";
            this.btnstudents.UseVisualStyleBackColor = true;
            this.btnstudents.Click += new System.EventHandler(this.btnstudents_Click);
            // 
            // btnissue
            // 
            this.btnissue.Location = new System.Drawing.Point(0, 128);
            this.btnissue.Name = "btnissue";
            this.btnissue.Size = new System.Drawing.Size(203, 47);
            this.btnissue.TabIndex = 0;
            this.btnissue.Text = "Book Issue";
            this.btnissue.UseVisualStyleBackColor = true;
            this.btnissue.Click += new System.EventHandler(this.btnissue_Click);
            // 
            // btnreturn
            // 
            this.btnreturn.Location = new System.Drawing.Point(0, 191);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(203, 47);
            this.btnreturn.TabIndex = 0;
            this.btnreturn.Text = "Book Return";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // btnavailable
            // 
            this.btnavailable.Location = new System.Drawing.Point(0, 255);
            this.btnavailable.Name = "btnavailable";
            this.btnavailable.Size = new System.Drawing.Size(203, 47);
            this.btnavailable.TabIndex = 0;
            this.btnavailable.Text = "Books Not Returned";
            this.btnavailable.UseVisualStyleBackColor = true;
            this.btnavailable.Click += new System.EventHandler(this.btnavailable_Click);
            // 
            // btnstaff
            // 
            this.btnstaff.Location = new System.Drawing.Point(-3, 317);
            this.btnstaff.Name = "btnstaff";
            this.btnstaff.Size = new System.Drawing.Size(203, 47);
            this.btnstaff.TabIndex = 0;
            this.btnstaff.Text = "Staff Page";
            this.btnstaff.UseVisualStyleBackColor = true;
            this.btnstaff.Click += new System.EventHandler(this.btnstaff_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnbooks);
            this.panel1.Controls.Add(this.btnstudents);
            this.panel1.Controls.Add(this.btnissue);
            this.panel1.Controls.Add(this.btnstaff);
            this.panel1.Controls.Add(this.btnreturn);
            this.panel1.Controls.Add(this.btnavailable);
            this.panel1.Location = new System.Drawing.Point(3, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 374);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(205, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 50);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel3.BackgroundImage = global::Library.WinUI.Properties.Resources.book;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(3, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 50);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(80, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Worst Library Management System Ever";
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::Library.WinUI.Properties.Resources.photo_1507842217343_583bb7270b66;
            this.ClientSize = new System.Drawing.Size(708, 427);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StartPage";
            this.Text = "StartPage";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbooks;
        private System.Windows.Forms.Button btnstudents;
        private System.Windows.Forms.Button btnissue;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Button btnavailable;
        private System.Windows.Forms.Button btnstaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}