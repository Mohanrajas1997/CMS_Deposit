namespace CMS_Deposit.Forms
{
    partial class frmChqView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChqView));
            this.gvchqview = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.chq_gid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deposit_gid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chq_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chq_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chq_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acc_holder_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.micr_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tran_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.EnrichMent = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvchqview)).BeginInit();
            this.SuspendLayout();
            // 
            // gvchqview
            // 
            this.gvchqview.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gvchqview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvchqview.BackgroundColor = System.Drawing.Color.Azure;
            this.gvchqview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chq_gid,
            this.deposit_gid,
            this.chq_no,
            this.chq_date,
            this.chq_amount,
            this.acc_holder_name,
            this.micr_code,
            this.tran_code,
            this.edit,
            this.delete,
            this.EnrichMent});
            this.gvchqview.Location = new System.Drawing.Point(6, 6);
            this.gvchqview.Name = "gvchqview";
            this.gvchqview.ReadOnly = true;
            this.gvchqview.Size = new System.Drawing.Size(1019, 143);
            this.gvchqview.TabIndex = 1;
            this.gvchqview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvchqview_CellClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Edit";
            this.dataGridViewImageColumn1.FillWeight = 80.91245F;
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "Delete";
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 60;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.DataPropertyName = "Enrichment";
            this.dataGridViewImageColumn3.HeaderText = "Enrichment";
            this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // chq_gid
            // 
            this.chq_gid.DataPropertyName = "chq_gid";
            this.chq_gid.HeaderText = "chq_gid";
            this.chq_gid.Name = "chq_gid";
            this.chq_gid.ReadOnly = true;
            this.chq_gid.Visible = false;
            // 
            // deposit_gid
            // 
            this.deposit_gid.DataPropertyName = "deposit_gid";
            this.deposit_gid.HeaderText = "deposit_gid";
            this.deposit_gid.Name = "deposit_gid";
            this.deposit_gid.ReadOnly = true;
            this.deposit_gid.Visible = false;
            // 
            // chq_no
            // 
            this.chq_no.DataPropertyName = "chq_no";
            this.chq_no.FillWeight = 69.00147F;
            this.chq_no.HeaderText = "Cheque No";
            this.chq_no.Name = "chq_no";
            this.chq_no.ReadOnly = true;
            this.chq_no.Width = 120;
            // 
            // chq_date
            // 
            this.chq_date.DataPropertyName = "chq_date";
            this.chq_date.FillWeight = 69.00147F;
            this.chq_date.HeaderText = "Cheque Date";
            this.chq_date.Name = "chq_date";
            this.chq_date.ReadOnly = true;
            this.chq_date.Width = 110;
            // 
            // chq_amount
            // 
            this.chq_amount.DataPropertyName = "chq_amount";
            this.chq_amount.FillWeight = 69.00147F;
            this.chq_amount.HeaderText = "Cheque Amount";
            this.chq_amount.Name = "chq_amount";
            this.chq_amount.ReadOnly = true;
            this.chq_amount.Width = 120;
            // 
            // acc_holder_name
            // 
            this.acc_holder_name.DataPropertyName = "acc_holder_name";
            this.acc_holder_name.HeaderText = "A/c Holder";
            this.acc_holder_name.Name = "acc_holder_name";
            this.acc_holder_name.ReadOnly = true;
            // 
            // micr_code
            // 
            this.micr_code.DataPropertyName = "micr_code";
            this.micr_code.HeaderText = "Micr Code";
            this.micr_code.Name = "micr_code";
            this.micr_code.ReadOnly = true;
            // 
            // tran_code
            // 
            this.tran_code.DataPropertyName = "tran_code";
            this.tran_code.HeaderText = "Tran Code";
            this.tran_code.Name = "tran_code";
            this.tran_code.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.DataPropertyName = "edit";
            this.edit.HeaderText = "Edit";
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // delete
            // 
            this.delete.DataPropertyName = "delete";
            this.delete.HeaderText = "Delete";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EnrichMent
            // 
            this.EnrichMent.DataPropertyName = "EnrichMent";
            this.EnrichMent.HeaderText = "Enrichment";
            this.EnrichMent.Image = ((System.Drawing.Image)(resources.GetObject("EnrichMent.Image")));
            this.EnrichMent.Name = "EnrichMent";
            this.EnrichMent.ReadOnly = true;
            this.EnrichMent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmChqView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1033, 153);
            this.Controls.Add(this.gvchqview);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChqView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheque Entry View";
            this.Load += new System.EventHandler(this.frmChqView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvchqview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView gvchqview;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn chq_gid;
        private System.Windows.Forms.DataGridViewTextBoxColumn deposit_gid;
        private System.Windows.Forms.DataGridViewTextBoxColumn chq_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn chq_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn chq_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn acc_holder_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn micr_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn tran_code;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.DataGridViewImageColumn EnrichMent;
    }
}