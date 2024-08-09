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
using System.Configuration;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace CMS_Deposit.Business
{
  public   class DepositSlipBusiness
    {
      string apiurl = ConfigurationManager.AppSettings["APIServerURL"].ToString();
      public DataSet  GetDropDownDtls()
      {
          DataSet ds = new DataSet();
          try
          {
              Dictionary<string, Object> values = new Dictionary<string, object>();

              ds = global_variable.con.RunProc_ds("pr_cms_get_tdeposit_dropdown", values);
          }
          catch (Exception ex)
          {
              throw (ex);
          }
          return ds;
      }
      public string GetBranchName(string QcdBankCode)
      {
          string ClientName = "";
          try
          {
              Dictionary<string, Object> values = new Dictionary<string, object>();
              
              values.Add("In_bank_code", QcdBankCode);
              ClientName = global_variable.con.RunScalar("pr_cms_get_BranchName", values);
          }
          catch (Exception ex)
          {
              throw (ex);
          }
          return ClientName;
      }
      public DataTable GetPickuppointDtls(string loc)
      {
          DataTable dt = new DataTable();
          try
          {
              Dictionary<string, Object> values = new Dictionary<string, object>();
              values.Add("in_location_code", loc);
              dt = global_variable.con.RunProc("pr_cms_get_pickup_new", values);
          }
          catch (Exception ex)
          {
              throw (ex);
          }
          return dt;
      }
      public string[] SaveDepositSlip(DepositSlipEntities.DepositSlipHdr  ObjDeposit)
      {
          string[] result = { };
          try
          {
              Dictionary<string, Object> values = new Dictionary<string, object>();
              
              values.Add("in_deposit_gid", ObjDeposit.DepositGid );
              values.Add("in_deposit_date", ObjDeposit.DepositDate );
              values.Add("in_deposit_slip_no", ObjDeposit.DepositSlipNo );
              values.Add("in_tot_chqs", ObjDeposit.NoOfChqs );
              values.Add("in_deposit_amount", ObjDeposit.DepositAmount );
              values.Add("in_client_code", ObjDeposit.ClientCode );
              values.Add("in_loc_code", ObjDeposit.LocationCode );
              values.Add("in_pp_code", ObjDeposit.pickuppoint);
              values.Add("in_agent_code", ObjDeposit.AgentCode );
              values.Add("in_bank_code", ObjDeposit.BankCode );
              values.Add("in_bank_branch", ObjDeposit.BranchName);
              values.Add("in_mapped_amount", ObjDeposit.Mapped_Amount );
              values.Add("in_mapped_chq", ObjDeposit.Mapped_Chq );
              values.Add("in_action", ObjDeposit.action);
              values.Add("in_action_by", ObjDeposit.action_by);
              values.Add("out_gid", "out");
              values.Add("out_msg", "out");
              values.Add("out_result", "out");
              result = global_variable.con.RunGUIDProc("pr_cms_trn_tdeposit", values);

          }
          catch (Exception ex)
          {
              throw (ex);
          }
          return result;
      }

      public DataSet  EditDepositHdr(DepositSlipEntities.DepositSlipHdr ObjDeposit)
      {
          DataSet dtedit = new DataSet();
          try
          {
              Dictionary<string, Object> values = new Dictionary<string, object>();
              
              values.Add("in_deposit_gid", ObjDeposit.DepositGid);
              values.Add("in_deposit_date", ObjDeposit.DepositDate);
              values.Add("in_deposit_slip_no", ObjDeposit.DepositSlipNo);
              values.Add("in_tot_chqs", ObjDeposit.NoOfChqs);
              values.Add("in_deposit_amount", ObjDeposit.DepositAmount);
              values.Add("in_client_code", ObjDeposit.ClientCode);
              values.Add("in_loc_code", ObjDeposit.LocationCode);
              values.Add("in_pp_code", ObjDeposit.pickuppoint);
              values.Add("in_agent_code", ObjDeposit.AgentCode);
              values.Add("in_bank_code", ObjDeposit.BankCode);
              values.Add("in_bank_branch", ObjDeposit.BranchName);
              values.Add("in_mapped_amount", ObjDeposit.Mapped_Amount);
              values.Add("in_mapped_chq", ObjDeposit.Mapped_Chq);
              values.Add("in_action", ObjDeposit.action);
              values.Add("in_action_by", ObjDeposit.action_by);
              values.Add("out_gid", "out");
              values.Add("out_msg", "out");
              values.Add("out_result", "out");
              dtedit = global_variable.con.Runeditds("pr_cms_trn_tdeposit", values);

          }
          catch (Exception ex)
          {
              throw (ex);
          }
          return dtedit;
      }
      public string[] SaveDepositAttachment(DepositSlipEntities.DepositAttachment  ObjDepositAttch)
      {
          string[] result = { };
          try
          {
              Dictionary<string, Object> values = new Dictionary<string, object>();
              
              values.Add("in_attachment_gid", ObjDepositAttch.AttachmentGid );
              values.Add("in_deposit_gid", ObjDepositAttch.DepositGid );
              values.Add("in_file_name", ObjDepositAttch.FileName);
              values.Add("in_action", ObjDepositAttch.action);
              values.Add("in_action_by", ObjDepositAttch.action_by);
              values.Add("out_gid", "out");
              values.Add("out_msg", "out");
              values.Add("out_result", "out");
              result = global_variable.con.Runsaveheadr("pr_cms_trn_tattachment", values);
          }
          catch (Exception ex)
          {
              throw (ex);
          }
          return result;
      }
      public DepositSlipEntities.DepositAttachment_Api SaveImageFld(DepositSlipEntities.DepositAttachment_Api ObjImageFld)
      {
          DepositSlipEntities.DepositAttachment_Api ObjImageRes = new DepositSlipEntities.DepositAttachment_Api();
          try
          {
              using (var client = new HttpClient())
              {
                  string Urlcon = "Attachment/";
                  client.BaseAddress = new Uri(apiurl + Urlcon);
                  client.DefaultRequestHeaders.Accept.Clear();
                  client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                  HttpContent content = new StringContent(JsonConvert.SerializeObject(ObjImageFld), UTF8Encoding.UTF8, "application/json");
                  var response = client.PostAsync("SaveAttachment", content).Result;
                  Stream data = response.Content.ReadAsStreamAsync().Result;
                  StreamReader reader = new StreamReader(data);
                  string post_data = reader.ReadToEnd();
                  ObjImageRes = (DepositSlipEntities.DepositAttachment_Api)JsonConvert.DeserializeObject(post_data, ObjImageRes.GetType());
              }
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          return ObjImageRes;
      }
      public DataTable GetDepositQue(string ConditionStatus)
      {
          DataTable dtDepdtl = new DataTable();
          try
          {
              Dictionary<string, Object> values = new Dictionary<string, object>();
              
              values.Add("In_Condition", ConditionStatus);
              dtDepdtl = global_variable.con.RunProc("pr_cms_get_tdeposit_queue", values);
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          return dtDepdtl;
      }
      public DataTable GetAttachmentDtls(long  DepositGid)
      {
          DataTable dtAttch = new DataTable();
          try
          {
              Dictionary<string, Object> values = new Dictionary<string, object>();
              
              values.Add("in_deposit_gid", DepositGid);
              dtAttch = global_variable.con.RunProc("pr_cms_get_tattachment", values);
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          return dtAttch;
      }
      public DataTable GetTotalRefAmount(long DepositGid,long ChequeGid )
      {
          DataTable dtAttch = new DataTable();
          try
          {
              Dictionary<string, Object> values = new Dictionary<string, object>();
              
              values.Add("in_deposit_gid", DepositGid);
              values.Add("in_chq_gid", ChequeGid);
              dtAttch = global_variable.con.RunProc("pr_cms_get_tenrichment_amount", values);
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          return dtAttch;
      }
      public DataTable GetChequeEntryCount(long DepositGid)
      {
          DataTable dtAttch = new DataTable();
          try
          {
              Dictionary<string, Object> values = new Dictionary<string, object>();
              
              values.Add("in_deposit_gid", DepositGid);
              dtAttch = global_variable.con.RunProc("pr_cms_get_tdeposit_count", values);
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          return dtAttch;
      }
      public DepositSlipEntities.DepositAttachment_Api GetAttachmentImage(DepositSlipEntities.DepositAttachment_Api ObjGetImage)
      {
          DepositSlipEntities.DepositAttachment_Api ObjGetImageRes = new DepositSlipEntities.DepositAttachment_Api();
          try
          {
              using (var client = new HttpClient())
              {
                  string Urlcon = "Attachment/";
                  client.BaseAddress = new Uri(apiurl + Urlcon);
                  client.DefaultRequestHeaders.Accept.Clear();
                  client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                  HttpContent content = new StringContent(JsonConvert.SerializeObject(ObjGetImage), UTF8Encoding.UTF8, "application/json");
                  var response = client.PostAsync("viewimage", content).Result;
                  Stream data = response.Content.ReadAsStreamAsync().Result;
                  StreamReader reader = new StreamReader(data);
                  string post_data = reader.ReadToEnd();

                  string res = (string)JsonConvert.DeserializeObject(post_data, typeof(string));
                  ObjGetImageRes = (DepositSlipEntities.DepositAttachment_Api)JsonConvert.DeserializeObject(res, typeof(DepositSlipEntities.DepositAttachment_Api));

                 
              }
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          return ObjGetImageRes;
      }
    }
}
