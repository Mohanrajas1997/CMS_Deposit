using CMS_Deposit.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS_Deposit.Business
{
    public class AdminMasterBusiness
    {
        public DataTable GetUsermaster(string Usercode)
        {
            DataTable dt = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("In_usercode", Usercode);

                dt = global_variable.con.RunProc("pr_get_usercode", values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
        public DataTable GetPasswordDtls(int UserId, string newpwd, int slno, string selectflag)
        {
            DataTable dt = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("In_userid", UserId);
                values.Add("In_newpwd", newpwd);
                values.Add("In_slno", slno);
                values.Add("In_SelectFlag", selectflag);

                dt = global_variable.con.RunProc("pr_get_passwordhis", values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
        public string[] SavePasswordHistory(int UserId, string NewPwd, int PwdSlno, int PwdId, string Action)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("In_userid", UserId);
                values.Add("In_newpwd", NewPwd);
                values.Add("In_pwdslno", PwdSlno);
                values.Add("In_pwdId", PwdId);
                values.Add("In_action", Action);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");

                result = global_variable.con.RunDmlProc("pr_ins_password", values);

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public string[] UpdatePassword(int UserId, string NewPwd, int Slno, string Action)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("In_userid", UserId);
                values.Add("In_newpwd", NewPwd);
                values.Add("In_slno", Slno);
                values.Add("In_action", Action);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");

                result = global_variable.con.RunDmlProc("pr_upd_usermaster", values);

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;

        }

        public string[] SetPassword(string UserName, string OldPwd, string NewPwd, int Slno)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("in_user_code", UserName);
                values.Add("in_old_pwd", OldPwd);
                values.Add("in_new_pwd", NewPwd);
                values.Add("in_max_pwd_sno", Slno);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");

                result = global_variable.con.RunDmlProc("pr_set_password", values);

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}
