namespace CMS_Deposit.Reports
{
    partial class frmDepositRpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepositRpt));
            this.pnlmain = new System.Windows.Forms.Panel();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLocationName = new System.Windows.Forms.ComboBox();
            this.txtDepositAmt = new System.Windows.Forms.TextBox();
            this.lblPayamt = new System.Windows.Forms.Label();
            this.txtDepositSlipNo = new System.Windows.Forms.TextBox();
            this.lblSuppno = new System.Windows.Forms.Label();
            this.dtpDepTo = new System.Windows.Forms.DateTimePicker();
            this.lblPayto = new System.Windows.Forms.Label();
            this.dtpDepFrom = new System.Windows.Forms.DateTimePicker();
            this.lblPayfrm = new System.Windows.Forms.Label();
            this.lblremarks = new System.Windows.Forms.Label();
            this.cmbAgentName = new System.Windows.Forms.ComboBox();
            this.lblsupp = new System.Windows.Forms.Label();
            this.cmbClientName = new System.Windows.Forms.ComboBox();
            this.lblmdul = new System.Windows.Forms.Label();
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
            this.pnlmain.Controls.Add(this.cmbStatus);
            this.pnlmain.Controls.Add(this.label1);
            this.pnlmain.Controls.Add(this.cmbLocationName);
            this.pnlmain.Controls.Add(this.txtDepositAmt);
            this.pnlmain.Controls.Add(this.lblPayamt);
            this.pnlmain.Controls.Add(this.txtDepositSlipNo);
            this.pnlmain.Controls.Add(this.lblSuppno);
            this.pnlmain.Controls.Add(this.dtpDepTo);
            this.pnlmain.Controls.Add(this.lblPayto);
            this.pnlmain.Controls.Add(this.dtpDepFrom);
            this.pnlmain.Controls.Add(this.lblPayfrm);
            this.pnlmain.Controls.Add(this.lblremarks);
            this.pnlmain.Controls.Add(this.cmbAgentName);
            this.pnlmain.Controls.Add(this.lblsupp);
            this.pnlmain.Controls.Add(this.cmbClientName);
            this.pnlmain.Controls.Add(this.lblmdul);
            this.pnlmain.Location = new System.Drawing.Point(3, 6);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(1179, 70);
            this.pnlmain.TabIndex = 0;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(993, 38);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(180, 21);
            this.cmbStatus.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(890, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Status";
            // 
            // cmbLocationName
            // 
            this.cmbLocationName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLocationName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLocationName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocationName.FormattingEnabled = true;
            this.cmbLocationName.Location = new System.Drawing.Point(700, 38);
            this.cmbLocationName.Name = "cmbLocationName";
            this.cmbLocationName.Size = new System.Drawing.Size(180, 21);
            this.cmbLocationName.TabIndex = 6;
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
            this.lblPayamt.Size = new System.Drawing.Size(77, 13);
            this.lblPayamt.TabIndex = 31;
            this.lblPayamt.Text = "Deposit Amt";
            // 
            // txtDepositSlipNo
            // 
            this.txtDepositSlipNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepositSlipNo.Location = new System.Drawing.Point(700, 8);
            this.txtDepositSlipNo.MaxLength = 16;
            this.txtDepositSlipNo.Name = "txtDepositSlipNo";
            this.txtDepositSlipNo.Size = new System.Drawing.Size(180, 21);
            this.txtDepositSlipNo.TabIndex = 2;
            // 
            // lblSuppno
            // 
            this.lblSuppno.AutoSize = true;
            this.lblSuppno.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSuppno.Location = new System.Drawing.Point(586, 12);
            this.lblSuppno.Name = "lblSuppno";
            this.lblSuppno.Size = new System.Drawing.Size(90, 13);
            this.lblSuppno.TabIndex = 29;
            this.lblSuppno.Text = "Deposit Slip No";
            // 
            // dtpDepTo
            // 
            this.dtpDepTo.Checked = false;
            this.dtpDepTo.CustomFormat = "dd-MM-yyyy";
            this.dtpDepTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpDepTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepTo.Location = new System.Drawing.Point(399, 8);
            this.dtpDepTo.Name = "dtpDepTo";
            this.dtpDepTo.ShowCheckBox = true;
            this.dtpDepTo.Size = new System.Drawing.Size(179, 21);
            this.dtpDepTo.TabIndex = 1;
            // 
            // lblPayto
            // 
            this.lblPayto.AutoSize = true;
            this.lblPayto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPayto.Location = new System.Drawing.Point(304, 12);
            this.lblPayto.Name = "lblPayto";
            this.lblPayto.Size = new System.Drawing.Size(67, 13);
            this.lblPayto.TabIndex = 27;
            this.lblPayto.Text = "Deposit To";
            // 
            // dtpDepFrom
            // 
            this.dtpDepFrom.Checked = false;
            this.dtpDepFrom.CustomFormat = "dd-MM-yyyy";
            this.dtpDepFrom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpDepFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepFrom.Location = new System.Drawing.Point(118, 8);
            this.dtpDepFrom.Name = "dtpDepFrom";
            this.dtpDepFrom.ShowCheckBox = true;
            this.dtpDepFrom.Size = new System.Drawing.Size(179, 21);
            this.dtpDepFrom.TabIndex = 0;
            // 
            // lblPayfrm
            // 
            this.lblPayfrm.AutoSize = true;
            this.lblPayfrm.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPayfrm.Location = new System.Drawing.Point(6, 12);
            this.lblPayfrm.Name = "lblPayfrm";
            this.lblPayfrm.Size = new System.Drawing.Size(82, 13);
            this.lblPayfrm.TabIndex = 25;
            this.lblPayfrm.Text = "Deposit From";
            // 
            // lblremarks
            // 
            this.lblremarks.AutoSize = true;
            this.lblremarks.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblremarks.Location = new System.Drawing.Point(586, 43);
            this.lblremarks.Name = "lblremarks";
            this.lblremarks.Size = new System.Drawing.Size(90, 13);
            this.lblremarks.TabIndex = 23;
            this.lblremarks.Text = "Location Name";
            // 
            // cmbAgentName
            // 
            this.cmbAgentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAgentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAgentName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAgentName.FormattingEnabled = true;
            this.cmbAgentName.Location = new System.Drawing.Point(399, 38);
            this.cmbAgentName.Name = "cmbAgentName";
            this.cmbAgentName.Size = new System.Drawing.Size(180, 21);
            this.cmbAgentName.TabIndex = 5;
            // 
            // lblsupp
            // 
            this.lblsupp.AutoSize = true;
            this.lblsupp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblsupp.Location = new System.Drawing.Point(304, 43);
            this.lblsupp.Name = "lblsupp";
            this.lblsupp.Size = new System.Drawing.Size(76, 13);
            this.lblsupp.TabIndex = 21;
            this.lblsupp.Text = "Agent Name";
            // 
            // cmbClientName
            // 
            this.cmbClientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbClientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClientName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientName.FormattingEnabled = true;
            this.cmbClientName.Location = new System.Drawing.Point(118, 38);
            this.cmbClientName.Name = "cmbClientName";
            this.cmbClientName.Size = new System.Drawing.Size(179, 21);
            this.cmbClientName.TabIndex = 4;
            // 
            // lblmdul
            // 
            this.lblmdul.AutoSize = true;
            this.lblmdul.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblmdul.Location = new System.Drawing.Point(6, 43);
            this.lblmdul.Name = "lblmdul";
            this.lblmdul.Size = new System.Drawing.Size(74, 13);
            this.lblmdul.TabIndex = 19;
            this.lblmdul.Text = "Client Name";
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
            this.dgvDeposit.Location = new System.Drawing.Point(3, 113);
            this.dgvDeposit.Name = "dgvDeposit";
            this.dgvDeposit.ReadOnly = true;
            this.dgvDeposit.RowTemplate.ReadOnly = true;
            this.dgvDeposit.Size = new System.Drawing.Size(1179, 408);
            this.dgvDeposit.TabIndex = 5;
            // 
            // lblload
            // 
            this.lblload.AutoSize = true;
            this.lblload.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblload.ForeColor = System.Drawing.Color.Red;
            this.lblload.Location = new System.Drawing.Point(336, 87);
            this.lblload.Name = "lblload";
            this.lblload.Size = new System.Drawing.Size(57, 13);
            this.lblload.TabIndex = 80;
            this.lblload.Text = "Loading..";
            this.lblload.Visible = false;
            // 
            // btnload
            // 
            this.btnload.Image = ((System.Drawing.Image)(resources.GetObject("btnload.Image")));
            this.btnload.Location = new System.Drawing.Point(399, 84);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(164, 19);
            this.btnload.TabIndex = 82;
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Visible = false;
            // 
            // btnexport
            // 
            this.btnexport.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnexport.Image = ((System.Drawing.Image)(resources.GetObject("btnexport.Image")));
            this.btnexport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexport.Location = new System.Drawing.Point(1032, 83);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(72, 24);
            this.btnexport.TabIndex = 3;
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
            this.btncls.Location = new System.Drawing.Point(1110, 83);
            this.btncls.Name = "btncls";
            this.btncls.Size = new System.Drawing.Size(72, 24);
            this.btncls.TabIndex = 4;
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
            this.btnref.Location = new System.Drawing.Point(954, 83);
            this.btnref.Name = "btnref";
            this.btnref.Size = new System.Drawing.Size(72, 24);
            this.btnref.TabIndex = 2;
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
            this.lblTotRec.Location = new System.Drawing.Point(0, 87);
            this.lblTotRec.Name = "lblTotRec";
            this.lblTotRec.Size = new System.Drawing.Size(94, 13);
            this.lblTotRec.TabIndex = 1;
            this.lblTotRec.Text = "Total Records : ";
            // 
            // frmDepositRpt
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
            this.Name = "frmDepositRpt";
            this.Text = "Deposit Report";
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
        private System.Windows.Forms.TextBox txtDepositSlipNo;
        private System.Windows.Forms.Label lblSuppno;
        private System.Windows.Forms.DateTimePicker dtpDepTo;
        private System.Windows.Forms.Label lblPayto;
        private System.Windows.Forms.DateTimePicker dtpDepFrom;
        private System.Windows.Forms.Label lblPayfrm;
        private System.Windows.Forms.Label lblremarks;
        private System.Windows.Forms.ComboBox cmbAgentName;
        private System.Windows.Forms.Label lblsupp;
        private System.Windows.Forms.ComboBox cmbClientName;
        private System.Windows.Forms.Label lblmdul;
        private System.Windows.Forms.DataGridView dgvDeposit;
        private System.Windows.Forms.Label lblload;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btncls;
        private System.Windows.Forms.Button btnref;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.ComboBox cmbLocationName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblTotRec;
    }
}