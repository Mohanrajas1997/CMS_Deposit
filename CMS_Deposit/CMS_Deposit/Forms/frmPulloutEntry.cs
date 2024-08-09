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
    public partial class frmPulloutEntry : Form
    {
        private int chq_gid = 0;
        private int pullout_gid = 0;

        public frmPulloutEntry(int _chq_gid)
        {
            InitializeComponent();

            txtChqId.Text = chq_gid.ToString();
            chq_gid = _chq_gid;
        }


        private void btnadd1_Click(object sender, EventArgs e)
        {
            #region VALIDATION
            if ((DateTime.Now - dtpPullout.Value).TotalDays < 0)
            {
                MessageBox.Show("Future pullout date !", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpPullout.Focus();
                return;
            }

            if (cmbReason.Text.Trim() == "")
            {
                MessageBox.Show("Reason cannot be empty !", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbReason.Focus();
                return;
            }

            #endregion

            CMSEntryBusiness ObjCmsBusiness = new CMSEntryBusiness();
            string[] result = ObjCmsBusiness.SavePullout(chq_gid,dtpPullout.Value,cmbReason.Text.Trim());

            if (result[1].ToString() == "1")
            {
                MessageBox.Show(result[0].ToString(), global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(result[0].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }    

        private void ChqEntry_Load(object sender, EventArgs e)
        {
            dtpPullout.Value = DateTime.Now;
            load_data();
        }

        private void txtChqNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtChqAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void load_data()
        {
            DataTable dt = new DataTable();
            DataTable dtChq = new DataTable();
            
            QuickCodeMasterBusiness objBs = new QuickCodeMasterBusiness();
            dt = objBs.GetQcdList("QCD_PULLOUT");

            cmbReason.DataSource = dt;
            cmbReason.DisplayMember = "qcd_name";
            cmbReason.ValueMember = "qcd_code";

            CMSEntryBusiness objCms = new CMSEntryBusiness();
            dtChq = objCms.GetPullout(chq_gid);

            if (dtChq.Rows.Count > 0)
            {
                dtpChqDate.Value = Convert.ToDateTime(dtChq.Rows[0]["chq_date"]);
                txtChqId.Text = dtChq.Rows[0]["chq_gid"].ToString();
                txtPulloutId.Text = dtChq.Rows[0]["pullout_gid"].ToString();
                txtChqNo.Text = dtChq.Rows[0]["chq_no"].ToString();
                cmbReason.Text = dtChq.Rows[0]["pullout_reason"].ToString();
                txtChqAmt.Text = Convert.ToDouble( dtChq.Rows[0]["chq_amount"].ToString()).ToString("0.00");

                pullout_gid = Convert.ToInt32(txtPulloutId.Text);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete ?", global_variable.proj_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                CMSEntryBusiness ObjCmsBusiness = new CMSEntryBusiness();
                string[] result = ObjCmsBusiness.DelPullout(pullout_gid, chq_gid);

                if (result[1].ToString() == "1")
                {
                    MessageBox.Show(result[0].ToString(), global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result[0].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
