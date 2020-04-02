namespace Library.WinUI
{
    partial class BookIssuePage
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
            this.datastudent = new System.Windows.Forms.DataGridView();
            this.databook = new System.Windows.Forms.DataGridView();
            this.btngive = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datastudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databook)).BeginInit();
            this.SuspendLayout();
            // 
            // datastudent
            // 
            this.datastudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datastudent.Location = new System.Drawing.Point(12, 42);
            this.datastudent.Name = "datastudent";
            this.datastudent.Size = new System.Drawing.Size(389, 338);
            this.datastudent.TabIndex = 0;
            // 
            // databook
            // 
            this.databook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databook.Location = new System.Drawing.Point(418, 42);
            this.databook.Name = "databook";
            this.databook.Size = new System.Drawing.Size(389, 338);
            this.databook.TabIndex = 0;
            // 
            // btngive
            // 
            this.btngive.Location = new System.Drawing.Point(12, 386);
            this.btngive.Name = "btngive";
            this.btngive.Size = new System.Drawing.Size(113, 56);
            this.btngive.TabIndex = 1;
            this.btngive.Text = "Give Book ";
            this.btngive.UseVisualStyleBackColor = true;
            this.btngive.Click += new System.EventHandler(this.btngive_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(694, 386);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(113, 56);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "Back to Main Page ";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Books Available:";
            // 
            // BookIssuePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 454);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btngive);
            this.Controls.Add(this.databook);
            this.Controls.Add(this.datastudent);
            this.Name = "BookIssuePage";
            this.Text = "BookIssuePage";
            this.Load += new System.EventHandler(this.BookIssuePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datastudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datastudent;
        private System.Windows.Forms.DataGridView databook;
        private System.Windows.Forms.Button btngive;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}