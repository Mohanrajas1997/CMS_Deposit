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
    public partial class frmEnrichmentEntry : Form
    {
        public CMSEntities.ChqEntry_Model ObjChqEntry = new CMSEntities.ChqEntry_Model();

        public frmEnrichmentEntry(CMSEntities.ChqEntry_Model _ChqEntry)
        {
            InitializeComponent();
            ObjChqEntry = _ChqEntry;

            txtRefNo.Text = ObjChqEntry.ref_no;
            txtRefAmt.Text = ObjChqEntry.ref_amount.ToString();
            txtchqgid.Text = Convert.ToInt32(ObjChqEntry.chq_gid).ToString();
            txtdepositGid.Text = ObjChqEntry.deposit_gid.ToString();
            txtenrichgid.Text = ObjChqEntry.enrichment_gid.ToString();
        }


        private void btnadd1_Click(object sender, EventArgs e)
        {
            #region VALIDATION
            if (txtRefNo.Text == "")
            {
                MessageBox.Show("Please enter the ref no", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRefNo.Focus();
                return;
            }

            if (txtRefAmt.Text == "")
            {
                MessageBox.Show("Please enter the ref amt", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRefAmt.Focus();
                return;
            }
            #endregion

            //Chq Entry grid Value Binding area..
            string[] result = { };
            if (txtenrichgid .Text !="0")
            {
                ObjChqEntry.deposit_gid = Convert.ToInt32(txtdepositGid.Text.ToString());
                ObjChqEntry.chq_gid = Convert.ToInt32(txtchqgid.Text.ToString());
                ObjChqEntry.enrichment_gid = Convert.ToInt32(txtenrichgid.Text.ToString());
                ObjChqEntry.chq_no = "";
                ObjChqEntry.chq_date = "";
                ObjChqEntry.chq_amount = 0;
                ObjChqEntry.ref_no = txtRefNo.Text.ToString();
                ObjChqEntry.ref_amount = Convert.ToInt32(txtRefAmt.Text.ToString());
                ObjChqEntry.action = global_variable.action_update;
                ObjChqEntry.action_by = global_variable.user_name;

                CMSEntryBusiness ObjCmsBusiness = new CMSEntryBusiness();
                 result = ObjCmsBusiness.SaveEnrichMent(ObjChqEntry);
                ObjChqEntry.msg = result[0].ToString();
                ObjChqEntry.out_gid = Convert.ToInt32(result[2]);
            }
            else
            {
                ObjChqEntry.deposit_gid = Convert.ToInt32(txtdepositGid.Text.ToString());
                ObjChqEntry.chq_gid = Convert.ToInt32(txtchqgid.Text.ToString());
                ObjChqEntry.enrichment_gid = Convert.ToInt32(txtenrichgid.Text.ToString());
                ObjChqEntry.chq_no = "";
                ObjChqEntry.chq_date = "";
                ObjChqEntry.chq_amount = 0;
                ObjChqEntry.ref_no = txtRefNo.Text.ToString();
                ObjChqEntry.ref_amount = Convert.ToInt32(txtRefAmt.Text.ToString());
                ObjChqEntry.action = global_variable.action_insert;
                ObjChqEntry.action_by = global_variable.user_name;

                CMSEntryBusiness ObjCmsBusiness = new CMSEntryBusiness();
                result = ObjCmsBusiness.SaveEnrichMent(ObjChqEntry);
                ObjChqEntry.msg = result[0].ToString();
                ObjChqEntry.out_gid = Convert.ToInt32(result[2]);
            }
           

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

        private void txtRefAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

    }
}
