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
    public partial class frmChqEntryView : Form
    {
        public CMSEntities.ChqEntry_Model ObjChqEntry = new CMSEntities.ChqEntry_Model();

        public frmChqEntryView(CMSEntities.ChqEntry_Model _ChqEntry)
        {
            InitializeComponent();
            ObjChqEntry = _ChqEntry;

            txtChqNo.Text = ObjChqEntry.chq_no;
            dtpChqDate.Text = ObjChqEntry.chq_date;
            txtChqAmt.Text = ObjChqEntry.chq_amount.ToString();
            txtAccHolder.Text = ObjChqEntry.acc_holder.ToString();
            txtchqgid.Text = Convert.ToInt32(ObjChqEntry.chq_gid).ToString();
            txtdepositGid.Text = ObjChqEntry.deposit_gid.ToString();
        }


        private void btnadd1_Click(object sender, EventArgs e)
        {
            #region VALIDATION
            txtChqNo.Text = txtChqNo.Text.Trim();
            txtAccHolder.Text = txtAccHolder.Text.Trim();

            if (txtChqNo.Text == "")
            {
                MessageBox.Show("Please enter the cheque no", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChqNo.Focus();
                return;
            }
            if (dtpChqDate.Text == "")
            {
                MessageBox.Show("Please enter the chq date", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpChqDate.Focus();
                return;
            }
            if (txtChqAmt.Text == "")
            {
                MessageBox.Show("Please enter the chq amt", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChqAmt.Focus();
                return;
            }

            if (txtAccHolder.Text == "")
            {
                MessageBox.Show("A/c holder name cannot be empty !", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAccHolder.Focus();
                return;
            }
            #endregion

            //Chq Entry grid Value Binding area..
            ObjChqEntry.deposit_gid = Convert.ToInt32(txtdepositGid.Text.ToString());
            ObjChqEntry.chq_gid = Convert.ToInt32(txtchqgid.Text.ToString());
            ObjChqEntry.chq_no = string.Format("{0:000000}",Convert.ToInt32 (txtChqNo.Text.ToString()));
            ObjChqEntry.chq_date = dtpChqDate.Value.ToString("yyyy-MM-dd");
            ObjChqEntry.chq_amount = Convert.ToInt32(txtChqAmt.Text.ToString());
            ObjChqEntry.acc_holder = txtAccHolder.Text;
            ObjChqEntry.ref_no = "";
            ObjChqEntry.ref_amount = 0;
            ObjChqEntry.action = global_variable.action_update;
            ObjChqEntry.action_by = global_variable.user_name;

            CMSEntryBusiness ObjCmsBusiness = new CMSEntryBusiness();
            string[] result = ObjCmsBusiness.SaveCMSEntry(ObjChqEntry);
            ObjChqEntry.msg = result[0].ToString();
            ObjChqEntry.out_gid = Convert.ToInt32(result[2]);
            if (result[1].ToString() == "0")
            {
                MessageBox.Show(result[0].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(result[0].ToString(), global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }    

        private void ChqEntry_Load(object sender, EventArgs e)
        {

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

        private void txtchqgid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdepositGid_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnladdr_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
