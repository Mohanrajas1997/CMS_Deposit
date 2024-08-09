using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_Deposit.Common
{
    public class global_variable
    {
        public static string proj_name = "CMS DEPOSIT";
        public static string user_code;
        public static string user_name ;
        public static int  UserId;
        public static int Usergroupid;
        public static string Password = "";
        public static string action_insert = "INSERT";
        public static string action_update = "UPDATE";
        public static string action_delete = "DELETE";
        public static string action_select = "SELECT";

        public static string SymmetricKey = "b14ca5898a4e4133bbce2ea2315a1940";
        public static string report_path = @"e:\temp\temp\";

        public static Dataconnection con;
    }
}
