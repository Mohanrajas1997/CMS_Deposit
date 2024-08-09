using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS_Deposit.Common;
using CMS_Deposit.Entities;
using System.Data;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Configuration;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace CMS_Deposit.Business
{
    public class CMSEntryBusiness
    {
        public string[] SaveCMSEntry(CMSEntities.ChqEntry_Model  ObjCms)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("in_deposit_gid", ObjCms.deposit_gid );
                values.Add("in_chq_gid", ObjCms.chq_gid );
                values.Add("in_chq_date", ObjCms.chq_date );
                values.Add("in_chq_no", ObjCms.chq_no );
                values.Add("in_chq_amount", ObjCms.chq_amount );
                values.Add("in_acc_holder", ObjCms.acc_holder);
                values.Add("in_mapped_amount", ObjCms.mapped_amount );
                values.Add("in_clearing_gid", ObjCms.clearing_gid );
                values.Add("in_ref_no", ObjCms.ref_no );
                values.Add("in_ref_amount", ObjCms.ref_amount );               
                values.Add("in_action", ObjCms.action);
                values.Add("in_action_by", ObjCms.action_by);
                values.Add("out_gid", "out");
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = global_variable.con.RunGUIDProc("pr_cms_trn_tcheque", values);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public string[] SaveCMSNewEntry(CMSEntities.ChqEntry_Model ObjCms)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();

                values.Add("in_deposit_gid", ObjCms.deposit_gid);
                values.Add("in_chq_gid", ObjCms.chq_gid);
                values.Add("in_chq_date", ObjCms.chq_date);
                values.Add("in_chq_no", ObjCms.chq_no);
                values.Add("in_chq_amount", ObjCms.chq_amount);
                values.Add("in_acc_holder", ObjCms.acc_holder);
                values.Add("in_micr_code", ObjCms.micr_code);
                values.Add("in_tran_code", ObjCms.tran_code);
                values.Add("in_mapped_amount", ObjCms.mapped_amount);
                values.Add("in_clearing_gid", ObjCms.clearing_gid);
                values.Add("in_ref_no", ObjCms.ref_no);
                values.Add("in_ref_amount", ObjCms.ref_amount);
                values.Add("in_action", ObjCms.action);
                values.Add("in_action_by", ObjCms.action_by);
                values.Add("out_gid", "out");
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = global_variable.con.RunGUIDProc("pr_cms_trn_tchequenew", values);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public string[] SaveEnrichMent(CMSEntities.ChqEntry_Model ObjCms)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("in_enrich_gid", ObjCms.enrichment_gid );
                values.Add("in_deposit_gid", ObjCms.deposit_gid );
                values.Add("in_chq_gid", ObjCms.chq_gid );
                values.Add("in_ref_no", ObjCms.ref_no );
                values.Add("in_ref_amount", ObjCms.ref_amount );               
                values.Add("in_action", ObjCms.action);
                values.Add("in_action_by", ObjCms.action_by);
                values.Add("out_gid", "out");
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = global_variable.con.RunGUIDProc("pr_cms_ins_tenrichment", values);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }


        public DataTable GetChqEntryView(int depositgid)
        {
            DataTable dt = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("in_deposit_gid", depositgid);
                dt = global_variable.con.RunProc("pr_cms_get_tchqview", values);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public DataTable GetChqEntryNewView(int depositgid)
        {
            DataTable dt = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();

                values.Add("in_deposit_gid", depositgid);
                dt = global_variable.con.RunProc("pr_cms_get_tchqnewview", values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public DataTable GetChqPulloutList(int depositgid)
        {
            DataTable dt = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("in_deposit_gid", depositgid);
                dt = global_variable.con.RunProc("pr_cms_get_tchqlist", values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public string[] SavePullout(int chq_gid,DateTime pullout_date,string pullout_reason)
        {
            string[] result = { };

            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                

                values.Add("in_chq_gid", chq_gid);
                values.Add("in_pullout_date", pullout_date);
                values.Add("in_pullout_reason", pullout_reason);
                values.Add("in_action_by", global_variable.user_code);
                values.Add("out_gid", "out");
                values.Add("out_msg", "out");
                values.Add("out_result", "out");

                result = global_variable.con.RunGUIDProc("pr_cms_ins_pullout", values);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        public string[] DelPullout(int pullout_gid,int chq_gid)
        {
            string[] result = { };

            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                

                values.Add("in_pullout_gid", pullout_gid);
                values.Add("in_chq_gid", chq_gid);
                values.Add("in_action_by", global_variable.user_code);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");

                result = global_variable.con.RunDmlProc("pr_cms_del_pullout", values);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        public DataTable GetPullout(int chq_gid)
        {
            DataTable dt = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("in_chq_gid", chq_gid);
                dt = global_variable.con.RunProc("pr_cms_get_pullout", values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        public DataTable GetEnrichmentView(int chqgid)
        {
            DataTable dt = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("in_chq_gid", chqgid);
                dt = global_variable.con.RunProc("pr_cms_get_tenrichmentView", values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
    }
}
