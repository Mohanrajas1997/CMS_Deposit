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
    public partial class frmQuickCode : Form
    {
        frmQuickCodeList frmqcdlist;
        public QuickCodeMasterEntites qcdcode = new QuickCodeMasterEntites();
        public string rbtyesno = "";
        public string cmbdepnmst = "";
        public string txtdepnqcdcode = "";
        public int id = 0;

        public frmQuickCode(QuickCodeMasterEntites _qcd_code)
        {

            InitializeComponent();

            qcdcode = _qcd_code;
            cmbmst.Text = _qcd_code.master_code;
            txtqcdcode.Text = _qcd_code.qcd_code;
            txtshtcode.Text = _qcd_code.qcd_short_code;
            txtshtdesc.Text = _qcd_code.qcd_name;
            if (_qcd_code.depend_flag == "Y")
            {
                rbtyes.Checked = true;
                rbtno.Checked = false;
            }

            if (_qcd_code.depend_flag == "N")
            {
                rbtyes.Checked = false;
                rbtno.Checked = true;
            }

            rbtno.Text = "No";
            rbtyes.Text = "Yes";
            cmbdepmst.Text = _qcd_code.depend_qcd_code;
            cmbdeptqcd.Text = _qcd_code.depend_master_code;

        }
        public void Clear()
        {
            cmbmst.ResetText();
            txtqcdcode.Clear();
            txtshtcode.Clear();
            txtshtdesc.Clear();
            rbtyes.Checked = false;
            rbtno.Checked = true;
            cmbdepmst.ResetText();
            cmbdeptqcd.ResetText();
        }
        public void Enable()
        {
            cmbmst.Enabled = true;
            txtqcdcode.Enabled = true;
            txtshtcode.Enabled = true;
            txtshtdesc.Enabled = true;
            rbtyes.Enabled = true;
            rbtno.Enabled = true;
            cmbdepmst.Enabled = true;
            cmbdeptqcd.Enabled = true;
        }
        public void Disable()
        {
            cmbmst.Enabled = false;
            txtqcdcode.Enabled = false;
            txtshtcode.Enabled = false;
            txtshtdesc.Enabled = false;
            rbtyes.Enabled = false;
            rbtno.Enabled = false;
            cmbdepmst.Enabled = false;
            cmbdeptqcd.Enabled = false;
        }
        public void LoadQCDMaster()
        {
            if (qcdcode.qcd_gid <= 0)
            {
                QuickCodeMasterBusiness objmst = new QuickCodeMasterBusiness();
                DataTable dtmst = new DataTable();
                dtmst = objmst.GetQCDMasterName();
                if (dtmst.Rows.Count > 0)
                {
                    DataRow rows = dtmst.NewRow();
                    cmbmst.DataSource = dtmst;
                    cmbmst.DisplayMember = "qcd_name";
                    cmbmst.ValueMember = "qcd_code";
                    cmbmst.Text = dtmst.Rows[0]["qcd_name"].ToString();

                }
                else
                {
                    cmbmst.Text = " ";
                }
            }
        }

        private void Quick_Code_Master_Load(object sender, EventArgs e)
        {
            // LoadQCDMaster();
            QuickCodeMasterBusiness objmst = new QuickCodeMasterBusiness();
            DataTable dtdpn = new DataTable();
            string qcdname = cmbmst.Text.ToString();
            dtdpn = objmst.GetDependentName(qcdname);
            if (dtdpn.Rows.Count > 0)
            {
                DataRow rows = dtdpn.NewRow();
                cmbdepmst.DataSource = dtdpn;
                cmbdepmst.DisplayMember = "depend_master_code";
                cmbdepmst.Text = dtdpn.Rows[0]["depend_master_code"].ToString();
            }
            else
            {
                cmbdepmst.Text = " ";
                cmbdeptqcd.Text = " ";
            }
        }

        private void btnsve_Click(object sender, EventArgs e)
        {
            #region VALIDATIONS
            if (cmbmst.Text == "")
            {
                MessageBox.Show("Select the Master", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbmst.Focus();
                return;
            }
            if (txtqcdcode.Text == "")
            {
                MessageBox.Show("Please Fill Quick Code", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtqcdcode.Focus();
                return;
            }
            if (txtshtcode.Text == "")
            {
                MessageBox.Show("Please Fill Short Code", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtshtcode.Focus();
                return;
            }
            if (txtshtdesc.Text == "")
            {
                MessageBox.Show("Please Fill Short Desc", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtshtdesc.Focus();
                return;
            }
            #endregion
            if (rbtyes.Checked)
            {
                rbtyesno = "Y";
                cmbdepmst.Enabled = false;
                if (cmbdepmst.SelectedItem != null)
                {
                    cmbdepnmst = cmbdepmst.SelectedItem.ToString();
                }
                else
                {
                    cmbdepnmst = "";
                }

                if (cmbdeptqcd.Text == "")
                {
                    MessageBox.Show("Please Fill Dependent QCD Code", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbdeptqcd.Focus();
                    return;
                }
                else
                {
                    txtdepnqcdcode = cmbdeptqcd.Text.ToString();
                }
            }
            else if (rbtno.Checked)
            {
                rbtyesno = "N";
                cmbdepnmst = "";
                txtdepnqcdcode = "";
                cmbdepmst.Enabled = false;
                cmbdeptqcd.Enabled = false;
            }
            DataTable dtqcdmst = new DataTable();
            QuickCodeMasterEntites objqcdmaster = new QuickCodeMasterEntites();

            //if (txtqcdgid.Text.ToString() == "") id = 0; else id = Int32.Parse(txtqcdgid.Text.ToString());
            id = qcdcode.qcd_gid;
            if (id == 0)
            {
                objqcdmaster.qcd_gid = id;
                //objqcdmaster.qcd_entity_gid = global_variable.entity_gid;
                objqcdmaster.qcd_code = txtqcdcode.Text.ToString().Trim();
                objqcdmaster.qcd_short_code = txtshtcode.Text.ToString().Trim();
                objqcdmaster.qcd_name = txtshtdesc.Text.ToString().Trim();
                objqcdmaster.master_code = cmbmst.Text.ToString();//cmbmst.SelectedValue.ToString();
                objqcdmaster.depend_flag = rbtyesno;
                objqcdmaster.depend_master_code = cmbdepmst.Text.ToString();//cmbdepnmst;
                objqcdmaster.depend_qcd_code = txtdepnqcdcode;
                objqcdmaster.action = global_variable.action_insert;
                objqcdmaster.action_by = global_variable.user_name;
            }
            else
            {
                objqcdmaster.qcd_gid = id;
                //objqcdmaster.qcd_entity_gid = global_variable.entity_gid;
                objqcdmaster.qcd_code = txtqcdcode.Text.ToString().Trim();
                objqcdmaster.qcd_short_code = txtshtcode.Text.ToString().Trim();
                objqcdmaster.qcd_name = txtshtdesc.Text.ToString().Trim();
                objqcdmaster.master_code = cmbmst.Text.ToString();//cmbmst.SelectedValue.ToString();
                objqcdmaster.depend_flag = rbtyesno;
                objqcdmaster.depend_master_code = cmbdepmst.Text.ToString();
                objqcdmaster.depend_qcd_code = txtdepnqcdcode;
                objqcdmaster.action = global_variable.action_update;
                objqcdmaster.action_by = global_variable.user_name;
            }

            QuickCodeMasterBusiness objBusiness = new QuickCodeMasterBusiness();
            string[] result = objBusiness.SaveQCDMaster(objqcdmaster);
            objqcdmaster.msg = result[0].ToString();
            MessageBox.Show(result[0].ToString(), global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void rbtyes_CheckedChanged(object sender, EventArgs e)
        {
            cmbdepmst.Enabled = false;
            cmbdeptqcd.Enabled = true;
        }

        private void rbtno_CheckedChanged(object sender, EventArgs e)
        {
            cmbdepmst.Enabled = false;
            cmbdeptqcd.Enabled = false;
        }

        private void cmbmst_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbdepmst_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbdepmst.SelectedValue != "")
            {
                QuickCodeMasterBusiness objmst = new QuickCodeMasterBusiness();
                DataTable dtdpn = new DataTable();
                string qcdcode = cmbdepmst.Text.ToString();
                dtdpn = objmst.GetDependentQcd(qcdcode);
                if (dtdpn.Rows.Count > 0)
                {
                    DataRow rows = dtdpn.NewRow();
                    cmbdeptqcd.DataSource = dtdpn;
                    cmbdeptqcd.DisplayMember = "qcd_name";
                    cmbdeptqcd.Text = dtdpn.Rows[0]["qcd_name"].ToString();
                    rbtyes.Checked = true;
                }
                else
                {
                    cmbdeptqcd.Text = " ";
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
