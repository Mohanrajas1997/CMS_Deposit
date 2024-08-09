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
    public partial class frmEnrichmentView : Form
    {
         DataTable dtChequeQ = new DataTable();
        int ChqGid = 0;
        int DepositGid = 0;
        public frmEnrichmentView(int chqgid, int Deposit_Gid)
        {
            InitializeComponent();
            ChqGid = chqgid;
            DepositGid = Deposit_Gid;
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

            if (ChqGid > 0)
            {
                dtChequeQ.Rows.Clear();
                dtChequeQ = ObjCmsBusiness.GetEnrichmentView(ChqGid);
                gvchqview.DataSource = dtChequeQ;
            }
        }
        private void set_grid_datacolumn_dipositQ()
        {
            if (dtChequeQ.Columns.Count == 0)
            {
                dtChequeQ.Columns.Add("enrich_gid", typeof(int));
                dtChequeQ.Columns.Add("deposit_gid", typeof(int));
                dtChequeQ.Columns.Add("chq_gid", typeof(int));
                dtChequeQ.Columns.Add("ref_no", typeof(string));
                dtChequeQ.Columns.Add("ref_amount", typeof(int));
            }          

        }

        private void gvchqview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CMSEntities.ChqEntry_Model ObjChqHdr = new CMSEntities.ChqEntry_Model();
            if (e.ColumnIndex >= 0)
            {
                if (gvchqview.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex == 0)
                {


                    ObjChqHdr.deposit_gid = Convert.ToInt32(gvchqview.CurrentRow.Cells["deposit_gid"].Value.ToString());
                    ObjChqHdr.chq_gid = Convert.ToInt32(gvchqview.CurrentRow.Cells["chq_gid"].Value.ToString());
                    ObjChqHdr.enrichment_gid = Convert.ToInt32(gvchqview.CurrentRow.Cells["enrich_gid"].Value.ToString());
                    ObjChqHdr.ref_no = gvchqview.CurrentRow.Cells["ref_no"].Value.ToString();
                    ObjChqHdr.ref_amount = Convert.ToInt32(gvchqview.CurrentRow.Cells["ref_amount"].Value.ToString());

                    frmEnrichmentEntry frm = new frmEnrichmentEntry(ObjChqHdr);
                    frm.ShowDialog();
                    frmChqView_Load(sender,e);
                }
                else if (gvchqview.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex == 1)
                {
                    DialogResult result = MessageBox.Show("Are You sure Want to Delete", global_variable.proj_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        ObjChqHdr.deposit_gid = Convert.ToInt32(gvchqview.CurrentRow.Cells["deposit_gid"].Value.ToString());
                        ObjChqHdr.chq_gid = Convert.ToInt32(gvchqview.CurrentRow.Cells["chq_gid"].Value.ToString());
                        ObjChqHdr.enrichment_gid = Convert.ToInt32(gvchqview.CurrentRow.Cells["enrich_gid"].Value.ToString());
                        ObjChqHdr.chq_no = "";
                        ObjChqHdr.chq_date = "";
                        ObjChqHdr.ref_no = "";
                        ObjChqHdr.ref_amount = 0;
                        ObjChqHdr.action = global_variable.action_delete ;
                        ObjChqHdr.action_by = global_variable.user_name;

                        CMSEntryBusiness ObjCmsBusiness = new CMSEntryBusiness();
                        string[] result_dtl = ObjCmsBusiness.SaveEnrichMent(ObjChqHdr);
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
            }
        }

        private void btnEnrichmentEntry_Click(object sender, EventArgs e)
        {
            try
            {
                CMSEntities.ChqEntry_Model ObjChqHdr = new CMSEntities.ChqEntry_Model();
                ObjChqHdr.chq_gid = ChqGid;
                ObjChqHdr.deposit_gid = DepositGid;
                ObjChqHdr.ref_no = "";
                ObjChqHdr.ref_amount = 0;
                ObjChqHdr.enrichment_gid = 0;

                frmEnrichmentEntry frm = new frmEnrichmentEntry(ObjChqHdr);
                frm.ShowDialog();
                frmChqView_Load(sender, e);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
