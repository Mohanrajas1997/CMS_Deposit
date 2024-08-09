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
   public  class LoginBusiness
    {
       public DataTable GetLoginValidation(string UserCode, string Password, string SystemIP, int maxpwdattempt)
       {
           DataTable logindt = new DataTable();

           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               
               values.Add("in_user_code", UserCode);
               values.Add("in_pwd", Password.ToString());
               values.Add("in_ip_addr", SystemIP);
               values.Add("in_max_pwd_attempt", maxpwdattempt);
               logindt = global_variable.con.RunProc("pr_soft_get_loginvalidation", values);
               return logindt;
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           
           return logindt;

       }
    }
}
