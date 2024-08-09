using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMS_Deposit.Common;
using CMS_Deposit.Business;

namespace CMS_Deposit.Reports
{
    public partial class frmUserLog : Form
    {
        public frmUserLog()
        {
            InitializeComponent();
        }

        private void frmUserLog_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;

            cboRptType.Items.Clear();
            cboRptType.Items.Add("Login History");
            cboRptType.Items.Add("Login Attempt");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtpFrom.Checked = false;
            dtpTo.Checked = false;
            cboRptType.SelectedIndex = -1;
            cboRptType.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            btnRefresh.Enabled = false;

            load_data();

            btnRefresh.Enabled = true;
            this.Cursor = System.Windows.Forms.Cursors.Default;
            btnRefresh.Focus();
        }

        private void load_data()
        { 
            string sql = "";
            string cond = "";
            DateTime date;
            ReportBusiness objBuss = new ReportBusiness();
            DataTable dt = new DataTable();

            try
            {
                date = dtpFrom.Value;

                if (dtpFrom.Checked) cond = cond + " and a.login_date >= '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' ";
                if (dtpTo.Checked) cond = cond + " and a.login_date <= '" + dtpTo.Value.ToString("yyyy-MM-dd") + "' ";

                if (cboRptType.Text == "Login History")
                {
                    sql = "";
                    sql += " select a.login_date as 'Login Date',b.user_code as 'User Code',a.system_ip as 'System IP' ";
                    sql += " from soft_trn_tloginhistory as a,soft_mst_tuser as b ";
                    sql += " where 1 = 1 ";
                    sql += " and b.user_gid = a.user_gid ";
                    sql += cond;
                    sql += " and a.delete_flag = 'N' ";
                    sql += " and b.delete_flag = 'N' ";
                }
                else if (cboRptType.Text == "Login Attempt")
                {
                    sql = "";
                    sql += " select a.login_date as 'Login Date',a.user_code as 'User Code',a.system_ip as 'System IP' ";
                    sql += " from soft_trn_tloginattempt as a ";
                    sql += " where 1 = 1 ";
                    sql += cond;
                    sql += " and a.delete_flag = 'N' ";
                }

                if (sql != "")
                {
                    dgvReport.DataSource = null;
                    dt = objBuss.GetQryOutput(sql);
                    dgvReport.DataSource = dt;

                    txtTotRec.Text = "Total Records : " + dt.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,global_variable.proj_name,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void frmUserLog_Resize(object sender, EventArgs e)
        {
            dgvReport.Width = this.Width - 32;
            dgvReport.Height = this.Height - (dgvReport.Top + pnlExport.Height + 48);

            pnlExport.Left = dgvReport.Left;
            pnlExport.Top = dgvReport.Top + dgvReport.Height + 8;
            pnlExport.Width = dgvReport.Width;
            btnExport.Left = pnlExport.Width - btnExport.Width;
            txtTotRec.Left = 0;
        }
    }
}
