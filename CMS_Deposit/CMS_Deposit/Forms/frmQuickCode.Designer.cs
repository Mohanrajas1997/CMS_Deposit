namespace CMS_Deposit.Forms
{
    partial class frmQuickCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuickCode));
            this.label5 = new System.Windows.Forms.Label();
            this.cmbmst = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtqcdcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtshtcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtshtdesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblqcdcode = new System.Windows.Forms.Label();
            this.lbldepyesno = new System.Windows.Forms.Label();
            this.rbtyes = new System.Windows.Forms.RadioButton();
            this.rbtno = new System.Windows.Forms.RadioButton();
            this.pnlmst = new System.Windows.Forms.Panel();
            this.cmbdeptqcd = new System.Windows.Forms.ComboBox();
            this.cmbdepmst = new System.Windows.Forms.ComboBox();
            this.btnsve = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.pnlmst.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Master";
            // 
            // cmbmst
            // 
            this.cmbmst.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbmst.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbmst.Enabled = false;
            this.cmbmst.FormattingEnabled = true;
            this.cmbmst.Items.AddRange(new object[] {
            "Tamilnadu"});
            this.cmbmst.Location = new System.Drawing.Point(137, 5);
            this.cmbmst.Name = "cmbmst";
            this.cmbmst.Size = new System.Drawing.Size(178, 21);
            this.cmbmst.TabIndex = 0;
            this.cmbmst.SelectedValueChanged += new System.EventHandler(this.cmbmst_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Quick Code";
            // 
            // txtqcdcode
            // 
            this.txtqcdcode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqcdcode.Location = new System.Drawing.Point(137, 32);
            this.txtqcdcode.MaxLength = 25;
            this.txtqcdcode.Name = "txtqcdcode";
            this.txtqcdcode.Size = new System.Drawing.Size(178, 21);
            this.txtqcdcode.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Short Code";
            // 
            // txtshtcode
            // 
            this.txtshtcode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtshtcode.Location = new System.Drawing.Point(137, 59);
            this.txtshtcode.MaxLength = 25;
            this.txtshtcode.Name = "txtshtcode";
            this.txtshtcode.Size = new System.Drawing.Size(178, 21);
            this.txtshtcode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Short Desc";
            // 
            // txtshtdesc
            // 
            this.txtshtdesc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtshtdesc.Location = new System.Drawing.Point(137, 86);
            this.txtshtdesc.MaxLength = 50;
            this.txtshtdesc.Name = "txtshtdesc";
            this.txtshtdesc.Size = new System.Drawing.Size(178, 21);
            this.txtshtdesc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Dependent Master";
            // 
            // lblqcdcode
            // 
            this.lblqcdcode.AutoSize = true;
            this.lblqcdcode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqcdcode.Location = new System.Drawing.Point(5, 166);
            this.lblqcdcode.Name = "lblqcdcode";
            this.lblqcdcode.Size = new System.Drawing.Size(95, 13);
            this.lblqcdcode.TabIndex = 81;
            this.lblqcdcode.Text = "Dependent QCD";
            // 
            // lbldepyesno
            // 
            this.lbldepyesno.AutoSize = true;
            this.lbldepyesno.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepyesno.Location = new System.Drawing.Point(4, 115);
            this.lbldepyesno.Name = "lbldepyesno";
            this.lbldepyesno.Size = new System.Drawing.Size(69, 13);
            this.lbldepyesno.TabIndex = 83;
            this.lbldepyesno.Text = "Dependent";
            // 
            // rbtyes
            // 
            this.rbtyes.AutoSize = true;
            this.rbtyes.Enabled = false;
            this.rbtyes.Location = new System.Drawing.Point(137, 113);
            this.rbtyes.Name = "rbtyes";
            this.rbtyes.Size = new System.Drawing.Size(45, 17);
            this.rbtyes.TabIndex = 4;
            this.rbtyes.Text = "Yes";
            this.rbtyes.UseVisualStyleBackColor = true;
            this.rbtyes.CheckedChanged += new System.EventHandler(this.rbtyes_CheckedChanged);
            // 
            // rbtno
            // 
            this.rbtno.AutoSize = true;
            this.rbtno.Checked = true;
            this.rbtno.Enabled = false;
            this.rbtno.Location = new System.Drawing.Point(199, 113);
            this.rbtno.Name = "rbtno";
            this.rbtno.Size = new System.Drawing.Size(39, 17);
            this.rbtno.TabIndex = 5;
            this.rbtno.TabStop = true;
            this.rbtno.Text = "No";
            this.rbtno.UseVisualStyleBackColor = true;
            this.rbtno.CheckedChanged += new System.EventHandler(this.rbtno_CheckedChanged);
            // 
            // pnlmst
            // 
            this.pnlmst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlmst.Controls.Add(this.cmbdeptqcd);
            this.pnlmst.Controls.Add(this.cmbdepmst);
            this.pnlmst.Controls.Add(this.rbtno);
            this.pnlmst.Controls.Add(this.rbtyes);
            this.pnlmst.Controls.Add(this.lbldepyesno);
            this.pnlmst.Controls.Add(this.lblqcdcode);
            this.pnlmst.Controls.Add(this.label1);
            this.pnlmst.Controls.Add(this.txtshtdesc);
            this.pnlmst.Controls.Add(this.label2);
            this.pnlmst.Controls.Add(this.txtshtcode);
            this.pnlmst.Controls.Add(this.label3);
            this.pnlmst.Controls.Add(this.txtqcdcode);
            this.pnlmst.Controls.Add(this.label4);
            this.pnlmst.Controls.Add(this.cmbmst);
            this.pnlmst.Controls.Add(this.label5);
            this.pnlmst.Location = new System.Drawing.Point(7, 6);
            this.pnlmst.Name = "pnlmst";
            this.pnlmst.Size = new System.Drawing.Size(325, 192);
            this.pnlmst.TabIndex = 0;
            // 
            // cmbdeptqcd
            // 
            this.cmbdeptqcd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbdeptqcd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbdeptqcd.Enabled = false;
            this.cmbdeptqcd.FormattingEnabled = true;
            this.cmbdeptqcd.Items.AddRange(new object[] {
            "India"});
            this.cmbdeptqcd.Location = new System.Drawing.Point(137, 163);
            this.cmbdeptqcd.Name = "cmbdeptqcd";
            this.cmbdeptqcd.Size = new System.Drawing.Size(178, 21);
            this.cmbdeptqcd.TabIndex = 7;
            // 
            // cmbdepmst
            // 
            this.cmbdepmst.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbdepmst.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbdepmst.Enabled = false;
            this.cmbdepmst.FormattingEnabled = true;
            this.cmbdepmst.Items.AddRange(new object[] {
            "India"});
            this.cmbdepmst.Location = new System.Drawing.Point(137, 136);
            this.cmbdepmst.Name = "cmbdepmst";
            this.cmbdepmst.Size = new System.Drawing.Size(178, 21);
            this.cmbdepmst.TabIndex = 6;
            this.cmbdepmst.SelectedValueChanged += new System.EventHandler(this.cmbdepmst_SelectedValueChanged);
            // 
            // btnsve
            // 
            this.btnsve.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsve.Image = ((System.Drawing.Image)(resources.GetObject("btnsve.Image")));
            this.btnsve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsve.Location = new System.Drawing.Point(182, 204);
            this.btnsve.Name = "btnsve";
            this.btnsve.Size = new System.Drawing.Size(72, 24);
            this.btnsve.TabIndex = 1;
            this.btnsve.Text = "&Save";
            this.btnsve.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsve.UseVisualStyleBackColor = true;
            this.btnsve.Click += new System.EventHandler(this.btnsve_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(260, 204);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(72, 24);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Cancel";
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // frmQuickCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(339, 233);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsve);
            this.Controls.Add(this.pnlmst);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuickCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QCD Master";
            this.Load += new System.EventHandler(this.Quick_Code_Master_Load);
            this.pnlmst.ResumeLayout(false);
            this.pnlmst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbmst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtqcdcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtshtcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtshtdesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblqcdcode;
        private System.Windows.Forms.Label lbldepyesno;
        private System.Windows.Forms.RadioButton rbtyes;
        private System.Windows.Forms.RadioButton rbtno;
        private System.Windows.Forms.Panel pnlmst;
        private System.Windows.Forms.ComboBox cmbdepmst;
        private System.Windows.Forms.Button btnsve;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.ComboBox cmbdeptqcd;
    }
}