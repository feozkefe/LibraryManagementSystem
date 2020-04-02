namespace Library.WinUI
{
    partial class BookReturnPage
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
            this.btnreturn = new System.Windows.Forms.Button();
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
            this.datastudent.Location = new System.Drawing.Point(12, 32);
            this.datastudent.Name = "datastudent";
            this.datastudent.Size = new System.Drawing.Size(363, 304);
            this.datastudent.TabIndex = 0;
            // 
            // databook
            // 
            this.databook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databook.Location = new System.Drawing.Point(398, 32);
            this.databook.Name = "databook";
            this.databook.Size = new System.Drawing.Size(364, 304);
            this.databook.TabIndex = 0;
            // 
            // btnreturn
            // 
            this.btnreturn.Location = new System.Drawing.Point(12, 342);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(106, 48);
            this.btnreturn.TabIndex = 1;
            this.btnreturn.Text = "Return Book";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(656, 342);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(106, 48);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "Main Page";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Students:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Books are not available:";
            // 
            // BookReturnPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.databook);
            this.Controls.Add(this.datastudent);
            this.Name = "BookReturnPage";
            this.Text = "BookReturnPage";
            this.Load += new System.EventHandler(this.BookReturnPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datastudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datastudent;
        private System.Windows.Forms.DataGridView databook;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}