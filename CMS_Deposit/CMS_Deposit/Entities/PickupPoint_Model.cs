using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_Deposit.Entities
{
    public class PickupPoint_Model
    {

        public class PickupPointHdr
        {
            public int pickupentry_gid { get; set; }
            public string pickup_date { get; set; }
            public string pickup_loc_code { get; set; }
            public string agent_code { get; set; }
            public string action { get; set; }
            public string action_by { get; set; }
            public string save_flag { get; set; }
            public string delete_flag { get; set; }
            public int out_gid { get; set; }
            public string msg { get; set; }
            public int result { get; set; }
        }

        public class PickupPointDtls
        {
            public PickupPointDtls()
            {
                save_flag = "N";
                return;
            }

            public int pickupdtl_gid { get; set; }
            public int pickup_gid { get; set; }
            public string qcd_client_code { get; set; }
            public string client_code { get; set; }
            public string client_name { get; set; }
            public string qcd_pickup_code { get; set; }
            public string pickup_point { get; set; }
            public int tot_chq { get; set; }
            public string client_ack { get; set; }
            public string save_flag { get; set; }
            public string delete_flag { get; set; }
            public string action { get; set; }
            public string action_by { get; set; }
            public string msg { get; set; }
            public int result { get; set; }

        }

    }
}
