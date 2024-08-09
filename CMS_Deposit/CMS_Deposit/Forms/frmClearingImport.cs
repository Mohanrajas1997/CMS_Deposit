using CMS_Deposit.Business;
using CMS_Deposit.Common;
using CMS_Deposit.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace CMS_Deposit.Forms
{
    public partial class frmClearingImport : Form
    {
        public frmClearingImport()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            try
            {
                //  openFileDialog1.Filter = "Excel Files|*.xls";
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName.Length != 0)
                {
                    txtFilePath.Text = openFileDialog1.FileName;
                }

                LoadSheet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void formatsheet(string ExcelFileName, string SheetName)
        {
            Microsoft.Office.Interop.Excel.Application objApplication = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks objBooks;
            Microsoft.Office.Interop.Excel.Workbook objWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet objWorkSheet;
            Microsoft.Office.Interop.Excel.Range objRange;

            var a = new short[] { 1, 2 };
            int i;

            try
            {
                if (File.Exists(ExcelFileName) == false) return;

                objBooks = objApplication.Workbooks;
                objWorkBook = objBooks.Open(ExcelFileName, false, false);
                objWorkSheet = objWorkBook.Worksheets[SheetName];
                objApplication.Visible = true;

                for (i = 1; i <= 256; i++)
                {
                    if (objWorkSheet.Cells[1, i].Value != null)
                    {
                        if (objWorkSheet.Cells[1, i].Value != "")
                        {
                            if (objWorkSheet.Cells[2, i].Value != null)
                            {
                                DateTime temp;

                                if (DateTime.TryParse(objWorkSheet.Cells[2, i].Value.ToString(), out temp) == true)
                                {
                                    objRange = objWorkSheet.Columns[i];
                                    objRange.TextToColumns(objRange, Microsoft.Office.Interop.Excel.XlTextParsingType.xlDelimited, Microsoft.Office.Interop.Excel.XlTextQualifier.xlTextQualifierDoubleQuote, ConsecutiveDelimiter: false, Tab: true, Semicolon: false, Comma: false, Space: false, Other: false, FieldInfo: new short[] { 1, 1 }, TrailingMinusNumbers: true);
                                }
                                else
                                {
                                    objRange = objWorkSheet.Columns[i];
                                    objRange.TextToColumns(objRange, Microsoft.Office.Interop.Excel.XlTextParsingType.xlDelimited, Microsoft.Office.Interop.Excel.XlTextQualifier.xlTextQualifierDoubleQuote, ConsecutiveDelimiter: false, Tab: true, Semicolon: false, Comma: false, Space: false, Other: false, FieldInfo: new short[] { 1, 2 }, TrailingMinusNumbers: true);
                                }
                            }
                            else
                            {
                                objRange = objWorkSheet.Columns[i];
                                objRange.TextToColumns(objRange, Microsoft.Office.Interop.Excel.XlTextParsingType.xlDelimited, Microsoft.Office.Interop.Excel.XlTextQualifier.xlTextQualifierDoubleQuote, ConsecutiveDelimiter: false, Tab: true, Semicolon: false, Comma: false, Space: false, Other: false, FieldInfo: new short[] { 1, 2 }, TrailingMinusNumbers: true);
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                objWorkBook.Save();
                objWorkBook.Close();
                objBooks.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            finally
            {
                objApplication.Quit();
                Marshal.FinalReleaseComObject(objApplication);
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void LoadSheet()
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application objXls = new Microsoft.Office.Interop.Excel.Application();
                // Microsoft.Office.Interop.Excel.Workbook objBook = new Microsoft.Office.Interop.Excel.Workbook();
                Microsoft.Office.Interop.Excel.Workbook objBook;

                if (txtFilePath.Text != "")
                {
                    objBook = objXls.Workbooks.Open(txtFilePath.Text);
                    cmbSheetName.Items.Clear();
                    for (int i = 1; i <= objXls.ActiveWorkbook.Worksheets.Count; i++)
                    {
                        cmbSheetName.Items.Add(objXls.ActiveWorkbook.Worksheets[i].Name);
                    }
                    objXls.Workbooks.Close();
                }
                objXls.Quit();
                cmbSheetName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            btnImport.Enabled = false;
            btnCancel.Enabled = false;

            importfile();

            btnImport.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void importfile()
        {
            string[] ExcelFields;
            string selectedfields = "";
            string status = "";
            string[] query;

            string[] DBFields = new string[] { "CLEARING_DATE","CLEARING_LOC_CODE","CLIENT_CODE", "CHQ_DATE", "CHQ_NO", "CHQ_AMOUNT",
                "MICR_CODE", "TRAN_CODE", "BASE_CODE", "ACC_NO","CUSTOMER_NAME", "DEPOSIT_DATE", "DEPOSIT_SLIP_NO","DEPOSIT_AMOUNT",
                "LOCATION_CODE","BANK_CODE","BANK_ACC_NO" };

            if (txtFilePath.Text == "")
            {
                MessageBox.Show("File path should not be empty", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFilePath.Focus();
                return;
            }

            if (cmbSheetName.Text.Trim() == "")
            {
                MessageBox.Show("Sheet name should not be empty", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbSheetName.Focus();
                return;
            }

            formatsheet(txtFilePath.Text, cmbSheetName.Text);

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            string file = txtFilePath.Text;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(file);
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[cmbSheetName.Text.Trim()]; // assume it is the first sheet
            Microsoft.Office.Interop.Excel.Range range = xlWorksheet.UsedRange;

            try
            {
                ExcelFields = new string[range.Columns.Count];
                for (int i = 1; i <= range.Columns.Count; i++)
                {
                    if (((Microsoft.Office.Interop.Excel.Range)range.Cells[1, i]).Value2 != null)
                    {
                        ExcelFields[(i - 1)] = ((Microsoft.Office.Interop.Excel.Range)range.Cells[1, i]).Value2;
                        if (i == 1)
                        {
                            selectedfields = ((Microsoft.Office.Interop.Excel.Range)range.Cells[1, i]).Value2;
                        }
                        else
                        {
                            selectedfields = selectedfields + "," + ((Microsoft.Office.Interop.Excel.Range)range.Cells[1, i]).Value2; ;
                        }
                    }
                }

                List<string> y = ExcelFields.ToList<string>();
                y.RemoveAll(p => string.IsNullOrEmpty(p));
                ExcelFields = y.ToArray();
                bool areEqual = DBFields.SequenceEqual(ExcelFields);
                //bool areEqual = true;
                query = new string[(range.Rows.Count - 1)];

                if (areEqual == true)
                {
                    if (range.Rows.Count > 0)
                    {
                        string excelConnectionString = "";

                        if (file.Split('.')[file.Split('.').Length - 1].ToLower() == "xlsx")
                            excelConnectionString = excelConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";";
                        else
                            excelConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + file + ";" + "Extended Properties=Excel 8.0;";

                        OleDbConnection excelConnection = new OleDbConnection(excelConnectionString);
                        excelConnection.Open();
                        string tableName = excelConnection.GetSchema("Tables").Rows[0]["TABLE_NAME"].ToString();
                        OleDbCommand cmd = new OleDbCommand("Select " + selectedfields + " from [" + tableName + "]", excelConnection);
                        DataSet ds = new DataSet();
                        OleDbDataAdapter da = new OleDbDataAdapter("Select " + selectedfields + " from [" + tableName + "]", excelConnection);
                        da.Fill(ds);
                        DataTable dt = ds.Tables[0];
                        int k = 0;
                        ClearingDump_Model.FileHdr ObjFilehdr = new ClearingDump_Model.FileHdr();
                        ClearingDump_Model.ClearingDumHdr ObjClearinghdr = new ClearingDump_Model.ClearingDumHdr();

                        ClearingDumpBusiness ObjBusiness = new ClearingDumpBusiness();
                        string[] result = { };
                       
                        if (dt.Rows.Count > 0)
                        {
                            ObjFilehdr.file_gid = 0;
                            ObjFilehdr.file_name = file.Split('\\')[file.Split('\\').Length - 1];
                            ObjFilehdr.file_type = "C";
                            ObjFilehdr.sheet_name = cmbSheetName.Text.Trim();
                            ObjFilehdr.action = global_variable.action_insert;
                            ObjFilehdr.action_by = global_variable.user_name;
                            result = ObjBusiness.SaveFileDetails(ObjFilehdr);
                            ObjFilehdr.out_gid = Convert.ToInt32(result[2]);
                        }

                        if (result[1].ToString() == "1")
                        {
                            string txt;

                            using (StreamWriter writer = new StreamWriter(global_variable.report_path + "err.txt"))
                            {
                                for (long i = 0; i < dt.Rows.Count; i++)
                                {
                                    ObjClearinghdr.clrg_gid = 0;
                                    ObjClearinghdr.file_gid = ObjFilehdr.out_gid;
                                    string clrg_date_str = dt.Rows[Convert.ToInt32(i)]["CLEARING_DATE"].ToString();

                                    if (clrg_date_str != "")
                                    {
                                        DateTime Clrdate = DateTime.Parse(clrg_date_str);
                                        ObjClearinghdr.clrg_date = Clrdate.ToString("yyyy-MM-dd");
                                    }
                                    else
                                    {
                                        ObjClearinghdr.clrg_date = "";
                                    }

                                    ObjClearinghdr.clrg_loc_code = dt.Rows[Convert.ToInt32(i)]["CLEARING_LOC_CODE"].ToString();
                                    ObjClearinghdr.client_code = dt.Rows[Convert.ToInt32(i)]["CLIENT_CODE"].ToString();

                                    string chq_date_str = dt.Rows[Convert.ToInt32(i)]["CHQ_DATE"].ToString();

                                    if (chq_date_str != "")
                                    {
                                        DateTime Clrdate = DateTime.Parse(chq_date_str);
                                        ObjClearinghdr.chq_date = Clrdate.ToString("yyyy-MM-dd");
                                    }
                                    else
                                    {
                                        ObjClearinghdr.chq_date = "";
                                    }

                                    ObjClearinghdr.chq_no = string.Format("{0:000000}", Convert.ToInt32(dt.Rows[Convert.ToInt32(i)]["CHQ_NO"].ToString()));
                                    ObjClearinghdr.chq_amount = Convert.ToDouble(dt.Rows[Convert.ToInt32(i)]["CHQ_AMOUNT"].ToString());
                                    ObjClearinghdr.micr_code = dt.Rows[Convert.ToInt32(i)]["MICR_CODE"].ToString();
                                    ObjClearinghdr.tran_code = dt.Rows[Convert.ToInt32(i)]["TRAN_CODE"].ToString();
                                    ObjClearinghdr.base_code = dt.Rows[Convert.ToInt32(i)]["BASE_CODE"].ToString();
                                    ObjClearinghdr.acc_no = dt.Rows[Convert.ToInt32(i)]["ACC_NO"].ToString();
                                    ObjClearinghdr.cust_name = dt.Rows[Convert.ToInt32(i)]["CUSTOMER_NAME"].ToString();
                                    string deposit_date_str = dt.Rows[Convert.ToInt32(i)]["DEPOSIT_DATE"].ToString();
                                    if (chq_date_str != "")
                                    {
                                        DateTime Clrdate = DateTime.Parse(deposit_date_str);
                                        ObjClearinghdr.deposit_date = Clrdate.ToString("yyyy-MM-dd");
                                    }
                                    else
                                    {
                                        ObjClearinghdr.deposit_date = "";
                                    }
                                    ObjClearinghdr.deposit_slip_no = dt.Rows[Convert.ToInt32(i)]["DEPOSIT_SLIP_NO"].ToString();
                                    ObjClearinghdr.deposit_amount = Convert.ToDouble(dt.Rows[Convert.ToInt32(i)]["DEPOSIT_AMOUNT"].ToString());
                                    ObjClearinghdr.loc_code = dt.Rows[Convert.ToInt32(i)]["LOCATION_CODE"].ToString();
                                    ObjClearinghdr.bank_code = dt.Rows[Convert.ToInt32(i)]["BANK_CODE"].ToString();
                                    ObjClearinghdr.bank_acc_no = dt.Rows[Convert.ToInt32(i)]["BANK_ACC_NO"].ToString();
                                    ObjClearinghdr.action = global_variable.action_insert;
                                    ObjClearinghdr.action_by = global_variable.user_name;

                                    string[] result_clear = ObjBusiness.SaveClearingDtls(ObjClearinghdr);

                                    ObjClearinghdr.out_gid = Convert.ToInt32(result_clear[2]);

                                    if (result_clear[1] == "1")
                                    {
                                        k++;
                                    }
                                    else
                                    {
                                        txt = "Line " + (i + 1).ToString() + " : " + result_clear[0];
                                        writer.WriteLine(txt);
                                    }

                                    status = String.Concat("Out of ", dt.Rows.Count, " record(s) reading ", (i+1).ToString(), " record ...");

                                    Application.DoEvents();
                                    lblStatus.Text = status;
                                }
                            }

                            lblStatus.Text = "";

                            excelConnection.Close();

                            status = String.Concat("Out of ", dt.Rows.Count, " record(s) ", k, " record(s) imported successfully ! ");

                            MessageBox.Show(status,global_variable.proj_name,MessageBoxButtons.OK,MessageBoxIcon.Information);

                            status = "success";

                            if (k != dt.Rows.Count)
                            {
                                System.Diagnostics.Process.Start(global_variable.report_path + "err.txt");
                            }

                        }
                        else
                        {
                            MessageBox.Show(result[0].ToString(), global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    else
                    {

                        MessageBox.Show("There is no Records in Excel Sheet. Please Update Valid Excel..", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        status = "failed";
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Excel! Please Check it...", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    status = "failed";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                xlWorkbook.Close(true, Missing.Value, Missing.Value);
                xlApp.Quit();
                Marshal.ReleaseComObject(xlWorkbook);
                Marshal.ReleaseComObject(xlApp);

                Process[] excelProcesses = Process.GetProcessesByName("excel");

                foreach (Process p in excelProcesses)
                {
                    if (string.IsNullOrEmpty(p.MainWindowTitle)) // use MainWindowTitle to distinguish this excel process with other excel processes 
                    {
                        p.Kill();
                    }
                }
            }
        }
    }
}
