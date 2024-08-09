namespace CMS_Deposit.Reports
{
    partial class frmClearingRpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClearingRpt));
            this.pnlmain = new System.Windows.Forms.Panel();
            this.txtClearingId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUploadId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChqId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpChqTo = new System.Windows.Forms.DateTimePicker();
            this.dtpChqFrom = new System.Windows.Forms.DateTimePicker();
            this.cmbFileName = new System.Windows.Forms.ComboBox();
            this.txtDepositAmt = new System.Windows.Forms.TextBox();
            this.lblPayamt = new System.Windows.Forms.Label();
            this.txtChqNo = new System.Windows.Forms.TextBox();
            this.lblSuppno = new System.Windows.Forms.Label();
            this.dtpClrgTo = new System.Windows.Forms.DateTimePicker();
            this.lblPayto = new System.Windows.Forms.Label();
            this.dtpClrgFrom = new System.Windows.Forms.DateTimePicker();
            this.lblPayfrm = new System.Windows.Forms.Label();
            this.lblremarks = new System.Windows.Forms.Label();
            this.lblsupp = new System.Windows.Forms.Label();
            this.lblmdul = new System.Windows.Forms.Label();
            this.dgvDeposit = new System.Windows.Forms.DataGridView();
            this.lblload = new System.Windows.Forms.Label();
            this.lblTotRec = new System.Windows.Forms.Label();
            this.btnload = new System.Windows.Forms.Button();
            this.btnexport = new System.Windows.Forms.Button();
            this.btncls = new System.Windows.Forms.Button();
            this.btnref = new System.Windows.Forms.Button();
            this.pnlmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlmain
            // 
            this.pnlmain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlmain.Controls.Add(this.txtClearingId);
            this.pnlmain.Controls.Add(this.label4);
            this.pnlmain.Controls.Add(this.cmbStatus);
            this.pnlmain.Controls.Add(this.label3);
            this.pnlmain.Controls.Add(this.txtUploadId);
            this.pnlmain.Controls.Add(this.label2);
            this.pnlmain.Controls.Add(this.txtChqId);
            this.pnlmain.Controls.Add(this.label1);
            this.pnlmain.Controls.Add(this.dtpChqTo);
            this.pnlmain.Controls.Add(this.dtpChqFrom);
            this.pnlmain.Controls.Add(this.cmbFileName);
            this.pnlmain.Controls.Add(this.txtDepositAmt);
            this.pnlmain.Controls.Add(this.lblPayamt);
            this.pnlmain.Controls.Add(this.txtChqNo);
            this.pnlmain.Controls.Add(this.lblSuppno);
            this.pnlmain.Controls.Add(this.dtpClrgTo);
            this.pnlmain.Controls.Add(this.lblPayto);
            this.pnlmain.Controls.Add(this.dtpClrgFrom);
            this.pnlmain.Controls.Add(this.lblPayfrm);
            this.pnlmain.Controls.Add(this.lblremarks);
            this.pnlmain.Controls.Add(this.lblsupp);
            this.pnlmain.Controls.Add(this.lblmdul);
            this.pnlmain.Location = new System.Drawing.Point(3, 6);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(1179, 102);
            this.pnlmain.TabIndex = 0;
            // 
            // txtClearingId
            // 
            this.txtClearingId.Location = new System.Drawing.Point(399, 70);
            this.txtClearingId.Name = "txtClearingId";
            this.txtClearingId.Size = new System.Drawing.Size(179, 21);
            this.txtClearingId.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Clearing Id";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(993, 70);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(180, 21);
            this.cmbStatus.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(890, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Status";
            // 
            // txtUploadId
            // 
            this.txtUploadId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUploadId.Location = new System.Drawing.Point(704, 70);
            this.txtUploadId.MaxLength = 16;
            this.txtUploadId.Name = "txtUploadId";
            this.txtUploadId.Size = new System.Drawing.Size(175, 21);
            this.txtUploadId.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Upload Id";
            // 
            // txtChqId
            // 
            this.txtChqId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChqId.Location = new System.Drawing.Point(118, 70);
            this.txtChqId.MaxLength = 16;
            this.txtChqId.Name = "txtChqId";
            this.txtChqId.Size = new System.Drawing.Size(179, 21);
            this.txtChqId.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Cheque Id";
            // 
            // dtpChqTo
            // 
            this.dtpChqTo.Checked = false;
            this.dtpChqTo.CustomFormat = "dd-MM-yyyy";
            this.dtpChqTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpChqTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChqTo.Location = new System.Drawing.Point(399, 40);
            this.dtpChqTo.Name = "dtpChqTo";
            this.dtpChqTo.ShowCheckBox = true;
            this.dtpChqTo.Size = new System.Drawing.Size(179, 21);
            this.dtpChqTo.TabIndex = 5;
            // 
            // dtpChqFrom
            // 
            this.dtpChqFrom.Checked = false;
            this.dtpChqFrom.CustomFormat = "dd-MM-yyyy";
            this.dtpChqFrom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpChqFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChqFrom.Location = new System.Drawing.Point(118, 40);
            this.dtpChqFrom.Name = "dtpChqFrom";
            this.dtpChqFrom.ShowCheckBox = true;
            this.dtpChqFrom.Size = new System.Drawing.Size(179, 21);
            this.dtpChqFrom.TabIndex = 4;
            // 
            // cmbFileName
            // 
            this.cmbFileName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFileName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFileName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFileName.FormattingEnabled = true;
            this.cmbFileName.Location = new System.Drawing.Point(704, 40);
            this.cmbFileName.Name = "cmbFileName";
            this.cmbFileName.Size = new System.Drawing.Size(468, 21);
            this.cmbFileName.TabIndex = 6;
            // 
            // txtDepositAmt
            // 
            this.txtDepositAmt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepositAmt.Location = new System.Drawing.Point(993, 8);
            this.txtDepositAmt.MaxLength = 16;
            this.txtDepositAmt.Name = "txtDepositAmt";
            this.txtDepositAmt.Size = new System.Drawing.Size(180, 21);
            this.txtDepositAmt.TabIndex = 3;
            // 
            // lblPayamt
            // 
            this.lblPayamt.AutoSize = true;
            this.lblPayamt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPayamt.Location = new System.Drawing.Point(890, 12);
            this.lblPayamt.Name = "lblPayamt";
            this.lblPayamt.Size = new System.Drawing.Size(76, 13);
            this.lblPayamt.TabIndex = 31;
            this.lblPayamt.Text = "Cheque Amt";
            // 
            // txtChqNo
            // 
            this.txtChqNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChqNo.Location = new System.Drawing.Point(704, 8);
            this.txtChqNo.MaxLength = 16;
            this.txtChqNo.Name = "txtChqNo";
            this.txtChqNo.Size = new System.Drawing.Size(175, 21);
            this.txtChqNo.TabIndex = 2;
            // 
            // lblSuppno
            // 
            this.lblSuppno.AutoSize = true;
            this.lblSuppno.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSuppno.Location = new System.Drawing.Point(592, 12);
            this.lblSuppno.Name = "lblSuppno";
            this.lblSuppno.Size = new System.Drawing.Size(66, 13);
            this.lblSuppno.TabIndex = 29;
            this.lblSuppno.Text = "Cheque No";
            // 
            // dtpClrgTo
            // 
            this.dtpClrgTo.Checked = false;
            this.dtpClrgTo.CustomFormat = "dd-MM-yyyy";
            this.dtpClrgTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpClrgTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpClrgTo.Location = new System.Drawing.Point(399, 8);
            this.dtpClrgTo.Name = "dtpClrgTo";
            this.dtpClrgTo.ShowCheckBox = true;
            this.dtpClrgTo.Size = new System.Drawing.Size(179, 21);
            this.dtpClrgTo.TabIndex = 1;
            // 
            // lblPayto
            // 
            this.lblPayto.AutoSize = true;
            this.lblPayto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPayto.Location = new System.Drawing.Point(304, 12);
            this.lblPayto.Name = "lblPayto";
            this.lblPayto.Size = new System.Drawing.Size(70, 13);
            this.lblPayto.TabIndex = 27;
            this.lblPayto.Text = "Clearing To";
            // 
            // dtpClrgFrom
            // 
            this.dtpClrgFrom.Checked = false;
            this.dtpClrgFrom.CustomFormat = "dd-MM-yyyy";
            this.dtpClrgFrom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpClrgFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpClrgFrom.Location = new System.Drawing.Point(118, 8);
            this.dtpClrgFrom.Name = "dtpClrgFrom";
            this.dtpClrgFrom.ShowCheckBox = true;
            this.dtpClrgFrom.Size = new System.Drawing.Size(179, 21);
            this.dtpClrgFrom.TabIndex = 0;
            // 
            // lblPayfrm
            // 
            this.lblPayfrm.AutoSize = true;
            this.lblPayfrm.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPayfrm.Location = new System.Drawing.Point(6, 12);
            this.lblPayfrm.Name = "lblPayfrm";
            this.lblPayfrm.Size = new System.Drawing.Size(85, 13);
            this.lblPayfrm.TabIndex = 25;
            this.lblPayfrm.Text = "Clearing From";
            // 
            // lblremarks
            // 
            this.lblremarks.AutoSize = true;
            this.lblremarks.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblremarks.Location = new System.Drawing.Point(592, 44);
            this.lblremarks.Name = "lblremarks";
            this.lblremarks.Size = new System.Drawing.Size(61, 13);
            this.lblremarks.TabIndex = 23;
            this.lblremarks.Text = "File Name";
            // 
            // lblsupp
            // 
            this.lblsupp.AutoSize = true;
            this.lblsupp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblsupp.Location = new System.Drawing.Point(304, 44);
            this.lblsupp.Name = "lblsupp";
            this.lblsupp.Size = new System.Drawing.Size(66, 13);
            this.lblsupp.TabIndex = 21;
            this.lblsupp.Text = "Cheque To";
            // 
            // lblmdul
            // 
            this.lblmdul.AutoSize = true;
            this.lblmdul.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblmdul.Location = new System.Drawing.Point(6, 44);
            this.lblmdul.Name = "lblmdul";
            this.lblmdul.Size = new System.Drawing.Size(81, 13);
            this.lblmdul.TabIndex = 19;
            this.lblmdul.Text = "Cheque From";
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
            this.dgvDeposit.Location = new System.Drawing.Point(3, 144);
            this.dgvDeposit.Name = "dgvDeposit";
            this.dgvDeposit.ReadOnly = true;
            this.dgvDeposit.RowTemplate.ReadOnly = true;
            this.dgvDeposit.Size = new System.Drawing.Size(1179, 378);
            this.dgvDeposit.TabIndex = 7;
            // 
            // lblload
            // 
            this.lblload.AutoSize = true;
            this.lblload.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblload.ForeColor = System.Drawing.Color.Red;
            this.lblload.Location = new System.Drawing.Point(336, 120);
            this.lblload.Name = "lblload";
            this.lblload.Size = new System.Drawing.Size(57, 13);
            this.lblload.TabIndex = 2;
            this.lblload.Text = "Loading..";
            this.lblload.Visible = false;
            // 
            // lblTotRec
            // 
            this.lblTotRec.AutoSize = true;
            this.lblTotRec.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTotRec.ForeColor = System.Drawing.Color.Blue;
            this.lblTotRec.Location = new System.Drawing.Point(1, 120);
            this.lblTotRec.Name = "lblTotRec";
            this.lblTotRec.Size = new System.Drawing.Size(94, 13);
            this.lblTotRec.TabIndex = 1;
            this.lblTotRec.Text = "Total Records : ";
            // 
            // btnload
            // 
            this.btnload.Image = ((System.Drawing.Image)(resources.GetObject("btnload.Image")));
            this.btnload.Location = new System.Drawing.Point(403, 117);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(164, 19);
            this.btnload.TabIndex = 3;
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Visible = false;
            // 
            // btnexport
            // 
            this.btnexport.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnexport.Image = ((System.Drawing.Image)(resources.GetObject("btnexport.Image")));
            this.btnexport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexport.Location = new System.Drawing.Point(1032, 114);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(72, 24);
            this.btnexport.TabIndex = 5;
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
            this.btncls.Location = new System.Drawing.Point(1110, 114);
            this.btncls.Name = "btncls";
            this.btncls.Size = new System.Drawing.Size(72, 24);
            this.btncls.TabIndex = 6;
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
            this.btnref.Location = new System.Drawing.Point(954, 114);
            this.btnref.Name = "btnref";
            this.btnref.Size = new System.Drawing.Size(72, 24);
            this.btnref.TabIndex = 4;
            this.btnref.Text = "Refresh";
            this.btnref.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnref.UseVisualStyleBackColor = true;
            this.btnref.Click += new System.EventHandler(this.btnref_Click);
            // 
            // frmClearingRpt
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
            this.Controls.Add(this.pnlmain);
            this.Controls.Add(this.btncls);
            this.Controls.Add(this.btnref);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClearingRpt";
            this.Text = "Clearing Report";
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
        private System.Windows.Forms.TextBox txtDepositAmt;
        private System.Windows.Forms.Label lblPayamt;
        private System.Windows.Forms.TextBox txtChqNo;
        private System.Windows.Forms.Label lblSuppno;
        private System.Windows.Forms.DateTimePicker dtpClrgTo;
        private System.Windows.Forms.Label lblPayto;
        private System.Windows.Forms.DateTimePicker dtpClrgFrom;
        private System.Windows.Forms.Label lblPayfrm;
        private System.Windows.Forms.Label lblremarks;
        private System.Windows.Forms.Label lblsupp;
        private System.Windows.Forms.Label lblmdul;
        private System.Windows.Forms.DataGridView dgvDeposit;
        private System.Windows.Forms.Label lblload;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btncls;
        private System.Windows.Forms.Button btnref;
        private System.Windows.Forms.ComboBox cmbFileName;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.DateTimePicker dtpChqFrom;
        private System.Windows.Forms.DateTimePicker dtpChqTo;
        private System.Windows.Forms.TextBox txtChqId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUploadId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClearingId;
        private System.Windows.Forms.Label lblTotRec;
    }
}