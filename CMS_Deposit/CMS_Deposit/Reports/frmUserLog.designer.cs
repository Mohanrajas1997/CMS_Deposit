namespace CMS_Deposit.Reports
{
    partial class frmUserLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserLog));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.Label8 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.Label7 = new System.Windows.Forms.Label();
            this.cboRptType = new System.Windows.Forms.ComboBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlExport = new System.Windows.Forms.Panel();
            this.txtTotRec = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.pnlMain.SuspendLayout();
            this.pnlExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.dtpTo);
            this.pnlMain.Controls.Add(this.Label8);
            this.pnlMain.Controls.Add(this.dtpFrom);
            this.pnlMain.Controls.Add(this.Label7);
            this.pnlMain.Controls.Add(this.cboRptType);
            this.pnlMain.Controls.Add(this.Label9);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Controls.Add(this.btnClear);
            this.pnlMain.Controls.Add(this.btnRefresh);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(861, 43);
            this.pnlMain.TabIndex = 0;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd-MM-yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(206, 12);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.ShowCheckBox = true;
            this.dtpTo.Size = new System.Drawing.Size(105, 21);
            this.dtpTo.TabIndex = 1;
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(170, 14);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(31, 17);
            this.Label8.TabIndex = 115;
            this.Label8.Text = "To";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd-MM-yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(59, 12);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.ShowCheckBox = true;
            this.dtpFrom.Size = new System.Drawing.Size(105, 21);
            this.dtpFrom.TabIndex = 0;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(10, 14);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(43, 17);
            this.Label7.TabIndex = 115;
            this.Label7.Text = "From";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboRptType
            // 
            this.cboRptType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboRptType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboRptType.FormattingEnabled = true;
            this.cboRptType.Location = new System.Drawing.Point(402, 12);
            this.cboRptType.Name = "cboRptType";
            this.cboRptType.Size = new System.Drawing.Size(215, 21);
            this.cboRptType.TabIndex = 2;
            // 
            // Label9
            // 
            this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label9.Location = new System.Drawing.Point(317, 14);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(79, 17);
            this.Label9.TabIndex = 113;
            this.Label9.Text = "Report Type";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(779, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 24);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(701, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 24);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C&lear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(623, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 24);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlExport
            // 
            this.pnlExport.Controls.Add(this.txtTotRec);
            this.pnlExport.Controls.Add(this.btnExport);
            this.pnlExport.Location = new System.Drawing.Point(12, 321);
            this.pnlExport.Name = "pnlExport";
            this.pnlExport.Size = new System.Drawing.Size(634, 33);
            this.pnlExport.TabIndex = 2;
            // 
            // txtTotRec
            // 
            this.txtTotRec.BackColor = System.Drawing.Color.Azure;
            this.txtTotRec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotRec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTotRec.Location = new System.Drawing.Point(6, 8);
            this.txtTotRec.MaxLength = 100;
            this.txtTotRec.Name = "txtTotRec";
            this.txtTotRec.ReadOnly = true;
            this.txtTotRec.Size = new System.Drawing.Size(433, 14);
            this.txtTotRec.TabIndex = 0;
            this.txtTotRec.TabStop = false;
            this.txtTotRec.Text = "Total Records : ";
            // 
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(558, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(72, 24);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "&Export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(12, 61);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(630, 244);
            this.dgvReport.TabIndex = 1;
            // 
            // frmUserLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(901, 513);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlExport);
            this.Controls.Add(this.dgvReport);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserLog";
            this.Text = "User Log Report";
            this.Load += new System.EventHandler(this.frmUserLog_Load);
            this.Resize += new System.EventHandler(this.frmUserLog_Resize);
            this.pnlMain.ResumeLayout(false);
            this.pnlExport.ResumeLayout(false);
            this.pnlExport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnlMain;
        internal System.Windows.Forms.DateTimePicker dtpTo;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.DateTimePicker dtpFrom;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.ComboBox cboRptType;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.Panel pnlExport;
        internal System.Windows.Forms.TextBox txtTotRec;
        internal System.Windows.Forms.Button btnExport;
        internal System.Windows.Forms.DataGridView dgvReport;
    }
}