namespace CMS_Deposit
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnuUserAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userVsGroupMappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qCDMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PickupEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDepositSlipEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCMSEntryQueue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearingDump = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPosting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnPosting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPulloutEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuUpload = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReUpload = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteUpload = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDeleteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsMisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDepositRpt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChqReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearingRpt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnrichmentRpt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUploadRpt = new System.Windows.Forms.ToolStripMenuItem();
            this.fileReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPoweredBy = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNafLogo = new System.Windows.Forms.ToolStripStatusLabel();
            this.imgLst = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.lblLoginUser = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnChangePwd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDashboard = new System.Windows.Forms.ToolStripButton();
            this.mnufinnnaxiaRpt = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUserAdmin,
            this.maintenanceToolStripMenuItem,
            this.toolStripMenuItem1,
            this.reportsMisToolStripMenuItem,
            this.WindowsMenu});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.MdiWindowListItem = this.WindowsMenu;
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1364, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked_1);
            // 
            // mnuUserAdmin
            // 
            this.mnuUserAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnuUserAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem,
            this.createGroupToolStripMenuItem,
            this.userVsGroupMappingToolStripMenuItem,
            this.userLogToolStripMenuItem});
            this.mnuUserAdmin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.mnuUserAdmin.Image = ((System.Drawing.Image)(resources.GetObject("mnuUserAdmin.Image")));
            this.mnuUserAdmin.Name = "mnuUserAdmin";
            this.mnuUserAdmin.Size = new System.Drawing.Size(148, 20);
            this.mnuUserAdmin.Text = "User Administration";
            this.mnuUserAdmin.Click += new System.EventHandler(this.mnuUserAdmin_Click);
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createUserToolStripMenuItem.Image")));
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.createUserToolStripMenuItem.Text = "User";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // createGroupToolStripMenuItem
            // 
            this.createGroupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createGroupToolStripMenuItem.Image")));
            this.createGroupToolStripMenuItem.Name = "createGroupToolStripMenuItem";
            this.createGroupToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.createGroupToolStripMenuItem.Text = "User Group";
            this.createGroupToolStripMenuItem.Click += new System.EventHandler(this.createGroupToolStripMenuItem_Click);
            // 
            // userVsGroupMappingToolStripMenuItem
            // 
            this.userVsGroupMappingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userVsGroupMappingToolStripMenuItem.Image")));
            this.userVsGroupMappingToolStripMenuItem.Name = "userVsGroupMappingToolStripMenuItem";
            this.userVsGroupMappingToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.userVsGroupMappingToolStripMenuItem.Text = "User Vs User Group";
            this.userVsGroupMappingToolStripMenuItem.Click += new System.EventHandler(this.userVsGroupMappingToolStripMenuItem_Click);
            // 
            // userLogToolStripMenuItem
            // 
            this.userLogToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userLogToolStripMenuItem.Image")));
            this.userLogToolStripMenuItem.Name = "userLogToolStripMenuItem";
            this.userLogToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.userLogToolStripMenuItem.Text = "User Log";
            this.userLogToolStripMenuItem.Click += new System.EventHandler(this.userLogToolStripMenuItem_Click_1);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qCDMasterToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.maintenanceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("maintenanceToolStripMenuItem.Image")));
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // qCDMasterToolStripMenuItem
            // 
            this.qCDMasterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("qCDMasterToolStripMenuItem.Image")));
            this.qCDMasterToolStripMenuItem.Name = "qCDMasterToolStripMenuItem";
            this.qCDMasterToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.qCDMasterToolStripMenuItem.Text = "QCD";
            this.qCDMasterToolStripMenuItem.Click += new System.EventHandler(this.qCDMasterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PickupEntryToolStripMenuItem,
            this.mnuDepositSlipEntry,
            this.mnuCMSEntryQueue,
            this.mnuClearingDump,
            this.toolStripSeparator1,
            this.mnuPosting,
            this.mnuUnPosting,
            this.mnuPulloutEntry,
            this.toolStripSeparator2,
            this.mnuUpload,
            this.mnuReUpload,
            this.mnuDeleteUpload,
            this.toolStripSeparator3,
            this.mnuDeleteFile});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(102, 20);
            this.toolStripMenuItem1.Text = "Transaction";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // PickupEntryToolStripMenuItem
            // 
            this.PickupEntryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PickupEntryToolStripMenuItem.Image")));
            this.PickupEntryToolStripMenuItem.Name = "PickupEntryToolStripMenuItem";
            this.PickupEntryToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.PickupEntryToolStripMenuItem.Text = "Pickup Entry";
            this.PickupEntryToolStripMenuItem.Click += new System.EventHandler(this.PickupEntryToolStripMenuItem_Click);
            // 
            // mnuDepositSlipEntry
            // 
            this.mnuDepositSlipEntry.Image = ((System.Drawing.Image)(resources.GetObject("mnuDepositSlipEntry.Image")));
            this.mnuDepositSlipEntry.Name = "mnuDepositSlipEntry";
            this.mnuDepositSlipEntry.Size = new System.Drawing.Size(173, 22);
            this.mnuDepositSlipEntry.Text = "Deposit Slip Entry";
            this.mnuDepositSlipEntry.Click += new System.EventHandler(this.mnuDepositSlipEntry_Click);
            // 
            // mnuCMSEntryQueue
            // 
            this.mnuCMSEntryQueue.Image = ((System.Drawing.Image)(resources.GetObject("mnuCMSEntryQueue.Image")));
            this.mnuCMSEntryQueue.Name = "mnuCMSEntryQueue";
            this.mnuCMSEntryQueue.Size = new System.Drawing.Size(173, 22);
            this.mnuCMSEntryQueue.Text = "CMS Entry Queue";
            this.mnuCMSEntryQueue.Click += new System.EventHandler(this.mnuCMSEntryQueue_Click);
            // 
            // mnuClearingDump
            // 
            this.mnuClearingDump.Image = ((System.Drawing.Image)(resources.GetObject("mnuClearingDump.Image")));
            this.mnuClearingDump.Name = "mnuClearingDump";
            this.mnuClearingDump.Size = new System.Drawing.Size(173, 22);
            this.mnuClearingDump.Text = "Clearing Dump";
            this.mnuClearingDump.Click += new System.EventHandler(this.mnuClearingDump_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // mnuPosting
            // 
            this.mnuPosting.Image = ((System.Drawing.Image)(resources.GetObject("mnuPosting.Image")));
            this.mnuPosting.Name = "mnuPosting";
            this.mnuPosting.Size = new System.Drawing.Size(173, 22);
            this.mnuPosting.Text = "Posting";
            this.mnuPosting.Click += new System.EventHandler(this.mnuPosting_Click);
            // 
            // mnuUnPosting
            // 
            this.mnuUnPosting.Image = ((System.Drawing.Image)(resources.GetObject("mnuUnPosting.Image")));
            this.mnuUnPosting.Name = "mnuUnPosting";
            this.mnuUnPosting.Size = new System.Drawing.Size(173, 22);
            this.mnuUnPosting.Text = "Un Posting";
            this.mnuUnPosting.Click += new System.EventHandler(this.mnuUnPosting_Click);
            // 
            // mnuPulloutEntry
            // 
            this.mnuPulloutEntry.Image = ((System.Drawing.Image)(resources.GetObject("mnuPulloutEntry.Image")));
            this.mnuPulloutEntry.Name = "mnuPulloutEntry";
            this.mnuPulloutEntry.Size = new System.Drawing.Size(173, 22);
            this.mnuPulloutEntry.Text = "Pullout Entry";
            this.mnuPulloutEntry.Click += new System.EventHandler(this.mnuPulloutEntry_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // mnuUpload
            // 
            this.mnuUpload.Image = ((System.Drawing.Image)(resources.GetObject("mnuUpload.Image")));
            this.mnuUpload.Name = "mnuUpload";
            this.mnuUpload.Size = new System.Drawing.Size(173, 22);
            this.mnuUpload.Text = "Upload";
            this.mnuUpload.Click += new System.EventHandler(this.mnuUpload_Click);
            // 
            // mnuReUpload
            // 
            this.mnuReUpload.Image = ((System.Drawing.Image)(resources.GetObject("mnuReUpload.Image")));
            this.mnuReUpload.Name = "mnuReUpload";
            this.mnuReUpload.Size = new System.Drawing.Size(173, 22);
            this.mnuReUpload.Text = "Re Upload";
            this.mnuReUpload.Click += new System.EventHandler(this.mnuReUpload_Click);
            // 
            // mnuDeleteUpload
            // 
            this.mnuDeleteUpload.Image = ((System.Drawing.Image)(resources.GetObject("mnuDeleteUpload.Image")));
            this.mnuDeleteUpload.Name = "mnuDeleteUpload";
            this.mnuDeleteUpload.Size = new System.Drawing.Size(173, 22);
            this.mnuDeleteUpload.Text = "Delete Upload";
            this.mnuDeleteUpload.Click += new System.EventHandler(this.mnuDeleteUpload_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(170, 6);
            // 
            // mnuDeleteFile
            // 
            this.mnuDeleteFile.Image = ((System.Drawing.Image)(resources.GetObject("mnuDeleteFile.Image")));
            this.mnuDeleteFile.Name = "mnuDeleteFile";
            this.mnuDeleteFile.Size = new System.Drawing.Size(173, 22);
            this.mnuDeleteFile.Text = "Delete File";
            this.mnuDeleteFile.Click += new System.EventHandler(this.mnuDeleteFile_Click);
            // 
            // reportsMisToolStripMenuItem
            // 
            this.reportsMisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDepositRpt,
            this.mnuChqReport,
            this.mnuClearingRpt,
            this.mnuEnrichmentRpt,
            this.mnuUploadRpt,
            this.fileReportToolStripMenuItem,
            this.mnufinnnaxiaRpt});
            this.reportsMisToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.reportsMisToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportsMisToolStripMenuItem.Image")));
            this.reportsMisToolStripMenuItem.Name = "reportsMisToolStripMenuItem";
            this.reportsMisToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.reportsMisToolStripMenuItem.Text = "Reports";
            // 
            // mnuDepositRpt
            // 
            this.mnuDepositRpt.Image = ((System.Drawing.Image)(resources.GetObject("mnuDepositRpt.Image")));
            this.mnuDepositRpt.Name = "mnuDepositRpt";
            this.mnuDepositRpt.Size = new System.Drawing.Size(180, 22);
            this.mnuDepositRpt.Text = "Deposit Report";
            this.mnuDepositRpt.Click += new System.EventHandler(this.mnuDepositRpt_Click);
            // 
            // mnuChqReport
            // 
            this.mnuChqReport.Image = ((System.Drawing.Image)(resources.GetObject("mnuChqReport.Image")));
            this.mnuChqReport.Name = "mnuChqReport";
            this.mnuChqReport.Size = new System.Drawing.Size(180, 22);
            this.mnuChqReport.Text = "Cheque Report";
            this.mnuChqReport.Click += new System.EventHandler(this.mnuChqReport_Click);
            // 
            // mnuClearingRpt
            // 
            this.mnuClearingRpt.Image = ((System.Drawing.Image)(resources.GetObject("mnuClearingRpt.Image")));
            this.mnuClearingRpt.Name = "mnuClearingRpt";
            this.mnuClearingRpt.Size = new System.Drawing.Size(180, 22);
            this.mnuClearingRpt.Text = "Clearing Report";
            this.mnuClearingRpt.Click += new System.EventHandler(this.mnuClearingRpt_Click);
            // 
            // mnuEnrichmentRpt
            // 
            this.mnuEnrichmentRpt.Image = ((System.Drawing.Image)(resources.GetObject("mnuEnrichmentRpt.Image")));
            this.mnuEnrichmentRpt.Name = "mnuEnrichmentRpt";
            this.mnuEnrichmentRpt.Size = new System.Drawing.Size(180, 22);
            this.mnuEnrichmentRpt.Text = "Enrichment Report";
            this.mnuEnrichmentRpt.Click += new System.EventHandler(this.mnuEnrichmentRpt_Click);
            // 
            // mnuUploadRpt
            // 
            this.mnuUploadRpt.Image = ((System.Drawing.Image)(resources.GetObject("mnuUploadRpt.Image")));
            this.mnuUploadRpt.Name = "mnuUploadRpt";
            this.mnuUploadRpt.Size = new System.Drawing.Size(180, 22);
            this.mnuUploadRpt.Text = "Upload Report";
            this.mnuUploadRpt.Click += new System.EventHandler(this.mnuUploadRpt_Click);
            // 
            // mnufinnnaxiaRpt
            // 
            this.mnufinnnaxiaRpt.Image = ((System.Drawing.Image)(resources.GetObject("mnuUploadRpt.Image")));
            this.mnufinnnaxiaRpt.Name = "mnufinnnaxiaRpt";
            this.mnufinnnaxiaRpt.Size = new System.Drawing.Size(180, 22);
            this.mnufinnnaxiaRpt.Text = "Finnaxia Report";
            this.mnufinnnaxiaRpt.Click += new System.EventHandler(this.mnufinnnaxiaRpt_Click);
            // 
            // fileReportToolStripMenuItem
            // 
            this.fileReportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileReportToolStripMenuItem.Image")));
            this.fileReportToolStripMenuItem.Name = "fileReportToolStripMenuItem";
            this.fileReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fileReportToolStripMenuItem.Text = "File Report";
            this.fileReportToolStripMenuItem.Click += new System.EventHandler(this.fileReportToolStripMenuItem_Click);
            // 
            // WindowsMenu
            // 
            this.WindowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CascadeToolStripMenuItem,
            this.TileVerticalToolStripMenuItem,
            this.TileHorizontalToolStripMenuItem,
            this.CloseAllToolStripMenuItem,
            this.ArrangeIconsToolStripMenuItem});
            this.WindowsMenu.Image = ((System.Drawing.Image)(resources.GetObject("WindowsMenu.Image")));
            this.WindowsMenu.Name = "WindowsMenu";
            this.WindowsMenu.Size = new System.Drawing.Size(85, 20);
            this.WindowsMenu.Text = "&Windows";
            // 
            // CascadeToolStripMenuItem
            // 
            this.CascadeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CascadeToolStripMenuItem.Image")));
            this.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem";
            this.CascadeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.CascadeToolStripMenuItem.Text = "&Cascade";
            this.CascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // TileVerticalToolStripMenuItem
            // 
            this.TileVerticalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("TileVerticalToolStripMenuItem.Image")));
            this.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem";
            this.TileVerticalToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.TileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            this.TileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // TileHorizontalToolStripMenuItem
            // 
            this.TileHorizontalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("TileHorizontalToolStripMenuItem.Image")));
            this.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem";
            this.TileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            this.TileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // CloseAllToolStripMenuItem
            // 
            this.CloseAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CloseAllToolStripMenuItem.Image")));
            this.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem";
            this.CloseAllToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.CloseAllToolStripMenuItem.Text = "C&lose All";
            this.CloseAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // ArrangeIconsToolStripMenuItem
            // 
            this.ArrangeIconsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ArrangeIconsToolStripMenuItem.Image")));
            this.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem";
            this.ArrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ArrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            this.ArrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblPoweredBy,
            this.lblNafLogo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 379);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1364, 45);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Image = ((System.Drawing.Image)(resources.GetObject("lblStatus.Image")));
            this.lblStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lblStatus.IsLink = true;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(449, 40);
            this.lblStatus.Spring = true;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPoweredBy
            // 
            this.lblPoweredBy.Name = "lblPoweredBy";
            this.lblPoweredBy.Size = new System.Drawing.Size(449, 40);
            this.lblPoweredBy.Spring = true;
            this.lblPoweredBy.Text = "Powered By : Flexicode Technologies Pvt Ltd";
            this.lblPoweredBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNafLogo
            // 
            this.lblNafLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNafLogo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lblNafLogo.Name = "lblNafLogo";
            this.lblNafLogo.Size = new System.Drawing.Size(449, 40);
            this.lblNafLogo.Spring = true;
            this.lblNafLogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imgLst
            // 
            this.imgLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLst.ImageStream")));
            this.imgLst.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLst.Images.SetKeyName(0, "Add_Symbol.ico");
            this.imgLst.Images.SetKeyName(1, "edit1.ico");
            this.imgLst.Images.SetKeyName(2, "Delete.ico");
            this.imgLst.Images.SetKeyName(3, "Find.ico");
            this.imgLst.Images.SetKeyName(4, "Floppy-green-icon.png");
            this.imgLst.Images.SetKeyName(5, "Link.ico");
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnExit,
            this.lblLoginUser,
            this.tsbtnChangePwd,
            this.tsbtnDashboard});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1364, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 4;
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExit.Image")));
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(23, 22);
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // lblLoginUser
            // 
            this.lblLoginUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblLoginUser.Image = ((System.Drawing.Image)(resources.GetObject("lblLoginUser.Image")));
            this.lblLoginUser.Name = "lblLoginUser";
            this.lblLoginUser.Size = new System.Drawing.Size(112, 22);
            this.lblLoginUser.Text = "Welcome Admin";
            // 
            // tsbtnChangePwd
            // 
            this.tsbtnChangePwd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnChangePwd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnChangePwd.Image")));
            this.tsbtnChangePwd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnChangePwd.Name = "tsbtnChangePwd";
            this.tsbtnChangePwd.Size = new System.Drawing.Size(123, 22);
            this.tsbtnChangePwd.Text = "Manage Password";
            this.tsbtnChangePwd.Click += new System.EventHandler(this.tsbtnChangePwd_Click_1);
            // 
            // tsbtnDashboard
            // 
            this.tsbtnDashboard.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDashboard.Image")));
            this.tsbtnDashboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDashboard.Name = "tsbtnDashboard";
            this.tsbtnDashboard.Size = new System.Drawing.Size(23, 22);
            this.tsbtnDashboard.Click += new System.EventHandler(this.tsbtnDashboard_Click);
            // 
            // mnufinnnaxiaRpt
            // 
            this.mnufinnnaxiaRpt.Name = "mnufinnnaxiaRpt";
            this.mnufinnnaxiaRpt.Size = new System.Drawing.Size(180, 22);
            this.mnufinnnaxiaRpt.Text = "Finnaxia Report";
            this.mnufinnnaxiaRpt.Click += new System.EventHandler(this.mnufinnnaxiaRpt_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1364, 424);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CMS Deposit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnuUserAdmin;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userVsGroupMappingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qCDMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsMisToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.ToolStripLabel lblLoginUser;
        private System.Windows.Forms.ToolStripButton tsbtnDashboard;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblPoweredBy;
        private System.Windows.Forms.ToolStripStatusLabel lblNafLogo;
        private System.Windows.Forms.ImageList imgLst;
        private System.Windows.Forms.ToolStripButton tsbtnChangePwd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem PickupEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDepositSlipEntry;
        private System.Windows.Forms.ToolStripMenuItem mnuCMSEntryQueue;
        private System.Windows.Forms.ToolStripMenuItem mnuClearingDump;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteFile;
        private System.Windows.Forms.ToolStripMenuItem mnuPosting;
        private System.Windows.Forms.ToolStripMenuItem mnuUnPosting;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuUpload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuReUpload;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteUpload;
        private System.Windows.Forms.ToolStripMenuItem mnuDepositRpt;
        private System.Windows.Forms.ToolStripMenuItem mnuClearingRpt;
        private System.Windows.Forms.ToolStripMenuItem mnuChqReport;
        private System.Windows.Forms.ToolStripMenuItem mnuEnrichmentRpt;
        private System.Windows.Forms.ToolStripMenuItem mnuUploadRpt;
        private System.Windows.Forms.ToolStripMenuItem fileReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPulloutEntry;
        internal System.Windows.Forms.ToolStripMenuItem WindowsMenu;
        internal System.Windows.Forms.ToolStripMenuItem CascadeToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem TileVerticalToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem TileHorizontalToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CloseAllToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ArrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnufinnnaxiaRpt;
    }
}