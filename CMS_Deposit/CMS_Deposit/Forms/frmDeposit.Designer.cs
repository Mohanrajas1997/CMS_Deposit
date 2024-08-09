namespace CMS_Deposit.Forms
{
    partial class frmDeposit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeposit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBankName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbClientName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAgentName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.txtDepositSlipNo = new System.Windows.Forms.TextBox();
            this.dtpDepositDt = new System.Windows.Forms.DateTimePicker();
            this.lblMailId = new System.Windows.Forms.Label();
            this.txtBankBranch = new System.Windows.Forms.TextBox();
            this.txtdepositgid = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtNoOfChq = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.btndlt = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnedt = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsve = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imgLst = new System.Windows.Forms.ImageList(this.components);
            this.cmbpup = new System.Windows.Forms.ComboBox();
            this.lblpup = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.lblpup);
            this.pnlMain.Controls.Add(this.cmbpup);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.btnFile);
            this.pnlMain.Controls.Add(this.txtFile);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.cmbBankName);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.cmbClientName);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.cmbAgentName);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.cmbLocation);
            this.pnlMain.Controls.Add(this.txtDepositSlipNo);
            this.pnlMain.Controls.Add(this.dtpDepositDt);
            this.pnlMain.Controls.Add(this.lblMailId);
            this.pnlMain.Controls.Add(this.txtBankBranch);
            this.pnlMain.Controls.Add(this.txtdepositgid);
            this.pnlMain.Controls.Add(this.Label9);
            this.pnlMain.Controls.Add(this.Label8);
            this.pnlMain.Controls.Add(this.txtNoOfChq);
            this.pnlMain.Controls.Add(this.txtAmount);
            this.pnlMain.Controls.Add(this.Label2);
            this.pnlMain.Controls.Add(this.Label1);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Location = new System.Drawing.Point(9, 7);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(494, 271);
            this.pnlMain.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(436, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(27, 24);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFile
            // 
            this.btnFile.FlatAppearance.BorderSize = 0;
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFile.Image = ((System.Drawing.Image)(resources.GetObject("btnFile.Image")));
            this.btnFile.Location = new System.Drawing.Point(407, 235);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(27, 24);
            this.btnFile.TabIndex = 11;
            this.btnFile.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // txtFile
            // 
            this.txtFile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.Location = new System.Drawing.Point(105, 238);
            this.txtFile.MaxLength = 32;
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(295, 21);
            this.txtFile.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(13, 242);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Attachment";
            // 
            // cmbBankName
            // 
            this.cmbBankName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBankName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBankName.FormattingEnabled = true;
            this.cmbBankName.Location = new System.Drawing.Point(105, 180);
            this.cmbBankName.Name = "cmbBankName";
            this.cmbBankName.Size = new System.Drawing.Size(382, 21);
            this.cmbBankName.TabIndex = 8;
            this.cmbBankName.SelectionChangeCommitted += new System.EventHandler(this.cmbBankName_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(2, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Bank Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbClientName
            // 
            this.cmbClientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbClientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClientName.FormattingEnabled = true;
            this.cmbClientName.Location = new System.Drawing.Point(105, 120);
            this.cmbClientName.Name = "cmbClientName";
            this.cmbClientName.Size = new System.Drawing.Size(382, 21);
            this.cmbClientName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(-1, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Client Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbAgentName
            // 
            this.cmbAgentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAgentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAgentName.FormattingEnabled = true;
            this.cmbAgentName.Location = new System.Drawing.Point(105, 92);
            this.cmbAgentName.Name = "cmbAgentName";
            this.cmbAgentName.Size = new System.Drawing.Size(382, 21);
            this.cmbAgentName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(2, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Agent Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbLocation
            // 
            this.cmbLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(105, 37);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(382, 21);
            this.cmbLocation.TabIndex = 2;
            this.cmbLocation.Leave += new System.EventHandler(this.locationleave_evt);
            // 
            // txtDepositSlipNo
            // 
            this.txtDepositSlipNo.Location = new System.Drawing.Point(356, 11);
            this.txtDepositSlipNo.MaxLength = 16;
            this.txtDepositSlipNo.Name = "txtDepositSlipNo";
            this.txtDepositSlipNo.Size = new System.Drawing.Size(131, 21);
            this.txtDepositSlipNo.TabIndex = 1;
            // 
            // dtpDepositDt
            // 
            this.dtpDepositDt.CustomFormat = "dd-MM-yyyy";
            this.dtpDepositDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepositDt.Location = new System.Drawing.Point(105, 10);
            this.dtpDepositDt.Name = "dtpDepositDt";
            this.dtpDepositDt.Size = new System.Drawing.Size(131, 21);
            this.dtpDepositDt.TabIndex = 0;
            // 
            // lblMailId
            // 
            this.lblMailId.Location = new System.Drawing.Point(13, 213);
            this.lblMailId.Name = "lblMailId";
            this.lblMailId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMailId.Size = new System.Drawing.Size(87, 16);
            this.lblMailId.TabIndex = 45;
            this.lblMailId.Text = "Bank Branch";
            // 
            // txtBankBranch
            // 
            this.txtBankBranch.Location = new System.Drawing.Point(105, 210);
            this.txtBankBranch.MaxLength = 128;
            this.txtBankBranch.Name = "txtBankBranch";
            this.txtBankBranch.Size = new System.Drawing.Size(382, 21);
            this.txtBankBranch.TabIndex = 9;
            // 
            // txtdepositgid
            // 
            this.txtdepositgid.Location = new System.Drawing.Point(244, 10);
            this.txtdepositgid.Name = "txtdepositgid";
            this.txtdepositgid.Size = new System.Drawing.Size(25, 21);
            this.txtdepositgid.TabIndex = 42;
            this.txtdepositgid.Visible = false;
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(4, 153);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label8.Size = new System.Drawing.Size(98, 16);
            this.Label8.TabIndex = 14;
            this.Label8.Text = "Deposit Amount";
            // 
            // txtNoOfChq
            // 
            this.txtNoOfChq.Location = new System.Drawing.Point(356, 150);
            this.txtNoOfChq.MaxLength = 6;
            this.txtNoOfChq.Name = "txtNoOfChq";
            this.txtNoOfChq.Size = new System.Drawing.Size(131, 21);
            this.txtNoOfChq.TabIndex = 7;
            this.txtNoOfChq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoOfChq_KeyPress);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(105, 150);
            this.txtAmount.MaxLength = 15;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(131, 21);
            this.txtAmount.TabIndex = 6;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // Label2
            // 
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(241, 14);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(109, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Deposit Slip No";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(-1, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(101, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Deposit Date";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(-1, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(98, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Location";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Azure;
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButtons.Controls.Add(this.btnclose);
            this.pnlButtons.Controls.Add(this.btndlt);
            this.pnlButtons.Controls.Add(this.btnfind);
            this.pnlButtons.Controls.Add(this.btnedt);
            this.pnlButtons.Controls.Add(this.btnNew);
            this.pnlButtons.Location = new System.Drawing.Point(57, 475);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(396, 35);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(315, 4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(72, 24);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "Close";
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btndlt
            // 
            this.btndlt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btndlt.Image = ((System.Drawing.Image)(resources.GetObject("btndlt.Image")));
            this.btndlt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndlt.Location = new System.Drawing.Point(237, 4);
            this.btndlt.Name = "btndlt";
            this.btndlt.Size = new System.Drawing.Size(72, 24);
            this.btndlt.TabIndex = 3;
            this.btndlt.Text = "Delete";
            this.btndlt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndlt.UseVisualStyleBackColor = true;
            this.btndlt.Click += new System.EventHandler(this.btndlt_Click);
            // 
            // btnfind
            // 
            this.btnfind.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnfind.Image = ((System.Drawing.Image)(resources.GetObject("btnfind.Image")));
            this.btnfind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfind.Location = new System.Drawing.Point(159, 4);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(72, 24);
            this.btnfind.TabIndex = 2;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btnedt
            // 
            this.btnedt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnedt.Image = ((System.Drawing.Image)(resources.GetObject("btnedt.Image")));
            this.btnedt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnedt.Location = new System.Drawing.Point(81, 4);
            this.btnedt.Name = "btnedt";
            this.btnedt.Size = new System.Drawing.Size(72, 24);
            this.btnedt.TabIndex = 1;
            this.btnedt.Text = "Edit";
            this.btnedt.UseVisualStyleBackColor = true;
            this.btnedt.Click += new System.EventHandler(this.btnedt_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(72, 24);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.bntnew_Click);
            // 
            // pnlSave
            // 
            this.pnlSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSave.Controls.Add(this.btncancel);
            this.pnlSave.Controls.Add(this.btnsve);
            this.pnlSave.Location = new System.Drawing.Point(174, 471);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(160, 35);
            this.pnlSave.TabIndex = 1;
            this.pnlSave.Visible = false;
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(81, 4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(72, 24);
            this.btncancel.TabIndex = 1;
            this.btncancel.Text = "Cancel";
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsve
            // 
            this.btnsve.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsve.Image = ((System.Drawing.Image)(resources.GetObject("btnsve.Image")));
            this.btnsve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsve.Location = new System.Drawing.Point(3, 4);
            this.btnsve.Name = "btnsve";
            this.btnsve.Size = new System.Drawing.Size(72, 24);
            this.btnsve.TabIndex = 0;
            this.btnsve.Text = "&Save";
            this.btnsve.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsve.UseVisualStyleBackColor = true;
            this.btnsve.Click += new System.EventHandler(this.btnsve_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReport.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.GridColor = System.Drawing.Color.Azure;
            this.dgvReport.Location = new System.Drawing.Point(9, 284);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowTemplate.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(494, 190);
            this.dgvReport.TabIndex = 1;
            this.dgvReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellContentClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // imgLst
            // 
            this.imgLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLst.ImageStream")));
            this.imgLst.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLst.Images.SetKeyName(0, "Delete.ico");
            // 
            // cmbpup
            // 
            this.cmbpup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbpup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbpup.FormattingEnabled = true;
            this.cmbpup.Location = new System.Drawing.Point(104, 64);
            this.cmbpup.Name = "cmbpup";
            this.cmbpup.Size = new System.Drawing.Size(382, 21);
            this.cmbpup.TabIndex = 3;
            // 
            // lblpup
            // 
            this.lblpup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblpup.Location = new System.Drawing.Point(2, 64);
            this.lblpup.Name = "lblpup";
            this.lblpup.Size = new System.Drawing.Size(98, 13);
            this.lblpup.TabIndex = 57;
            this.lblpup.Text = "PickUp Point";
            this.lblpup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(241, 153);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label9.Size = new System.Drawing.Size(110, 16);
            this.Label9.TabIndex = 16;
            this.Label9.Text = "No of Cheques";
            // 
            // frmDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(510, 513);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlSave);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit Slip Entry";
            this.Load += new System.EventHandler(this.frmCreateUser_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDeposit_KeyDown);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnlMain;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtNoOfChq;
        internal System.Windows.Forms.TextBox txtAmount;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btndlt;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnedt;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsve;
        internal System.Windows.Forms.Label lblMailId;
        internal System.Windows.Forms.TextBox txtBankBranch;
        private System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.DateTimePicker dtpDepositDt;
        internal System.Windows.Forms.TextBox txtdepositgid;
        internal System.Windows.Forms.TextBox txtDepositSlipNo;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.ComboBox cmbAgentName;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbClientName;
        private System.Windows.Forms.ComboBox cmbBankName;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imgLst;
        internal System.Windows.Forms.Label lblpup;
        private System.Windows.Forms.ComboBox cmbpup;
        internal System.Windows.Forms.Label Label9;
    }
}