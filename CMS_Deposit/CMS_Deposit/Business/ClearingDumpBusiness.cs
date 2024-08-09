using CMS_Deposit.Common;
using CMS_Deposit.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS_Deposit.Business
{
   public class ClearingDumpBusiness
    {
       public string[] SaveFileDetails(ClearingDump_Model.FileHdr ObjFiledtls)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               
               values.Add("in_file_gid", ObjFiledtls.file_gid );
               values.Add("in_file_name", ObjFiledtls.file_name );
               values.Add("in_sheet_name", ObjFiledtls.sheet_name );
               values.Add("in_file_type", ObjFiledtls.file_type );
               values.Add("in_action", ObjFiledtls.action);
               values.Add("in_action_by", ObjFiledtls.action_by);
               values.Add("out_gid", "out");
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = global_variable.con.RunGUIDProc("pr_cms_ins_tfile", values);

           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           return result;
       }
       public string[] SaveClearingDtls(ClearingDump_Model.ClearingDumHdr ObjClearingDump)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               
               values.Add("in_clrg_gid", ObjClearingDump.clrg_gid );
               values.Add("in_file_gid", ObjClearingDump.file_gid );
               values.Add("in_clrg_date", ObjClearingDump.clrg_date );
               values.Add("in_clrg_loc_code", ObjClearingDump.clrg_loc_code );
               values.Add("in_client_code", ObjClearingDump.client_code);
               values.Add("in_chq_date", ObjClearingDump.chq_date );
               values.Add("in_chq_no", ObjClearingDump.chq_no );
               values.Add("in_chq_amount", ObjClearingDump.chq_amount );
               values.Add("in_micr_code", ObjClearingDump.micr_code );
               values.Add("in_tran_code", ObjClearingDump.tran_code );
               values.Add("in_base_code", ObjClearingDump.base_code );
               values.Add("in_acc_no", ObjClearingDump.acc_no);
               values.Add("in_cust_name", ObjClearingDump.cust_name );
               values.Add("in_deposit_date", ObjClearingDump.deposit_date );
               values.Add("in_deposit_slip_no", ObjClearingDump.deposit_slip_no );
               values.Add("in_deposit_amount", ObjClearingDump.deposit_amount );
               values.Add("in_loc_code", ObjClearingDump.loc_code );
               values.Add("in_bank_code", ObjClearingDump.bank_code );
               values.Add("in_bank_acc_no", ObjClearingDump.bank_acc_no );
               values.Add("in_action", ObjClearingDump.action);
               values.Add("in_action_by", ObjClearingDump.action_by);
               values.Add("out_gid", "out");
               values.Add("out_msg", "out");
               values.Add("out_result", "out");

               result = global_variable.con.RunGUIDProc("pr_cms_ins_tclearing", values);
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           return result;
       }
    }
}
