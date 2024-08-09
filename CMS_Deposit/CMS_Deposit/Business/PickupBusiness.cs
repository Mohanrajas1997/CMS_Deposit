using CMS_Deposit.Common;
using CMS_Deposit.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS_Deposit.Business
{
   public  class PickupBusiness
    {
       public DataTable GetLocationDtls()
       {
           DataTable dt = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();

               dt = global_variable.con.RunProc("pr_cms_get_location", values);
           }
           catch (Exception ex)
           {
               throw (ex);
           }
           return dt;
       }
       public DataTable GetAgentDtls()
       {
           DataTable dt = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();

               dt = global_variable.con.RunProc("pr_cms_get_agent", values);
           }
           catch(Exception ex)
           {
               throw (ex);
           }
           return dt;
       }
       public DataTable GetClientCode()
       {
           DataTable dt = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();

               dt = global_variable.con.RunProc("pr_cms_get_client", values);
           }
           catch(Exception ex)
           {
               throw (ex);
           }
           return dt;
       }
       public DataTable GetPickupDtls()
       {
           DataTable dt = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();

               dt = global_variable.con.RunProc("pr_cms_get_pickup", values);
           }
           catch(Exception ex)
           {
               throw (ex);
           }
           return dt;
       }
       public string GetClientName(string QcdClientCode)
       {
           string ClientName = "";
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               
               values.Add("In_qcd_code", QcdClientCode);
               ClientName = global_variable.con.RunScalar("pr_cms_get_clientname", values);
           }
           catch(Exception ex)
           {
               throw (ex);
           }
           return ClientName;
       }
       public string[] SavePickupHeader(PickupPoint_Model.PickupPointHdr Pickuphead)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               
               values.Add("in_pickup_gid", Pickuphead.pickupentry_gid);
               values.Add("in_pickup_date", Pickuphead.pickup_date);
               values.Add("in_loc_code", Pickuphead.pickup_loc_code);
               values.Add("in_agent_code", Pickuphead.agent_code);
               values.Add("in_action", Pickuphead.action);
               values.Add("in_action_by", Pickuphead.action_by);
               values.Add("out_gid", "out");
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = global_variable.con.RunGUIDProc("pr_cms_trn_tpickup", values);
              
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           return result;
       }
       public string[] SavePickupDetails(PickupPoint_Model.PickupPointDtls  ObjPickupDtl)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               
               values.Add("in_pickupdtl_gid", ObjPickupDtl.pickupdtl_gid);
               values.Add("in_pickup_gid", ObjPickupDtl.pickup_gid);
               values.Add("in_client_code", ObjPickupDtl.qcd_client_code);
               values.Add("in_pp_code", ObjPickupDtl.qcd_pickup_code);
               values.Add("in_tot_chqs", ObjPickupDtl.tot_chq);
               values.Add("in_client_ack", ObjPickupDtl.client_ack);            
               values.Add("in_action", ObjPickupDtl.action);
               values.Add("in_action_by", ObjPickupDtl.action_by);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = global_variable.con.RunDmlProc("pr_cms_trn_tpickupdtl", values);
               
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           return result;
       }
       public DataSet EditPickupHeader(PickupPoint_Model.PickupPointHdr  ObjPickupheader)
       {
           DataSet dtedit = new DataSet();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               
               values.Add("in_pickup_gid", ObjPickupheader.pickupentry_gid );
               values.Add("in_pickup_date", ObjPickupheader.pickup_date );
               values.Add("in_loc_code", ObjPickupheader.pickup_loc_code );
               values.Add("in_agent_code", ObjPickupheader.agent_code );            
               values.Add("in_action", ObjPickupheader.action);
               values.Add("in_action_by", ObjPickupheader.action_by);
               values.Add("out_gid", "out");
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               dtedit = global_variable.con.Runeditds("pr_cms_trn_tpickup", values);

           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           return dtedit;
       }

    }
}
