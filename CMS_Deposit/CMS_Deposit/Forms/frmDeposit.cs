using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMS_Deposit.Business;
using CMS_Deposit.Common;
using CMS_Deposit.Entities;
using System.IO;

namespace CMS_Deposit.Forms
{
    public partial class frmDeposit : Form
    {
        public DataTable dtAttachment = new DataTable("attachment");
        DataColumn dc;

        public int DepositGid = 0;
        public string Action = "";
        string user_name = string.Empty;
        DataTable dtentity = new DataTable();

        public frmDeposit()
        {
            InitializeComponent();

            pnlSave.Visible = true;
            create_stru();
        }
        private void create_stru()
        {
            DataGridViewImageColumn objImg = new DataGridViewImageColumn();

            objImg.HeaderText = "Delete";
            objImg.Name = "Delete";
            objImg.Image = imgLst.Images[0];

            dc = new DataColumn();
            dc.DataType = Type.GetType("System.Int32");
            dc.ColumnName = "Serial No";
            dc.Caption = "#";
            dtAttachment.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = Type.GetType("System.Int32");
            dc.ColumnName = "attachment_gid";
            dc.Caption = "attachment_gid";
            dtAttachment.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = Type.GetType("System.String");
            dc.ColumnName = "File Name";
            dc.Caption = "File Name";
            dtAttachment.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = Type.GetType("System.String");
            dc.ColumnName = "File Path";
            dc.Caption = "File Path";
            dtAttachment.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "Attachment_image_str";
            dc.DataType = System.Type.GetType("System.String");
            dtAttachment.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = Type.GetType("System.String");
            dc.ColumnName = "delete_flag";
            dc.Caption = "Delete Flag";
            dtAttachment.Columns.Add(dc);    

            dgvReport.DataSource = dtAttachment;

            foreach (DataGridViewColumn dgvc in dgvReport.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dgvReport.Columns.Add(objImg);

            dgvReport.Columns["File Path"].Visible = false;
            dgvReport.Columns["attachment_gid"].Visible = false;
            dgvReport.Columns["delete_flag"].Visible = false;
            dgvReport.Columns["Serial No"].Width = (int)(100 * 0.65);
            dgvReport.Columns["File Name"].Width = (int)(100 * 3);
            dgvReport.Columns["Attachment_image_str"].Visible = false;
            dgvReport.Columns["Delete"].Width = (int)(100 * 0.5);
        }

        public void Clear()
        {
            txtdepositgid.Text = "";
            txtDepositSlipNo.Text = "";
            cmbLocation.Text = "";
            cmbAgentName.Text = "";
            cmbClientName.Text = "";
            txtAmount.Text = "";
            txtNoOfChq.Text = "";
            cmbBankName.Text = "";
            txtBankBranch.Text = "";
            txtFile.Text = "";
            cmbpup.Text = "";
            dtAttachment.Rows.Clear();           

        }

        public void LoadMasterDetails()
        {

            try
            {
                DepositSlipBusiness obj = new DepositSlipBusiness();
                DataSet ds = new DataSet();
                DataTable dtloc = new DataTable();
                DataTable dtAgent = new DataTable();
                DataTable dtClient = new DataTable();
                DataTable dtBankName = new DataTable();
                DataTable dtpup = new DataTable();

                ds = obj.GetDropDownDtls();
                if (ds.Tables[0].Rows .Count >0)
                {
                    dtloc = ds.Tables[0];
                }
                if (ds.Tables[1].Rows .Count >0 )
                {
                    dtAgent = ds.Tables[1];
                }
                if(ds.Tables [2].Rows .Count >0)
                {
                    dtClient = ds.Tables[2];
                }
                if (ds.Tables[3].Rows .Count >0 )
                {
                    dtBankName = ds.Tables[3];
                }

                if (dtloc.Rows.Count > 0)
                {
                    DataRow rows = dtloc.NewRow();
                    rows["qcd_name"] = "--Select--";
                    dtloc.Rows.InsertAt(rows, 0);
                    cmbLocation.DataSource = dtloc;
                    cmbLocation.DisplayMember = "qcd_name";
                    cmbLocation.ValueMember = "qcd_code";
                }                
               
                if (dtAgent.Rows.Count > 0)
                {
                    DataRow rows = dtAgent.NewRow();
                    rows["qcd_name"] = "--Select--";
                    dtAgent.Rows.InsertAt(rows, 0);
                    cmbAgentName.DataSource = dtAgent;
                    cmbAgentName.DisplayMember = "qcd_name";
                    cmbAgentName.ValueMember = "qcd_code";
                }               
             
                if(dtClient .Rows .Count >0)
                {
                    DataRow rows = dtClient.NewRow();
                    rows["ClientCode_Name"] = "--Select--";
                    dtClient.Rows.InsertAt(rows,0);
                    cmbClientName.DataSource = dtClient;
                    cmbClientName.DisplayMember = "ClientCode_Name";
                    cmbClientName.ValueMember = "qcd_code";
                }
                if (dtBankName.Rows.Count >0)
                {
                    DataRow rows = dtBankName.NewRow();
                    rows["qcd_name"] = "--Select--";
                    dtBankName.Rows.InsertAt(rows ,0);
                    cmbBankName.DataSource = dtBankName;
                    cmbBankName.DisplayMember = "qcd_name";
                    cmbBankName.ValueMember = "qcd_code";
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void locationleave_evt(object sender, EventArgs e)
        {
            DropdownloadPup();
        }
        public void DropdownloadPup()
        {
            DepositSlipBusiness obj = new DepositSlipBusiness();
            DataTable dtpup = new DataTable();

            dtpup = obj.GetPickuppointDtls(cmbLocation.SelectedValue.ToString());
            if (dtpup.Rows.Count > 0)
            {
                DataRow rows = dtpup.NewRow();
                rows["qcd_name"] = "--Select--";
                dtpup.Rows.InsertAt(rows, 0);
                cmbpup.DataSource = dtpup;
                cmbpup.DisplayMember = "qcd_name";
                cmbpup.ValueMember = "qcd_code";

                cmbpup.Text = "";
                cmbpup.SelectedIndex = -1;
            }
            else
            {
                cmbpup.Text = " ";
            }
        }
        private void frmCreateUser_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMasterDetails();                
                pnlButtons.Visible = true;
                pnlSave.Visible = false;
                pnlMain.Enabled = false;

                KeyPreview = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnsve_Click(object sender, EventArgs e)
        {
            try
            {

                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to save the record?", global_variable.proj_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {

                    if (cmbLocation.SelectedItem == null || cmbLocation.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select the location", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbLocation.Focus();
                        return;
                    }
                    if (cmbAgentName.SelectedItem == null)
                    {
                        MessageBox.Show("Please select the Agent", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbAgentName.Focus();
                        return;
                    }
                    if (cmbpup.SelectedItem == null)
                    {
                        MessageBox.Show("Please select the PickUP Point", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbpup.Focus();
                        return;
                    }
                    if (cmbClientName .SelectedItem == null)
                    {
                        MessageBox.Show("Please select the Client", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbClientName.Focus();
                        return;
                    }
                    if (cmbBankName .SelectedItem == null)
                    {
                        MessageBox.Show("Please select the Bank", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbBankName.Focus();
                        return;
                    }
                    if (txtDepositSlipNo .Text == "")
                    {
                        MessageBox.Show("Deposit Slip no cannot be empty! ", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDepositSlipNo.Focus();
                        return;
                    }
                
                    if (txtAmount.Text == "" || txtAmount .Text =="0")
                    {
                        MessageBox.Show("Amount cannot be empty !", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAmount.Focus();
                        return;
                    }
                    if(txtNoOfChq .Text =="" || txtNoOfChq .Text =="0")
                    {
                        MessageBox.Show("No of Cheques cannot be empty !", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAmount.Focus();
                        return;
                    }
                    if(txtBankBranch .Text =="")
                    {
                        MessageBox.Show("Bank Branch cannot be empty !", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAmount.Focus();
                        return;
                    }
                    
                 
                    DepositSlipEntities.DepositSlipHdr ObjDepositHdr = new DepositSlipEntities.DepositSlipHdr();
                    if (txtdepositgid.Text.ToString() == "") DepositGid = 0; else DepositGid = Int32.Parse(txtdepositgid.Text.ToString());
                    if (DepositGid == 0)
                    {
                        ObjDepositHdr.DepositGid = DepositGid;
                        ObjDepositHdr.DepositDate = dtpDepositDt.Value.ToString("yyyy-MM-dd");
                        ObjDepositHdr.DepositSlipNo = txtDepositSlipNo.Text.Trim();
                        ObjDepositHdr.NoOfChqs = Convert.ToInt32(txtNoOfChq.Text.Trim());
                        ObjDepositHdr.DepositAmount = Convert.ToInt32(txtAmount.Text.Trim());
                        ObjDepositHdr.ClientCode = cmbClientName.SelectedValue.ToString();
                        ObjDepositHdr.LocationCode = cmbLocation.SelectedValue.ToString();
                        ObjDepositHdr.AgentCode = cmbAgentName.SelectedValue.ToString();
                        ObjDepositHdr.BankCode = cmbBankName.SelectedValue.ToString();
                        ObjDepositHdr.pickuppoint = cmbpup.SelectedValue.ToString();
                        ObjDepositHdr.BranchName = txtBankBranch.Text.Trim();
                        ObjDepositHdr.action = global_variable.action_insert;
                        ObjDepositHdr.action_by = global_variable.user_name;
                        
                    }
                    else
                    {
                        ObjDepositHdr.DepositGid = DepositGid;
                        ObjDepositHdr.DepositDate = dtpDepositDt.Value.ToString("yyyy-MM-dd");
                        ObjDepositHdr.DepositSlipNo = txtDepositSlipNo.Text.Trim();
                        ObjDepositHdr.NoOfChqs = Convert.ToInt32(txtNoOfChq.Text.Trim());
                        ObjDepositHdr.DepositAmount = Convert.ToInt32(txtAmount.Text.Trim());
                        ObjDepositHdr.ClientCode = cmbClientName.SelectedValue.ToString();
                        ObjDepositHdr.LocationCode = cmbLocation.SelectedValue.ToString();
                        ObjDepositHdr.AgentCode = cmbAgentName.SelectedValue.ToString();
                        ObjDepositHdr.BankCode = cmbBankName.SelectedValue.ToString();
                        ObjDepositHdr.pickuppoint = cmbpup.SelectedValue.ToString();
                        ObjDepositHdr.BranchName = txtBankBranch.Text.Trim();
                        ObjDepositHdr.action = global_variable.action_update;
                        ObjDepositHdr.action_by = global_variable.user_name;
                    }

                    DepositSlipBusiness objBusiness = new DepositSlipBusiness();
                    string[] result = objBusiness.SaveDepositSlip(ObjDepositHdr);
                    ObjDepositHdr.msg = result[0].ToString();
                    ObjDepositHdr.out_gid = Convert.ToInt32(result[2]);

                    if (DepositGid == 0)
                    {
                        ObjDepositHdr.DepositGid = ObjDepositHdr.out_gid;
                    }
                    if (result[1].ToString() == "0")
                    {
                        MessageBox.Show(result[0].ToString(), global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    DepositSlipEntities.DepositAttachment ObjDepositAttch = new DepositSlipEntities.DepositAttachment();
                    DepositSlipEntities.DepositAttachment_Api ObjDepositApi = new DepositSlipEntities.DepositAttachment_Api();
                    int attachment_gid = 0;

                    //if (dgvReport .RowCount > 0)
                    //{
                    //    foreach (DataGridViewRow rows in dgvReport.Rows)
                    //    {
                    //        if (Int32.Parse(rows.Cells["attachment_gid"].Value.ToString()) == 0)
                    //        {
                    //            ObjDepositAttch.DepositGid = ObjDepositHdr.DepositGid;
                    //            ObjDepositAttch.AttachmentGid = Convert.ToInt32(rows.Cells["attachment_gid"].ToString());
                    //            ObjDepositAttch.FileName = rows.Cells["File Name"].ToString();
                    //            ObjDepositAttch.action_by = global_variable.user_code;
                    //            ObjDepositAttch.action = global_variable.action_insert;
                    //            string[] result_attch = objBusiness.SaveDepositAttachment(ObjDepositAttch);
                    //            if (result_attch[2] == "1")
                    //            {
                    //                attachment_gid = Convert.ToInt32(result_attch[0]);

                    //                ObjDepositApi.attachment_gid = attachment_gid;
                    //                ObjDepositApi.attachment_dtls = dtAttachment.Rows[i]["Attachment_image_str"].ToString();
                    //                ObjDepositApi = objBusiness.SaveImageFld(ObjDepositApi);
                    //            }
                    //            else
                    //            {
                    //                MessageBox.Show(result_attch[0], global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //            }
                    //        }
                    //        if (Int32.Parse(rows.Cells["attachment_gid"].Value.ToString()) != 0 && rows.Cells["Delete Flag"].Value.ToString() == "Y")
                    //        {
                    //            ObjDepositAttch.DepositGid = ObjDepositHdr.DepositGid;
                    //            ObjDepositAttch.AttachmentGid = Convert.ToInt32(rows.Cells["attachment_gid"].ToString());
                    //            ObjDepositAttch.FileName = rows.Cells["File Name"].ToString();
                    //            ObjDepositAttch.action_by = global_variable.user_code;
                    //            ObjDepositAttch.action = global_variable.action_delete;
                    //            string[] result_attch = objBusiness.SaveDepositAttachment(ObjDepositAttch);
                    //        }
                    //    }
                    //}


                    for (int i = 0; i < dtAttachment.Rows.Count; i++)
                    {
                        ObjDepositAttch.DepositGid = ObjDepositHdr.DepositGid;
                        ObjDepositAttch.AttachmentGid = Convert.ToInt32(dtAttachment.Rows[i]["attachment_gid"].ToString());
                        ObjDepositAttch.FileName = dtAttachment.Rows[i]["File Name"].ToString();
                        ObjDepositAttch.action_by = global_variable.user_code;
                        if (dtAttachment.Rows[i]["delete_flag"].ToString() == "Y")
                        {
                            ObjDepositAttch.action = global_variable.action_delete;

                            if (ObjDepositAttch.AttachmentGid > 0)
                            {
                                string[] result_attch = objBusiness.SaveDepositAttachment(ObjDepositAttch);
                            }
                        }
                        else
                        {
                            ObjDepositAttch.action = global_variable.action_insert;
                            if (ObjDepositAttch.AttachmentGid == 0)
                            {
                                string[] result_attch = objBusiness.SaveDepositAttachment(ObjDepositAttch);

                                if (result_attch[2] == "1")
                                {
                                    attachment_gid = Convert.ToInt32(result_attch[0]);

                                    ObjDepositApi.attachment_gid = attachment_gid;
                                    ObjDepositApi.attachment_dtls = dtAttachment.Rows[i]["Attachment_image_str"].ToString();
                                    ObjDepositApi = objBusiness.SaveImageFld(ObjDepositApi);
                                }
                                else
                                {
                                    MessageBox.Show(result_attch[0], global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }


                    MessageBox.Show(result[0].ToString(), global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result[1].ToString() == "1")
                    {
                        if (DialogResult.Yes == MessageBox.Show("Do you want to add the record?", global_variable.proj_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            bntnew_Click(sender, e);
                           
                        }
                        else
                        {
                            btncancel.PerformClick();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            pnlButtons.Show();
            pnlSave.Hide();
            Clear();
            LoadMasterDetails();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntnew_Click(object sender, EventArgs e)
        {
            pnlMain.Enabled = true;
            pnlButtons.Hide();
            pnlSave.Show();
            Clear();
            LoadMasterDetails();
            txtDepositSlipNo.Focus();
        }

        private void btnedt_Click(object sender, EventArgs e)
        {
            if (txtDepositSlipNo .Text == "")
            {
                MessageBox.Show("select some Record to Edit", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            pnlMain.Enabled = true;
            pnlButtons.Hide();
            pnlSave.Show();
        }

      

        private void btndlt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDepositSlipNo .Text == "")
                {
                    MessageBox.Show("select some Record to Delete", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DialogResult Dialog = MessageBox.Show("Are you sure delete the record?", global_variable.proj_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dialog == DialogResult.Yes)
                {
                    DepositSlipEntities.DepositSlipHdr ObjDepositHdr = new DepositSlipEntities.DepositSlipHdr();
                    if (txtdepositgid.Text.ToString() == "") DepositGid = 0; else DepositGid = Int32.Parse(txtdepositgid.Text.ToString());
                    if (DepositGid != 0)
                    {
                        ObjDepositHdr.DepositGid = DepositGid;
                        ObjDepositHdr.DepositSlipNo = "";
                        ObjDepositHdr.DepositDate = dtpDepositDt.Value.ToString("yyyy-MM-dd"); ;
                        ObjDepositHdr.NoOfChqs = 0;
                        ObjDepositHdr.DepositAmount = 0;
                        ObjDepositHdr.ClientCode = "";
                        ObjDepositHdr.LocationCode = "";
                        ObjDepositHdr.AgentCode = "";
                        ObjDepositHdr.BankCode = "";
                        ObjDepositHdr.BranchName = "";
                        ObjDepositHdr.pickuppoint = "";
                        ObjDepositHdr.Mapped_Amount = 0;
                        ObjDepositHdr.Mapped_Chq = 0;
                        ObjDepositHdr.action_by = global_variable.user_name;
                        ObjDepositHdr.action = global_variable.action_delete;
                    }
                    DepositSlipBusiness  objBusiness = new DepositSlipBusiness ();
                    string[] result = objBusiness.SaveDepositSlip(ObjDepositHdr);
                    MessageBox.Show(result[0].ToString(), global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result[1].ToString() == "1")
                    {
                        if (DialogResult.Yes == MessageBox.Show("Do you want to add the record?", global_variable.proj_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            Clear();
                            LoadMasterDetails();
                            frmCreateUser_Load(sender, e);
                            pnlButtons.Hide();
                            pnlMain.Enabled = true;
                            pnlSave.Show();
                        }
                        else
                        {
                            Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            DataTable dtedit = new DataTable();
            DataSet dsedit = new DataSet();

            try
            {
                string tablename = "cms_trn_tdeposit";
                string fieldname = "deposit_gid as Id,deposit_date as 'Deposit Date',deposit_slip_no as 'Deposit Slip No',tot_chqs as 'Total Chq',deposit_amount as 'Deposit Amount'";
                string Where_condition = "delete_flag='N'";
                string oderby = "deposit_gid asc";
                string returnfld = "Id";
                frmFind formfind = new frmFind(tablename, fieldname, Where_condition, oderby, returnfld);
                formfind.ShowDialog();
                int gid = Convert.ToInt32(formfind.txt);
                DepositSlipEntities.DepositSlipHdr objdepositedit = new DepositSlipEntities.DepositSlipHdr();
                if (gid > 0)
                {
                    objdepositedit.DepositGid  = gid;
                    objdepositedit.DepositSlipNo  = "";
                    objdepositedit.DepositDate = dtpDepositDt.Value.ToString("yyyy-MM-dd"); ;
                    objdepositedit.NoOfChqs  = 0;
                    objdepositedit.DepositAmount = 0;
                    objdepositedit.ClientCode = "";
                    objdepositedit.LocationCode  = "";
                    objdepositedit.AgentCode  = "";
                    objdepositedit.BankCode  = "";
                    objdepositedit.BranchName  = "";
                    objdepositedit.pickuppoint = "";
                    objdepositedit.Mapped_Amount  = 0;
                    objdepositedit.Mapped_Chq  = 0;
                    objdepositedit.action_by = global_variable.user_name;
                    objdepositedit.action = global_variable.action_select;
                }

                DepositSlipBusiness objBusiness = new DepositSlipBusiness();
                dsedit = objBusiness.EditDepositHdr(objdepositedit);

                if (dsedit.Tables[0].Rows.Count > 0)
                {
                    DataRow rows = dtedit.NewRow();
                    txtdepositgid.Text = dsedit.Tables[0].Rows[0]["deposit_gid"].ToString();
                    dtpDepositDt.Text = dsedit.Tables[0].Rows[0]["Deposit_Date"].ToString();
                    txtDepositSlipNo .Text = dsedit.Tables[0].Rows[0]["deposit_slip_no"].ToString();
                    txtNoOfChq .Text = dsedit.Tables[0].Rows[0]["tot_chqs"].ToString();
                    txtAmount.Text = dsedit.Tables[0].Rows[0]["deposit_amount"].ToString();
                    cmbClientName.Text = dsedit.Tables[0].Rows[0]["Client_Name"].ToString();
                    cmbLocation.Text = dsedit.Tables[0].Rows[0]["Location_Name"].ToString();
                    DropdownloadPup();
                    cmbAgentName.Text = dsedit.Tables[0].Rows[0]["Agent_Name"].ToString();
                    cmbBankName.Text = dsedit.Tables[0].Rows[0]["Bank_Name"].ToString();
                    txtBankBranch.Text = dsedit.Tables[0].Rows[0]["bank_branch"].ToString();
                    cmbpup.Text = dsedit.Tables[0].Rows[0]["pp_code"].ToString();
                    dtAttachment = dsedit.Tables [1];
                    dgvReport.DataSource = dsedit.Tables[1];           
                }

                pnlMain.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void cmbBankName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DepositSlipBusiness ObjDeposit = new DepositSlipBusiness();
            if (cmbBankName .SelectedIndex > -1)
            {
                txtBankBranch.Text = ObjDeposit.GetBranchName (cmbBankName.SelectedValue.ToString());
            }
            else
            {
                txtBankBranch.Text = "";
            }
        }

        private void cmbBankName_Leave(object sender, EventArgs e)
        {
            DepositSlipBusiness ObjDeposit = new DepositSlipBusiness();
            if (cmbBankName.SelectedIndex > -1)
            {
                txtBankBranch.Text = ObjDeposit.GetBranchName(cmbBankName.SelectedValue.ToString());
            }
            else
            {
                txtBankBranch.Text = "";
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = "";
                openFileDialog1.ShowDialog();
                add_attachment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_attachment()
        {
            DataRow row;

            foreach (string file_name in openFileDialog1.FileNames)
            {
                if (File.Exists(file_name) == true)
                {
                    row = dtAttachment.NewRow();

                    row["Serial No"] = dtAttachment.Rows.Count + 1;
                    row["attachment_gid"] = 0;
                    row["File Name"] = file_name.Split('\\')[file_name.Split('\\').Length - 1];
                    row["File Path"] = file_name;

                    byte[] imageArray = System.IO.File.ReadAllBytes(file_name);
                    row["Attachment_image_str"] = Convert.ToBase64String(imageArray);

                    row["delete_flag"] = "N";

                    dtAttachment.Rows.Add(row);
                }
            }
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow row;
            string file_name = openFileDialog1.FileName;

            if (File.Exists(file_name) == true)
            {
                row = dtAttachment.NewRow();
                row["Serial No"] = dtAttachment.Rows.Count + 1;
                row["attachment_gid"] = 0;
                row["File Name"] = file_name.Split('\\')[file_name.Split('\\').Length - 1];
                row["File Path"] = file_name;

                byte[] imageArray = System.IO.File.ReadAllBytes(openFileDialog1.FileName);
                row["Attachment_image_str"] = Convert.ToBase64String(imageArray);               
             
                row["delete_flag"] = "N";

                dtAttachment.Rows.Add(row);
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;       
        }

        private void txtNoOfChq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

      

        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReport.Columns[e.ColumnIndex].HeaderText == "Delete" && e.RowIndex >= 0)
            {
                if (dtAttachment.Rows[e.RowIndex]["delete_flag"].ToString() == "N")
                {
                    if (MessageBox.Show("Are you sure to remove the attachment ?", global_variable.proj_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        dtAttachment.Rows[e.RowIndex]["delete_flag"] = "Y";
                        dgvReport.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                        dgvReport.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        private void frmDeposit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }
    }
}
