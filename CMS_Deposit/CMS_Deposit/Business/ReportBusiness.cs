using CMS_Deposit.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS_Deposit.Business
{
   public class ReportBusiness
    {
       public DataTable GetDepositRpt(string Condition)
       {
           DataTable dt = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               values.Add("In_Condition", Condition);
               dt = global_variable.con.RunProc("pr_cms_get_tdeposit_Rpt", values);
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           return dt;
       }
       public DataTable GetClearingFile ()
       {
           DataTable dt = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               dt = global_variable.con.RunProc("pr_cms_get_tfile_clearing", values);
           }
           catch(Exception ex)
           {
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           return dt;
       }
       public DataTable GetClearingRpt(string Condition)
       {
           DataTable dt = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               values.Add("In_Condition", Condition);
               dt = global_variable.con.RunProc("pr_cms_get_tclearing_rpt", values);
           }
           catch(Exception ex)
           {
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           return dt;
       }
       public DataTable GetChequeRpt(string Condition)
       {
           DataTable dt = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               values.Add("In_Condition", Condition);
               dt = global_variable.con.RunProc("pr_cms_get_tchq_rpt", values);
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           return dt;
       }
       public DataTable GetChequeNewRpt(string Condition)
       {
           DataTable dt = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               values.Add("In_Condition", Condition);
               dt = global_variable.con.RunProc("pr_cms_get_tchqnew_rpt", values);
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           return dt;
       }

       public DataTable GetEnrichmentRpt(string Condition)
       {
           DataTable dt = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               values.Add("In_Condition", Condition);
               //dt = global_variable.con.RunProc("pr_cms_get_enrichment_rpt", values);
               dt = global_variable.con.RunProc("pr_cms_get_enrichment_rpt_new", values);
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           return dt;
       }
       public DataTable GetUploadRpt(string Condition)
       {
           DataTable dt = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               values.Add("In_Condition", Condition);
               dt = global_variable.con.RunProc("pr_cms_get_tupload_rpt", values);
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           return dt;
       }
       public DataTable GetFinnaxiaRpt(string Condition)
       {
           DataTable dt = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               values.Add("in_upload_gid", Condition);
               dt = global_variable.con.RunProc("pr_cms_get_uploadxl1", values);
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           return dt;
       }

       public DataTable GetQryOutput(string qry)
       {
           DataTable dt = new DataTable();

           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               values.Add("in_sql", qry);
               dt = global_variable.con.Runeditdt("pr_kha_rpt_query", values);
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }

           return dt;
       }

       public DataTable GetFileReport(string Condition)
       {
           DataTable dt = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               values.Add("In_Condition", Condition);
               dt = global_variable.con.RunProc("pr_cms_get_tfile_rpt", values);
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           return dt;
       }
    }
}
