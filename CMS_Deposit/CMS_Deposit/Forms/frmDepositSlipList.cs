using CMS_Deposit.Business;
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
    public partial class frmDepositSlipList : Form
    {
        string root = string.Empty;
        public string ConditionStatus = "";
        DataTable dtDepositQ = new DataTable();
        public frmDepositSlipList()
        {
            InitializeComponent();
            dtQueue.AutoGenerateColumns = true;
            dtQueue.EnableHeadersVisualStyles = false;
            dtQueue.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dtQueue.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void frmDepositQueue_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;

            set_grid_datacolumn_dipositQ();
            DropDown();
            string DepositFromdate = "";
            string DepositTodate = "";
            ConditionStatus = "";
            if (dtpDepositfrm.Checked == true)
            {
                DepositFromdate = dtpDepositfrm.Value.ToString("yyyy-MM-dd");
            }
            if (dtpDepositTo .Checked == true)
            {
                DepositTodate = dtpDepositTo.Value.ToString("yyyy-MM-dd");
            }
            if (DepositFromdate != "")
            {
                ConditionStatus = " and a.deposit_date >=" + "'" + DepositFromdate + "'";
            }

            if (DepositTodate != "")
            {
                if (ConditionStatus != "")
                {
                    ConditionStatus += " and a.deposit_date <=" + "'" + DepositTodate + "'";
                }
                else
                {
                    ConditionStatus = " and a.deposit_date <=" + "'" + DepositTodate + "'";
                }
            }

            LoadDepositQue(ConditionStatus);
            
        }

        private void set_grid_datacolumn_dipositQ()
        {
            if (dtDepositQ.Columns .Count ==0)
            {
                dtDepositQ.Columns.Add("deposit_gid", typeof(int));
                dtDepositQ.Columns.Add("deposit_date", typeof(string));
                dtDepositQ.Columns.Add("deposit_slip_no", typeof(string));
                dtDepositQ.Columns.Add("location_name", typeof(string));
                dtDepositQ.Columns.Add("agent_name", typeof(string));
                dtDepositQ.Columns.Add("client_name", typeof(string));
                dtDepositQ.Columns.Add("Bank_Name", typeof(string));
                dtDepositQ.Columns.Add("deposit_amount", typeof(int));
                dtDepositQ.Columns.Add("tot_chqs", typeof(int));
            }            
        
        }

        private void LoadDepositQue(string ConditionStatus)
        {
            try
            {
                DataGridViewButtonColumn objBtn = new DataGridViewButtonColumn();

                dtDepositQ.Rows.Clear();

                DepositSlipBusiness ObjInward = new DepositSlipBusiness();
                dtDepositQ = ObjInward.GetDepositQue(ConditionStatus);
                dtQueue.DataSource = dtDepositQ;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DropDown()
        {
            try
            {
                DepositSlipBusiness obj = new DepositSlipBusiness();
                DataSet ds = new DataSet();
                DataTable dtloc = new DataTable();
                DataTable dtAgent = new DataTable();

                ds = obj.GetDropDownDtls();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dtloc = ds.Tables[0];
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    dtAgent = ds.Tables[1];
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
                    cmbAgent.DataSource = dtAgent;
                    cmbAgent.DisplayMember = "qcd_name";
                    cmbAgent.ValueMember = "qcd_code";
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDepositQueue_Resize(object sender, EventArgs e)
        {
            dtQueue.Height = this.Height - dtQueue.Top - 40;
            dtQueue.Width = this.Width - 32;

        }

        private void btnref_Click(object sender, EventArgs e)
        {
            try
            {
                ConditionStatus = "";

                if(cmbLocation .SelectedIndex >0)
                {
                    ConditionStatus += "and a.loc_code=" + "'" + cmbLocation.SelectedValue.ToString() + "'";
                }

                if(cmbAgent .SelectedIndex >0)
                {
                    ConditionStatus += "and a.agent_code=" + "'" + cmbAgent.SelectedValue.ToString()  + "'";
                }
              
                if (dtpDepositfrm.Checked == true)
                {
                    ConditionStatus = " and a.deposit_date >=" + "'" + dtpDepositfrm.Value.ToString("yyyy-MM-dd")  + "'";
                }

                if (dtpDepositTo.Checked == true)
                {
                    ConditionStatus += " and a.deposit_date <=" + "'" + dtpDepositTo.Value.ToString("yyyy-MM-dd") + "'";
                }

                if (ConditionStatus == "") ConditionStatus = " and 1 = 2 ";

                LoadDepositQue(ConditionStatus);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void sc_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmDepositQueue_Load(sender, e);
        }

        private void btncls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtQueue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            { 
                int deposit_gid = 0;

                Int32.TryParse(dtQueue.Rows[e.RowIndex].Cells["deposit_gid"].Value.ToString(),out deposit_gid);

                frmChqPulloutList frm = new frmChqPulloutList(deposit_gid);
                frm.ShowDialog();
            }
        }
    }
}
