using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_Deposit.Entities
{
   public class CMSEntities
    {
       public class ChqEntry_Model
       {
           public int deposit_gid { get; set; }
           public int chq_gid { get; set; }
           public string chq_date { get; set; }
           public string chq_no { get; set; }
           public string acc_holder { get; set; }
           public string micr_code { get; set; }
           public string tran_code { get; set; }
           public double chq_amount { get; set; }
           public int mapped_amount { get; set; }
           public int clearing_gid { get; set; }
           public int enrichment_gid { get; set; }
           public string ref_no { get; set; }
           public double ref_amount { get; set; }
           public string action { get; set; }
           public string action_by { get; set; }
           public int out_gid { get; set; }
           public string msg { get; set; }
           public int result { get; set; }
       }
      
    }
}
