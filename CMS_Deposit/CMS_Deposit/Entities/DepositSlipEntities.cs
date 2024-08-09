using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_Deposit.Entities
{
   public class DepositSlipEntities
    {
       public class DepositSlipHdr
       {
           public int DepositGid { get; set; }
           public string DepositSlipNo { get; set; }
           public string DepositDate { get; set; }
           public int NoOfChqs { get; set; }
           public int DepositAmount { get; set; }
           public string ClientCode { get; set; }
           public string ClientName { get; set; }
           public string LocationCode { get; set; }
           public string LocationName { get; set; }
           public string pickuppoint { get; set; }
           public string AgentCode { get; set; }
           public string AgentName { get; set; }
           public string BankCode { get; set; }
           public string BankName { get; set; }
           public string BranchName { get; set; }
           public int Mapped_Amount { get; set; }
           public int Mapped_Chq { get; set; }
           public string action { get; set; }
           public string action_by { get; set; }
           public string msg { get; set; }
           public int result { get; set; }
           public int out_gid { get; set; }
       }
       public class DepositAttachment
       {
           public int AttachmentGid { get; set; }
           public int DepositGid { get; set; }
           public string FileName { get; set; }
           public string action_by { get; set; }
           public string action { get; set; }
       }
       public class DepositAttachment_Api
       {
           public int attachment_gid { get; set; }
           public string attachment_dtls { get; set; }
       }
       
    }
}
