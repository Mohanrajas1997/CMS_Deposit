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
    public partial class frmReUpload : Form
    {
        string UploadFormName = "";
        public frmReUpload(string UploadStatus)
        {
            InitializeComponent();
            
            UploadFormName = UploadStatus;
            if (UploadFormName.ToUpper() == "REUPLOAD")
            {
                this.Text = "Re Upload";
                btnReupload.Text = "Re Upload";
            }
            else if (UploadFormName.ToUpper() == "DELETEUPLOAD")
            {
                this.Text = "Delete Upload";
                btnReupload.Text = "Delete";
            }
        }

        private void frmReUpload_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;

            GetUploadcode();
        }

        private void GetUploadcode()
        {
            DataTable dtupload = new DataTable();
            UploadBusiness ObjBusiness = new UploadBusiness();

            string UploadFromdt = dtpFrom.Value.ToString("yyyy-MM-dd");
            string UploadTodt = dtpTo.Value.ToString("yyyy-MM-dd");
            dtupload = ObjBusiness.GetUploadCode(UploadFromdt, UploadTodt);

            if (dtupload.Rows.Count > 0)
            {
                DataRow rows = dtupload.NewRow();

                dtupload.Rows.InsertAt(rows, 0);
                cmbUploadNo.DataSource = dtupload;
                cmbUploadNo.DisplayMember = "upload_code";
                cmbUploadNo.ValueMember = "upload_gid";

            }
        }

        private void dtpUploadFrom_Leave(object sender, EventArgs e)
        {
            GetUploadcode();
        }

        private void dtpUploadTo_Leave(object sender, EventArgs e)
        {
            GetUploadcode();
        }

        private void btnReupload_Click(object sender, EventArgs e)
        {
            btnload.Visible = true;
            lblload.Visible = true;
            DataTable dtupload = new DataTable();           
            UploadBusiness ObjBusiness = new UploadBusiness();
            Upload_Model.UploadHdr ObjModel = new Upload_Model.UploadHdr();

            int UploadGid = 0;
            string UploadNo = "";
            try
            {

                if (cmbUploadNo.Text == "" || cmbUploadNo.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select the UploadNo ", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbUploadNo.Focus();
                    btnload.Visible = false;
                    lblload.Visible = false;
                    return;
                }

                UploadGid = Convert.ToInt16(cmbUploadNo.SelectedValue.ToString());
                UploadNo = cmbUploadNo.Text.ToString();

                //dtupload = ObjBusiness.GetUpload(UploadGid);
                 DataTable dtfile = new DataTable();
                dtfile = ObjBusiness.Getfilename(UploadGid);
                DataTable dt = new DataTable();
                dt = ObjBusiness.GetFinnaxiaRpt(Convert.ToInt32(cmbUploadNo.SelectedValue.ToString()));
               

                if (UploadFormName.ToUpper() == "REUPLOAD")
                {

                    string uploadpath_fx = CreateFolderForUpload(UploadNo) + "\\Finnaxia\\";
                    if (!System.IO.Directory.Exists(uploadpath_fx))
                    {
                        System.IO.Directory.CreateDirectory(uploadpath_fx);
                    }                  
                    GetFinnaxiaFileexcel(uploadpath_fx, dt,Convert.ToInt32(cmbUploadNo.SelectedValue.ToString()), dtfile); 
                    return;
                }
                else if (UploadFormName.ToUpper() == "DELETEUPLOAD")
                {
                    ObjModel.clgrfromdate = "";
                    ObjModel.clrgtodate = "";
                    ObjModel.upload_gid = UploadGid;
                    ObjModel.upload_code = "";
                    ObjModel.upload_slno = 0;
                    ObjModel.action = global_variable.action_delete;
                    ObjModel.action_by = global_variable.user_name;
                    string[] result = ObjBusiness.SaveUploadid(ObjModel);

                    ObjModel.Out_gid = Convert.ToInt16(result[2].ToString());
                    ObjModel.Out_msg = result[0].ToString();
                    ObjModel.Out_result = Convert.ToInt16(result[1].ToString());

                    MessageBox.Show(result[0].ToString(), global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information );
                    btnload.Visible = false;
                    lblload.Visible = false;
                    return;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnload.Visible = false;
                lblload.Visible = false;
            }
        }
        private string CreateFolderForUpload(string Upd_Code)
        {
            string returnVal = "";
            try
            {
                string PrgPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
                Upd_Code = Upd_Code.Replace("-", "");
                String Todaysdate = DateTime.Now.ToString("dd-MMM-yyyy");
                string uploadpath = "";

                PrgPath = PrgPath + "\\" + Todaysdate;

                if (!System.IO.Directory.Exists(PrgPath))
                {
                    System.IO.Directory.CreateDirectory(PrgPath);
                }

                PrgPath = PrgPath + "\\Upload";

                if (!System.IO.Directory.Exists(PrgPath))
                {
                    System.IO.Directory.CreateDirectory(PrgPath);
                }

                PrgPath = PrgPath + "\\" + Upd_Code;

                if (!System.IO.Directory.Exists(PrgPath))
                {
                    System.IO.Directory.CreateDirectory(PrgPath);
                }

                uploadpath = PrgPath;

                returnVal = uploadpath;
            }
            catch (Exception ex)
            {
                returnVal = "";
                //LogHelper.WriteLog(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnload.Visible = false;
                lblload.Visible = false;
            }
            finally
            {

            }
            return returnVal;
        }
        public void GetFinnaxiaFileexcel(string uploadpath, DataTable dt, int upload_code, DataTable dtfile)
        {
            try
            {
            string batch_no_data = upload_code.ToString();
            string batch_cde = batch_no_data;
            string basefileName = uploadpath + dtfile.Rows[0]["Finnaxia"].ToString() + ".xlsx";
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No Records found..!", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnload.Visible = false;
                lblload.Visible = false;

                return;
            }
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = false;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Finnaxia_Rpt";

            // storing header part in Excel  
            //object[] Header = new object[dt.Columns.Count + 1];

            // column headings               
            for (var i = 0; i < dt.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if (dt.Rows[i][j].ToString() != "")
                    {
                        if (j == 5 || j == 4 || j == 7 || j == 22 || j == 2 || j == 3 || j == 17)
                        {
                            worksheet.Cells[i + 2, j + 1] = "'" + dt.Rows[i][j].ToString();
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                        }
                    }
                }
            }
            worksheet.SaveAs(basefileName);            
            MessageBox.Show("Uploaded Succesfully", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnload.Visible = false;
            lblload.Visible = false;  
            }
                catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnload.Visible = false;
                lblload.Visible = false;
            }
        }
        public void GetFinnaxiaFile(string uploadpath, DataTable dt)
        {
            try
            {
                if (dt.Rows.Count > 0)
                {


                    string batch_no_data = dt.Rows[0]["upload_code"].ToString();
                    string batch_cde = batch_no_data;
                    string basefileName = uploadpath + dt.Rows[0]["Finnaxia"].ToString() + ".txt";

                    try
                    {
                        using (StreamWriter fs = File.CreateText(basefileName))
                        {

                            string dd = DateTime.Now.Day.ToString("d2");
                            string mm = DateTime.Now.Month.ToString("d2");
                            string yy = DateTime.Now.Year.ToString();
                            decimal Totalamt = 0;
                            fs.WriteLine("HDR~0811" + yy + mm + dd + batch_cde + "~0811~");
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                int j = i + 1;
                                DateTime value = Convert.ToDateTime(dt.Rows[i]["chq_date"].ToString());

                                string vdd = value.Day.ToString("d2");
                                string vmm = value.Month.ToString("d2");
                                string vyy = value.Year.ToString();
                                decimal amount = Convert.ToDecimal(dt.Rows[i]["chq_amount"].ToString().Replace(",", ""));
                                string sortCode = dt.Rows[i]["micr_code"].ToString();
                                string chequeamount = amount.ToString("N0");
                                string customerCode = dt.Rows[i]["customer_code"].ToString();
                                //if (customerCode != "") //Comment by Murali 23/12/2020
                                //{
                                //    customerCode = customerCode.Substring(0, customerCode.IndexOf('/'));

                                //}

                                if (dt.Rows[i]["location_code"].ToString() == "600")
                                {
                                    // sortCode = sortCode.Substring(0, 6) + "002"; /// Commented by Murali 03/12/2020
                                    fs.WriteLine("I~" + j + "~" + dt.Rows[i]["chq_no"] + "~" + amount + "~" + vdd + vmm + vyy + "~" + dd + mm + yy + "~" + customerCode + "~" + dd + mm + yy + "~CHEN~N~M~" + dt.Rows[i]["bank_code"] + "~" + sortCode + "~~" + dt.Rows[i]["acc_holder_name"] + "~~CHQ~" + dt.Rows[i]["deposit_slip_no"] + "~~~~~");
                                }
                                else if (dt.Rows[i]["location_code"].ToString() == "560")
                                {
                                    fs.WriteLine("I~" + j + "~" + dt.Rows[i]["chq_no"] + "~" + amount + "~" + vdd + vmm + vyy + "~" + dd + mm + yy + "~" + customerCode + "~" + dd + mm + yy + "~BAN~N~M~" + dt.Rows[i]["bank_code"] + "~" + sortCode + "~~" + dt.Rows[i]["acc_holder_name"] + "~~CHQ~" + dt.Rows[i]["deposit_slip_no"] + "~~~~~");
                                }
                                else if (dt.Rows[i]["location_code"].ToString() == "110")
                                {
                                    fs.WriteLine("I~" + j + "~" + dt.Rows[i]["chq_no"] + "~" + amount + "~" + vdd + vmm + vyy + "~" + dd + mm + yy + "~" + customerCode + "~" + dd + mm + yy + "~DEL~N~M~" + dt.Rows[i]["bank_code"] + "~" + sortCode + "~~" + dt.Rows[i]["acc_holder_name"] + "~~CHQ~" + dt.Rows[i]["deposit_slip_no"] + "~~~~~");
                                }
                                else
                                {
                                    fs.WriteLine("I~" + j + "~" + dt.Rows[i]["chq_no"] + "~" + amount + "~" + vdd + vmm + vyy + "~" + dd + mm + yy + "~" + customerCode + "~" + dd + mm + yy + "~" + dt.Rows[i]["location_code"].ToString() + "~N~M~" + dt.Rows[i]["bank_code"] + "~" + sortCode + "~~" + dt.Rows[i]["acc_holder_name"] + "~~CHQ~" + dt.Rows[i]["deposit_slip_no"] + "~~~~~");
                                }
                                decimal val = Convert.ToDecimal(dt.Rows[i]["chq_amount"].ToString());
                                Totalamt += val;
                            }
                            int line = Convert.ToInt32(dt.Rows.Count) + 2;
                            fs.WriteLine("TRL~" + line + "~" + Totalamt + "~");
                        }

                    }
                    catch (Exception Ex)
                    {
                        //LogHelper.WriteLog(Ex.ToString());
                        MessageBox.Show(Ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnload.Visible = false;
                        lblload.Visible = false;

                        return;
                    }
                }
            }
            catch (Exception Ex)
            {
                //LogHelper.WriteLog(Ex.ToString());
                MessageBox.Show(Ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnload.Visible = false;
                lblload.Visible = false;

                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
