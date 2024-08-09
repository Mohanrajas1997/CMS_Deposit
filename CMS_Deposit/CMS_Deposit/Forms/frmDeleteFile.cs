using CMS_Deposit.Business;
using CMS_Deposit.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS_Deposit.Forms
{
    public partial class frmDeleteFile : Form
    {
        string FileType = "";
        public frmDeleteFile()
        {
            InitializeComponent();
        }

        private void frmDeleteFile_Load(object sender, EventArgs e)
        {
            cmbFileType.Items.Add("Clearing Dump");

            dtpDate.Value = DateTime.Now;
            dtpDate.Focus();
        }

        private void cmbFileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFileType.Text != "")
            {
                GetFileName();
                cmbFileName.Focus();
            }
        }

        private void GetFileName()
        {
            string Importdate = dtpDate.Value.ToString("yyyy-MM-dd");

            DataTable dtFilename = new DataTable();
            AdminBusiness ObjBusiness = new AdminBusiness();

            if (cmbFileType.Text.ToUpper() == "CLEARING DUMP")
            {
                FileType = "C";
            }

            dtFilename = ObjBusiness.GetFileName(Importdate, FileType);

            if (dtFilename.Rows.Count > 0)
            {
                DataRow rows = dtFilename.NewRow();
                rows["file_name"] = "--Select--";
                dtFilename.Rows.InsertAt(rows, 0);
                cmbFileName.DataSource = dtFilename;
                cmbFileName.DisplayMember = "file_name";
                cmbFileName.ValueMember = "file_gid";
            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You sure Want to Delete", global_variable.proj_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                AdminBusiness ObjBusiness = new AdminBusiness();
                int FileGid = Convert.ToInt32(cmbFileName.SelectedValue.ToString());
                string[] results = ObjBusiness.SetDeleteFile(FileType, FileGid, global_variable.user_name);
                if (results[1].ToString() == "1")
                {
                    MessageBox.Show(results[0].ToString(), global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show(results[0].ToString(), global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
        }

    }
}
