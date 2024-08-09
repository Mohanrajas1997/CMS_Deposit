using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_Deposit.Entities
{
  public class AdminEntities
    {
      public class UserMaster
      {
          public int user_gid { get; set; }
          public string user_code { get; set; }
          public string user_name { get; set; }
          public string addr1 { get; set; }
          public string addr2 { get; set; }
          public string addr3 { get; set; }
          public string addr4 { get; set; }
          public string city { get; set; }
          public string pincode { get; set; }
          public string mobile_no { get; set; }
          public string mail_id { get; set; }
          public string sex { get; set; }
          public string dob { get; set; }
          public string doj { get; set; }
          public string desig_name { get; set; }
          public string dept_name { get; set; }
          public string user_status { get; set; }
          public int usergroup_gid { get; set; }
          public bool pwd_flag { get; set; }
          public string action { get; set; }
      }
    }
}
