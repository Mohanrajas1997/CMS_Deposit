using CMS_Deposit.Business;
using CMS_Deposit.Common;
using CMS_Deposit.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS_Deposit.Forms
{
    public partial class frmPickupEntry : Form
    {
        DataTable dtPickup = new DataTable();
        frmPickupPoint  formPickupPoint;
        int id = 0;
        public frmPickupEntry()
        {
            InitializeComponent();
            gvPickupPoint.AutoGenerateColumns = true;
            gvPickupPoint.EnableHeadersVisualStyles = false;
            gvPickupPoint.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            gvPickupPoint.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void frmPickupEntry_Load(object sender, EventArgs e)
        {
            KeyPreview = true;

            set_grid_datacolumn_pickup();
            Disable();
            PickupBusiness objpickup = new PickupBusiness();
            DataTable dtloc = new DataTable();
            DataTable dtagent = new DataTable();

            dtloc = objpickup.GetLocationDtls();
            if (dtloc.Rows.Count > 0)
            {
                DataRow rows = dtloc.NewRow();
                rows["qcd_name"] = "--Select--";
                dtloc.Rows.InsertAt(rows, 0);
                cmbLocation.DataSource = dtloc;
                cmbLocation.DisplayMember = "qcd_name";
                cmbLocation.ValueMember = "qcd_code";
                //cmbLocation.Text = dtloc.Rows[0]["qcd_name"].ToString();
            }
            else
            {
                cmbLocation.Text = " ";
            }

            dtagent = objpickup.GetAgentDtls();
            if(dtagent .Rows .Count >0)
            {
                DataRow rows = dtagent.NewRow();
                rows["qcd_name"] = "--Select--";
                dtagent.Rows.InsertAt(rows, 0);
                cmbAgent.DataSource = dtagent;
                cmbAgent.DisplayMember = "qcd_name";
                cmbAgent.ValueMember = "qcd_code";
                //cmbAgent.Text = dtagent.Rows[0]["qcd_name"].ToString();
            }
            else
            {
                cmbAgent.Text = " ";
            }
        }
        private void set_grid_datacolumn_pickup()
        {
            dtPickup.Columns.Add("PickupdtlsGid", typeof(int));
            dtPickup.Columns.Add("Pickup_Gid", typeof(int));
            dtPickup.Columns.Add("qcd_client_code", typeof(string));
            dtPickup.Columns.Add("Client_Code", typeof(string));
            dtPickup.Columns.Add("ClientName", typeof(string));
            dtPickup.Columns.Add("qcd_pickup_code", typeof(string));
            dtPickup.Columns.Add("pickuppoint", typeof(string));
            dtPickup.Columns.Add("Tot_chqs", typeof(string));
            dtPickup.Columns.Add("Client_Ack", typeof(string));          
            dtPickup.Columns.Add("SaveFlag", typeof(string));
            dtPickup.Columns.Add("DeleteFlag", typeof(string));
        }
        public void Disable()
        {
            dtpPickupDate.Enabled = false;
            cmbLocation.Enabled = false;
            cmbAgent.Enabled = false;
            btnpickupentry.Enabled = false;          

        }

        private void btnpickupentry_Click(object sender, EventArgs e)
        {
            try
            {
                PickupPoint_Model.PickupPointDtls add_pickuppoint = new PickupPoint_Model.PickupPointDtls();
                formPickupPoint = new frmPickupPoint(add_pickuppoint);
                formPickupPoint.ShowDialog();
                add_pickuppoint = formPickupPoint.ObjPickupPoint;

                if (add_pickuppoint.save_flag == "Y")
                {
                    DataRow row = dtPickup.NewRow();

                    row["PickupdtlsGid"] = add_pickuppoint.pickupdtl_gid;
                    row["Pickup_Gid"] = add_pickuppoint.pickup_gid;
                    row["qcd_client_code"] = add_pickuppoint.qcd_client_code;
                    row["Client_Code"] = add_pickuppoint.client_code;
                    row["ClientName"] = add_pickuppoint.client_name ;
                    row["qcd_pickup_code"] = add_pickuppoint.qcd_pickup_code;
                    row["pickuppoint"] = add_pickuppoint.pickup_point;
                    row["Tot_chqs"] = add_pickuppoint.tot_chq;
                    row["Client_Ack"] = add_pickuppoint.client_ack;                   
                    row["SaveFlag"] = add_pickuppoint.save_flag;
                    row["DeleteFlag"] = add_pickuppoint.delete_flag;

                    dtPickup.Rows.Add(row);
                    gvPickupPoint.DataSource = dtPickup;
                    gvPickupPoint.Refresh();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntnew_Click(object sender, EventArgs e)
        {
            Enable();
            Clear();
            pnlbtnaccprd.Hide();
            pnlsaveedit.Show();
            dtpPickupDate.Focus();
        }
        public void Enable()
        {
            dtpPickupDate.Enabled = true;
            cmbLocation .Enabled = true;
            cmbAgent.Enabled = true;
            btnpickupentry.Enabled = true;          
        }

        public void Clear()
        {
            txtPickEntryGid.Clear();
            dtpPickupDate.Value = DateTime.Now;
            cmbLocation.ResetText();
            cmbAgent.ResetText();
            dtPickup.Rows.Clear();       
        }

        private void btnedt_Click(object sender, EventArgs e)
        {
            if (txtPickEntryGid.Text == "")
            {
                MessageBox.Show("select some Record to Edit", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Enable();

            pnlbtnaccprd.Hide();
            pnlsaveedit.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            pnlbtnaccprd.Show();
            pnlsaveedit.Hide();
            Clear();
        }

        private void btnsve_Click(object sender, EventArgs e)
        {
            try
            {
                string Client_Ack = "";
                if (txtPickEntryGid.Text.ToString() == "") id = 0; else id = Int32.Parse(txtPickEntryGid.Text.ToString());
                DataTable dtentyhead = new DataTable();
                PickupPoint_Model.PickupPointHdr ObjHdr = new PickupPoint_Model.PickupPointHdr();
                
                    ObjHdr.pickupentry_gid  = id;
                    ObjHdr.pickup_date = dtpPickupDate.Value.ToString("yyyy-MM-dd");
                    ObjHdr.pickup_loc_code = cmbLocation.SelectedValue.ToString().Trim();
                    ObjHdr.agent_code  = cmbAgent.SelectedValue.ToString();

                    if (id == 0)
                    {
                        ObjHdr.action = global_variable.action_insert;
                    }
                    else
                    {
                        ObjHdr.action = global_variable.action_update;
                    }

                    ObjHdr.action_by = global_variable.user_name;

                    PickupBusiness objBusiness = new PickupBusiness();
                    string[] result = objBusiness.SavePickupHeader (ObjHdr);
                    ObjHdr.msg = result[0].ToString();
                    ObjHdr.out_gid = Convert.ToInt32(result[2]);
                    if (id == 0)
                    {
                        ObjHdr.pickupentry_gid  = ObjHdr.out_gid;
                    }
                    DataTable dtentyaddr = new DataTable();
                    PickupPoint_Model.PickupPointDtls objpickupadd = new PickupPoint_Model.PickupPointDtls();
                    if (gvPickupPoint.RowCount > 0)
                    {
                        foreach (DataGridViewRow rows in gvPickupPoint.Rows)
                        {
                            if (rows.Cells["Client_Ack"].Value.ToString().ToUpper() == "YES")
                            {
                                Client_Ack = "Y";
                            }
                            else
                            {
                                Client_Ack = "N";
                            }

                            if (Int32.Parse(rows.Cells["PickupdtlsGid"].Value.ToString()) == 0)
                            {

                                objpickupadd.pickup_gid = ObjHdr.out_gid;
                                objpickupadd.pickupdtl_gid = Convert.ToInt32(rows.Cells["PickupdtlsGid"].Value.ToString());
                                objpickupadd.qcd_client_code = rows.Cells["qcd_client_code"].Value.ToString();
                                objpickupadd.qcd_pickup_code = rows.Cells["qcd_pickup_code"].Value.ToString();
                                objpickupadd.tot_chq = Convert .ToInt32 (rows.Cells["Tot_chqs"].Value.ToString());
                                objpickupadd.client_ack = Client_Ack;
                                objpickupadd.action = global_variable.action_insert;
                                objpickupadd.action_by = global_variable.user_name;
                                result = objBusiness.SavePickupDetails(objpickupadd);

                            }
                            if (Int32.Parse(rows.Cells["PickupdtlsGid"].Value.ToString()) != 0 && rows.Cells["dltflag"].Value.ToString() != "Y")
                            {

                                objpickupadd.pickup_gid = ObjHdr.out_gid;
                                objpickupadd.pickupdtl_gid = Convert.ToInt32(rows.Cells["PickupdtlsGid"].Value.ToString());
                                objpickupadd.qcd_client_code = rows.Cells["qcd_client_code"].Value.ToString();
                                objpickupadd.qcd_pickup_code = rows.Cells["qcd_pickup_code"].Value.ToString();
                                objpickupadd.tot_chq = Convert.ToInt32(rows.Cells["Tot_chqs"].Value.ToString());
                                objpickupadd.client_ack = Client_Ack;
                                objpickupadd.action = global_variable.action_update;
                                objpickupadd.action_by = global_variable.user_name;
                                result = objBusiness.SavePickupDetails(objpickupadd);
                            }
                            if (Int32.Parse(rows.Cells["PickupdtlsGid"].Value.ToString()) != 0 && rows.Cells["dltflag"].Value.ToString() == "Y")
                            {

                                objpickupadd.pickup_gid = ObjHdr.out_gid;
                                objpickupadd.pickupdtl_gid = Convert.ToInt32(rows.Cells["PickupdtlsGid"].Value.ToString());
                                objpickupadd.qcd_client_code = rows.Cells["qcd_client_code"].Value.ToString();
                                objpickupadd.qcd_pickup_code = rows.Cells["qcd_pickup_code"].Value.ToString();
                                objpickupadd.tot_chq = Convert.ToInt32(rows.Cells["Tot_chqs"].Value.ToString());
                                objpickupadd.client_ack = Client_Ack;
                                objpickupadd.action = global_variable.action_delete;
                                objpickupadd.action_by = global_variable.user_name;
                                result = objBusiness.SavePickupDetails(objpickupadd);
                            }
                        }

                    }

                    MessageBox.Show("Record Saved Successfully", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    dtPickup.Rows.Clear();                   
                    pnlbtnaccprd.Show();
                    pnlsaveedit.Hide();
                    Enable();
            }
            catch(Exception ex)
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
                string tablename = "cms_trn_tpickup as a inner join cms_mst_tquickcode as b on a.loc_code=b.qcd_code and b.delete_flag='N' inner join cms_mst_tquickcode as c on a.agent_code=c.qcd_code and c.delete_flag='N'";
                string fieldname = "pickup_gid as 'Pickup Id',pickup_date as 'Pickup Date',b.qcd_name as 'Location',c.qcd_name as 'Agent'";
                string Where_condition = "a.delete_flag='N' ";
                string oderby = "pickup_gid asc";
                string returnfld = "Pickup Id";
                frmFind formfind = new frmFind(tablename, fieldname, Where_condition, oderby, returnfld);
                formfind.ShowDialog();
                int gid = Convert.ToInt32(formfind.txt);
                PickupPoint_Model.PickupPointHdr objheaderedit = new PickupPoint_Model.PickupPointHdr();
                if (gid > 0)
                {
                    objheaderedit.pickupentry_gid  = gid;
                    objheaderedit.pickup_loc_code  = "";
                    objheaderedit.agent_code  = "";
                    objheaderedit.pickup_date = dtpPickupDate .Value.ToString("yyyy-MM-dd");                   
                    objheaderedit.action = global_variable.action_select;
                    objheaderedit.action_by = global_variable.user_name;
                }
                PickupBusiness objBusiness = new PickupBusiness();
                dsedit = objBusiness.EditPickupHeader(objheaderedit);
                if (dsedit.Tables.Count > 1)
                {
                    DataRow rows = dtedit.NewRow();
                    txtPickEntryGid.Text = dsedit.Tables[0].Rows[0]["pickup_gid"].ToString();
                    dtpPickupDate.Text = dsedit.Tables[0].Rows[0]["Pickup_Date"].ToString();
                    cmbLocation.Text = dsedit.Tables[0].Rows[0]["loc_name"].ToString();
                    cmbAgent.Text = dsedit.Tables[0].Rows[0]["agent_desc"].ToString();                   
                  
                    dtPickup = dsedit.Tables[1];             

                    gvPickupPoint.DataSource = dsedit.Tables[1];                   

                }
                Disable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPickEntryGid.Text == "" || txtPickEntryGid .Text == "0")
                {
                    MessageBox.Show("select some Record to Delete", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DialogResult Dialog = MessageBox.Show("Are you sure delete the record?", global_variable.proj_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dialog == DialogResult.Yes)
                {
                    DataTable dtentyhead = new DataTable();
                    PickupPoint_Model.PickupPointHdr objentyhead = new PickupPoint_Model.PickupPointHdr();
                    if (txtPickEntryGid.Text.ToString() == "") id = 0; else id = Int32.Parse(txtPickEntryGid.Text.ToString());
                    if (id > 0)
                    {
                        objentyhead.pickupentry_gid  = id;
                        objentyhead.pickup_date = dtpPickupDate.Value.ToString("yyyy-MM-dd");
                        objentyhead.pickup_loc_code = cmbLocation.SelectedValue.ToString();
                        objentyhead.agent_code  = cmbAgent.SelectedValue.ToString();                       
                        objentyhead.out_gid = 0;
                        objentyhead.action = global_variable.action_delete;
                        objentyhead.action_by = global_variable.user_name;
                        PickupBusiness objBusiness = new PickupBusiness();
                        string[] result = objBusiness.SavePickupHeader(objentyhead);
                        objentyhead.msg = result[0].ToString();
                        MessageBox.Show(result[0].ToString(), global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (objentyhead.msg == "Record deleted successfully")
                    {

                        pnlbtnaccprd.Show();
                        pnlsaveedit.Hide();
                        Clear();
                        Disable();
                        dtPickup.Rows.Clear();             


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvPickupPoint_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (gvPickupPoint .Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex == 0)
                {
                    PickupPoint_Model.PickupPointDtls ObjPickupDtl = new PickupPoint_Model.PickupPointDtls();

                    ObjPickupDtl.pickupdtl_gid = Convert.ToInt32(gvPickupPoint.CurrentRow.Cells["PickupdtlsGid"].Value.ToString());
                    ObjPickupDtl.pickup_gid = Convert.ToInt32(gvPickupPoint.CurrentRow.Cells["Pickup_Gid"].Value.ToString());
                    ObjPickupDtl.qcd_client_code = gvPickupPoint.CurrentRow.Cells["qcd_client_code"].Value.ToString();
                    ObjPickupDtl.client_code = gvPickupPoint.CurrentRow.Cells["Client_Code"].Value.ToString();
                    ObjPickupDtl.client_name = gvPickupPoint.CurrentRow.Cells["ClientName"].Value.ToString();
                    ObjPickupDtl.qcd_pickup_code = gvPickupPoint.CurrentRow.Cells["qcd_pickup_code"].Value.ToString();
                    ObjPickupDtl.pickup_point = gvPickupPoint.CurrentRow.Cells["pickuppoint"].Value.ToString();
                    ObjPickupDtl.tot_chq = Convert.ToInt32(gvPickupPoint.CurrentRow.Cells["Tot_chqs"].Value.ToString());
                    ObjPickupDtl.client_ack = gvPickupPoint.CurrentRow.Cells["Client_Ack"].Value.ToString();
                    ObjPickupDtl.save_flag = "N";
                   
                    frmPickupPoint frm = new frmPickupPoint(ObjPickupDtl);
                    frm.ShowDialog();
                    ObjPickupDtl = frm.ObjPickupPoint;

                    if (ObjPickupDtl.save_flag == "Y")
                    {
                        DataRow row = dtPickup.Rows[e.RowIndex];

                        row["PickupdtlsGid"] = ObjPickupDtl.pickupdtl_gid ;
                        row["Pickup_Gid"] = ObjPickupDtl.pickup_gid ;
                        row["qcd_client_code"] = ObjPickupDtl.qcd_client_code ;
                        row["Client_Code"] = ObjPickupDtl.client_code ;
                        row["ClientName"] = ObjPickupDtl.client_name ;
                        row["qcd_pickup_code"] = ObjPickupDtl.qcd_pickup_code ;
                        row["pickuppoint"] = ObjPickupDtl.pickup_point;
                        row["Tot_chqs"] = ObjPickupDtl.tot_chq ;
                        row["Client_Ack"] = ObjPickupDtl.client_ack ;
                        row["SaveFlag"] = ObjPickupDtl.save_flag;
                    }
                }
                if (gvPickupPoint.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex == 1)
                {
                    DialogResult result = MessageBox.Show("Are you sure to delete ?", global_variable.proj_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DataRow row = dtPickup.Rows[e.RowIndex];
                        row["DeleteFlag"] = "Y";
                        gvPickupPoint.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
                    }
                    if (result == DialogResult.No)
                    {
                        DataRow row = dtPickup.Rows[e.RowIndex];
                        row["DeleteFlag"] = "N";
                        gvPickupPoint.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }

        private void pnlsaveedit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPickupEntry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }
    }
}
