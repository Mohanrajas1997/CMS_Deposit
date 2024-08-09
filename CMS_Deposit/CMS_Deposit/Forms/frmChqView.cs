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
    public partial class frmChqView : Form
    {
        DataTable dtChequeQ = new DataTable();
        int DepositGid = 0;
        public frmChqView(int depositgid)
        {
            InitializeComponent();
            DepositGid = depositgid;
            gvchqview.AutoGenerateColumns = true;
            gvchqview.EnableHeadersVisualStyles = false;
            gvchqview.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            gvchqview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }


        private void frmChqView_Load(object sender, EventArgs e)
        {
            set_grid_datacolumn_dipositQ();

            GetChqEntryView();
        }

        private void GetChqEntryView()
        {
            CMSEntryBusiness ObjCmsBusiness = new CMSEntryBusiness();

            if (DepositGid > 0)
            {
                dtChequeQ.Rows.Clear();
                dtChequeQ = ObjCmsBusiness.GetChqEntryView(DepositGid);
                gvchqview.DataSource = dtChequeQ;
            }
        }
        private void set_grid_datacolumn_dipositQ()
        {
            if (dtChequeQ.Columns.Count == 0)
            {
                dtChequeQ.Columns.Add("chq_gid", typeof(int));
                dtChequeQ.Columns.Add("deposit_gid", typeof(int));
                dtChequeQ.Columns.Add("chq_date", typeof(string));
                dtChequeQ.Columns.Add("chq_no", typeof(string));
                dtChequeQ.Columns.Add("chq_amount", typeof(int));
                dtChequeQ.Columns.Add("acc_holder_name", typeof(string));
            }

        }

        private void gvchqview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CMSEntities.ChqEntry_Model ObjChqHdr = new CMSEntities.ChqEntry_Model();
            if (e.ColumnIndex >= 0)
            {
                if (gvchqview.Columns[e.ColumnIndex].Name == "edit")
                {
                    CMSEntities.ChqEntry_Model ObjChqDtls = new CMSEntities.ChqEntry_Model();

                    ObjChqDtls.deposit_gid = Convert.ToInt32(gvchqview.CurrentRow.Cells["deposit_gid"].Value.ToString());
                    ObjChqDtls.chq_gid = Convert.ToInt32(gvchqview.CurrentRow.Cells["chq_gid"].Value.ToString());
                    ObjChqDtls.chq_no = gvchqview.CurrentRow.Cells["chq_no"].Value.ToString();
                    ObjChqDtls.chq_date = gvchqview.CurrentRow.Cells["chq_date"].Value.ToString();
                    ObjChqDtls.chq_amount = Convert.ToInt32(gvchqview.CurrentRow.Cells["chq_amount"].Value.ToString());
                    ObjChqDtls.acc_holder = gvchqview.CurrentRow.Cells["acc_holder_name"].Value.ToString();

                    frmChqEntryView frm = new frmChqEntryView(ObjChqDtls);
                    frm.ShowDialog();
                    frmChqView_Load(sender, e);
                }
                else if (gvchqview.Columns[e.ColumnIndex].Name == "delete")
                {
                    DialogResult result = MessageBox.Show("Are You sure Want to Delete", global_variable.proj_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        ObjChqHdr.deposit_gid = Convert.ToInt32(gvchqview.CurrentRow.Cells["deposit_gid"].Value.ToString());
                        ObjChqHdr.chq_gid = Convert.ToInt32(gvchqview.CurrentRow.Cells["chq_gid"].Value.ToString());
                        ObjChqHdr.chq_no = "";
                        ObjChqHdr.chq_date = "";
                        ObjChqHdr.ref_no = "";
                        ObjChqHdr.ref_amount = 0;
                        ObjChqHdr.action = global_variable.action_delete;
                        ObjChqHdr.action_by = global_variable.user_name;

                        CMSEntryBusiness ObjCmsBusiness = new CMSEntryBusiness();
                        string[] result_dtl = ObjCmsBusiness.SaveCMSEntry(ObjChqHdr);
                        ObjChqHdr.msg = result_dtl[0].ToString();
                        ObjChqHdr.out_gid = Convert.ToInt32(result_dtl[2]);

                        if (result_dtl[1].ToString() == "0")
                        {
                            MessageBox.Show(result_dtl[0].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(result_dtl[0].ToString(), global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        frmChqView_Load(sender, e);
                    }

                }
                else if (gvchqview.Columns[e.ColumnIndex].Name == "EnrichMent")
                {
                    int chqGid = Convert.ToInt32(gvchqview.CurrentRow.Cells["chq_gid"].Value.ToString());
                    int Deposit_Gid = Convert.ToInt32(gvchqview.CurrentRow.Cells["deposit_gid"].Value.ToString());
                    frmEnrichmentView frm = new frmEnrichmentView(chqGid, Deposit_Gid);
                    frm.ShowDialog();
                    frmChqView_Load(sender, e);
                }
            }
        }
    }
}
