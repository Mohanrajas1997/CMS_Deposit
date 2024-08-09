namespace CMS_Deposit.Forms
{
    partial class frmEnrichmentEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnrichmentEntry));
            this.pnladdr = new System.Windows.Forms.Panel();
            this.txtRefAmt = new System.Windows.Forms.TextBox();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.lblctydist = new System.Windows.Forms.Label();
            this.lbladdrtype = new System.Windows.Forms.Label();
            this.txtdepositGid = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnadd1 = new System.Windows.Forms.Button();
            this.txtchqgid = new System.Windows.Forms.TextBox();
            this.txtenrichgid = new System.Windows.Forms.TextBox();
            this.pnladdr.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnladdr
            // 
            this.pnladdr.BackColor = System.Drawing.Color.Azure;
            this.pnladdr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnladdr.Controls.Add(this.txtRefAmt);
            this.pnladdr.Controls.Add(this.txtRefNo);
            this.pnladdr.Controls.Add(this.lblctydist);
            this.pnladdr.Controls.Add(this.lbladdrtype);
            this.pnladdr.Location = new System.Drawing.Point(12, 12);
            this.pnladdr.Name = "pnladdr";
            this.pnladdr.Size = new System.Drawing.Size(278, 68);
            this.pnladdr.TabIndex = 0;
            // 
            // txtRefAmt
            // 
            this.txtRefAmt.Location = new System.Drawing.Point(92, 36);
            this.txtRefAmt.Name = "txtRefAmt";
            this.txtRefAmt.Size = new System.Drawing.Size(176, 21);
            this.txtRefAmt.TabIndex = 33;
            this.txtRefAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRefAmt_KeyPress);
            // 
            // txtRefNo
            // 
            this.txtRefNo.Location = new System.Drawing.Point(92, 7);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(176, 21);
            this.txtRefNo.TabIndex = 31;
            // 
            // lblctydist
            // 
            this.lblctydist.AutoSize = true;
            this.lblctydist.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblctydist.Location = new System.Drawing.Point(3, 40);
            this.lblctydist.Name = "lblctydist";
            this.lblctydist.Size = new System.Drawing.Size(74, 13);
            this.lblctydist.TabIndex = 23;
            this.lblctydist.Text = "Ref Amount";
            // 
            // lbladdrtype
            // 
            this.lbladdrtype.AutoSize = true;
            this.lbladdrtype.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdrtype.Location = new System.Drawing.Point(3, 11);
            this.lbladdrtype.Name = "lbladdrtype";
            this.lbladdrtype.Size = new System.Drawing.Size(43, 13);
            this.lbladdrtype.TabIndex = 7;
            this.lbladdrtype.Text = "Ref No";
            // 
            // txtdepositGid
            // 
            this.txtdepositGid.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdepositGid.Location = new System.Drawing.Point(44, 88);
            this.txtdepositGid.MaxLength = 20;
            this.txtdepositGid.Name = "txtdepositGid";
            this.txtdepositGid.Size = new System.Drawing.Size(23, 21);
            this.txtdepositGid.TabIndex = 33;
            this.txtdepositGid.Visible = false;
            // 
            // btncancel
            // 
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(218, 88);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(72, 24);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "&Cancel";
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnadd1
            // 
            this.btnadd1.Image = ((System.Drawing.Image)(resources.GetObject("btnadd1.Image")));
            this.btnadd1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd1.Location = new System.Drawing.Point(141, 88);
            this.btnadd1.Name = "btnadd1";
            this.btnadd1.Size = new System.Drawing.Size(72, 24);
            this.btnadd1.TabIndex = 1;
            this.btnadd1.Text = "&Save";
            this.btnadd1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadd1.UseVisualStyleBackColor = true;
            this.btnadd1.Click += new System.EventHandler(this.btnadd1_Click);
            // 
            // txtchqgid
            // 
            this.txtchqgid.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchqgid.Location = new System.Drawing.Point(12, 88);
            this.txtchqgid.MaxLength = 20;
            this.txtchqgid.Name = "txtchqgid";
            this.txtchqgid.Size = new System.Drawing.Size(26, 21);
            this.txtchqgid.TabIndex = 38;
            this.txtchqgid.Visible = false;
            // 
            // txtenrichgid
            // 
            this.txtenrichgid.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtenrichgid.Location = new System.Drawing.Point(73, 88);
            this.txtenrichgid.MaxLength = 20;
            this.txtenrichgid.Name = "txtenrichgid";
            this.txtenrichgid.Size = new System.Drawing.Size(23, 21);
            this.txtenrichgid.TabIndex = 39;
            this.txtenrichgid.Visible = false;
            // 
            // frmEnrichmentEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(299, 118);
            this.Controls.Add(this.txtenrichgid);
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
            this.Name = "frmEnrichmentEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrichment Entry";
            this.Load += new System.EventHandler(this.ChqEntry_Load);
            this.pnladdr.ResumeLayout(false);
            this.pnladdr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbladdrtype;
        private System.Windows.Forms.Label lblctydist;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnadd1;
        public System.Windows.Forms.Panel pnladdr;
        public System.Windows.Forms.TextBox txtdepositGid;
        public System.Windows.Forms.TextBox txtchqgid;
        private System.Windows.Forms.TextBox txtRefNo;
        private System.Windows.Forms.TextBox txtRefAmt;
        public System.Windows.Forms.TextBox txtenrichgid;
    }
}