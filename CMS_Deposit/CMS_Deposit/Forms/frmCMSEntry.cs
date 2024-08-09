using CMS_Deposit.Business;
using CMS_Deposit.Common;
using CMS_Deposit.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS_Deposit.Forms
{
    public partial class frmCMSEntry : Form
    {
        public DepositSlipEntities.DepositSlipHdr ObjCMS = new DepositSlipEntities.DepositSlipHdr();
        long DepositGid = 0;
        DataTable dtAttachment = new DataTable();
        int ImageQue = 0;
        System.IO.MemoryStream streamBmpImg;

        Bitmap bitImg;
        string prvvalue = "";
        string ChqDate = "";
        bool ChqAmount_Check = false;

        private int ImageWidth, ImageHeight;
        private float ImageScale = 1.0f;

        public frmCMSEntry(DepositSlipEntities.DepositSlipHdr _cmsEntry)
        {
            InitializeComponent();
            ObjCMS = _cmsEntry;

            DepositGid = Convert.ToInt32(ObjCMS.DepositGid.ToString());

            TxtDepositGid.Text = ObjCMS.DepositGid.ToString();
            TxtDepositSlipNo.Text = ObjCMS.DepositSlipNo.ToString();
            TxtDepositDt.Text = ObjCMS.DepositDate.ToString();
            TxtLocation.Text = ObjCMS.LocationName.ToString();
            TxtCustomerName.Text = ObjCMS.ClientName.ToString();
            TxtDepositAmt.Text = ObjCMS.DepositAmount.ToString();
            TxtNoOfChq.Text = ObjCMS.NoOfChqs.ToString();
        }

        private void frmCMSEntry_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            DisplayImage();
            ChqMapped();
            TxtChqNo.Focus();

            ImageQue = -1;

            btnNxtChq.PerformClick();
            GetTotalRefAmount();

            KeyPreview = true;

            //PicFrontSide.Top = pnlBatch.Top + pnlBatch.Height + 8;
            //PicFrontSide.Left = pnlBatch.Left;
            //PicFrontSide.Width = this.Width - pnlEntry.Width - 48;
            //PicFrontSide.Height = pnlChq.Top - (pnlBatch.Top + pnlBatch.Height + 16);

            //ImageWidth = PicFrontSide.Image.Width;
            //ImageHeight = PicFrontSide.Image.Height;

            ////PicFrontSide.SizeMode = PictureBoxSizeMode.Zoom;
            ////PicFrontSide.Size = new Size(ImageWidth, ImageHeight);

            //this.MouseWheel += new MouseEventHandler(imgZoom_Mousewheel);
        }

        private void GetTotalRefAmount()
        {
            long ChqGid = 0;
            DataTable dtTotalRefAmt = new DataTable();
            try
            {
                DepositSlipBusiness ObjBusiness = new DepositSlipBusiness();
                if (DepositGid > 0)
                {
                    if (txtChqGid.Text != "")
                    {

                        ChqGid = Convert.ToInt32(txtChqGid.Text);

                        dtTotalRefAmt = ObjBusiness.GetTotalRefAmount(DepositGid, ChqGid);
                        txtTotalRefAmt.Text = dtTotalRefAmt.Rows[0]["RefAmount"].ToString();

                        if (Convert.ToDouble(txtchqamt.Text.ToString()) == Convert.ToDouble(txtTotalRefAmt.Text.ToString()))
                        {
                            if (Convert.ToDouble(txtTotalRefAmt.Text.ToString()) > 0)
                            {
                                MessageBox.Show("Cheque Amount and Total Ref Amount Matched", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                            ChqAmount_Check = false;
                            TxtChqNo.Text = "";
                            chqdtpicker.Text = "";
                            txtchqamt.Text = "";
                            txtAccHolder.Text = "";
                            TxtRefNo.Text = "";
                            TxtRefAmount.Text = "";
                            txtChqGid.Text = "";
                            txtTotalRefAmt.Text = "0";

                            TxtChqNo.ReadOnly = false;
                            chqdtpicker.ReadOnly = false;
                            txtchqamt.ReadOnly = false;
                            txtAccHolder.ReadOnly = false;

                            TxtChqNo.Focus();

                            ChqMapped();


                        }
                        else if (Convert.ToDouble(txtchqamt.Text.ToString()) > Convert.ToDouble(txtTotalRefAmt.Text.ToString()))
                        {
                            ChqAmount_Check = true;
                            TxtChqNo.ReadOnly = true;
                            chqdtpicker.ReadOnly = true;
                            txtchqamt.ReadOnly = true;
                            txtAccHolder.ReadOnly = true;
                            TxtRefNo.Text = "";
                            TxtRefAmount.Text = "";
                            TxtRefNo.Focus();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void imgZoom_Mousewheel(object sender, MouseEventArgs e)
        //{
        //    // The amount by which we adjust scale per wheel click.
        //    const float scale_per_delta = 0.1f / 120;

        //    // Update the drawing based upon the mouse wheel scrolling.
        //    ImageScale += e.Delta * scale_per_delta;
        //    if (ImageScale < 0) ImageScale = 0;

        //    // Size the image.
        //    PicFrontSide.Size = new Size(
        //        (int)(ImageWidth * ImageScale),
        //        (int)(ImageHeight * ImageScale));


        //}

        private void ChqMapped()
        {
            try
            {
                DepositSlipBusiness ObjBusiness = new DepositSlipBusiness();
                DataTable dtmappedlist = new DataTable();
                int PendingCount = 0;
                if (DepositGid > 0)
                {
                    dtmappedlist = ObjBusiness.GetChequeEntryCount(DepositGid);
                    PendingCount = Convert.ToInt32(TxtNoOfChq.Text) - Convert.ToInt32 (dtmappedlist.Rows[0]["mapped_chq"].ToString ());
                    lblPending.Text = "Pending : " + (Convert.ToInt32(TxtNoOfChq.Text) - Convert.ToInt32(dtmappedlist.Rows[0]["mapped_chq"].ToString())).ToString();
                    lblCompleted.Text = "Completed : " + dtmappedlist.Rows[0]["mapped_chq"].ToString();

                    lblPendingAmount.Text = "Difference Amount : " + (Convert.ToDouble(TxtDepositAmt.Text) - Convert.ToDouble(dtmappedlist.Rows[0]["mapped_amount"].ToString())).ToString();
                    lblMappedAmt.Text = "Mapped Amount : " + dtmappedlist.Rows[0]["mapped_amount"].ToString();

                    if (PendingCount == 0)
                    {
                        MessageBox.Show("Cheque Entry Count Mapped to Deposit", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayImage()
        {
            try
            {
                DepositSlipBusiness ObjBusiness = new DepositSlipBusiness();
                if (DepositGid > 0)
                {

                    dtAttachment = ObjBusiness.GetAttachmentDtls(DepositGid);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCMSEntry_Resize(object sender, EventArgs e)
        {
            pnlBatch.Width = this.Width - pnlBatch.Left * 2 - 16;

            pnlEntry.Width = 264;

            kpImageViewer1.Top = pnlBatch.Top + pnlBatch.Height + 8;
            kpImageViewer1.Left = pnlBatch.Left;
            //kpImageViewer1.Width = this.Width - pnlEntry.Width - 102;
            kpImageViewer1.Width = this.Width - pnlEntry.Width - 32;
            //kpImageViewer1.Width = this.Width - 32;
            kpImageViewer1.Height = this.Height - (kpImageViewer1.Top + 48);

            pnlEntry.Top = kpImageViewer1.Top + kpImageViewer1.Height - pnlEntry.Height;
            pnlEntry.Left = kpImageViewer1.Left + kpImageViewer1.Width + 4;

            kpImageViewer1.Width = this.Width - 2;
        }



        private void btnNxtChq_Click(object sender, EventArgs e)
        {
            try
            {
                long AttachmentGid = 0;

                if (ImageQue >= dtAttachment.Rows.Count - 1)
                {
                    MessageBox.Show("Display Image Completed.. ", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ImageQue++;

                    DepositSlipBusiness ObjBusiness = new DepositSlipBusiness();
                    DepositSlipEntities.DepositAttachment_Api ObjImageView = new DepositSlipEntities.DepositAttachment_Api();
                    AttachmentGid = Convert.ToInt32(dtAttachment.Rows[ImageQue]["attachment_gid"].ToString());

                    ObjImageView.attachment_gid = Convert.ToInt32(AttachmentGid);
                    ObjImageView.attachment_dtls = "";
                    ObjImageView = ObjBusiness.GetAttachmentImage(ObjImageView);

                    if (ObjImageView.attachment_dtls == "" || ObjImageView.attachment_dtls == null)
                    {
                       // PicFrontSide.Image = null;
                        kpImageViewer1.Image = null;
                    }
                    else
                    {
                        byte[] byteBuffer = Convert.FromBase64String(ObjImageView.attachment_dtls);
                        streamBmpImg = new MemoryStream(byteBuffer);
                        bitImg = new Bitmap(Image.FromStream(streamBmpImg));
                       // PicFrontSide.Image = bitImg;
                        kpImageViewer1.Image = bitImg;
                    }

                    TxtChqNo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsve_Click(object sender, EventArgs e)
        {
            DateTime chq_date;

            try
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to save the record?", global_variable.proj_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    txtAccHolder.Text = txtAccHolder.Text.Trim();
                    TxtChqNo.Text = TxtChqNo.Text.Trim();

                    if (TxtChqNo.Text.ToString() == "")
                    {
                        MessageBox.Show("Chq Amount Can't Empty ");
                        TxtChqNo.Focus();
                        return;
                    }
                    if (txtchqamt.Text.ToString() == "" || txtchqamt.Text.ToString() == "0")
                    {
                        MessageBox.Show("Chq Amount Can't Empty", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtchqamt.Focus();
                        return;
                    }
                    if (chqdtpicker.Text == "")
                    {
                        MessageBox.Show("Chq Date Can't Empty", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        chqdtpicker.Focus();
                        return;
                    }
                    else if (DateTime.TryParse(chqdtpicker.Text, out chq_date) == false)
                    {
                        MessageBox.Show("Invalid cheque date !", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        chqdtpicker.Focus();
                        return;
                    }
                    else if (chq_date > DateTime.Now)
                    {
                        MessageBox.Show("Cheque date is future date !", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        chqdtpicker.Focus();
                        return;
                    }
                    else if (DateTime.Now.Subtract(chq_date).Days > 90)
                    {
                        MessageBox.Show("Cheque is mutilated !", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        chqdtpicker.Focus();
                        return;
                    }

                    if (txtAccHolder.Text == "")
                    {
                        MessageBox.Show("A/C holder name cannot be empty !", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAccHolder.Focus();
                        return;
                    }

                    if (TxtRefNo.Text.Trim().ToString() == "")
                    {
                        MessageBox.Show("Ref No Can't Empty", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtRefNo.Focus();
                        return;
                    }
                    if (TxtRefAmount.Text.ToString() == "" || TxtRefAmount.Text.ToString() == "0")
                    {
                        MessageBox.Show("Ref Amount Can't Empty", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtRefAmount.Focus();
                        return;
                    }

                    CMSEntities.ChqEntry_Model ObjChqHdr = new CMSEntities.ChqEntry_Model();

                    string[] result = { };
                    string[] result_enrich = { };

                    if (ChqAmount_Check == false)
                    {
                        if (Convert.ToDouble(txtchqamt.Text.ToString()) != Convert.ToDouble(TxtRefAmount.Text.ToString()))
                        {
                            if (Convert.ToDouble(txtchqamt.Text.ToString()) < Convert.ToDouble(TxtRefAmount.Text.ToString()))
                            {
                                MessageBox.Show("Ref Amount greater then cheque Amount", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtRefAmount.Focus();
                                return;
                            }
                            else
                            {
                                ChqAmount_Check = true;
                            }
                        }

                        ObjChqHdr.deposit_gid = Convert.ToInt32(TxtDepositGid.Text.ToString());
                        ObjChqHdr.chq_gid = 0;
                        DateTime Clrdate = DateTime.Parse(chqdtpicker.Text);
                        ObjChqHdr.chq_date = Clrdate.ToString("yyyy-MM-dd");
                        ObjChqHdr.chq_no = string.Format("{0:000000}", Convert.ToInt32(TxtChqNo.Text.ToString()));
                        ObjChqHdr.acc_holder = txtAccHolder.Text;
                        ObjChqHdr.chq_amount = Convert.ToDouble(txtchqamt.Text.ToString());
                        ObjChqHdr.ref_no = TxtRefNo.Text;
                        ObjChqHdr.ref_amount = Convert.ToDouble(TxtRefAmount.Text.ToString());
                        ObjChqHdr.action = global_variable.action_insert;
                        ObjChqHdr.action_by = global_variable.user_name;

                        CMSEntryBusiness ObjCmsBusiness = new CMSEntryBusiness();
                        result = ObjCmsBusiness.SaveCMSEntry(ObjChqHdr);
                        ObjChqHdr.msg = result[0].ToString();
                        ObjChqHdr.out_gid = Convert.ToInt32(result[2]);
                        txtChqGid.Text = result[2].ToString();

                        if (result[1].ToString() == "0")
                        {
                            MessageBox.Show(result[0].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        if (Convert.ToDouble(txtchqamt.Text.ToString()) == Convert.ToDouble(TxtRefAmount.Text.ToString()))
                        {
                            ChqAmount_Check = false;
                        }
                    }
                    else if (ChqAmount_Check == true)
                    {
                        ObjChqHdr.deposit_gid = Convert.ToInt32(TxtDepositGid.Text.ToString());
                        ObjChqHdr.chq_gid = Convert.ToInt32(txtChqGid.Text.ToString());
                        DateTime Clrdate = DateTime.Parse(chqdtpicker.Text);
                        ObjChqHdr.chq_date = Clrdate.ToString("yyyy-MM-dd");
                        ObjChqHdr.chq_no = string.Format("{0:000000}", Convert.ToInt32(TxtChqNo.Text.ToString()));
                        ObjChqHdr.chq_amount = Convert.ToDouble(txtchqamt.Text.ToString());
                        ObjChqHdr.ref_no = TxtRefNo.Text;
                        ObjChqHdr.ref_amount = Convert.ToDouble(TxtRefAmount.Text.ToString());
                        ObjChqHdr.action = global_variable.action_insert;
                        ObjChqHdr.action_by = global_variable.user_name;

                        CMSEntryBusiness ObjCmsBusiness = new CMSEntryBusiness();
                        result_enrich = ObjCmsBusiness.SaveEnrichMent(ObjChqHdr);
                        ObjChqHdr.msg = result_enrich[0].ToString();
                        ObjChqHdr.out_gid = Convert.ToInt32(result_enrich[2]);

                        if (result_enrich[1].ToString() == "0")
                        {
                            MessageBox.Show(result_enrich[0].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    GetTotalRefAmount();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chqdtpicker_Leave(object sender, EventArgs e)
        {
            try
            {
                if (chqdtpicker.Text.Length != 6) return;
                prvvalue = chqdtpicker.Text;
                string result = prvvalue.Substring(0, 2) + "/" + prvvalue.Substring(2, 2) + "/" + "20" + prvvalue.Substring(4, 2);
                ChqDate = "20" + prvvalue.Substring(4, 2) + "-" + prvvalue.Substring(2, 2) + "-" + prvvalue.Substring(0, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtChqNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtchqamt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TxtRefNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TxtRefAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int depositgid = 0;
            depositgid = Convert.ToInt32(TxtDepositGid.Text.ToString());
            frmChqView frm = new frmChqView(depositgid);
            frm.ShowDialog();

            DisplayImage();
            ChqMapped();
            GetTotalRefAmount();
        }

        private void chqdtpicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnPrvChq_Click(object sender, EventArgs e)
        {
            try
            {
                int AttachmentGid = 0;

                if (ImageQue > 0)
                {
                    ImageQue--;

                    DepositSlipBusiness ObjBusiness = new DepositSlipBusiness();
                    DepositSlipEntities.DepositAttachment_Api ObjImageView = new DepositSlipEntities.DepositAttachment_Api();
                    AttachmentGid = Convert.ToInt32(dtAttachment.Rows[ImageQue]["attachment_gid"].ToString());

                    ObjImageView.attachment_gid = Convert.ToInt32(AttachmentGid);
                    ObjImageView.attachment_dtls = "";
                    ObjImageView = ObjBusiness.GetAttachmentImage(ObjImageView);

                    if (ObjImageView.attachment_dtls == "" || ObjImageView.attachment_dtls == null)
                    {
                      //  PicFrontSide.Image = null;
                        kpImageViewer1.Image = null;
                    }
                    else
                    {
                        byte[] byteBuffer = Convert.FromBase64String(ObjImageView.attachment_dtls);
                        streamBmpImg = new MemoryStream(byteBuffer);
                        bitImg = new Bitmap(Image.FromStream(streamBmpImg));
                       // PicFrontSide.Image = bitImg;
                        kpImageViewer1.Image = bitImg;
                    }

                    TxtChqNo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtRefAmount_Leave(object sender, EventArgs e)
        {
            double TotalRefAmt = 0;

            if (txtTotalRefAmt.Text != "")
            {
                TotalRefAmt = Convert.ToDouble(txtTotalRefAmt.Text);
            }
            else
            {
                TotalRefAmt = 0;
            }

            txtTotalRefAmt.Text = (TotalRefAmt + Convert.ToDouble(TxtRefAmount.Text)).ToString();
        }

        private void pnlChq_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCMSEntry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void TxtChqNo_Leave(object sender, EventArgs e)
        {
            if (TxtChqNo.Text.Length < 6)
            {
//TxtChqNo.Text = TxtChqNo.Text.ToString("000000");
            }
        }

        private void lblchqamt_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void TxtRefNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
