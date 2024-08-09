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
   public  class UploadBusiness
    {
       public string[] SaveUploadid(Upload_Model.UploadHdr ObjUploadHdr)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               
               values.Add("in_clrg_fromdt", ObjUploadHdr.clgrfromdate );
               values.Add("in_clrg_todt", ObjUploadHdr.clrgtodate );
               values.Add("in_upload_gid", ObjUploadHdr.upload_gid );
               values.Add("in_upload_code", ObjUploadHdr.upload_code );
               values.Add("in_upload_sno", ObjUploadHdr.upload_slno);
               values.Add("in_action", ObjUploadHdr.action);
               values.Add("in_action_by", ObjUploadHdr.action_by);
               values.Add("out_gid", "out");
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = global_variable.con.RunGUIDProc("pr_cms_ins_tupload", values);

           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           return result;
       }
       public DataTable GetFinnaxiaRpt(int UploadGid)
       {
           DataTable dt = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               values.Add("in_upload_gid", UploadGid);
               dt = global_variable.con.RunProc("pr_cms_get_uploadxl", values);
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           return dt;
       }
       public DataTable GetUpload(int UploadGid)
       {
           DataTable dt = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               
               values.Add("in_upload_gid", UploadGid);
               dt = global_variable.con.RunProc("pr_cms_get_tupload", values);
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           return dt;
       }
       public DataTable Getfilename(int UploadGid)
       {
           DataTable dt = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();

               values.Add("in_upload_gid", UploadGid);
               dt = global_variable.con.RunProc("pr_cms_get_filename", values);
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           return dt;
       }
       public DataTable GetUploadCode(string UploaddtFrom,string UploaddtTo)
       {
           DataTable dt = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               
               values.Add("in_uploaddate_from", UploaddtFrom);
               values.Add("in_uploaddate_to", UploaddtTo);
               dt = global_variable.con.RunProc("pr_cms_get_tuploadNo", values);
           }
           catch(Exception ex)
           {
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           return dt;
       }
    }
}
