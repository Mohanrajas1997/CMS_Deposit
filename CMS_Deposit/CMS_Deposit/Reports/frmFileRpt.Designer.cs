namespace CMS_Deposit.Reports
{
    partial class frmFileRpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFileRpt));
            this.pnlmain = new System.Windows.Forms.Panel();
            this.txtSheetName = new System.Windows.Forms.TextBox();
            this.lblPayamt = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblSuppno = new System.Windows.Forms.Label();
            this.dtpImportTo = new System.Windows.Forms.DateTimePicker();
            this.lblPayto = new System.Windows.Forms.Label();
            this.dtpImportFrom = new System.Windows.Forms.DateTimePicker();
            this.lblPayfrm = new System.Windows.Forms.Label();
            this.dgvDeposit = new System.Windows.Forms.DataGridView();
            this.lblload = new System.Windows.Forms.Label();
            this.btnexport = new System.Windows.Forms.Button();
            this.btncls = new System.Windows.Forms.Button();
            this.btnref = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.lblTotRec = new System.Windows.Forms.Label();
            this.pnlmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlmain
            // 
            this.pnlmain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlmain.Controls.Add(this.txtSheetName);
            this.pnlmain.Controls.Add(this.lblPayamt);
            this.pnlmain.Controls.Add(this.txtFileName);
            this.pnlmain.Controls.Add(this.lblSuppno);
            this.pnlmain.Controls.Add(this.dtpImportTo);
            this.pnlmain.Controls.Add(this.lblPayto);
            this.pnlmain.Controls.Add(this.dtpImportFrom);
            this.pnlmain.Controls.Add(this.lblPayfrm);
            this.pnlmain.Location = new System.Drawing.Point(3, 6);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(1085, 37);
            this.pnlmain.TabIndex = 0;
            // 
            // txtSheetName
            // 
            this.txtSheetName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSheetName.Location = new System.Drawing.Point(834, 8);
            this.txtSheetName.MaxLength = 16;
            this.txtSheetName.Name = "txtSheetName";
            this.txtSheetName.Size = new System.Drawing.Size(238, 21);
            this.txtSheetName.TabIndex = 3;
            // 
            // lblPayamt
            // 
            this.lblPayamt.AutoSize = true;
            this.lblPayamt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPayamt.Location = new System.Drawing.Point(753, 12);
            this.lblPayamt.Name = "lblPayamt";
            this.lblPayamt.Size = new System.Drawing.Size(75, 13);
            this.lblPayamt.TabIndex = 31;
            this.lblPayamt.Text = "Sheet Name";
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(496, 8);
            this.txtFileName.MaxLength = 16;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(238, 21);
            this.txtFileName.TabIndex = 2;
            // 
            // lblSuppno
            // 
            this.lblSuppno.AutoSize = true;
            this.lblSuppno.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSuppno.Location = new System.Drawing.Point(429, 12);
            this.lblSuppno.Name = "lblSuppno";
            this.lblSuppno.Size = new System.Drawing.Size(61, 13);
            this.lblSuppno.TabIndex = 29;
            this.lblSuppno.Text = "File Name";
            // 
            // dtpImportTo
            // 
            this.dtpImportTo.Checked = false;
            this.dtpImportTo.CustomFormat = "dd-MM-yyyy";
            this.dtpImportTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpImportTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpImportTo.Location = new System.Drawing.Point(291, 8);
            this.dtpImportTo.Name = "dtpImportTo";
            this.dtpImportTo.ShowCheckBox = true;
            this.dtpImportTo.Size = new System.Drawing.Size(124, 21);
            this.dtpImportTo.TabIndex = 1;
            // 
            // lblPayto
            // 
            this.lblPayto.AutoSize = true;
            this.lblPayto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPayto.Location = new System.Drawing.Point(264, 12);
            this.lblPayto.Name = "lblPayto";
            this.lblPayto.Size = new System.Drawing.Size(21, 13);
            this.lblPayto.TabIndex = 27;
            this.lblPayto.Text = "To";
            // 
            // dtpImportFrom
            // 
            this.dtpImportFrom.Checked = false;
            this.dtpImportFrom.CustomFormat = "dd-MM-yyyy";
            this.dtpImportFrom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpImportFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpImportFrom.Location = new System.Drawing.Point(91, 8);
            this.dtpImportFrom.Name = "dtpImportFrom";
            this.dtpImportFrom.ShowCheckBox = true;
            this.dtpImportFrom.Size = new System.Drawing.Size(124, 21);
            this.dtpImportFrom.TabIndex = 0;
            // 
            // lblPayfrm
            // 
            this.lblPayfrm.AutoSize = true;
            this.lblPayfrm.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPayfrm.Location = new System.Drawing.Point(6, 12);
            this.lblPayfrm.Name = "lblPayfrm";
            this.lblPayfrm.Size = new System.Drawing.Size(79, 13);
            this.lblPayfrm.TabIndex = 25;
            this.lblPayfrm.Text = "Import From";
            // 
            // dt
            // 
            this.dgvDeposit.AllowUserToAddRows = false;
            this.dgvDeposit.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDeposit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeposit.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeposit.GridColor = System.Drawing.Color.Azure;
            this.dgvDeposit.Location = new System.Drawing.Point(3, 78);
            this.dgvDeposit.Name = "dgvDeposit";
            this.dgvDeposit.ReadOnly = true;
            this.dgvDeposit.RowTemplate.ReadOnly = true;
            this.dgvDeposit.Size = new System.Drawing.Size(1179, 448);
            this.dgvDeposit.TabIndex = 81;
            // 
            // lblload
            // 
            this.lblload.AutoSize = true;
            this.lblload.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblload.ForeColor = System.Drawing.Color.Red;
            this.lblload.Location = new System.Drawing.Point(336, 52);
            this.lblload.Name = "lblload";
            this.lblload.Size = new System.Drawing.Size(57, 13);
            this.lblload.TabIndex = 80;
            this.lblload.Text = "Loading..";
            this.lblload.Visible = false;
            // 
            // btnexport
            // 
            this.btnexport.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnexport.Image = ((System.Drawing.Image)(resources.GetObject("btnexport.Image")));
            this.btnexport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexport.Location = new System.Drawing.Point(938, 49);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(72, 24);
            this.btnexport.TabIndex = 2;
            this.btnexport.Text = "Export";
            this.btnexport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexport.UseVisualStyleBackColor = true;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // btncls
            // 
            this.btncls.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btncls.Image = ((System.Drawing.Image)(resources.GetObject("btncls.Image")));
            this.btncls.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncls.Location = new System.Drawing.Point(1016, 49);
            this.btncls.Name = "btncls";
            this.btncls.Size = new System.Drawing.Size(72, 24);
            this.btncls.TabIndex = 3;
            this.btncls.Text = "Close";
            this.btncls.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncls.UseVisualStyleBackColor = true;
            this.btncls.Click += new System.EventHandler(this.btncls_Click);
            // 
            // btnref
            // 
            this.btnref.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnref.Image = ((System.Drawing.Image)(resources.GetObject("btnref.Image")));
            this.btnref.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnref.Location = new System.Drawing.Point(860, 49);
            this.btnref.Name = "btnref";
            this.btnref.Size = new System.Drawing.Size(72, 24);
            this.btnref.TabIndex = 1;
            this.btnref.Text = "Refresh";
            this.btnref.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnref.UseVisualStyleBackColor = true;
            this.btnref.Click += new System.EventHandler(this.btnref_Click);
            // 
            // btnload
            // 
            this.btnload.Image = ((System.Drawing.Image)(resources.GetObject("btnload.Image")));
            this.btnload.Location = new System.Drawing.Point(403, 49);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(164, 19);
            this.btnload.TabIndex = 83;
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Visible = false;
            // 
            // lblTotRec
            // 
            this.lblTotRec.AutoSize = true;
            this.lblTotRec.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTotRec.ForeColor = System.Drawing.Color.Blue;
            this.lblTotRec.Location = new System.Drawing.Point(0, 52);
            this.lblTotRec.Name = "lblTotRec";
            this.lblTotRec.Size = new System.Drawing.Size(94, 13);
            this.lblTotRec.TabIndex = 84;
            this.lblTotRec.Text = "Total Records : ";
            // 
            // frmFileRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1189, 526);
            this.Controls.Add(this.lblTotRec);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.dgvDeposit);
            this.Controls.Add(this.lblload);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.btncls);
            this.Controls.Add(this.btnref);
            this.Controls.Add(this.pnlmain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFileRpt";
            this.Text = "File Report";
            this.Load += new System.EventHandler(this.frmDepositRpt_Load);
            this.Resize += new System.EventHandler(this.frmDepositRpt_Resize);
            this.pnlmain.ResumeLayout(false);
            this.pnlmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlmain;
        private System.Windows.Forms.TextBox txtSheetName;
        private System.Windows.Forms.Label lblPayamt;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblSuppno;
        private System.Windows.Forms.DateTimePicker dtpImportTo;
        private System.Windows.Forms.Label lblPayto;
        private System.Windows.Forms.DateTimePicker dtpImportFrom;
        private System.Windows.Forms.Label lblPayfrm;
        private System.Windows.Forms.DataGridView dgvDeposit;
        private System.Windows.Forms.Label lblload;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btncls;
        private System.Windows.Forms.Button btnref;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Label lblTotRec;
    }
}