namespace CMS_Deposit.Forms
{
    partial class frmCMSEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCMSEntry));
            this.pnlBatch = new System.Windows.Forms.Panel();
            this.lblPendingAmount = new System.Windows.Forms.Label();
            this.lblMappedAmt = new System.Windows.Forms.Label();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.TxtDepositDt = new System.Windows.Forms.TextBox();
            this.TxtDepositGid = new System.Windows.Forms.TextBox();
            this.TxtNoOfChq = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtLocation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDepositAmt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDepositSlipNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlEntry = new System.Windows.Forms.Panel();
            this.txtTranCode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMicrCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAccHolder = new System.Windows.Forms.TextBox();
            this.lblAccHolder = new System.Windows.Forms.Label();
            this.txtTotalRefAmt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtChqGid = new System.Windows.Forms.TextBox();
            this.btnPrvChq = new System.Windows.Forms.Button();
            this.chqdtpicker = new System.Windows.Forms.MaskedTextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnNxtChq = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsve = new System.Windows.Forms.Button();
            this.TxtRefAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtRefNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtChqNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtchqamt = new System.Windows.Forms.TextBox();
            this.lblchqamt = new System.Windows.Forms.Label();
            this.lblchqdate = new System.Windows.Forms.Label();
            this.kpImageViewer1 = new KaiwaProjects.KpImageViewer();
            this.pnlBatch.SuspendLayout();
            this.pnlEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBatch
            // 
            this.pnlBatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBatch.Controls.Add(this.lblPendingAmount);
            this.pnlBatch.Controls.Add(this.lblMappedAmt);
            this.pnlBatch.Controls.Add(this.lblCompleted);
            this.pnlBatch.Controls.Add(this.lblPending);
            this.pnlBatch.Controls.Add(this.TxtDepositDt);
            this.pnlBatch.Controls.Add(this.TxtDepositGid);
            this.pnlBatch.Controls.Add(this.TxtNoOfChq);
            this.pnlBatch.Controls.Add(this.label7);
            this.pnlBatch.Controls.Add(this.TxtLocation);
            this.pnlBatch.Controls.Add(this.label6);
            this.pnlBatch.Controls.Add(this.label5);
            this.pnlBatch.Controls.Add(this.TxtCustomerName);
            this.pnlBatch.Controls.Add(this.label4);
            this.pnlBatch.Controls.Add(this.TxtDepositAmt);
            this.pnlBatch.Controls.Add(this.label3);
            this.pnlBatch.Controls.Add(this.TxtDepositSlipNo);
            this.pnlBatch.Controls.Add(this.label2);
            this.pnlBatch.Location = new System.Drawing.Point(6, 32);
            this.pnlBatch.Name = "pnlBatch";
            this.pnlBatch.Size = new System.Drawing.Size(1213, 65);
            this.pnlBatch.TabIndex = 2;
            // 
            // lblPendingAmount
            // 
            this.lblPendingAmount.AutoSize = true;
            this.lblPendingAmount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingAmount.ForeColor = System.Drawing.Color.Red;
            this.lblPendingAmount.Location = new System.Drawing.Point(946, 39);
            this.lblPendingAmount.Name = "lblPendingAmount";
            this.lblPendingAmount.Size = new System.Drawing.Size(122, 13);
            this.lblPendingAmount.TabIndex = 32;
            this.lblPendingAmount.Text = "Difference Amount : ";
            // 
            // lblMappedAmt
            // 
            this.lblMappedAmt.AutoSize = true;
            this.lblMappedAmt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMappedAmt.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMappedAmt.Location = new System.Drawing.Point(732, 39);
            this.lblMappedAmt.Name = "lblMappedAmt";
            this.lblMappedAmt.Size = new System.Drawing.Size(109, 13);
            this.lblMappedAmt.TabIndex = 31;
            this.lblMappedAmt.Text = "Mapped Amount : ";
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleted.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCompleted.Location = new System.Drawing.Point(504, 39);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(77, 13);
            this.lblCompleted.TabIndex = 30;
            this.lblCompleted.Text = "Completed : ";
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPending.ForeColor = System.Drawing.Color.Red;
            this.lblPending.Location = new System.Drawing.Point(637, 39);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(61, 13);
            this.lblPending.TabIndex = 29;
            this.lblPending.Text = "Pending : ";
            // 
            // TxtDepositDt
            // 
            this.TxtDepositDt.Location = new System.Drawing.Point(364, 7);
            this.TxtDepositDt.Name = "TxtDepositDt";
            this.TxtDepositDt.ReadOnly = true;
            this.TxtDepositDt.Size = new System.Drawing.Size(130, 21);
            this.TxtDepositDt.TabIndex = 1;
            // 
            // TxtDepositGid
            // 
            this.TxtDepositGid.Location = new System.Drawing.Point(269, 35);
            this.TxtDepositGid.Name = "TxtDepositGid";
            this.TxtDepositGid.Size = new System.Drawing.Size(24, 21);
            this.TxtDepositGid.TabIndex = 28;
            this.TxtDepositGid.Visible = false;
            // 
            // TxtNoOfChq
            // 
            this.TxtNoOfChq.Location = new System.Drawing.Point(364, 34);
            this.TxtNoOfChq.Name = "TxtNoOfChq";
            this.TxtNoOfChq.ReadOnly = true;
            this.TxtNoOfChq.Size = new System.Drawing.Size(130, 21);
            this.TxtNoOfChq.TabIndex = 5;
            this.TxtNoOfChq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "No of Chq";
            // 
            // TxtLocation
            // 
            this.TxtLocation.Location = new System.Drawing.Point(98, 35);
            this.TxtLocation.Name = "TxtLocation";
            this.TxtLocation.ReadOnly = true;
            this.TxtLocation.Size = new System.Drawing.Size(165, 21);
            this.TxtLocation.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Deposit Date";
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.Location = new System.Drawing.Point(844, 7);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.ReadOnly = true;
            this.TxtCustomerName.Size = new System.Drawing.Size(352, 21);
            this.TxtCustomerName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(766, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Client Name";
            // 
            // TxtDepositAmt
            // 
            this.TxtDepositAmt.Location = new System.Drawing.Point(605, 7);
            this.TxtDepositAmt.Name = "TxtDepositAmt";
            this.TxtDepositAmt.ReadOnly = true;
            this.TxtDepositAmt.Size = new System.Drawing.Size(130, 21);
            this.TxtDepositAmt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Deposit Amount";
            // 
            // TxtDepositSlipNo
            // 
            this.TxtDepositSlipNo.Location = new System.Drawing.Point(98, 7);
            this.TxtDepositSlipNo.Name = "TxtDepositSlipNo";
            this.TxtDepositSlipNo.ReadOnly = true;
            this.TxtDepositSlipNo.Size = new System.Drawing.Size(165, 21);
            this.TxtDepositSlipNo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Deposit Slip No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Deposit Slip Details";
            // 
            // pnlEntry
            // 
            this.pnlEntry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEntry.Controls.Add(this.txtTranCode);
            this.pnlEntry.Controls.Add(this.label13);
            this.pnlEntry.Controls.Add(this.txtMicrCode);
            this.pnlEntry.Controls.Add(this.label12);
            this.pnlEntry.Controls.Add(this.txtAccHolder);
            this.pnlEntry.Controls.Add(this.lblAccHolder);
            this.pnlEntry.Controls.Add(this.txtTotalRefAmt);
            this.pnlEntry.Controls.Add(this.label11);
            this.pnlEntry.Controls.Add(this.txtChqGid);
            this.pnlEntry.Controls.Add(this.btnPrvChq);
            this.pnlEntry.Controls.Add(this.chqdtpicker);
            this.pnlEntry.Controls.Add(this.btnView);
            this.pnlEntry.Controls.Add(this.btnNxtChq);
            this.pnlEntry.Controls.Add(this.btnclose);
            this.pnlEntry.Controls.Add(this.btnsve);
            this.pnlEntry.Controls.Add(this.TxtRefAmount);
            this.pnlEntry.Controls.Add(this.label10);
            this.pnlEntry.Controls.Add(this.TxtRefNo);
            this.pnlEntry.Controls.Add(this.label9);
            this.pnlEntry.Controls.Add(this.TxtChqNo);
            this.pnlEntry.Controls.Add(this.label8);
            this.pnlEntry.Controls.Add(this.txtchqamt);
            this.pnlEntry.Controls.Add(this.lblchqamt);
            this.pnlEntry.Controls.Add(this.lblchqdate);
            this.pnlEntry.Location = new System.Drawing.Point(955, 107);
            this.pnlEntry.Name = "pnlEntry";
            this.pnlEntry.Size = new System.Drawing.Size(264, 306);
            this.pnlEntry.TabIndex = 0;
            // 
            // txtTranCode
            // 
            this.txtTranCode.Location = new System.Drawing.Point(116, 141);
            this.txtTranCode.MaxLength = 2;
            this.txtTranCode.Name = "txtTranCode";
            this.txtTranCode.Size = new System.Drawing.Size(131, 21);
            this.txtTranCode.TabIndex = 8;
            this.txtTranCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTranCode_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Tran Code";
            // 
            // txtMicrCode
            // 
            this.txtMicrCode.Location = new System.Drawing.Point(116, 114);
            this.txtMicrCode.MaxLength = 9;
            this.txtMicrCode.Name = "txtMicrCode";
            this.txtMicrCode.Size = new System.Drawing.Size(131, 21);
            this.txtMicrCode.TabIndex = 7;
            this.txtMicrCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMicrCode_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Micr Code";
            // 
            // txtAccHolder
            // 
            this.txtAccHolder.Location = new System.Drawing.Point(116, 87);
            this.txtAccHolder.MaxLength = 128;
            this.txtAccHolder.Name = "txtAccHolder";
            this.txtAccHolder.Size = new System.Drawing.Size(131, 21);
            this.txtAccHolder.TabIndex = 6;
            // 
            // lblAccHolder
            // 
            this.lblAccHolder.AutoSize = true;
            this.lblAccHolder.Location = new System.Drawing.Point(3, 91);
            this.lblAccHolder.Name = "lblAccHolder";
            this.lblAccHolder.Size = new System.Drawing.Size(67, 13);
            this.lblAccHolder.TabIndex = 38;
            this.lblAccHolder.Text = "Acc Holder";
            // 
            // txtTotalRefAmt
            // 
            this.txtTotalRefAmt.Location = new System.Drawing.Point(116, 220);
            this.txtTotalRefAmt.Name = "txtTotalRefAmt";
            this.txtTotalRefAmt.ReadOnly = true;
            this.txtTotalRefAmt.Size = new System.Drawing.Size(131, 21);
            this.txtTotalRefAmt.TabIndex = 11;
            this.txtTotalRefAmt.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Total Ref Amount";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtChqGid
            // 
            this.txtChqGid.Location = new System.Drawing.Point(-1, 178);
            this.txtChqGid.Name = "txtChqGid";
            this.txtChqGid.Size = new System.Drawing.Size(32, 21);
            this.txtChqGid.TabIndex = 34;
            this.txtChqGid.Visible = false;
            // 
            // btnPrvChq
            // 
            this.btnPrvChq.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrvChq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrvChq.Location = new System.Drawing.Point(57, 277);
            this.btnPrvChq.Name = "btnPrvChq";
            this.btnPrvChq.Size = new System.Drawing.Size(72, 24);
            this.btnPrvChq.TabIndex = 17;
            this.btnPrvChq.Text = "<< Prev";
            this.btnPrvChq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrvChq.UseVisualStyleBackColor = true;
            this.btnPrvChq.Click += new System.EventHandler(this.btnPrvChq_Click);
            // 
            // chqdtpicker
            // 
            this.chqdtpicker.Location = new System.Drawing.Point(116, 33);
            this.chqdtpicker.Mask = "00-00-0000";
            this.chqdtpicker.Name = "chqdtpicker";
            this.chqdtpicker.Size = new System.Drawing.Size(131, 21);
            this.chqdtpicker.TabIndex = 2;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(97, 247);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(72, 24);
            this.btnView.TabIndex = 13;
            this.btnView.Text = "&View";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnNxtChq
            // 
            this.btnNxtChq.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNxtChq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNxtChq.Location = new System.Drawing.Point(135, 277);
            this.btnNxtChq.Name = "btnNxtChq";
            this.btnNxtChq.Size = new System.Drawing.Size(72, 24);
            this.btnNxtChq.TabIndex = 18;
            this.btnNxtChq.Text = "Next >>";
            this.btnNxtChq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNxtChq.UseVisualStyleBackColor = true;
            this.btnNxtChq.Click += new System.EventHandler(this.btnNxtChq_Click);
            // 
            // btnclose
            // 
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(175, 247);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(72, 24);
            this.btnclose.TabIndex = 15;
            this.btnclose.Text = "Close";
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnsve
            // 
            this.btnsve.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsve.Image = ((System.Drawing.Image)(resources.GetObject("btnsve.Image")));
            this.btnsve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsve.Location = new System.Drawing.Point(19, 247);
            this.btnsve.Name = "btnsve";
            this.btnsve.Size = new System.Drawing.Size(72, 24);
            this.btnsve.TabIndex = 11;
            this.btnsve.Text = "&Save";
            this.btnsve.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsve.UseVisualStyleBackColor = true;
            this.btnsve.Click += new System.EventHandler(this.btnsve_Click);
            // 
            // TxtRefAmount
            // 
            this.TxtRefAmount.Location = new System.Drawing.Point(116, 194);
            this.TxtRefAmount.MaxLength = 15;
            this.TxtRefAmount.Name = "TxtRefAmount";
            this.TxtRefAmount.Size = new System.Drawing.Size(131, 21);
            this.TxtRefAmount.TabIndex = 10;
            this.TxtRefAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRefAmount_KeyPress);
            this.TxtRefAmount.Leave += new System.EventHandler(this.TxtRefAmount_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Ref Amount";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // TxtRefNo
            // 
            this.TxtRefNo.Location = new System.Drawing.Point(116, 167);
            this.TxtRefNo.MaxLength = 16;
            this.TxtRefNo.Name = "TxtRefNo";
            this.TxtRefNo.Size = new System.Drawing.Size(131, 21);
            this.TxtRefNo.TabIndex = 9;
            this.TxtRefNo.TextChanged += new System.EventHandler(this.TxtRefNo_TextChanged);
            this.TxtRefNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRefNo_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Ref No";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TxtChqNo
            // 
            this.TxtChqNo.Location = new System.Drawing.Point(116, 6);
            this.TxtChqNo.MaxLength = 6;
            this.TxtChqNo.Name = "TxtChqNo";
            this.TxtChqNo.Size = new System.Drawing.Size(131, 21);
            this.TxtChqNo.TabIndex = 0;
            this.TxtChqNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtChqNo_KeyPress);
            this.TxtChqNo.Leave += new System.EventHandler(this.TxtChqNo_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Cheque Date";
            // 
            // txtchqamt
            // 
            this.txtchqamt.Location = new System.Drawing.Point(116, 60);
            this.txtchqamt.MaxLength = 15;
            this.txtchqamt.Name = "txtchqamt";
            this.txtchqamt.Size = new System.Drawing.Size(131, 21);
            this.txtchqamt.TabIndex = 4;
            this.txtchqamt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtchqamt_KeyPress);
            // 
            // lblchqamt
            // 
            this.lblchqamt.AutoSize = true;
            this.lblchqamt.Location = new System.Drawing.Point(3, 64);
            this.lblchqamt.Name = "lblchqamt";
            this.lblchqamt.Size = new System.Drawing.Size(97, 13);
            this.lblchqamt.TabIndex = 23;
            this.lblchqamt.Text = "Cheque Amount";
            this.lblchqamt.Click += new System.EventHandler(this.lblchqamt_Click);
            // 
            // lblchqdate
            // 
            this.lblchqdate.AutoSize = true;
            this.lblchqdate.BackColor = System.Drawing.SystemColors.Control;
            this.lblchqdate.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.lblchqdate.Location = new System.Drawing.Point(3, 10);
            this.lblchqdate.Name = "lblchqdate";
            this.lblchqdate.Size = new System.Drawing.Size(66, 13);
            this.lblchqdate.TabIndex = 21;
            this.lblchqdate.Text = "Cheque No";
            // 
            // kpImageViewer1
            // 
            this.kpImageViewer1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.kpImageViewer1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kpImageViewer1.GifAnimation = false;
            this.kpImageViewer1.GifFPS = 15D;
            this.kpImageViewer1.Image = global::CMS_Deposit.Properties.Resources.create;
            this.kpImageViewer1.Location = new System.Drawing.Point(6, 107);
            this.kpImageViewer1.MenuColor = System.Drawing.Color.LightSteelBlue;
            this.kpImageViewer1.MenuPanelColor = System.Drawing.Color.LightSteelBlue;
            this.kpImageViewer1.MinimumSize = new System.Drawing.Size(530, 157);
            this.kpImageViewer1.Name = "kpImageViewer1";
            this.kpImageViewer1.NavigationPanelColor = System.Drawing.Color.LightSteelBlue;
            this.kpImageViewer1.NavigationTextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kpImageViewer1.OpenButton = false;
            this.kpImageViewer1.PreviewButton = true;
            this.kpImageViewer1.PreviewPanelColor = System.Drawing.Color.LightSteelBlue;
            this.kpImageViewer1.PreviewText = "Preview";
            this.kpImageViewer1.PreviewTextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kpImageViewer1.Rotation = 0;
            this.kpImageViewer1.Scrollbars = true;
            this.kpImageViewer1.ShowPreview = true;
            this.kpImageViewer1.Size = new System.Drawing.Size(941, 556);
            this.kpImageViewer1.TabIndex = 4;
            this.kpImageViewer1.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kpImageViewer1.Zoom = 100D;
            // 
            // frmCMSEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1318, 650);
            this.Controls.Add(this.pnlEntry);
            this.Controls.Add(this.kpImageViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBatch);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCMSEntry";
            this.Text = "CMS Entry";
            this.Load += new System.EventHandler(this.frmCMSEntry_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCMSEntry_KeyDown);
            this.Resize += new System.EventHandler(this.frmCMSEntry_Resize);
            this.pnlBatch.ResumeLayout(false);
            this.pnlBatch.PerformLayout();
            this.pnlEntry.ResumeLayout(false);
            this.pnlEntry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBatch;
        private System.Windows.Forms.TextBox TxtNoOfChq;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDepositAmt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDepositSlipNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlEntry;
        private System.Windows.Forms.TextBox txtchqamt;
        private System.Windows.Forms.Label lblchqamt;
        private System.Windows.Forms.Label lblchqdate;
        private System.Windows.Forms.TextBox TxtDepositGid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtChqNo;
        private System.Windows.Forms.TextBox TxtRefNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtRefAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnsve;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.TextBox TxtDepositDt;
        private System.Windows.Forms.Button btnNxtChq;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.MaskedTextBox chqdtpicker;
        private System.Windows.Forms.Button btnPrvChq;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.TextBox txtChqGid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalRefAmt;
        private System.Windows.Forms.Label lblPendingAmount;
        private System.Windows.Forms.Label lblMappedAmt;
        private KaiwaProjects.KpImageViewer kpImageViewer1;
        private System.Windows.Forms.TextBox txtAccHolder;
        private System.Windows.Forms.Label lblAccHolder;
        private System.Windows.Forms.TextBox txtTranCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMicrCode;
        private System.Windows.Forms.Label label12;
    }
}