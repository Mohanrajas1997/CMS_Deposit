using CMS_Deposit.Business;
using CMS_Deposit.Common;
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
    public partial class frmPostClearing : Form
    {
        string Screen_Name = "";

        public frmPostClearing(string MnuForm)
        {
            InitializeComponent();
            Screen_Name = MnuForm;

            if (Screen_Name.ToUpper() == "POSTING")
            {
                this.Text = "Post Clearing";
            }
            else if (Screen_Name.ToUpper() == "UNPOSTING")
            {
                this.Text = "Undo Clearing Posting";
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string status = "";
            AdminBusiness ObjBusiness = new AdminBusiness();

            try
            {
                DataTable dtclearing = new DataTable();

                string ChqFromdt = dtpFrom.Value.ToString("yyyy-MM-dd");
                string ChqTodt = dtpTo.Value.ToString("yyyy-MM-dd");

                if (Screen_Name.ToUpper() == "POSTING")
                {
                    dtclearing = ObjBusiness.GetClearingDtls(ChqFromdt, ChqTodt);
                    
                    int k = 0;

                    if (dtclearing.Rows.Count > 0)
                    {
                        lblStatus.Visible = true;
                        for (int i = 0; i < dtclearing.Rows.Count; i++)
                        {
                            int clrg_gid = Convert.ToInt32(dtclearing.Rows[i]["clrg_gid"].ToString());
                            string Client_Code = dtclearing.Rows[i]["client_code"].ToString();
                            string Chq_Date = dtclearing.Rows[i]["chq_date"].ToString();
                            string Chq_No = dtclearing.Rows[i]["chq_no"].ToString();
                            double Chq_Amt = Convert.ToDouble(dtclearing.Rows[i]["chq_amount"].ToString());

                            string[] result = ObjBusiness.SetPostingCheques(clrg_gid, Client_Code, Chq_Date, Chq_No, Chq_Amt);

                            if (result[1].ToString() == "1")
                            {
                                k++;
                            }

                            status = String.Concat("Out of ", dtclearing.Rows.Count, " record(s) ", k, " record(s) posted ! ");
                            lblStatus.Text = status;
                        }

                        MessageBox.Show(status, global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (Screen_Name.ToUpper() == "UNPOSTING")
                {
                    string[] result = ObjBusiness.SetUnPostingCheques(ChqFromdt, ChqTodt);
                    
                    MessageBox.Show(result[0].ToString(), global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPostClearing_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;

            lblStatus.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
