namespace CMS_Deposit.Forms
{
    partial class frmFind
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFind));
            this.cmbheader = new System.Windows.Forms.ComboBox();
            this.cmbcondition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.condtext = new System.Windows.Forms.TextBox();
            this.dgvsearch = new System.Windows.Forms.DataGridView();
            this.pnlsaveedit = new System.Windows.Forms.Panel();
            this.btncls = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.lblTotRec = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearch)).BeginInit();
            this.pnlsaveedit.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbheader
            // 
            this.cmbheader.FormattingEnabled = true;
            this.cmbheader.Location = new System.Drawing.Point(83, 17);
            this.cmbheader.Name = "cmbheader";
            this.cmbheader.Size = new System.Drawing.Size(225, 21);
            this.cmbheader.TabIndex = 0;
            // 
            // cmbcondition
            // 
            this.cmbcondition.FormattingEnabled = true;
            this.cmbcondition.Location = new System.Drawing.Point(314, 17);
            this.cmbcondition.Name = "cmbcondition";
            this.cmbcondition.Size = new System.Drawing.Size(85, 21);
            this.cmbcondition.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search By";
            // 
            // condtext
            // 
            this.condtext.Location = new System.Drawing.Point(405, 17);
            this.condtext.Name = "condtext";
            this.condtext.Size = new System.Drawing.Size(235, 21);
            this.condtext.TabIndex = 3;
            // 
            // dgvsearch
            // 
            this.dgvsearch.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvsearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsearch.GridColor = System.Drawing.Color.Azure;
            this.dgvsearch.Location = new System.Drawing.Point(14, 43);
            this.dgvsearch.Name = "dgvsearch";
            this.dgvsearch.ReadOnly = true;
            this.dgvsearch.Size = new System.Drawing.Size(706, 357);
            this.dgvsearch.TabIndex = 5;
            this.dgvsearch.DoubleClick += new System.EventHandler(this.dgvsearch_DoubleClick);
            // 
            // pnlsaveedit
            // 
            this.pnlsaveedit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlsaveedit.Controls.Add(this.btncls);
            this.pnlsaveedit.Controls.Add(this.btnok);
            this.pnlsaveedit.Location = new System.Drawing.Point(279, 406);
            this.pnlsaveedit.Name = "pnlsaveedit";
            this.pnlsaveedit.Size = new System.Drawing.Size(158, 31);
            this.pnlsaveedit.TabIndex = 70;
            // 
            // btncls
            // 
            this.btncls.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncls.Image = ((System.Drawing.Image)(resources.GetObject("btncls.Image")));
            this.btncls.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncls.Location = new System.Drawing.Point(80, 3);
            this.btncls.Name = "btncls";
            this.btncls.Size = new System.Drawing.Size(72, 24);
            this.btncls.TabIndex = 1;
            this.btncls.Text = "Close";
            this.btncls.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncls.UseVisualStyleBackColor = true;
            this.btncls.Click += new System.EventHandler(this.btncls_Click);
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Image = ((System.Drawing.Image)(resources.GetObject("btnok.Image")));
            this.btnok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnok.Location = new System.Drawing.Point(2, 3);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(72, 24);
            this.btnok.TabIndex = 0;
            this.btnok.Text = "&Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // lblTotRec
            // 
            this.lblTotRec.AutoSize = true;
            this.lblTotRec.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotRec.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTotRec.Location = new System.Drawing.Point(14, 415);
            this.lblTotRec.Name = "lblTotRec";
            this.lblTotRec.Size = new System.Drawing.Size(101, 13);
            this.lblTotRec.TabIndex = 71;
            this.lblTotRec.Text = "Total Records : 0";
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsearch.Location = new System.Drawing.Point(646, 15);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(72, 23);
            this.btnsearch.TabIndex = 73;
            this.btnsearch.Text = "Search";
            this.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // frmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(730, 444);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.lblTotRec);
            this.Controls.Add(this.pnlsaveedit);
            this.Controls.Add(this.dgvsearch);
            this.Controls.Add(this.condtext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbcondition);
            this.Controls.Add(this.cmbheader);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find";
            this.Load += new System.EventHandler(this.Find_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearch)).EndInit();
            this.pnlsaveedit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbheader;
        private System.Windows.Forms.ComboBox cmbcondition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox condtext;
        private System.Windows.Forms.DataGridView dgvsearch;
        private System.Windows.Forms.Panel pnlsaveedit;
        private System.Windows.Forms.Button btncls;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label lblTotRec;
        private System.Windows.Forms.Button btnsearch;
    }
}