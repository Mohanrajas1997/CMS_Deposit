using CMS_Deposit.Business;
using CMS_Deposit.Common;
using CMS_Deposit.Forms;
using CMS_Deposit.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CMS_Deposit
{
    public partial class frmMain : Form
    {
        string user_name = "";
        int UserId = 0;
        int Usergroupid = 0;
        string Password = "";
        public frmMain()
        {
            InitializeComponent();
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCreateUser frmcrtuser = new frmCreateUser(user_name);
                frmcrtuser.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                frmCreateGroup frmcrtgroup = new frmCreateGroup();
                frmcrtgroup.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void userVsGroupMappingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUserGroupMapping frmusermap = new frmUserGroupMapping(menuStrip2);
                frmusermap.ShowDialog();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void userLogToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void entityToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accountingYearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accountHeadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ledgerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void voucherTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void qCDMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmQuickCodeList frmqcdmst = new frmQuickCodeList();
                frmqcdmst.MdiParent = this;
                frmqcdmst.Show();
                frmqcdmst.WindowState = FormWindowState.Normal;
                frmqcdmst.WindowState = FormWindowState.Maximized;
                frmqcdmst.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void voucherClosingDateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openingEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void scheduleTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ledgerExtractToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trailBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profitLoseACToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuCashFlowReport_Click(object sender, EventArgs e)
        {

        }

        private void transactionToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void paToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void reportsMisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblFinYear_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnSelectEntity_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PickupEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPickupEntry Objfrm = new frmPickupEntry();
                Objfrm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuDepositSlipEntry_Click(object sender, EventArgs e)
        {
            try
            {
                frmDeposit Objfrm = new frmDeposit();
                Objfrm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuCMSEntryQueue_Click(object sender, EventArgs e)
        {
            try
            {
                frmDepositQueue Objfrm = new frmDepositQueue();
                Objfrm.MdiParent = this;
                Objfrm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuClearingDump_Click(object sender, EventArgs e)
        {
            try
            {
                frmClearingImport Objfrm = new frmClearingImport();
                Objfrm.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuDeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                frmDeleteFile Objfrm = new frmDeleteFile();
                Objfrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuPosting_Click(object sender, EventArgs e)
        {
            try
            {
                frmPostClearing Objfrm = new frmPostClearing("POSTING");
                Objfrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuUnPosting_Click(object sender, EventArgs e)
        {
            try
            {
                frmPostClearing Objfrm = new frmPostClearing("UNPOSTING");
                Objfrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuUpload_Click(object sender, EventArgs e)
        {
            try
            {
                frmUpload Objfrm = new frmUpload();
                Objfrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuReUpload_Click(object sender, EventArgs e)
        {
            try
            {
                frmReUpload Objfrm = new frmReUpload("REUPLOAD");
                Objfrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void mnuDeleteUpload_Click(object sender, EventArgs e)
        {
            try
            {
                frmReUpload Objfrm = new frmReUpload("DELETEUPLOAD");
                Objfrm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuDepositRpt_Click(object sender, EventArgs e)
        {
            try
            {
                frmDepositRpt frmPay = new frmDepositRpt();
                frmPay.MdiParent = this;
                frmPay.Show();
                frmPay.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuClearingRpt_Click(object sender, EventArgs e)
        {
            try
            {
                frmClearingRpt frmPay = new frmClearingRpt();
                frmPay.MdiParent = this;
                frmPay.Show();
                frmPay.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuChqReport_Click(object sender, EventArgs e)
        {
            try
            {
                frmChequeRpt frmPay = new frmChequeRpt();
                frmPay.MdiParent = this;
                frmPay.Show();
                frmPay.WindowState = FormWindowState.Maximized;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuEnrichmentRpt_Click(object sender, EventArgs e)
        {
            try
            {
                frmEnrichmentRpt frmPay = new frmEnrichmentRpt();
                frmPay.MdiParent = this;
                frmPay.Show();
                frmPay.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuUploadRpt_Click(object sender, EventArgs e)
        {
            try
            {
                frmUploadRpt frmPay = new frmUploadRpt();
                frmPay.MdiParent = this;
                frmPay.Show();
                frmPay.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fileReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmFileRpt frmPay = new frmFileRpt();
                frmPay.MdiParent = this;
                frmPay.Show();
                frmPay.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                string report_path = "", file_path = "";
                bool test_flag = false;
                Dataconnection con = new Dataconnection();
                global_variable.con = con;

                MenuStrip ms = new MenuStrip();

                if (!test_flag) Main();                

                lblLoginUser.Text = "Welcome " + global_variable.user_name;

                user_name = global_variable.user_code ;
                UserId = global_variable.UserId;
                Usergroupid = global_variable.Usergroupid;
                Password = global_variable.Password;

                if (user_name != "Admin")
                {
                    if (Usergroupid > 0)
                    {
                        ms = this.menuStrip2;
                        for (int i = 0; i < ms.Items.Count; i++)
                        {
                            Application.DoEvents();
                            LoadSubMenuItems(ms.Items[i]);

                        }
                    }
                }

                // report file path
                file_path = Application.StartupPath + @"\" + global_variable.user_code + @"\";
                if (Directory.Exists(file_path) == false) Directory.CreateDirectory(file_path);

                report_path = file_path + @"report\";
                if (Directory.Exists(report_path) == false) Directory.CreateDirectory(report_path);
                global_variable.report_path = report_path;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Main()
        {
            try
            {
                frmLogin frm = new frmLogin();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadSubMenuItems(ToolStripItem toolStripItem)
        {
            try
            {
                ToolStripDropDownItem drp = (ToolStripDropDownItem)toolStripItem;
                int RightsCount = 0;
                string menuname = toolStripItem.Name;
                AdminBusiness Obj_GetUserRights = new AdminBusiness();
                DataTable dt = new DataTable();
                dt = Obj_GetUserRights.GetUserMenuAccess(menuname, UserId, Usergroupid, user_name, Password);
                if (dt.Rows.Count > 0)
                {
                    RightsCount = Convert.ToInt16(dt.Rows[0]["Rights_count"]);
                }
                if (RightsCount > 0)
                {
                    for (int i = 0; i < drp.DropDownItems.Count; i++)
                    {
                        if (drp.DropDownItems[i].Text != "")
                        {
                            Application.DoEvents();
                            LoadSubMenuItems(drp.DropDownItems[i]);
                        }
                    }
                }
                else
                {
                    toolStripItem.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuPulloutEntry_Click(object sender, EventArgs e)
        {
            try
            {
                frmDepositSlipList Objfrm = new frmDepositSlipList();
                Objfrm.MdiParent = this;
                Objfrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close all child forms of the parent.
            foreach (Form childform in this.MdiChildren)
                childform.Close();
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void userLogToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmUserLog frm = new frmUserLog();
                frm.MdiParent = this;
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuUserAdmin_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnChangePwd_Click_1(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }

        private void tsbtnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void mnufinnnaxiaRpt_Click(object sender, EventArgs e)
        {
            try
            {
                frmFinnaxiaRpt frmfin = new frmFinnaxiaRpt();
                frmfin.MdiParent = this;
                frmfin.Show();
                frmfin.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
