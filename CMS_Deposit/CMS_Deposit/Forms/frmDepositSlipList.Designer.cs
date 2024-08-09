namespace CMS_Deposit.Forms
{
    partial class frmDepositSlipList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepositSlipList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlmain = new System.Windows.Forms.Panel();
            this.btnexport = new System.Windows.Forms.Button();
            this.btncls = new System.Windows.Forms.Button();
            this.btnref = new System.Windows.Forms.Button();
            this.cmbAgent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDepositTo = new System.Windows.Forms.DateTimePicker();
            this.lblinvcto = new System.Windows.Forms.Label();
            this.dtpDepositfrm = new System.Windows.Forms.DateTimePicker();
            this.lblinvfrm = new System.Windows.Forms.Label();
            this.dtQueue = new System.Windows.Forms.DataGridView();
            this.view_chqs = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deposit_gid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deposit_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deposit_slip_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agent_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bank_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deposit_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tot_chqs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtQueue)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlmain
            // 
            this.pnlmain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlmain.Controls.Add(this.btnexport);
            this.pnlmain.Controls.Add(this.btncls);
            this.pnlmain.Controls.Add(this.btnref);
            this.pnlmain.Controls.Add(this.cmbAgent);
            this.pnlmain.Controls.Add(this.label2);
            this.pnlmain.Controls.Add(this.cmbLocation);
            this.pnlmain.Controls.Add(this.label1);
            this.pnlmain.Controls.Add(this.dtpDepositTo);
            this.pnlmain.Controls.Add(this.lblinvcto);
            this.pnlmain.Controls.Add(this.dtpDepositfrm);
            this.pnlmain.Controls.Add(this.lblinvfrm);
            this.pnlmain.Location = new System.Drawing.Point(7, 6);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(969, 68);
            this.pnlmain.TabIndex = 1;
            // 
            // btnexport
            // 
            this.btnexport.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnexport.Image = ((System.Drawing.Image)(resources.GetObject("btnexport.Image")));
            this.btnexport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexport.Location = new System.Drawing.Point(808, 36);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(72, 24);
            this.btnexport.TabIndex = 65;
            this.btnexport.Text = "Export";
            this.btnexport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexport.UseVisualStyleBackColor = true;
            // 
            // btncls
            // 
            this.btncls.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btncls.Image = ((System.Drawing.Image)(resources.GetObject("btncls.Image")));
            this.btncls.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncls.Location = new System.Drawing.Point(886, 36);
            this.btncls.Name = "btncls";
            this.btncls.Size = new System.Drawing.Size(72, 24);
            this.btncls.TabIndex = 66;
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
            this.btnref.Location = new System.Drawing.Point(730, 36);
            this.btnref.Name = "btnref";
            this.btnref.Size = new System.Drawing.Size(72, 24);
            this.btnref.TabIndex = 64;
            this.btnref.Text = "Refresh";
            this.btnref.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnref.UseVisualStyleBackColor = true;
            this.btnref.Click += new System.EventHandler(this.btnref_Click);
            // 
            // cmbAgent
            // 
            this.cmbAgent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAgent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAgent.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAgent.FormattingEnabled = true;
            this.cmbAgent.Location = new System.Drawing.Point(706, 9);
            this.cmbAgent.Name = "cmbAgent";
            this.cmbAgent.Size = new System.Drawing.Size(252, 21);
            this.cmbAgent.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(657, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Agent";
            // 
            // cmbLocation
            // 
            this.cmbLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLocation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(485, 9);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(165, 21);
            this.cmbLocation.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(424, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Location";
            // 
            // dtpDepositTo
            // 
            this.dtpDepositTo.CustomFormat = "dd-MM-yyyy";
            this.dtpDepositTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpDepositTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepositTo.Location = new System.Drawing.Point(296, 9);
            this.dtpDepositTo.Name = "dtpDepositTo";
            this.dtpDepositTo.ShowCheckBox = true;
            this.dtpDepositTo.Size = new System.Drawing.Size(121, 21);
            this.dtpDepositTo.TabIndex = 28;
            // 
            // lblinvcto
            // 
            this.lblinvcto.AutoSize = true;
            this.lblinvcto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblinvcto.Location = new System.Drawing.Point(224, 13);
            this.lblinvcto.Name = "lblinvcto";
            this.lblinvcto.Size = new System.Drawing.Size(67, 13);
            this.lblinvcto.TabIndex = 27;
            this.lblinvcto.Text = "Deposit To";
            // 
            // dtpDepositfrm
            // 
            this.dtpDepositfrm.CustomFormat = "dd-MM-yyyy";
            this.dtpDepositfrm.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpDepositfrm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepositfrm.Location = new System.Drawing.Point(92, 7);
            this.dtpDepositfrm.Name = "dtpDepositfrm";
            this.dtpDepositfrm.ShowCheckBox = true;
            this.dtpDepositfrm.Size = new System.Drawing.Size(124, 21);
            this.dtpDepositfrm.TabIndex = 26;
            // 
            // lblinvfrm
            // 
            this.lblinvfrm.AutoSize = true;
            this.lblinvfrm.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblinvfrm.Location = new System.Drawing.Point(5, 10);
            this.lblinvfrm.Name = "lblinvfrm";
            this.lblinvfrm.Size = new System.Drawing.Size(82, 13);
            this.lblinvfrm.TabIndex = 25;
            this.lblinvfrm.Text = "Deposit From";
            // 
            // dtQueue
            // 
            this.dtQueue.AllowUserToAddRows = false;
            this.dtQueue.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtQueue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtQueue.BackgroundColor = System.Drawing.Color.Azure;
            this.dtQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.view_chqs,
            this.deposit_gid,
            this.deposit_date,
            this.deposit_slip_no,
            this.location_name,
            this.agent_name,
            this.client_name,
            this.Bank_Name,
            this.deposit_amount,
            this.tot_chqs});
            this.dtQueue.GridColor = System.Drawing.Color.Azure;
            this.dtQueue.Location = new System.Drawing.Point(9, 80);
            this.dtQueue.Name = "dtQueue";
            this.dtQueue.ReadOnly = true;
            this.dtQueue.RowTemplate.ReadOnly = true;
            this.dtQueue.Size = new System.Drawing.Size(969, 504);
            this.dtQueue.TabIndex = 78;
            this.dtQueue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtQueue_CellClick);
            // 
            // view_chqs
            // 
            this.view_chqs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.view_chqs.HeaderText = "View Cheques";
            this.view_chqs.Name = "view_chqs";
            this.view_chqs.ReadOnly = true;
            this.view_chqs.Text = "View Cheques";
            this.view_chqs.ToolTipText = "View Cheques";
            this.view_chqs.UseColumnTextForButtonValue = true;
            // 
            // deposit_gid
            // 
            this.deposit_gid.DataPropertyName = "deposit_gid";
            this.deposit_gid.HeaderText = "deposit_gid";
            this.deposit_gid.Name = "deposit_gid";
            this.deposit_gid.ReadOnly = true;
            this.deposit_gid.Visible = false;
            // 
            // deposit_date
            // 
            this.deposit_date.DataPropertyName = "deposit_date";
            this.deposit_date.HeaderText = "Deposit Date";
            this.deposit_date.Name = "deposit_date";
            this.deposit_date.ReadOnly = true;
            // 
            // deposit_slip_no
            // 
            this.deposit_slip_no.DataPropertyName = "deposit_slip_no";
            this.deposit_slip_no.HeaderText = "Deposit Slip No";
            this.deposit_slip_no.Name = "deposit_slip_no";
            this.deposit_slip_no.ReadOnly = true;
            // 
            // location_name
            // 
            this.location_name.DataPropertyName = "location_name";
            this.location_name.HeaderText = "Location Name";
            this.location_name.Name = "location_name";
            this.location_name.ReadOnly = true;
            // 
            // agent_name
            // 
            this.agent_name.DataPropertyName = "agent_name";
            this.agent_name.HeaderText = "Agent Name";
            this.agent_name.Name = "agent_name";
            this.agent_name.ReadOnly = true;
            this.agent_name.Width = 150;
            // 
            // client_name
            // 
            this.client_name.DataPropertyName = "client_name";
            this.client_name.HeaderText = "Client Name";
            this.client_name.Name = "client_name";
            this.client_name.ReadOnly = true;
            this.client_name.Width = 150;
            // 
            // Bank_Name
            // 
            this.Bank_Name.DataPropertyName = "Bank_Name";
            this.Bank_Name.HeaderText = "Bank Name";
            this.Bank_Name.Name = "Bank_Name";
            this.Bank_Name.ReadOnly = true;
            this.Bank_Name.Width = 150;
            // 
            // deposit_amount
            // 
            this.deposit_amount.DataPropertyName = "deposit_amount";
            this.deposit_amount.HeaderText = "Deposit Amount";
            this.deposit_amount.Name = "deposit_amount";
            this.deposit_amount.ReadOnly = true;
            this.deposit_amount.Width = 120;
            // 
            // tot_chqs
            // 
            this.tot_chqs.DataPropertyName = "tot_chqs";
            this.tot_chqs.HeaderText = "Total Cheques";
            this.tot_chqs.Name = "tot_chqs";
            this.tot_chqs.ReadOnly = true;
            // 
            // frmDepositSlipList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(986, 589);
            this.Controls.Add(this.dtQueue);
            this.Controls.Add(this.pnlmain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDepositSlipList";
            this.Text = "Deposit Slip List (Pullout)";
            this.Load += new System.EventHandler(this.frmDepositQueue_Load);
            this.Resize += new System.EventHandler(this.frmDepositQueue_Resize);
            this.pnlmain.ResumeLayout(false);
            this.pnlmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtQueue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlmain;
        private System.Windows.Forms.DateTimePicker dtpDepositTo;
        private System.Windows.Forms.Label lblinvcto;
        private System.Windows.Forms.DateTimePicker dtpDepositfrm;
        private System.Windows.Forms.Label lblinvfrm;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAgent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btncls;
        private System.Windows.Forms.Button btnref;
        public System.Windows.Forms.DataGridView dtQueue;
        private System.Windows.Forms.DataGridViewButtonColumn view_chqs;
        private System.Windows.Forms.DataGridViewTextBoxColumn deposit_gid;
        private System.Windows.Forms.DataGridViewTextBoxColumn deposit_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn deposit_slip_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn location_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn agent_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bank_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn deposit_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tot_chqs;

    }
}