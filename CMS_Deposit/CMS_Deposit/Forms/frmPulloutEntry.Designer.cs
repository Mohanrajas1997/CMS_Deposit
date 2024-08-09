namespace CMS_Deposit.Forms
{
    partial class frmPulloutEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPulloutEntry));
            this.pnladdr = new System.Windows.Forms.Panel();
            this.cmbReason = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpPullout = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChqAmt = new System.Windows.Forms.TextBox();
            this.dtpChqDate = new System.Windows.Forms.DateTimePicker();
            this.txtChqNo = new System.Windows.Forms.TextBox();
            this.lblctydist = new System.Windows.Forms.Label();
            this.lbladdrline = new System.Windows.Forms.Label();
            this.lbladdrtype = new System.Windows.Forms.Label();
            this.txtPulloutId = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPullout = new System.Windows.Forms.Button();
            this.txtChqId = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.pnladdr.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnladdr
            // 
            this.pnladdr.BackColor = System.Drawing.Color.Azure;
            this.pnladdr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnladdr.Controls.Add(this.cmbReason);
            this.pnladdr.Controls.Add(this.label2);
            this.pnladdr.Controls.Add(this.dtpPullout);
            this.pnladdr.Controls.Add(this.label1);
            this.pnladdr.Controls.Add(this.txtChqAmt);
            this.pnladdr.Controls.Add(this.dtpChqDate);
            this.pnladdr.Controls.Add(this.txtChqNo);
            this.pnladdr.Controls.Add(this.lblctydist);
            this.pnladdr.Controls.Add(this.lbladdrline);
            this.pnladdr.Controls.Add(this.lbladdrtype);
            this.pnladdr.Location = new System.Drawing.Point(12, 12);
            this.pnladdr.Name = "pnladdr";
            this.pnladdr.Size = new System.Drawing.Size(610, 64);
            this.pnladdr.TabIndex = 0;
            // 
            // cmbReason
            // 
            this.cmbReason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbReason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbReason.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReason.FormattingEnabled = true;
            this.cmbReason.Location = new System.Drawing.Point(277, 34);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.Size = new System.Drawing.Size(321, 21);
            this.cmbReason.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(205, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Reason";
            // 
            // dtpPullout
            // 
            this.dtpPullout.CustomFormat = "dd/MM/yyyy";
            this.dtpPullout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPullout.Location = new System.Drawing.Point(87, 34);
            this.dtpPullout.Name = "dtpPullout";
            this.dtpPullout.Size = new System.Drawing.Size(107, 21);
            this.dtpPullout.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Pullout Date";
            // 
            // txtChqAmt
            // 
            this.txtChqAmt.Enabled = false;
            this.txtChqAmt.Location = new System.Drawing.Point(491, 7);
            this.txtChqAmt.Name = "txtChqAmt";
            this.txtChqAmt.Size = new System.Drawing.Size(107, 21);
            this.txtChqAmt.TabIndex = 2;
            this.txtChqAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChqAmt_KeyPress);
            // 
            // dtpChqDate
            // 
            this.dtpChqDate.CustomFormat = "dd/MM/yyyy";
            this.dtpChqDate.Enabled = false;
            this.dtpChqDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChqDate.Location = new System.Drawing.Point(87, 7);
            this.dtpChqDate.Name = "dtpChqDate";
            this.dtpChqDate.Size = new System.Drawing.Size(107, 21);
            this.dtpChqDate.TabIndex = 0;
            // 
            // txtChqNo
            // 
            this.txtChqNo.Enabled = false;
            this.txtChqNo.Location = new System.Drawing.Point(277, 7);
            this.txtChqNo.Name = "txtChqNo";
            this.txtChqNo.Size = new System.Drawing.Size(107, 21);
            this.txtChqNo.TabIndex = 1;
            this.txtChqNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChqNo_KeyPress);
            // 
            // lblctydist
            // 
            this.lblctydist.AutoSize = true;
            this.lblctydist.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblctydist.Location = new System.Drawing.Point(390, 11);
            this.lblctydist.Name = "lblctydist";
            this.lblctydist.Size = new System.Drawing.Size(97, 13);
            this.lblctydist.TabIndex = 23;
            this.lblctydist.Text = "Cheque Amount";
            // 
            // lbladdrline
            // 
            this.lbladdrline.AutoSize = true;
            this.lbladdrline.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdrline.Location = new System.Drawing.Point(2, 11);
            this.lbladdrline.Name = "lbladdrline";
            this.lbladdrline.Size = new System.Drawing.Size(79, 13);
            this.lbladdrline.TabIndex = 0;
            this.lbladdrline.Text = "Cheque Date";
            // 
            // lbladdrtype
            // 
            this.lbladdrtype.AutoSize = true;
            this.lbladdrtype.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdrtype.Location = new System.Drawing.Point(205, 11);
            this.lbladdrtype.Name = "lbladdrtype";
            this.lbladdrtype.Size = new System.Drawing.Size(66, 13);
            this.lbladdrtype.TabIndex = 7;
            this.lbladdrtype.Text = "Cheque No";
            // 
            // txtPulloutId
            // 
            this.txtPulloutId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPulloutId.Location = new System.Drawing.Point(44, 85);
            this.txtPulloutId.MaxLength = 20;
            this.txtPulloutId.Name = "txtPulloutId";
            this.txtPulloutId.Size = new System.Drawing.Size(23, 21);
            this.txtPulloutId.TabIndex = 33;
            this.txtPulloutId.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(551, 82);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 24);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnPullout
            // 
            this.btnPullout.Image = ((System.Drawing.Image)(resources.GetObject("btnPullout.Image")));
            this.btnPullout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPullout.Location = new System.Drawing.Point(395, 82);
            this.btnPullout.Name = "btnPullout";
            this.btnPullout.Size = new System.Drawing.Size(72, 24);
            this.btnPullout.TabIndex = 0;
            this.btnPullout.Text = "Pullout";
            this.btnPullout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPullout.UseVisualStyleBackColor = true;
            this.btnPullout.Click += new System.EventHandler(this.btnadd1_Click);
            // 
            // txtChqId
            // 
            this.txtChqId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChqId.Location = new System.Drawing.Point(12, 85);
            this.txtChqId.MaxLength = 20;
            this.txtChqId.Name = "txtChqId";
            this.txtChqId.Size = new System.Drawing.Size(26, 21);
            this.txtChqId.TabIndex = 38;
            this.txtChqId.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(473, 82);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(72, 24);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Delete";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // frmPulloutEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(632, 111);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txtChqId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPullout);
            this.Controls.Add(this.pnladdr);
            this.Controls.Add(this.txtPulloutId);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPulloutEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chq Entry";
            this.Load += new System.EventHandler(this.ChqEntry_Load);
            this.pnladdr.ResumeLayout(false);
            this.pnladdr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbladdrtype;
        private System.Windows.Forms.Label lbladdrline;
        private System.Windows.Forms.Label lblctydist;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPullout;
        public System.Windows.Forms.Panel pnladdr;
        public System.Windows.Forms.TextBox txtPulloutId;
        public System.Windows.Forms.TextBox txtChqId;
        private System.Windows.Forms.TextBox txtChqNo;
        private System.Windows.Forms.DateTimePicker dtpChqDate;
        private System.Windows.Forms.TextBox txtChqAmt;
        private System.Windows.Forms.DateTimePicker dtpPullout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbReason;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDel;
    }
}