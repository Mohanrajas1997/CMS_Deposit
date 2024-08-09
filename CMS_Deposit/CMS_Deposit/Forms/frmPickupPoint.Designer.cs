namespace CMS_Deposit.Forms
{
    partial class frmPickupPoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPickupPoint));
            this.pnladdr = new System.Windows.Forms.Panel();
            this.txtNoofChq = new System.Windows.Forms.TextBox();
            this.cmbclientack = new System.Windows.Forms.ComboBox();
            this.lblcountry = new System.Windows.Forms.Label();
            this.lblstate = new System.Windows.Forms.Label();
            this.cmbpickuppoint = new System.Windows.Forms.ComboBox();
            this.CmbClientCode = new System.Windows.Forms.ComboBox();
            this.lblctydist = new System.Windows.Forms.Label();
            this.txtclientname = new System.Windows.Forms.TextBox();
            this.lbladdrline = new System.Windows.Forms.Label();
            this.lbladdrtype = new System.Windows.Forms.Label();
            this.txtdltfg = new System.Windows.Forms.TextBox();
            this.txtsavefg = new System.Windows.Forms.TextBox();
            this.txtentityaddrgid = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnadd1 = new System.Windows.Forms.Button();
            this.txtentygid = new System.Windows.Forms.TextBox();
            this.locationcode = new System.Windows.Forms.TextBox();
            this.pnladdr.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnladdr
            // 
            this.pnladdr.BackColor = System.Drawing.Color.Azure;
            this.pnladdr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnladdr.Controls.Add(this.txtNoofChq);
            this.pnladdr.Controls.Add(this.cmbclientack);
            this.pnladdr.Controls.Add(this.lblcountry);
            this.pnladdr.Controls.Add(this.lblstate);
            this.pnladdr.Controls.Add(this.cmbpickuppoint);
            this.pnladdr.Controls.Add(this.CmbClientCode);
            this.pnladdr.Controls.Add(this.lblctydist);
            this.pnladdr.Controls.Add(this.txtclientname);
            this.pnladdr.Controls.Add(this.lbladdrline);
            this.pnladdr.Controls.Add(this.lbladdrtype);
            this.pnladdr.Location = new System.Drawing.Point(12, 12);
            this.pnladdr.Name = "pnladdr";
            this.pnladdr.Size = new System.Drawing.Size(315, 153);
            this.pnladdr.TabIndex = 0;
            // 
            // txtNoofChq
            // 
            this.txtNoofChq.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoofChq.Location = new System.Drawing.Point(93, 93);
            this.txtNoofChq.MaxLength = 20;
            this.txtNoofChq.Name = "txtNoofChq";
            this.txtNoofChq.Size = new System.Drawing.Size(206, 21);
            this.txtNoofChq.TabIndex = 3;
            this.txtNoofChq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoofChq_KeyPress);
            // 
            // cmbclientack
            // 
            this.cmbclientack.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbclientack.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbclientack.FormattingEnabled = true;
            this.cmbclientack.Location = new System.Drawing.Point(93, 122);
            this.cmbclientack.Name = "cmbclientack";
            this.cmbclientack.Size = new System.Drawing.Size(206, 21);
            this.cmbclientack.TabIndex = 4;
            // 
            // lblcountry
            // 
            this.lblcountry.AutoSize = true;
            this.lblcountry.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcountry.Location = new System.Drawing.Point(3, 125);
            this.lblcountry.Name = "lblcountry";
            this.lblcountry.Size = new System.Drawing.Size(63, 13);
            this.lblcountry.TabIndex = 29;
            this.lblcountry.Text = "Client Ack";
            // 
            // lblstate
            // 
            this.lblstate.AutoSize = true;
            this.lblstate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstate.Location = new System.Drawing.Point(3, 97);
            this.lblstate.Name = "lblstate";
            this.lblstate.Size = new System.Drawing.Size(86, 13);
            this.lblstate.TabIndex = 27;
            this.lblstate.Text = "No of Cheques";
            // 
            // cmbpickuppoint
            // 
            this.cmbpickuppoint.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbpickuppoint.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbpickuppoint.FormattingEnabled = true;
            this.cmbpickuppoint.Location = new System.Drawing.Point(93, 64);
            this.cmbpickuppoint.Name = "cmbpickuppoint";
            this.cmbpickuppoint.Size = new System.Drawing.Size(206, 21);
            this.cmbpickuppoint.TabIndex = 2;
            // 
            // CmbClientCode
            // 
            this.CmbClientCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbClientCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbClientCode.FormattingEnabled = true;
            this.CmbClientCode.Items.AddRange(new object[] {
            "Main",
            "Billing"});
            this.CmbClientCode.Location = new System.Drawing.Point(93, 8);
            this.CmbClientCode.Name = "CmbClientCode";
            this.CmbClientCode.Size = new System.Drawing.Size(206, 21);
            this.CmbClientCode.TabIndex = 0;
            this.CmbClientCode.SelectedIndexChanged += new System.EventHandler(this.CmbClientCode_SelectedIndexChanged);
            // 
            // lblctydist
            // 
            this.lblctydist.AutoSize = true;
            this.lblctydist.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblctydist.Location = new System.Drawing.Point(3, 67);
            this.lblctydist.Name = "lblctydist";
            this.lblctydist.Size = new System.Drawing.Size(76, 13);
            this.lblctydist.TabIndex = 23;
            this.lblctydist.Text = "Pickup Point";
            // 
            // txtclientname
            // 
            this.txtclientname.Enabled = false;
            this.txtclientname.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclientname.Location = new System.Drawing.Point(93, 36);
            this.txtclientname.MaxLength = 20;
            this.txtclientname.Name = "txtclientname";
            this.txtclientname.ReadOnly = true;
            this.txtclientname.Size = new System.Drawing.Size(206, 21);
            this.txtclientname.TabIndex = 1;
            // 
            // lbladdrline
            // 
            this.lbladdrline.AutoSize = true;
            this.lbladdrline.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdrline.Location = new System.Drawing.Point(3, 39);
            this.lbladdrline.Name = "lbladdrline";
            this.lbladdrline.Size = new System.Drawing.Size(74, 13);
            this.lbladdrline.TabIndex = 19;
            this.lbladdrline.Text = "Client Name";
            // 
            // lbladdrtype
            // 
            this.lbladdrtype.AutoSize = true;
            this.lbladdrtype.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdrtype.Location = new System.Drawing.Point(3, 11);
            this.lbladdrtype.Name = "lbladdrtype";
            this.lbladdrtype.Size = new System.Drawing.Size(70, 13);
            this.lbladdrtype.TabIndex = 7;
            this.lbladdrtype.Text = "Client Code";
            // 
            // txtdltfg
            // 
            this.txtdltfg.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdltfg.Location = new System.Drawing.Point(13, 195);
            this.txtdltfg.MaxLength = 20;
            this.txtdltfg.Name = "txtdltfg";
            this.txtdltfg.Size = new System.Drawing.Size(26, 21);
            this.txtdltfg.TabIndex = 37;
            this.txtdltfg.Visible = false;
            // 
            // txtsavefg
            // 
            this.txtsavefg.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsavefg.Location = new System.Drawing.Point(14, 197);
            this.txtsavefg.MaxLength = 20;
            this.txtsavefg.Name = "txtsavefg";
            this.txtsavefg.Size = new System.Drawing.Size(24, 21);
            this.txtsavefg.TabIndex = 35;
            this.txtsavefg.Visible = false;
            // 
            // txtentityaddrgid
            // 
            this.txtentityaddrgid.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtentityaddrgid.Location = new System.Drawing.Point(12, 197);
            this.txtentityaddrgid.MaxLength = 20;
            this.txtentityaddrgid.Name = "txtentityaddrgid";
            this.txtentityaddrgid.Size = new System.Drawing.Size(23, 21);
            this.txtentityaddrgid.TabIndex = 33;
            this.txtentityaddrgid.Visible = false;
            // 
            // btncancel
            // 
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(255, 172);
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
            this.btnadd1.Location = new System.Drawing.Point(177, 172);
            this.btnadd1.Name = "btnadd1";
            this.btnadd1.Size = new System.Drawing.Size(72, 24);
            this.btnadd1.TabIndex = 1;
            this.btnadd1.Text = "Save";
            this.btnadd1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadd1.UseVisualStyleBackColor = true;
            this.btnadd1.Click += new System.EventHandler(this.btnadd1_Click);
            // 
            // txtentygid
            // 
            this.txtentygid.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtentygid.Location = new System.Drawing.Point(12, 172);
            this.txtentygid.MaxLength = 20;
            this.txtentygid.Name = "txtentygid";
            this.txtentygid.Size = new System.Drawing.Size(26, 21);
            this.txtentygid.TabIndex = 38;
            this.txtentygid.Visible = false;
            // 
            // locationcode
            // 
            this.locationcode.Enabled = false;
            this.locationcode.Location = new System.Drawing.Point(44, 171);
            this.locationcode.Name = "locationcode";
            this.locationcode.Size = new System.Drawing.Size(100, 21);
            this.locationcode.TabIndex = 30;
            // 
            // frmPickupPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(336, 198);
            this.Controls.Add(this.locationcode);
            this.Controls.Add(this.txtentygid);
            this.Controls.Add(this.txtdltfg);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.txtsavefg);
            this.Controls.Add(this.btnadd1);
            this.Controls.Add(this.pnladdr);
            this.Controls.Add(this.txtentityaddrgid);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPickupPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pickup Entry";
            this.Load += new System.EventHandler(this.EntityAddress_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPickupPoint_KeyDown);
            this.pnladdr.ResumeLayout(false);
            this.pnladdr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbladdrtype;
        private System.Windows.Forms.Label lbladdrline;
        private System.Windows.Forms.Label lblctydist;
        private System.Windows.Forms.Label lblstate;
        private System.Windows.Forms.Label lblcountry;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnadd1;
        public System.Windows.Forms.Panel pnladdr;
        public System.Windows.Forms.TextBox txtclientname;
        public System.Windows.Forms.ComboBox cmbpickuppoint;
        public System.Windows.Forms.ComboBox cmbclientack;
        public System.Windows.Forms.ComboBox CmbClientCode;
        public System.Windows.Forms.TextBox txtentityaddrgid;
        public System.Windows.Forms.TextBox txtsavefg;
        public System.Windows.Forms.TextBox txtdltfg;
        public System.Windows.Forms.TextBox txtentygid;
        public System.Windows.Forms.TextBox txtNoofChq;
        private System.Windows.Forms.TextBox locationcode;
    }
}