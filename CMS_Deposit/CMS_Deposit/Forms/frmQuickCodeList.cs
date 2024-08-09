using CMS_Deposit.Business;
using CMS_Deposit.Common;
using CMS_Deposit.Entities;
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
    public partial class frmQuickCodeList : Form
    {
        frmQuickCode frmqcdcode;
        DataTable dtqcdcode;

        public frmQuickCodeList()
        {
            InitializeComponent();

            dgvMaster.AutoGenerateColumns = true;
            dgvMasterList.AutoGenerateColumns = true;
            dgvMaster.EnableHeadersVisualStyles = false;
            dgvMaster.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dgvMaster.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMasterList.EnableHeadersVisualStyles = false;
            dgvMasterList.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dgvMasterList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        public void MasterLoad()
        {
            QuickCodeMasterBusiness objmst = new QuickCodeMasterBusiness();
            DataTable dtmst = new DataTable();
            dtmst = objmst.GetQCDMasterName();
            foreach (DataRow dr in dtmst.Rows)
            {
                dgvMaster.Rows.Add(dr.ItemArray);

            }

        }

        public void MasterGridload()
        {
            string mst_code = txtmstcode.Text.ToString();
            QuickCodeMasterBusiness obj = new QuickCodeMasterBusiness();
            DataTable dtlist = new DataTable();
            dtlist = obj.GetQCDMasterList(mst_code);
            dgvMasterList.Rows.Clear();
            dgvMasterList.Refresh();

            foreach (DataRow dr in dtlist.Rows)
            {
                dgvMasterList.Rows.Add(dr.ItemArray);

            }
        }

        private void frmQuickCodeList_Load(object sender, EventArgs e)
        {
            MasterLoad();
            btnadd.Enabled = false;
        }

        private void gvmasterlist_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMaster.Rows[e.RowIndex];
                txtmstcode.Text = row.Cells[0].Value.ToString();
                txtmstdesc.Text = row.Cells[1].Value.ToString();
                btnadd.Enabled = true;
            }
            MasterGridload();
        }

        private void gvqcdmstlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmQuickCodeList_Resize(object sender, EventArgs e)
        {
            pnlMain.Left = 0;
            pnlMain.Top = 0;
            pnlMain.Height = this.Height;
            pnlMain.Width = this.Width;

            dgvMaster.Height = pnlMain.Height - 48;
            dgvMasterList.Height = pnlMain.Height - 44 - dgvMasterList.Top;
            dgvMasterList.Width = pnlMain.Width - 24 - dgvMasterList.Left;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {

                QuickCodeMasterEntites add_qcdcode = new QuickCodeMasterEntites();
                add_qcdcode.master_code = txtmstdesc.Text.ToString();
                frmqcdcode = new frmQuickCode(add_qcdcode);
                frmqcdcode.ShowDialog();
                add_qcdcode = frmqcdcode.qcdcode;

                if (dtqcdcode != null)
                {

                    DataRow row = dtqcdcode.NewRow();

                    row["qcd_gid"] = add_qcdcode.qcd_gid;
                    row["shortcode"] = add_qcdcode.qcd_short_code;
                    row["shortdesc"] = add_qcdcode.qcd_name;
                    row["dependent"] = add_qcdcode.depend_flag;
                    row["depntmaster"] = add_qcdcode.depend_qcd_code;
                    row["depntcode"] = add_qcdcode.depend_master_code;

                    dtqcdcode.Rows.Add(row);
                    dgvMasterList.DataSource = dtqcdcode;
                    dgvMasterList.Refresh();
                }
                MasterGridload();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMasterList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (dgvMasterList.Columns[e.ColumnIndex].Name == "edit")
                {
                    QuickCodeMasterEntites qcd_code = new QuickCodeMasterEntites();

                    qcd_code.qcd_gid = Convert.ToInt32(dgvMasterList.CurrentRow.Cells["qcd_gid"].Value.ToString());
                    qcd_code.master_code = dgvMasterList.CurrentRow.Cells["master_code"].Value.ToString();
                    qcd_code.qcd_code = dgvMasterList.CurrentRow.Cells["qcd_code"].Value.ToString();
                    qcd_code.qcd_short_code = dgvMasterList.CurrentRow.Cells["shortcode"].Value.ToString();
                    qcd_code.qcd_name = dgvMasterList.CurrentRow.Cells["shortdesc"].Value.ToString();
                    qcd_code.depend_flag = dgvMasterList.CurrentRow.Cells["dependent"].Value.ToString();
                    qcd_code.depend_qcd_code = dgvMasterList.CurrentRow.Cells["depntmaster"].Value.ToString();
                    qcd_code.depend_master_code = dgvMasterList.CurrentRow.Cells["depntcode"].Value.ToString();
                    //qcd_code.save_flag = "N";
                    frmQuickCode frmqcdcode = new frmQuickCode(qcd_code);
                    frmqcdcode.ShowDialog();
                    qcd_code = frmqcdcode.qcdcode;
                    MasterGridload();
                }
                if (dgvMasterList.Columns[e.ColumnIndex].Name == "delete")
                {
                    DialogResult result = MessageBox.Show("Are you sure to delete ?", global_variable.proj_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        QuickCodeMasterEntites obj_qcd_code = new QuickCodeMasterEntites();
                        dgvMasterList.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
                        int id = Convert.ToInt32(dgvMasterList.CurrentRow.Cells["qcd_gid"].Value.ToString()); ;
                        if (id > 0)
                        {
                            obj_qcd_code.qcd_gid = id;
                            obj_qcd_code.action = global_variable.action_delete;
                            obj_qcd_code.action_by = global_variable.user_code;
                        }
                        QuickCodeMasterBusiness objBusiness = new QuickCodeMasterBusiness();
                        string[] result1 = objBusiness.SaveQCDMaster(obj_qcd_code);
                        obj_qcd_code.msg = result1[0].ToString();
                        MessageBox.Show(result1[0].ToString(), global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MasterGridload();

                    }
                    if (result == DialogResult.No)
                    {
                        dgvMasterList.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                        MasterGridload();

                    }
                }
            }
        }
    }
}
