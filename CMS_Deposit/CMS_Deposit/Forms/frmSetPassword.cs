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
    public partial class frmSetPassword : Form
    {
        public frmSetPassword()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string NewPwd = "";
                string UserCode = "";
                string UserStatus = "";
                string Selectflag = "";
                int lnUserId = 0;
                int lnPwdSno = 0;
                int lnPasswordId = 0;
                string action = "";
                NewPwd =  global_variable.con.EncryptString(txtNewPwd.Text);
                NewPwd = NewPwd.Replace("'", "''");
                UserCode = txtUserCode.Text.Trim();
                AdminMasterBusiness ObjMasterBusiness = new AdminMasterBusiness();
                DataTable dtuser = new DataTable();
                dtuser = ObjMasterBusiness.GetUsermaster(UserCode);
                lnUserId = Convert.ToInt16(dtuser.Rows[0]["user_gid"]);
                lnPwdSno = Convert.ToInt16(dtuser.Rows[0]["pwd_sno"]);
                UserStatus = dtuser.Rows[0]["user_status"].ToString();

                if (txtNewPwd.Text == txtRetypePwd.Text)
                {
                    if (UserStatus == "N")
                    {
                        MessageBox.Show("Password not changed ! Id was deactivated !", "Validation", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        return;
                    }
                    else if (UserStatus == "D")
                    {
                        MessageBox.Show("Password not changed ! Id was blocked !", "Validation", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        return;
                    }


                    DataTable dtPwdhis = new DataTable();
                    Selectflag = "P";
                    dtPwdhis = ObjMasterBusiness.GetPasswordDtls(lnUserId, NewPwd, lnPwdSno, Selectflag);

                    global_variable.Password = NewPwd;
                    if (dtPwdhis.Rows.Count > 0)
                    {
                        lnPasswordId = Convert.ToInt16(dtPwdhis.Rows[0]["password_gid"]);
                        MessageBox.Show("Your password not changed ! New password matched with previous !", "Validation", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        return;
                    }

                    if (lnPwdSno == 6)
                    {
                        lnPwdSno = 1;
                    }
                    else
                    {
                        lnPwdSno += 1;
                    }

                    DataTable dtPwdhist = new DataTable();
                    Selectflag = "H";
                    dtPwdhist = ObjMasterBusiness.GetPasswordDtls(lnUserId, NewPwd, lnPwdSno, Selectflag);
                    if (dtPwdhist.Rows.Count > 0)
                    {
                        action = "Update";
                        AdminMasterBusiness objSaveMaster = new AdminMasterBusiness();
                        string[] result = objSaveMaster.SavePasswordHistory(lnUserId, NewPwd, lnPwdSno, lnPasswordId, action);

                    }
                    else
                    {
                        action = "Insert";
                        AdminMasterBusiness objSaveMaster = new AdminMasterBusiness();
                        string[] result = objSaveMaster.SavePasswordHistory(lnUserId, NewPwd, lnPwdSno, lnPasswordId, action);

                    }

                    action = "Update";
                    AdminMasterBusiness ObjUptMaster = new AdminMasterBusiness();
                    string[] results = ObjUptMaster.UpdatePassword(lnUserId, NewPwd, lnPwdSno, action);

                    if (results[1].ToString() == "1")
                    {
                        MessageBox.Show("Password changed successfully !",global_variable.proj_name,MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(results[0].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Password mismatch !",global_variable.proj_name,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtRetypePwd.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetPassword_Load(object sender, EventArgs e)
        {
            txtUserCode.Text = global_variable.user_code;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
