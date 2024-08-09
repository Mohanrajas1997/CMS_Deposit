namespace CMS_Deposit.Forms
{
    partial class frmPickupEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPickupEntry));
            this.pnlEntry = new System.Windows.Forms.Panel();
            this.cmbAgent = new System.Windows.Forms.ComboBox();
            this.lblvoutype = new System.Windows.Forms.Label();
            this.lblvoudate = new System.Windows.Forms.Label();
            this.dtpPickupDate = new System.Windows.Forms.DateTimePicker();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.lblvouchno = new System.Windows.Forms.Label();
            this.txtPickEntryGid = new System.Windows.Forms.TextBox();
            this.lbladdr = new System.Windows.Forms.Label();
            this.gvPickupPoint = new System.Windows.Forms.DataGridView();
            this.PickupdtlsGid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pickup_Gid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qcd_client_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qcd_pickup_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickuppoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tot_chqs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_Ack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveflag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dltflag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlsaveedit = new System.Windows.Forms.Panel();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsve = new System.Windows.Forms.Button();
            this.pnlbtnaccprd = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.btndlt = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnedt = new System.Windows.Forms.Button();
            this.bntnew = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnpickupentry = new System.Windows.Forms.Button();
            this.pnlEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPickupPoint)).BeginInit();
            this.pnlsaveedit.SuspendLayout();
            this.pnlbtnaccprd.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEntry
            // 
            this.pnlEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEntry.Controls.Add(this.cmbAgent);
            this.pnlEntry.Controls.Add(this.lblvoutype);
            this.pnlEntry.Controls.Add(this.lblvoudate);
            this.pnlEntry.Controls.Add(this.dtpPickupDate);
            this.pnlEntry.Controls.Add(this.cmbLocation);
            this.pnlEntry.Controls.Add(this.lblvouchno);
            this.pnlEntry.Controls.Add(this.txtPickEntryGid);
            this.pnlEntry.Location = new System.Drawing.Point(12, 12);
            this.pnlEntry.Name = "pnlEntry";
            this.pnlEntry.Size = new System.Drawing.Size(763, 44);
            this.pnlEntry.TabIndex = 1;
            // 
            // cmbAgent
            // 
            this.cmbAgent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAgent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAgent.FormattingEnabled = true;
            this.cmbAgent.Location = new System.Drawing.Point(568, 8);
            this.cmbAgent.Name = "cmbAgent";
            this.cmbAgent.Size = new System.Drawing.Size(189, 21);
            this.cmbAgent.TabIndex = 2;
            // 
            // lblvoutype
            // 
            this.lblvoutype.AutoSize = true;
            this.lblvoutype.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvoutype.Location = new System.Drawing.Point(222, 12);
            this.lblvoutype.Name = "lblvoutype";
            this.lblvoutype.Size = new System.Drawing.Size(95, 13);
            this.lblvoutype.TabIndex = 130;
            this.lblvoutype.Text = "Pickup Location";
            // 
            // lblvoudate
            // 
            this.lblvoudate.AutoSize = true;
            this.lblvoudate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvoudate.Location = new System.Drawing.Point(29, 12);
            this.lblvoudate.Name = "lblvoudate";
            this.lblvoudate.Size = new System.Drawing.Size(74, 13);
            this.lblvoudate.TabIndex = 132;
            this.lblvoudate.Text = "Pickup Date";
            // 
            // dtpPickupDate
            // 
            this.dtpPickupDate.CustomFormat = "dd/MM/yyyy";
            this.dtpPickupDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPickupDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPickupDate.Location = new System.Drawing.Point(108, 8);
            this.dtpPickupDate.Name = "dtpPickupDate";
            this.dtpPickupDate.Size = new System.Drawing.Size(105, 21);
            this.dtpPickupDate.TabIndex = 0;
            // 
            // cmbLocation
            // 
            this.cmbLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(322, 8);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(159, 21);
            this.cmbLocation.TabIndex = 1;
            // 
            // lblvouchno
            // 
            this.lblvouchno.AutoSize = true;
            this.lblvouchno.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvouchno.Location = new System.Drawing.Point(487, 12);
            this.lblvouchno.Name = "lblvouchno";
            this.lblvouchno.Size = new System.Drawing.Size(76, 13);
            this.lblvouchno.TabIndex = 138;
            this.lblvouchno.Text = "Agent Name";
            // 
            // txtPickEntryGid
            // 
            this.txtPickEntryGid.Location = new System.Drawing.Point(300, -1);
            this.txtPickEntryGid.Name = "txtPickEntryGid";
            this.txtPickEntryGid.Size = new System.Drawing.Size(38, 21);
            this.txtPickEntryGid.TabIndex = 140;
            this.txtPickEntryGid.Visible = false;
            // 
            // lbladdr
            // 
            this.lbladdr.AutoSize = true;
            this.lbladdr.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdr.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbladdr.Location = new System.Drawing.Point(345, 64);
            this.lbladdr.Name = "lbladdr";
            this.lbladdr.Size = new System.Drawing.Size(84, 13);
            this.lbladdr.TabIndex = 3;
            this.lbladdr.Text = "Pickup Listing";
            // 
            // gvPickupPoint
            // 
            this.gvPickupPoint.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gvPickupPoint.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gvPickupPoint.BackgroundColor = System.Drawing.Color.Azure;
            this.gvPickupPoint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PickupdtlsGid,
            this.Pickup_Gid,
            this.qcd_client_code,
            this.Client_Code,
            this.ClientName,
            this.qcd_pickup_code,
            this.pickuppoint,
            this.Tot_chqs,
            this.Client_Ack,
            this.saveflag,
            this.dltflag,
            this.edit,
            this.delete});
            this.gvPickupPoint.Location = new System.Drawing.Point(12, 85);
            this.gvPickupPoint.Name = "gvPickupPoint";
            this.gvPickupPoint.ReadOnly = true;
            this.gvPickupPoint.Size = new System.Drawing.Size(763, 185);
            this.gvPickupPoint.TabIndex = 3;
            this.gvPickupPoint.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPickupPoint_CellClick);
            // 
            // PickupdtlsGid
            // 
            this.PickupdtlsGid.DataPropertyName = "PickupdtlsGid";
            this.PickupdtlsGid.HeaderText = "PickupdtlsGid";
            this.PickupdtlsGid.Name = "PickupdtlsGid";
            this.PickupdtlsGid.ReadOnly = true;
            this.PickupdtlsGid.Visible = false;
            // 
            // Pickup_Gid
            // 
            this.Pickup_Gid.DataPropertyName = "Pickup_Gid";
            this.Pickup_Gid.FillWeight = 69.00147F;
            this.Pickup_Gid.HeaderText = "PickupGid";
            this.Pickup_Gid.Name = "Pickup_Gid";
            this.Pickup_Gid.ReadOnly = true;
            this.Pickup_Gid.Visible = false;
            this.Pickup_Gid.Width = 110;
            // 
            // qcd_client_code
            // 
            this.qcd_client_code.DataPropertyName = "qcd_client_code";
            this.qcd_client_code.HeaderText = "Qcd client code";
            this.qcd_client_code.Name = "qcd_client_code";
            this.qcd_client_code.ReadOnly = true;
            this.qcd_client_code.Visible = false;
            // 
            // Client_Code
            // 
            this.Client_Code.DataPropertyName = "Client_Code";
            this.Client_Code.FillWeight = 69.00147F;
            this.Client_Code.HeaderText = "Client Code";
            this.Client_Code.Name = "Client_Code";
            this.Client_Code.ReadOnly = true;
            this.Client_Code.Width = 120;
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "ClientName";
            this.ClientName.HeaderText = "Client Name";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            this.ClientName.Width = 150;
            // 
            // qcd_pickup_code
            // 
            this.qcd_pickup_code.DataPropertyName = "qcd_pickup_code";
            this.qcd_pickup_code.HeaderText = "Qcd Pickup code";
            this.qcd_pickup_code.Name = "qcd_pickup_code";
            this.qcd_pickup_code.ReadOnly = true;
            this.qcd_pickup_code.Visible = false;
            // 
            // pickuppoint
            // 
            this.pickuppoint.DataPropertyName = "PickupPoint";
            this.pickuppoint.FillWeight = 69.00147F;
            this.pickuppoint.HeaderText = "Pickup Point";
            this.pickuppoint.Name = "pickuppoint";
            this.pickuppoint.ReadOnly = true;
            this.pickuppoint.Width = 140;
            // 
            // Tot_chqs
            // 
            this.Tot_chqs.DataPropertyName = "Tot_chqs";
            this.Tot_chqs.FillWeight = 69.00147F;
            this.Tot_chqs.HeaderText = "No of Chqs";
            this.Tot_chqs.Name = "Tot_chqs";
            this.Tot_chqs.ReadOnly = true;
            // 
            // Client_Ack
            // 
            this.Client_Ack.DataPropertyName = "Client_Ack";
            this.Client_Ack.HeaderText = "Client Ack";
            this.Client_Ack.Name = "Client_Ack";
            this.Client_Ack.ReadOnly = true;
            // 
            // saveflag
            // 
            this.saveflag.DataPropertyName = "SaveFlag";
            this.saveflag.HeaderText = "Save Flag";
            this.saveflag.Name = "saveflag";
            this.saveflag.ReadOnly = true;
            this.saveflag.Visible = false;
            // 
            // dltflag
            // 
            this.dltflag.DataPropertyName = "DeleteFlag";
            this.dltflag.HeaderText = "Delete Flag";
            this.dltflag.Name = "dltflag";
            this.dltflag.ReadOnly = true;
            this.dltflag.Visible = false;
            // 
            // edit
            // 
            this.edit.DataPropertyName = "Edit";
            this.edit.FillWeight = 80.91245F;
            this.edit.HeaderText = "Edit";
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.Width = 50;
            // 
            // delete
            // 
            this.delete.DataPropertyName = "Delete";
            this.delete.HeaderText = "Delete";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.Width = 60;
            // 
            // pnlsaveedit
            // 
            this.pnlsaveedit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlsaveedit.Controls.Add(this.btncancel);
            this.pnlsaveedit.Controls.Add(this.btnsve);
            this.pnlsaveedit.Location = new System.Drawing.Point(299, 276);
            this.pnlsaveedit.Name = "pnlsaveedit";
            this.pnlsaveedit.Size = new System.Drawing.Size(160, 35);
            this.pnlsaveedit.TabIndex = 71;
            this.pnlsaveedit.Visible = false;
            this.pnlsaveedit.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlsaveedit_Paint);
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
            // pnlbtnaccprd
            // 
            this.pnlbtnaccprd.BackColor = System.Drawing.Color.Azure;
            this.pnlbtnaccprd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlbtnaccprd.Controls.Add(this.btnclose);
            this.pnlbtnaccprd.Controls.Add(this.btndlt);
            this.pnlbtnaccprd.Controls.Add(this.btnfind);
            this.pnlbtnaccprd.Controls.Add(this.btnedt);
            this.pnlbtnaccprd.Controls.Add(this.bntnew);
            this.pnlbtnaccprd.Location = new System.Drawing.Point(181, 276);
            this.pnlbtnaccprd.Name = "pnlbtnaccprd";
            this.pnlbtnaccprd.Size = new System.Drawing.Size(396, 35);
            this.pnlbtnaccprd.TabIndex = 70;
            // 
            // btnclose
            // 
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(316, 6);
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
            this.btndlt.Image = ((System.Drawing.Image)(resources.GetObject("btndlt.Image")));
            this.btndlt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndlt.Location = new System.Drawing.Point(238, 6);
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
            this.btnfind.Image = ((System.Drawing.Image)(resources.GetObject("btnfind.Image")));
            this.btnfind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfind.Location = new System.Drawing.Point(160, 6);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(72, 24);
            this.btnfind.TabIndex = 2;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btnedt
            // 
            this.btnedt.Image = ((System.Drawing.Image)(resources.GetObject("btnedt.Image")));
            this.btnedt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnedt.Location = new System.Drawing.Point(82, 6);
            this.btnedt.Name = "btnedt";
            this.btnedt.Size = new System.Drawing.Size(72, 24);
            this.btnedt.TabIndex = 1;
            this.btnedt.Text = "Edit";
            this.btnedt.UseVisualStyleBackColor = true;
            this.btnedt.Click += new System.EventHandler(this.btnedt_Click);
            // 
            // bntnew
            // 
            this.bntnew.Image = ((System.Drawing.Image)(resources.GetObject("bntnew.Image")));
            this.bntnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntnew.Location = new System.Drawing.Point(4, 6);
            this.bntnew.Name = "bntnew";
            this.bntnew.Size = new System.Drawing.Size(72, 24);
            this.bntnew.TabIndex = 0;
            this.bntnew.Text = "New";
            this.bntnew.UseVisualStyleBackColor = true;
            this.bntnew.Click += new System.EventHandler(this.bntnew_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Edit";
            this.dataGridViewImageColumn1.FillWeight = 80.91245F;
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "Delete";
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 60;
            // 
            // btnpickupentry
            // 
            this.btnpickupentry.FlatAppearance.BorderSize = 0;
            this.btnpickupentry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpickupentry.Image = ((System.Drawing.Image)(resources.GetObject("btnpickupentry.Image")));
            this.btnpickupentry.Location = new System.Drawing.Point(12, 60);
            this.btnpickupentry.Name = "btnpickupentry";
            this.btnpickupentry.Size = new System.Drawing.Size(25, 20);
            this.btnpickupentry.TabIndex = 2;
            this.btnpickupentry.UseVisualStyleBackColor = true;
            this.btnpickupentry.Click += new System.EventHandler(this.btnpickupentry_Click);
            // 
            // frmPickupEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(780, 316);
            this.Controls.Add(this.gvPickupPoint);
            this.Controls.Add(this.btnpickupentry);
            this.Controls.Add(this.lbladdr);
            this.Controls.Add(this.pnlEntry);
            this.Controls.Add(this.pnlsaveedit);
            this.Controls.Add(this.pnlbtnaccprd);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPickupEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pickup Entry";
            this.Load += new System.EventHandler(this.frmPickupEntry_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPickupEntry_KeyDown);
            this.pnlEntry.ResumeLayout(false);
            this.pnlEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPickupPoint)).EndInit();
            this.pnlsaveedit.ResumeLayout(false);
            this.pnlbtnaccprd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEntry;
        private System.Windows.Forms.Label lblvoutype;
        private System.Windows.Forms.Label lblvoudate;
        private System.Windows.Forms.DateTimePicker dtpPickupDate;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Label lblvouchno;
        private System.Windows.Forms.TextBox txtPickEntryGid;
        private System.Windows.Forms.ComboBox cmbAgent;
        private System.Windows.Forms.Button btnpickupentry;
        private System.Windows.Forms.Label lbladdr;
        public System.Windows.Forms.DataGridView gvPickupPoint;
        private System.Windows.Forms.Panel pnlsaveedit;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsve;
        private System.Windows.Forms.Panel pnlbtnaccprd;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btndlt;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnedt;
        private System.Windows.Forms.Button bntnew;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickupdtlsGid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pickup_Gid;
        private System.Windows.Forms.DataGridViewTextBoxColumn qcd_client_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn qcd_pickup_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickuppoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tot_chqs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_Ack;
        private System.Windows.Forms.DataGridViewTextBoxColumn saveflag;
        private System.Windows.Forms.DataGridViewTextBoxColumn dltflag;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}