namespace CMS_Deposit.Forms
{
    partial class frmCreateGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateGroup));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtusergrpgid = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsve = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.btndlt = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnedt = new System.Windows.Forms.Button();
            this.bntnew = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.txtusergrpgid);
            this.pnlMain.Controls.Add(this.txtName);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Location = new System.Drawing.Point(6, 8);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(396, 36);
            this.pnlMain.TabIndex = 37;
            // 
            // txtusergrpgid
            // 
            this.txtusergrpgid.Location = new System.Drawing.Point(362, 6);
            this.txtusergrpgid.Name = "txtusergrpgid";
            this.txtusergrpgid.Size = new System.Drawing.Size(25, 21);
            this.txtusergrpgid.TabIndex = 43;
            this.txtusergrpgid.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 6);
            this.txtName.MaxLength = 64;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(293, 21);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(3, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 13);
            this.lblName.TabIndex = 55;
            this.lblName.Text = "Group Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlSave
            // 
            this.pnlSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSave.Controls.Add(this.btncancel);
            this.pnlSave.Controls.Add(this.btnsve);
            this.pnlSave.Location = new System.Drawing.Point(129, 50);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(160, 35);
            this.pnlSave.TabIndex = 71;
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
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Azure;
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButtons.Controls.Add(this.btnclose);
            this.pnlButtons.Controls.Add(this.btndlt);
            this.pnlButtons.Controls.Add(this.btnfind);
            this.pnlButtons.Controls.Add(this.btnedt);
            this.pnlButtons.Controls.Add(this.bntnew);
            this.pnlButtons.Location = new System.Drawing.Point(6, 50);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(396, 35);
            this.pnlButtons.TabIndex = 72;
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(315, 4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(72, 24);
            this.btnclose.TabIndex = 39;
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
            this.btndlt.TabIndex = 37;
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
            this.btnfind.TabIndex = 36;
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
            this.btnedt.TabIndex = 35;
            this.btnedt.Text = "Edit";
            this.btnedt.UseVisualStyleBackColor = true;
            this.btnedt.Click += new System.EventHandler(this.btnedt_Click);
            // 
            // bntnew
            // 
            this.bntnew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bntnew.Image = ((System.Drawing.Image)(resources.GetObject("bntnew.Image")));
            this.bntnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntnew.Location = new System.Drawing.Point(3, 4);
            this.bntnew.Name = "bntnew";
            this.bntnew.Size = new System.Drawing.Size(72, 24);
            this.bntnew.TabIndex = 0;
            this.bntnew.Text = "New";
            this.bntnew.UseVisualStyleBackColor = true;
            this.bntnew.Click += new System.EventHandler(this.bntnew_Click);
            // 
            // frmCreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(407, 92);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSave);
            this.Controls.Add(this.pnlButtons);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Group";
            this.Load += new System.EventHandler(this.frmCreateGroup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlSave.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnlMain;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsve;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btndlt;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnedt;
        private System.Windows.Forms.Button bntnew;
        internal System.Windows.Forms.TextBox txtusergrpgid;
    }
}