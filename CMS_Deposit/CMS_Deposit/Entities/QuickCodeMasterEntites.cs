using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_Deposit.Entities
{
    public class QuickCodeMasterEntites
    {
        public int qcd_gid { get; set; }
        public string qcd_code { get; set; }
        public string qcd_short_code { get; set; }
        public string qcd_name { get; set; }
        public string master_code { get; set; }
        public string depend_flag { get; set; }
        public string depend_master_code { get; set; }
        public string depend_qcd_code { get; set; }
        public string action { get; set; }
        public string action_by { get; set; }
        public string msg { get; set; }
        public int result { get; set; }
    }
}
