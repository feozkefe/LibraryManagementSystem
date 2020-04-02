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
            this.SuspendLayout();
            // 
            // btnbooks
            // 
            this.btnbooks.Location = new System.Drawing.Point(35, 58);
            this.btnbooks.Name = "btnbooks";
            this.btnbooks.Size = new System.Drawing.Size(125, 70);
            this.btnbooks.TabIndex = 0;
            this.btnbooks.Text = "Books";
            this.btnbooks.UseVisualStyleBackColor = true;
            this.btnbooks.Click += new System.EventHandler(this.btnbooks_Click);
            // 
            // btnstudents
            // 
            this.btnstudents.Location = new System.Drawing.Point(227, 58);
            this.btnstudents.Name = "btnstudents";
            this.btnstudents.Size = new System.Drawing.Size(125, 70);
            this.btnstudents.TabIndex = 0;
            this.btnstudents.Text = "Students";
            this.btnstudents.UseVisualStyleBackColor = true;
            this.btnstudents.Click += new System.EventHandler(this.btnstudents_Click);
            // 
            // btnissue
            // 
            this.btnissue.Location = new System.Drawing.Point(430, 58);
            this.btnissue.Name = "btnissue";
            this.btnissue.Size = new System.Drawing.Size(125, 70);
            this.btnissue.TabIndex = 0;
            this.btnissue.Text = "Book Issue";
            this.btnissue.UseVisualStyleBackColor = true;
            this.btnissue.Click += new System.EventHandler(this.btnissue_Click);
            // 
            // btnreturn
            // 
            this.btnreturn.Location = new System.Drawing.Point(35, 172);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(125, 70);
            this.btnreturn.TabIndex = 0;
            this.btnreturn.Text = "Book Return";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // btnavailable
            // 
            this.btnavailable.Location = new System.Drawing.Point(227, 172);
            this.btnavailable.Name = "btnavailable";
            this.btnavailable.Size = new System.Drawing.Size(125, 70);
            this.btnavailable.TabIndex = 0;
            this.btnavailable.Text = "Book Availables";
            this.btnavailable.UseVisualStyleBackColor = true;
            this.btnavailable.Click += new System.EventHandler(this.btnavailable_Click);
            // 
            // btnstaff
            // 
            this.btnstaff.Location = new System.Drawing.Point(430, 172);
            this.btnstaff.Name = "btnstaff";
            this.btnstaff.Size = new System.Drawing.Size(125, 70);
            this.btnstaff.TabIndex = 0;
            this.btnstaff.Text = "Staff Page";
            this.btnstaff.UseVisualStyleBackColor = true;
            this.btnstaff.Click += new System.EventHandler(this.btnstaff_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 278);
            this.Controls.Add(this.btnstaff);
            this.Controls.Add(this.btnavailable);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.btnissue);
            this.Controls.Add(this.btnstudents);
            this.Controls.Add(this.btnbooks);
            this.Name = "StartPage";
            this.Text = "StartPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbooks;
        private System.Windows.Forms.Button btnstudents;
        private System.Windows.Forms.Button btnissue;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Button btnavailable;
        private System.Windows.Forms.Button btnstaff;
    }
}