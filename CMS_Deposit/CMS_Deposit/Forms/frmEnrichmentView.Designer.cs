namespace CMS_Deposit.Forms
{
    partial class frmEnrichmentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnrichmentView));
            this.gvchqview = new System.Windows.Forms.DataGridView();
            this.enrich_gid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deposit_gid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chq_gid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ref_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ref_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEnrichmentEntry = new System.Windows.Forms.Button();
            this.lbladdr = new System.Windows.Forms.Label();
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
            this.enrich_gid,
            this.deposit_gid,
            this.chq_gid,
            this.ref_no,
            this.ref_amount,
            this.edit,
            this.delete});
            this.gvchqview.Location = new System.Drawing.Point(6, 23);
            this.gvchqview.Name = "gvchqview";
            this.gvchqview.ReadOnly = true;
            this.gvchqview.Size = new System.Drawing.Size(474, 143);
            this.gvchqview.TabIndex = 1;
            this.gvchqview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvchqview_CellClick);
            // 
            // enrich_gid
            // 
            this.enrich_gid.DataPropertyName = "enrich_gid";
            this.enrich_gid.HeaderText = "enrich_gid";
            this.enrich_gid.Name = "enrich_gid";
            this.enrich_gid.ReadOnly = true;
            this.enrich_gid.Visible = false;
            // 
            // deposit_gid
            // 
            this.deposit_gid.DataPropertyName = "deposit_gid";
            this.deposit_gid.HeaderText = "deposit_gid";
            this.deposit_gid.Name = "deposit_gid";
            this.deposit_gid.ReadOnly = true;
            this.deposit_gid.Visible = false;
            // 
            // chq_gid
            // 
            this.chq_gid.DataPropertyName = "chq_gid";
            this.chq_gid.HeaderText = "chq_gid";
            this.chq_gid.Name = "chq_gid";
            this.chq_gid.ReadOnly = true;
            this.chq_gid.Visible = false;
            // 
            // ref_no
            // 
            this.ref_no.DataPropertyName = "ref_no";
            this.ref_no.FillWeight = 69.00147F;
            this.ref_no.HeaderText = "Ref No";
            this.ref_no.Name = "ref_no";
            this.ref_no.ReadOnly = true;
            this.ref_no.Width = 120;
            // 
            // ref_amount
            // 
            this.ref_amount.DataPropertyName = "ref_amount";
            this.ref_amount.FillWeight = 69.00147F;
            this.ref_amount.HeaderText = "Ref Amount";
            this.ref_amount.Name = "ref_amount";
            this.ref_amount.ReadOnly = true;
            this.ref_amount.Width = 110;
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Edit";
            this.dataGridViewImageColumn1.FillWeight = 80.91245F;
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "Delete";
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 60;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.DataPropertyName = "Enrichment";
            this.dataGridViewImageColumn3.HeaderText = "Enrichment";
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // btnEnrichmentEntry
            // 
            this.btnEnrichmentEntry.FlatAppearance.BorderSize = 0;
            this.btnEnrichmentEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrichmentEntry.Image = ((System.Drawing.Image)(resources.GetObject("btnEnrichmentEntry.Image")));
            this.btnEnrichmentEntry.Location = new System.Drawing.Point(12, 2);
            this.btnEnrichmentEntry.Name = "btnEnrichmentEntry";
            this.btnEnrichmentEntry.Size = new System.Drawing.Size(25, 20);
            this.btnEnrichmentEntry.TabIndex = 3;
            this.btnEnrichmentEntry.UseVisualStyleBackColor = true;
            this.btnEnrichmentEntry.Click += new System.EventHandler(this.btnEnrichmentEntry_Click);
            // 
            // lbladdr
            // 
            this.lbladdr.AutoSize = true;
            this.lbladdr.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdr.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbladdr.Location = new System.Drawing.Point(188, 6);
            this.lbladdr.Name = "lbladdr";
            this.lbladdr.Size = new System.Drawing.Size(111, 13);
            this.lbladdr.TabIndex = 4;
            this.lbladdr.Text = "Enrichment Listing";
            // 
            // frmEnrichmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(486, 171);
            this.Controls.Add(this.lbladdr);
            this.Controls.Add(this.btnEnrichmentEntry);
            this.Controls.Add(this.gvchqview);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEnrichmentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnrichMent View";
            this.Load += new System.EventHandler(this.frmChqView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvchqview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView gvchqview;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrich_gid;
        private System.Windows.Forms.DataGridViewTextBoxColumn deposit_gid;
        private System.Windows.Forms.DataGridViewTextBoxColumn chq_gid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ref_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn ref_amount;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Button btnEnrichmentEntry;
        private System.Windows.Forms.Label lbladdr;
    }
}