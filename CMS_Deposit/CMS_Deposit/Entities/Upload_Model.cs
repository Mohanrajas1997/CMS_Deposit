using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_Deposit.Entities
{
    public class Upload_Model
    {
        public class UploadHdr
        {
            public string clgrfromdate { get; set; }
            public string clrgtodate { get; set; }
            public int upload_gid { get; set; }
            public string upload_code { get; set; }
            public int upload_slno { get; set; }
            public string action { get; set; }
            public string action_by { get; set; }
            public int Out_gid { get; set; }
            public string Out_msg { get; set; }
            public int Out_result { get; set; }
        }
    }
}
