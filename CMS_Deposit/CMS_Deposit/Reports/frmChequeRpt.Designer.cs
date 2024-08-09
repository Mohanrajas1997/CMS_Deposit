namespace CMS_Deposit.Reports
{
    partial class frmChequeRpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChequeRpt));
            this.pnlmain = new System.Windows.Forms.Panel();
            this.txtClearingId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtChqId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDepositId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDepositAmt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepositSlipNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDepositTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDepositFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChequeAmt = new System.Windows.Forms.TextBox();
            this.lblPayamt = new System.Windows.Forms.Label();
            this.txtChequeNo = new System.Windows.Forms.TextBox();
            this.lblSuppno = new System.Windows.Forms.Label();
            this.dtpChqTo = new System.Windows.Forms.DateTimePicker();
            this.lblPayto = new System.Windows.Forms.Label();
            this.dtpChqFrom = new System.Windows.Forms.DateTimePicker();
            this.lblPayfrm = new System.Windows.Forms.Label();
            this.dgvDeposit = new System.Windows.Forms.DataGridView();
            this.lblload = new System.Windows.Forms.Label();
            this.btnload = new System.Windows.Forms.Button();
            this.btnexport = new System.Windows.Forms.Button();
            this.btncls = new System.Windows.Forms.Button();
            this.btnref = new System.Windows.Forms.Button();
            this.lblTotRec = new System.Windows.Forms.Label();
            this.pnlmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlmain
            // 
            this.pnlmain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlmain.Controls.Add(this.txtClearingId);
            this.pnlmain.Controls.Add(this.label8);
            this.pnlmain.Controls.Add(this.cmbStatus);
            this.pnlmain.Controls.Add(this.label7);
            this.pnlmain.Controls.Add(this.txtChqId);
            this.pnlmain.Controls.Add(this.label6);
            this.pnlmain.Controls.Add(this.txtDepositId);
            this.pnlmain.Controls.Add(this.label5);
            this.pnlmain.Controls.Add(this.txtDepositAmt);
            this.pnlmain.Controls.Add(this.label4);
            this.pnlmain.Controls.Add(this.txtDepositSlipNo);
            this.pnlmain.Controls.Add(this.label3);
            this.pnlmain.Controls.Add(this.dtpDepositTo);
            this.pnlmain.Controls.Add(this.label2);
            this.pnlmain.Controls.Add(this.dtpDepositFrom);
            this.pnlmain.Controls.Add(this.label1);
            this.pnlmain.Controls.Add(this.txtChequeAmt);
            this.pnlmain.Controls.Add(this.lblPayamt);
            this.pnlmain.Controls.Add(this.txtChequeNo);
            this.pnlmain.Controls.Add(this.lblSuppno);
            this.pnlmain.Controls.Add(this.dtpChqTo);
            this.pnlmain.Controls.Add(this.lblPayto);
            this.pnlmain.Controls.Add(this.dtpChqFrom);
            this.pnlmain.Controls.Add(this.lblPayfrm);
            this.pnlmain.Location = new System.Drawing.Point(3, 6);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(1179, 97);
            this.pnlmain.TabIndex = 0;
            // 
            // txtClearingId
            // 
            this.txtClearingId.Location = new System.Drawing.Point(700, 67);
            this.txtClearingId.Name = "txtClearingId";
            this.txtClearingId.Size = new System.Drawing.Size(179, 21);
            this.txtClearingId.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(586, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Clearing Id";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(994, 67);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(180, 21);
            this.cmbStatus.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(890, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Status";
            // 
            // txtChqId
            // 
            this.txtChqId.Location = new System.Drawing.Point(399, 67);
            this.txtChqId.Name = "txtChqId";
            this.txtChqId.Size = new System.Drawing.Size(179, 21);
            this.txtChqId.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Cheque Id";
            // 
            // txtDepositId
            // 
            this.txtDepositId.Location = new System.Drawing.Point(118, 67);
            this.txtDepositId.Name = "txtDepositId";
            this.txtDepositId.Size = new System.Drawing.Size(179, 21);
            this.txtDepositId.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Deposit Id";
            // 
            // txtDepositAmt
            // 
            this.txtDepositAmt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepositAmt.Location = new System.Drawing.Point(994, 38);
            this.txtDepositAmt.MaxLength = 16;
            this.txtDepositAmt.Name = "txtDepositAmt";
            this.txtDepositAmt.Size = new System.Drawing.Size(180, 21);
            this.txtDepositAmt.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(890, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Deposit Amount";
            // 
            // txtDepositSlipNo
            // 
            this.txtDepositSlipNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepositSlipNo.Location = new System.Drawing.Point(700, 38);
            this.txtDepositSlipNo.MaxLength = 16;
            this.txtDepositSlipNo.Name = "txtDepositSlipNo";
            this.txtDepositSlipNo.Size = new System.Drawing.Size(180, 21);
            this.txtDepositSlipNo.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(586, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Deposit Slip No";
            // 
            // dtpDepositTo
            // 
            this.dtpDepositTo.Checked = false;
            this.dtpDepositTo.CustomFormat = "dd-MM-yyyy";
            this.dtpDepositTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpDepositTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepositTo.Location = new System.Drawing.Point(399, 38);
            this.dtpDepositTo.Name = "dtpDepositTo";
            this.dtpDepositTo.ShowCheckBox = true;
            this.dtpDepositTo.Size = new System.Drawing.Size(179, 21);
            this.dtpDepositTo.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Deposit To";
            // 
            // dtpDepositFrom
            // 
            this.dtpDepositFrom.Checked = false;
            this.dtpDepositFrom.CustomFormat = "dd-MM-yyyy";
            this.dtpDepositFrom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpDepositFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepositFrom.Location = new System.Drawing.Point(118, 38);
            this.dtpDepositFrom.Name = "dtpDepositFrom";
            this.dtpDepositFrom.ShowCheckBox = true;
            this.dtpDepositFrom.Size = new System.Drawing.Size(179, 21);
            this.dtpDepositFrom.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Deposit From";
            // 
            // txtChequeAmt
            // 
            this.txtChequeAmt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChequeAmt.Location = new System.Drawing.Point(993, 8);
            this.txtChequeAmt.MaxLength = 16;
            this.txtChequeAmt.Name = "txtChequeAmt";
            this.txtChequeAmt.Size = new System.Drawing.Size(180, 21);
            this.txtChequeAmt.TabIndex = 3;
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
            // txtChequeNo
            // 
            this.txtChequeNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChequeNo.Location = new System.Drawing.Point(700, 8);
            this.txtChequeNo.MaxLength = 16;
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Size = new System.Drawing.Size(180, 21);
            this.txtChequeNo.TabIndex = 2;
            // 
            // lblSuppno
            // 
            this.lblSuppno.AutoSize = true;
            this.lblSuppno.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSuppno.Location = new System.Drawing.Point(586, 12);
            this.lblSuppno.Name = "lblSuppno";
            this.lblSuppno.Size = new System.Drawing.Size(66, 13);
            this.lblSuppno.TabIndex = 29;
            this.lblSuppno.Text = "Cheque No";
            // 
            // dtpChqTo
            // 
            this.dtpChqTo.Checked = false;
            this.dtpChqTo.CustomFormat = "dd-MM-yyyy";
            this.dtpChqTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpChqTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChqTo.Location = new System.Drawing.Point(399, 8);
            this.dtpChqTo.Name = "dtpChqTo";
            this.dtpChqTo.ShowCheckBox = true;
            this.dtpChqTo.Size = new System.Drawing.Size(179, 21);
            this.dtpChqTo.TabIndex = 1;
            // 
            // lblPayto
            // 
            this.lblPayto.AutoSize = true;
            this.lblPayto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPayto.Location = new System.Drawing.Point(307, 12);
            this.lblPayto.Name = "lblPayto";
            this.lblPayto.Size = new System.Drawing.Size(66, 13);
            this.lblPayto.TabIndex = 27;
            this.lblPayto.Text = "Cheque To";
            // 
            // dtpChqFrom
            // 
            this.dtpChqFrom.Checked = false;
            this.dtpChqFrom.CustomFormat = "dd-MM-yyyy";
            this.dtpChqFrom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpChqFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChqFrom.Location = new System.Drawing.Point(118, 8);
            this.dtpChqFrom.Name = "dtpChqFrom";
            this.dtpChqFrom.ShowCheckBox = true;
            this.dtpChqFrom.Size = new System.Drawing.Size(179, 21);
            this.dtpChqFrom.TabIndex = 0;
            // 
            // lblPayfrm
            // 
            this.lblPayfrm.AutoSize = true;
            this.lblPayfrm.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPayfrm.Location = new System.Drawing.Point(6, 12);
            this.lblPayfrm.Name = "lblPayfrm";
            this.lblPayfrm.Size = new System.Drawing.Size(81, 13);
            this.lblPayfrm.TabIndex = 25;
            this.lblPayfrm.Text = "Cheque From";
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
            this.dgvDeposit.Location = new System.Drawing.Point(3, 133);
            this.dgvDeposit.Name = "dgvDeposit";
            this.dgvDeposit.ReadOnly = true;
            this.dgvDeposit.RowTemplate.ReadOnly = true;
            this.dgvDeposit.Size = new System.Drawing.Size(1179, 388);
            this.dgvDeposit.TabIndex = 81;
            // 
            // lblload
            // 
            this.lblload.AutoSize = true;
            this.lblload.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblload.ForeColor = System.Drawing.Color.Red;
            this.lblload.Location = new System.Drawing.Point(525, 111);
            this.lblload.Name = "lblload";
            this.lblload.Size = new System.Drawing.Size(57, 13);
            this.lblload.TabIndex = 80;
            this.lblload.Text = "Loading..";
            this.lblload.Visible = false;
            // 
            // btnload
            // 
            this.btnload.Image = ((System.Drawing.Image)(resources.GetObject("btnload.Image")));
            this.btnload.Location = new System.Drawing.Point(592, 108);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(356, 19);
            this.btnload.TabIndex = 83;
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Visible = false;
            // 
            // btnexport
            // 
            this.btnexport.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnexport.Image = ((System.Drawing.Image)(resources.GetObject("btnexport.Image")));
            this.btnexport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexport.Location = new System.Drawing.Point(1032, 106);
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
            this.btncls.Location = new System.Drawing.Point(1110, 106);
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
            this.btnref.Location = new System.Drawing.Point(954, 106);
            this.btnref.Name = "btnref";
            this.btnref.Size = new System.Drawing.Size(72, 24);
            this.btnref.TabIndex = 1;
            this.btnref.Text = "Refresh";
            this.btnref.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnref.UseVisualStyleBackColor = true;
            this.btnref.Click += new System.EventHandler(this.btnref_Click);
            // 
            // lblTotRec
            // 
            this.lblTotRec.AutoSize = true;
            this.lblTotRec.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTotRec.ForeColor = System.Drawing.Color.Blue;
            this.lblTotRec.Location = new System.Drawing.Point(0, 111);
            this.lblTotRec.Name = "lblTotRec";
            this.lblTotRec.Size = new System.Drawing.Size(94, 13);
            this.lblTotRec.TabIndex = 84;
            this.lblTotRec.Text = "Total Records : ";
            // 
            // frmChequeRpt
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
            this.Name = "frmChequeRpt";
            this.Text = "Cheque Report";
            this.Load += new System.EventHandler(this.frmChequeRpt_Load);
            this.Resize += new System.EventHandler(this.frmDepositRpt_Resize);
            this.pnlmain.ResumeLayout(false);
            this.pnlmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlmain;
        private System.Windows.Forms.TextBox txtChequeAmt;
        private System.Windows.Forms.Label lblPayamt;
        private System.Windows.Forms.TextBox txtChequeNo;
        private System.Windows.Forms.Label lblSuppno;
        private System.Windows.Forms.DateTimePicker dtpChqTo;
        private System.Windows.Forms.Label lblPayto;
        private System.Windows.Forms.DateTimePicker dtpChqFrom;
        private System.Windows.Forms.Label lblPayfrm;
        private System.Windows.Forms.DataGridView dgvDeposit;
        private System.Windows.Forms.Label lblload;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btncls;
        private System.Windows.Forms.Button btnref;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.DateTimePicker dtpDepositFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDepositTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepositSlipNo;
        private System.Windows.Forms.TextBox txtDepositAmt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDepositId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChqId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClearingId;
        private System.Windows.Forms.Label lblTotRec;
    }
}