using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CMS_Deposit.Common;
using CMS_Deposit.Entities;
using System.Windows.Forms;
namespace CMS_Deposit.Business
{
   public  class QuickCodeMasterBusiness
    {
        public DataTable GetQCDMasterName()
        {
            DataTable dt = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();

                dt = global_variable.con.RunProc("pr_cms_get_qcdname", values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public DataTable GetQCDMasterList(string master_code)
        {
            DataTable dt = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                                
                values.Add("in_master_code", master_code);
                dt = global_variable.con.RunProc("pr_cms_get_Masterlist", values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public DataTable GetQcdList(string master_code)
        {
            DataTable dt = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("in_master_code", master_code);

                dt = global_variable.con.RunProc("pr_cms_get_qcdlist", values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }      
      
        public DataTable GetDependentName(string qcdname)
        {
            DataTable dt = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("in_qcd_name", qcdname);
                dt = global_variable.con.RunProc("pr_cms_get_qcddepname", values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
        public DataTable GetDependentQcd(string qcdcode)
        {
            DataTable dt = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("in_qcd_code", qcdcode);
                dt = global_variable.con.RunProc("pr_cms_get_qcddepcode", values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
        public string[] SaveQCDMaster(QuickCodeMasterEntites QCDMaster)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("in_qcd_gid", QCDMaster.qcd_gid);                
                values.Add("in_qcd_code", QCDMaster.qcd_code);
                values.Add("in_qcd_short_code", QCDMaster.qcd_short_code);
                values.Add("in_qcd_name", QCDMaster.qcd_name);
                values.Add("in_master_code", QCDMaster.master_code);
                values.Add("in_depend_flag", QCDMaster.depend_flag);
                values.Add("in_depend_master_code", QCDMaster.depend_master_code);
                values.Add("in_depend_qcd_code", QCDMaster.depend_qcd_code);
                values.Add("in_action", QCDMaster.action);
                values.Add("in_action_by", QCDMaster.action_by);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = global_variable.con.RunDmlProc("pr_cms_mst_tquickcode", values);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
     
    }
}
