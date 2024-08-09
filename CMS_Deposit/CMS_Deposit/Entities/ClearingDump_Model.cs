using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_Deposit.Entities
{
   public class ClearingDump_Model
    {
       public class FileHdr
       {
           public int file_gid { get; set; }
           public string file_name { get; set; }
           public string sheet_name { get; set; }
           public string file_type { get; set; }
           public string action { get; set; }
           public string action_by { get; set; }           
           public int out_gid { get; set; }
           public string msg { get; set; }
           public int result { get; set; }
       }
       public class ClearingDumHdr
       {
           public int clrg_gid { get; set; }
           public int file_gid { get; set; }
           public string clrg_date { get; set; }
           public string clrg_loc_code { get; set; }
           public string client_code { get; set; }
           public string chq_date { get; set; }
           public string chq_no { get; set; }
           public double chq_amount { get; set; }
           public string micr_code { get; set; }
           public string tran_code { get; set; }
           public string base_code { get; set; }
           public string acc_no { get; set; }
           public string cust_name { get; set; }
           public string deposit_date { get; set; }
           public string deposit_slip_no { get; set; }
           public double deposit_amount { get; set; }
           public string loc_code { get; set; }
           public string bank_code { get; set; }
           public string bank_acc_no { get; set; }
           public string action { get; set; }
           public string action_by { get; set; }
           public int out_gid { get; set; }
           public string msg { get; set; }
           public int result { get; set; }

       }
    }
}
