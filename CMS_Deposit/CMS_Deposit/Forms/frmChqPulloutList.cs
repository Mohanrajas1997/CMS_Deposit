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
    public partial class frmChqPulloutList : Form
    {
        DataTable dtChqList = new DataTable();
        int DepositGid = 0;

        public frmChqPulloutList(int depositgid)
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
            GetChqEntryView();
        }

        private void GetChqEntryView()
        {
            CMSEntryBusiness ObjCmsBusiness = new CMSEntryBusiness();

            if (DepositGid > 0)
            {
                DataGridViewButtonColumn objBtn = new DataGridViewButtonColumn();

                objBtn.Name = "btnPullout";
                objBtn.HeaderText = "Pullout";
                objBtn.Text = "Pullout";
                objBtn.UseColumnTextForButtonValue = true;
                objBtn.FlatStyle = FlatStyle.Popup;

                dtChqList.Rows.Clear();
                dtChqList = ObjCmsBusiness.GetChqPulloutList(DepositGid);
                gvchqview.Columns.Clear();
                gvchqview.DataSource = dtChqList;

                gvchqview.Columns["chq_gid"].Visible = false;
                gvchqview.Columns["deposit_gid"].Visible = false;
                gvchqview.Columns["pullout_gid"].Visible = false;
                
                gvchqview.Columns.Insert(0, objBtn);
            }
        }

        private void gvchqview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CMSEntities.ChqEntry_Model ObjChqHdr = new CMSEntities.ChqEntry_Model();
            if (e.ColumnIndex >= 0)
            {
                if (gvchqview.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex == 0)
                {
                    frmPulloutEntry frm = new frmPulloutEntry(Convert.ToInt32(gvchqview.CurrentRow.Cells["chq_gid"].Value.ToString()));
                    frm.ShowDialog();

                    GetChqEntryView();
                }
            }
        }

        private void gvchqview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
