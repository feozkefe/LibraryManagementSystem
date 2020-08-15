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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtstdsearch = new System.Windows.Forms.TextBox();
            this.txtbooksearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datastudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databook)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datastudent
            // 
            this.datastudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datastudent.Location = new System.Drawing.Point(12, 84);
            this.datastudent.Name = "datastudent";
            this.datastudent.Size = new System.Drawing.Size(335, 277);
            this.datastudent.TabIndex = 0;
            // 
            // databook
            // 
            this.databook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databook.Location = new System.Drawing.Point(353, 84);
            this.databook.Name = "databook";
            this.databook.Size = new System.Drawing.Size(343, 277);
            this.databook.TabIndex = 0;
            // 
            // btnreturn
            // 
            this.btnreturn.Location = new System.Drawing.Point(12, 367);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(106, 48);
            this.btnreturn.TabIndex = 1;
            this.btnreturn.Text = "Return Book";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(590, 367);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(106, 48);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "Main Page";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel3.BackgroundImage = global::Library.WinUI.Properties.Resources.book;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(2, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 54);
            this.panel3.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(208, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 54);
            this.panel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(59, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Worst Library Management System Ever";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(350, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Books Are Not Available:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(12, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Students:";
            // 
            // txtstdsearch
            // 
            this.txtstdsearch.Location = new System.Drawing.Point(205, 61);
            this.txtstdsearch.Name = "txtstdsearch";
            this.txtstdsearch.Size = new System.Drawing.Size(139, 20);
            this.txtstdsearch.TabIndex = 16;
            this.txtstdsearch.TextChanged += new System.EventHandler(this.txtstdsearch_TextChanged);
            // 
            // txtbooksearch
            // 
            this.txtbooksearch.Location = new System.Drawing.Point(557, 61);
            this.txtbooksearch.Name = "txtbooksearch";
            this.txtbooksearch.Size = new System.Drawing.Size(139, 20);
            this.txtbooksearch.TabIndex = 16;
            this.txtbooksearch.TextChanged += new System.EventHandler(this.txtbooksearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(158, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Search:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(510, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Search:";
            // 
            // BookReturnPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(708, 427);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbooksearch);
            this.Controls.Add(this.txtstdsearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.databook);
            this.Controls.Add(this.datastudent);
            this.Name = "BookReturnPage";
            this.Text = "BookReturnPage";
            this.Load += new System.EventHandler(this.BookReturnPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datastudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databook)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datastudent;
        private System.Windows.Forms.DataGridView databook;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtstdsearch;
        private System.Windows.Forms.TextBox txtbooksearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}