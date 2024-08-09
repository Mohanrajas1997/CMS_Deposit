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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {

                string lsPwd = "";
                string lsNewPwd = "";
                int MaxSlno = 6;
                lsPwd = global_variable.con.EncryptString(txtOldPwd.Text);
                lsPwd = lsPwd.Replace("'", "''");

                lsNewPwd = global_variable.con.EncryptString(txtNewPwd.Text);
                lsNewPwd = lsNewPwd.Replace("'", "''");

                AdminMasterBusiness objSaveMaster = new AdminMasterBusiness();
                string[] result = objSaveMaster.SetPassword(global_variable.user_code, lsPwd, lsNewPwd, MaxSlno);
                if (result[1].ToString() == "1")
                {
                    MessageBox.Show(result[0].ToString(),global_variable.proj_name,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Chgpassowrd_Load(object sender, EventArgs e)
        {

            txtUserCode.Text = global_variable.user_code;
        }

        private void ChnagePwd_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == System.Windows.Forms.Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
