using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using CMS_Deposit.Common;
using CMS_Deposit.Entities;

namespace CMS_Deposit.Business
{
    public class AdminBusiness
    {
        public static string Usercode;
        public static int Usergroupid;
        public static int UserId;
        public static string Password;

        public DataTable GetUsermaster(string Usercode)
        {
            DataTable dt = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("In_usercode", Usercode);

                dt = global_variable.con.RunProc("pr_soft_get_usercode", values);
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

                dt = global_variable.con.RunProc("pr_soft_get_passwordhis", values);

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

                result = global_variable.con.RunDmlProc("pr_soft_ins_password", values);

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

                result = global_variable.con.RunDmlProc("pr_soft_upd_usermaster", values);

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public DataTable GetUserDetails(string UserEmpCode)
        {
            DataTable dt = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("In_emp_code", UserEmpCode);

                dt = global_variable.con.RunProc("sp_soft_get_user", values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public DataTable GetUserGroup()
        {
            DataTable dt = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();

                dt = global_variable.con.RunProc("pr_soft_get_usergroup", values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
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

                result = global_variable.con.RunDmlProc("pr_soft_set_password", values);

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public string[] SaveUserEntity(int user_gid, int entity_gid, string action, string action_by)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("in_user_gid", user_gid);
                values.Add("in_entity_gid", entity_gid);
                values.Add("in_action", action);
                values.Add("in_action_by", action_by);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");

                result = global_variable.con.RunDmlProc("pr_soft_ins_userentity", values);

                return result;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }
        public DataTable UserEntityEdit(int user_gid, int entity_gid, string action, string action_by)
        {
            DataTable dtedit = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("in_user_gid", user_gid);
                values.Add("in_entity_gid", entity_gid);
                values.Add("in_action", action);
                values.Add("in_action_by", action_by);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");

                dtedit = global_variable.con.Runeditdt("pr_soft_ins_userentity", values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dtedit;
        }
        public string[] SaveUserMaster(AdminEntities.UserMaster ObjUsermaster)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("in_user_gid", ObjUsermaster.user_gid);
                values.Add("in_user_code", ObjUsermaster.user_code);
                values.Add("in_user_name", ObjUsermaster.user_name);
                values.Add("in_addr1", ObjUsermaster.addr1);
                values.Add("in_addr2", ObjUsermaster.addr2);
                values.Add("in_addr3", ObjUsermaster.addr3);
                values.Add("in_addr4", ObjUsermaster.addr4);
                values.Add("in_city", ObjUsermaster.city);
                values.Add("in_pincode", ObjUsermaster.pincode);
                values.Add("in_mobile_no", ObjUsermaster.mobile_no);
                values.Add("in_mail_id", ObjUsermaster.mail_id);
                values.Add("in_sex", ObjUsermaster.sex);
                values.Add("in_dob", ObjUsermaster.dob);
                values.Add("in_doj", ObjUsermaster.doj);
                values.Add("in_desig_name", ObjUsermaster.desig_name);
                values.Add("in_dept_name", ObjUsermaster.dept_name);
                values.Add("in_user_status", ObjUsermaster.user_status);
                values.Add("in_pwd_flag", ObjUsermaster.pwd_flag);
                values.Add("in_usergroup_gid", ObjUsermaster.usergroup_gid);
                values.Add("in_action", ObjUsermaster.action);
                values.Add("out_gid", "out");
                values.Add("out_msg", "out");
                values.Add("out_result", "out");

                result = global_variable.con.RunGUIDProc("pr_soft_ins_user", values);

                return result;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        public DataTable GetUserById(int user_gid)
        {
            DataTable dt = new DataTable();

            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();

                values.Add("in_user_gid", user_gid);

                dt = global_variable.con.RunProc("pr_soft_get_userbyid", values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        public string[] SaveUserGroup(int usergroupid, string usergroupname, string action)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("In_groupid", usergroupid);
                values.Add("In_groupname", usergroupname);
                values.Add("In_action", action);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");

                result = global_variable.con.RunDmlProc("pr_soft_ins_usergroup", values);

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return result;
        }

        public DataTable UserGroupEdit(AdminEntities.UserMaster UserGrpEdit)
        {
            DataTable dtedit = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("In_groupid", UserGrpEdit.user_gid);
                values.Add("In_groupname", UserGrpEdit.user_name);
                values.Add("in_action", UserGrpEdit.action);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");

                dtedit = global_variable.con.Runeditdt("pr_soft_ins_usergroup", values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dtedit;
        }

        public DataTable GetUserMenuAccess(string MenuName, int usergid, int usergroupid, string usercode, string pwd)
        {
            DataTable dt = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("in_menu_name", MenuName);
                values.Add("in_user_gid", usergid);
                values.Add("in_usergroup_gid", usergroupid);
                values.Add("in_user_code", usercode);
                values.Add("in_pwd", pwd);

                dt = global_variable.con.RunProc("pr_get_menuaccess", values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public string[] DeleteUserGroupRights(int UserGroupId)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("in_UserGroupid", UserGroupId);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");

                result = global_variable.con.RunDmlProc("pr_del_userrights", values);

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public string[] SaveUserGroupRights(string MenuName, int rightsflag, int usergrouprights)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("In_menu_name", MenuName);
                values.Add("In_rights_flag", rightsflag);
                values.Add("In_usergroup_gid", usergrouprights);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");

                result = global_variable.con.RunDmlProc("pr_ins_usergrouprights", values);

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;

        }

        public DataTable GetUserGroupRights(string MenuName, int userGroupid)
        {
            DataTable dt = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("In_usergroupid", userGroupid);
                values.Add("In_menuname", MenuName);

                dt = global_variable.con.RunProc("pr_get_usergrouprights", values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
        public DataTable GetFileName(string Importdate,string FileType)
        {
            DataTable dt = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("in_import_date", Importdate);
                values.Add("in_file_type", FileType);

                dt = global_variable.con.RunProc("pr_cms_get_tfile", values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public string[] SetDeleteFile(string FileType, int FileGid, string ActionBy)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("in_file_type", FileType);
                values.Add("in_file_gid", FileGid);
                values.Add("in_action_by", ActionBy);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");

                result = global_variable.con.RunDmlProc("pr_cms_set_deletefile", values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public DataTable GetClearingDtls(string ChqFromdt, string ChqTodt)
        {
            DataTable dt = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("in_chq_from", ChqFromdt);
                values.Add("in_chq_to", ChqTodt);

                dt = global_variable.con.RunProc("pr_cms_get_tclearing", values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public string[] SetPostingCheques(int Clrg_Gid,string Client_Code,string Chq_Date,string Chq_No,double Chq_Amount)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("in_clrg_gid", Clrg_Gid);
                values.Add("in_client_code", Client_Code);
                values.Add("in_chq_date", Chq_Date);
                values.Add("in_chq_no", Chq_No);
                values.Add("in_chq_amount", Chq_Amount);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");

                result = global_variable.con.RunDmlProc("pr_cms_posting_tcheque", values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public string[] SetUnPostingCheques(string ChqFromdt,string ChqTodt)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("in_chq_from", ChqFromdt);
                values.Add("in_chq_to", ChqTodt);                
                values.Add("out_msg", "out");
                values.Add("out_result", "out");

                result = global_variable.con.RunDmlProc("pr_cms_unposting_tcheque", values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public int  GetUploadNo()
        {
            int Uploadno = 0;
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();

                Uploadno = global_variable.con.RunIntProc("pr_cms_get_tupload_count", values);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Uploadno;
        }

    }
}
