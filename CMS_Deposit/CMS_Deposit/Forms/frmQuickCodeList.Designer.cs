namespace CMS_Deposit.Forms
{
    partial class frmQuickCodeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuickCodeList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMaster = new System.Windows.Forms.DataGridView();
            this.mastercode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnadd = new System.Windows.Forms.Button();
            this.lblmstlst = new System.Windows.Forms.Label();
            this.dgvMasterList = new System.Windows.Forms.DataGridView();
            this.txtmstdesc = new System.Windows.Forms.TextBox();
            this.txtmstcode = new System.Windows.Forms.TextBox();
            this.lblcode = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.qcd_gid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.master_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qcd_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dependent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depntmaster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depntcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaster
            // 
            this.dgvMaster.AllowUserToAddRows = false;
            this.dgvMaster.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaster.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mastercode,
            this.masterdesc});
            this.dgvMaster.Location = new System.Drawing.Point(4, 3);
            this.dgvMaster.Name = "dgvMaster";
            this.dgvMaster.ReadOnly = true;
            this.dgvMaster.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvMaster.Size = new System.Drawing.Size(274, 600);
            this.dgvMaster.TabIndex = 0;
            this.dgvMaster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaster_CellContentClick);
            this.dgvMaster.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvmasterlist_CellMouseClick);
            // 
            // mastercode
            // 
            this.mastercode.HeaderText = "Master Code";
            this.mastercode.Name = "mastercode";
            this.mastercode.ReadOnly = true;
            // 
            // masterdesc
            // 
            this.masterdesc.HeaderText = "Master Description";
            this.masterdesc.Name = "masterdesc";
            this.masterdesc.ReadOnly = true;
            this.masterdesc.Width = 130;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnadd);
            this.pnlMain.Controls.Add(this.lblmstlst);
            this.pnlMain.Controls.Add(this.dgvMasterList);
            this.pnlMain.Controls.Add(this.txtmstdesc);
            this.pnlMain.Controls.Add(this.txtmstcode);
            this.pnlMain.Controls.Add(this.lblcode);
            this.pnlMain.Controls.Add(this.lbldesc);
            this.pnlMain.Controls.Add(this.dgvMaster);
            this.pnlMain.Location = new System.Drawing.Point(3, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1041, 472);
            this.pnlMain.TabIndex = 0;
            // 
            // btnadd
            // 
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(352, 33);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(26, 31);
            this.btnadd.TabIndex = 2;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lblmstlst
            // 
            this.lblmstlst.AutoSize = true;
            this.lblmstlst.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmstlst.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblmstlst.Location = new System.Drawing.Point(281, 42);
            this.lblmstlst.Name = "lblmstlst";
            this.lblmstlst.Size = new System.Drawing.Size(70, 13);
            this.lblmstlst.TabIndex = 81;
            this.lblmstlst.Text = "Master List";
            // 
            // dgvMasterList
            // 
            this.dgvMasterList.AllowUserToAddRows = false;
            this.dgvMasterList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMasterList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMasterList.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvMasterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasterList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qcd_gid,
            this.master_code,
            this.qcd_code,
            this.shortcode,
            this.shortdesc,
            this.dependent,
            this.depntmaster,
            this.depntcode,
            this.edit,
            this.delete});
            this.dgvMasterList.Location = new System.Drawing.Point(284, 65);
            this.dgvMasterList.Name = "dgvMasterList";
            this.dgvMasterList.ReadOnly = true;
            this.dgvMasterList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvMasterList.Size = new System.Drawing.Size(748, 402);
            this.dgvMasterList.TabIndex = 80;
            this.dgvMasterList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMasterList_CellContentClick);
            // 
            // txtmstdesc
            // 
            this.txtmstdesc.BackColor = System.Drawing.Color.Yellow;
            this.txtmstdesc.Enabled = false;
            this.txtmstdesc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmstdesc.ForeColor = System.Drawing.Color.White;
            this.txtmstdesc.Location = new System.Drawing.Point(725, 8);
            this.txtmstdesc.MaxLength = 25;
            this.txtmstdesc.Name = "txtmstdesc";
            this.txtmstdesc.Size = new System.Drawing.Size(178, 21);
            this.txtmstdesc.TabIndex = 1;
            // 
            // txtmstcode
            // 
            this.txtmstcode.BackColor = System.Drawing.Color.Yellow;
            this.txtmstcode.Enabled = false;
            this.txtmstcode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmstcode.ForeColor = System.Drawing.Color.White;
            this.txtmstcode.Location = new System.Drawing.Point(426, 8);
            this.txtmstcode.MaxLength = 25;
            this.txtmstcode.Name = "txtmstcode";
            this.txtmstcode.Size = new System.Drawing.Size(178, 21);
            this.txtmstcode.TabIndex = 0;
            // 
            // lblcode
            // 
            this.lblcode.AutoSize = true;
            this.lblcode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcode.Location = new System.Drawing.Point(384, 11);
            this.lblcode.Name = "lblcode";
            this.lblcode.Size = new System.Drawing.Size(35, 13);
            this.lblcode.TabIndex = 77;
            this.lblcode.Text = "Code";
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.Location = new System.Drawing.Point(638, 11);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(71, 13);
            this.lbldesc.TabIndex = 75;
            this.lbldesc.Text = "Description";
            // 
            // qcd_gid
            // 
            this.qcd_gid.HeaderText = "QCD Gid";
            this.qcd_gid.Name = "qcd_gid";
            this.qcd_gid.ReadOnly = true;
            this.qcd_gid.Visible = false;
            // 
            // master_code
            // 
            this.master_code.HeaderText = "Master Code";
            this.master_code.Name = "master_code";
            this.master_code.ReadOnly = true;
            this.master_code.Visible = false;
            // 
            // qcd_code
            // 
            this.qcd_code.HeaderText = "QCD Code";
            this.qcd_code.Name = "qcd_code";
            this.qcd_code.ReadOnly = true;
            // 
            // shortcode
            // 
            this.shortcode.HeaderText = "Short Code";
            this.shortcode.Name = "shortcode";
            this.shortcode.ReadOnly = true;
            // 
            // shortdesc
            // 
            this.shortdesc.HeaderText = "Short Description";
            this.shortdesc.Name = "shortdesc";
            this.shortdesc.ReadOnly = true;
            // 
            // dependent
            // 
            this.dependent.HeaderText = "Dependent";
            this.dependent.Name = "dependent";
            this.dependent.ReadOnly = true;
            // 
            // depntmaster
            // 
            this.depntmaster.HeaderText = "Dependent Master";
            this.depntmaster.Name = "depntmaster";
            this.depntmaster.ReadOnly = true;
            // 
            // depntcode
            // 
            this.depntcode.HeaderText = "Dependent Code";
            this.depntcode.Name = "depntcode";
            this.depntcode.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.HeaderText = "Edit";
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.Width = 50;
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.Width = 60;
            // 
            // frmQuickCodeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1048, 476);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuickCodeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick Code Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuickCodeList_Load);
            this.Resize += new System.EventHandler(this.frmQuickCodeList_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaster;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtmstcode;
        private System.Windows.Forms.Label lblcode;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.TextBox txtmstdesc;
        private System.Windows.Forms.DataGridView dgvMasterList;
        private System.Windows.Forms.Label lblmstlst;
        private System.Windows.Forms.DataGridViewTextBoxColumn mastercode;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterdesc;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn qcd_gid;
        private System.Windows.Forms.DataGridViewTextBoxColumn master_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn qcd_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortdesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dependent;
        private System.Windows.Forms.DataGridViewTextBoxColumn depntmaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn depntcode;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}