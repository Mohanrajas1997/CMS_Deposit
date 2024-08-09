namespace CMS_Deposit.Forms
{
    partial class frmChqEntryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChqEntryView));
            this.pnladdr = new System.Windows.Forms.Panel();
            this.txtChqAmt = new System.Windows.Forms.TextBox();
            this.dtpChqDate = new System.Windows.Forms.DateTimePicker();
            this.txtChqNo = new System.Windows.Forms.TextBox();
            this.lblctydist = new System.Windows.Forms.Label();
            this.lbladdrline = new System.Windows.Forms.Label();
            this.lbladdrtype = new System.Windows.Forms.Label();
            this.txtdepositGid = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnadd1 = new System.Windows.Forms.Button();
            this.txtchqgid = new System.Windows.Forms.TextBox();
            this.txtAccHolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnladdr.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnladdr
            // 
            this.pnladdr.BackColor = System.Drawing.Color.Azure;
            this.pnladdr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnladdr.Controls.Add(this.txtAccHolder);
            this.pnladdr.Controls.Add(this.label1);
            this.pnladdr.Controls.Add(this.txtChqAmt);
            this.pnladdr.Controls.Add(this.dtpChqDate);
            this.pnladdr.Controls.Add(this.txtChqNo);
            this.pnladdr.Controls.Add(this.lblctydist);
            this.pnladdr.Controls.Add(this.lbladdrline);
            this.pnladdr.Controls.Add(this.lbladdrtype);
            this.pnladdr.Location = new System.Drawing.Point(12, 12);
            this.pnladdr.Name = "pnladdr";
            this.pnladdr.Size = new System.Drawing.Size(290, 121);
            this.pnladdr.TabIndex = 0;
            this.pnladdr.Paint += new System.Windows.Forms.PaintEventHandler(this.pnladdr_Paint);
            // 
            // txtChqAmt
            // 
            this.txtChqAmt.Location = new System.Drawing.Point(104, 63);
            this.txtChqAmt.Name = "txtChqAmt";
            this.txtChqAmt.Size = new System.Drawing.Size(176, 21);
            this.txtChqAmt.TabIndex = 2;
            this.txtChqAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChqAmt_KeyPress);
            // 
            // dtpChqDate
            // 
            this.dtpChqDate.CustomFormat = "dd/MM/yyyy";
            this.dtpChqDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChqDate.Location = new System.Drawing.Point(104, 35);
            this.dtpChqDate.Name = "dtpChqDate";
            this.dtpChqDate.Size = new System.Drawing.Size(176, 21);
            this.dtpChqDate.TabIndex = 1;
            // 
            // txtChqNo
            // 
            this.txtChqNo.Location = new System.Drawing.Point(104, 7);
            this.txtChqNo.Name = "txtChqNo";
            this.txtChqNo.Size = new System.Drawing.Size(176, 21);
            this.txtChqNo.TabIndex = 0;
            this.txtChqNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChqNo_KeyPress);
            // 
            // lblctydist
            // 
            this.lblctydist.AutoSize = true;
            this.lblctydist.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblctydist.Location = new System.Drawing.Point(3, 67);
            this.lblctydist.Name = "lblctydist";
            this.lblctydist.Size = new System.Drawing.Size(97, 13);
            this.lblctydist.TabIndex = 23;
            this.lblctydist.Text = "Cheque Amount";
            // 
            // lbladdrline
            // 
            this.lbladdrline.AutoSize = true;
            this.lbladdrline.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdrline.Location = new System.Drawing.Point(3, 39);
            this.lbladdrline.Name = "lbladdrline";
            this.lbladdrline.Size = new System.Drawing.Size(79, 13);
            this.lbladdrline.TabIndex = 19;
            this.lbladdrline.Text = "Cheque Date";
            // 
            // lbladdrtype
            // 
            this.lbladdrtype.AutoSize = true;
            this.lbladdrtype.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdrtype.Location = new System.Drawing.Point(3, 11);
            this.lbladdrtype.Name = "lbladdrtype";
            this.lbladdrtype.Size = new System.Drawing.Size(66, 13);
            this.lbladdrtype.TabIndex = 7;
            this.lbladdrtype.Text = "Cheque No";
            // 
            // txtdepositGid
            // 
            this.txtdepositGid.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdepositGid.Location = new System.Drawing.Point(41, 149);
            this.txtdepositGid.MaxLength = 20;
            this.txtdepositGid.Name = "txtdepositGid";
            this.txtdepositGid.Size = new System.Drawing.Size(23, 21);
            this.txtdepositGid.TabIndex = 33;
            this.txtdepositGid.Visible = false;
            this.txtdepositGid.TextChanged += new System.EventHandler(this.txtdepositGid_TextChanged);
            // 
            // btncancel
            // 
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(230, 139);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(72, 24);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Cancel";
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnadd1
            // 
            this.btnadd1.Image = ((System.Drawing.Image)(resources.GetObject("btnadd1.Image")));
            this.btnadd1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd1.Location = new System.Drawing.Point(152, 139);
            this.btnadd1.Name = "btnadd1";
            this.btnadd1.Size = new System.Drawing.Size(72, 24);
            this.btnadd1.TabIndex = 1;
            this.btnadd1.Text = "Save";
            this.btnadd1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadd1.UseVisualStyleBackColor = true;
            this.btnadd1.Click += new System.EventHandler(this.btnadd1_Click);
            // 
            // txtchqgid
            // 
            this.txtchqgid.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchqgid.Location = new System.Drawing.Point(9, 149);
            this.txtchqgid.MaxLength = 20;
            this.txtchqgid.Name = "txtchqgid";
            this.txtchqgid.Size = new System.Drawing.Size(26, 21);
            this.txtchqgid.TabIndex = 38;
            this.txtchqgid.Visible = false;
            this.txtchqgid.TextChanged += new System.EventHandler(this.txtchqgid_TextChanged);
            // 
            // txtAccHolder
            // 
            this.txtAccHolder.Location = new System.Drawing.Point(104, 90);
            this.txtAccHolder.MaxLength = 128;
            this.txtAccHolder.Name = "txtAccHolder";
            this.txtAccHolder.Size = new System.Drawing.Size(176, 21);
            this.txtAccHolder.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "A/C Holder";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmChqEntryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(310, 171);
            this.Controls.Add(this.txtchqgid);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnadd1);
            this.Controls.Add(this.pnladdr);
            this.Controls.Add(this.txtdepositGid);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChqEntryView";
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
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnadd1;
        public System.Windows.Forms.Panel pnladdr;
        public System.Windows.Forms.TextBox txtdepositGid;
        public System.Windows.Forms.TextBox txtchqgid;
        private System.Windows.Forms.TextBox txtChqNo;
        private System.Windows.Forms.DateTimePicker dtpChqDate;
        private System.Windows.Forms.TextBox txtChqAmt;
        private System.Windows.Forms.TextBox txtAccHolder;
        private System.Windows.Forms.Label label1;
    }
}