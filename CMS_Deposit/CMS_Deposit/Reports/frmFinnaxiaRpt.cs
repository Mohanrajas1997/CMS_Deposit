using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMS_Deposit.Business;
using CMS_Deposit.Common;
using System.IO;

namespace CMS_Deposit.Reports
{
    public partial class frmFinnaxiaRpt : Form
    {
        string root = string.Empty;
        public frmFinnaxiaRpt()
        {
            InitializeComponent();
            dgvDeposit.AutoGenerateColumns = true;
            dgvDeposit.EnableHeadersVisualStyles = false;
            dgvDeposit.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dgvDeposit.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            GetUploadcode();
        }

        private void btnref_Click(object sender, EventArgs e)
        {
            btnload.Visible = true;
            lblload.Visible = true;
            try
            {
                string ConditionStatus = "";


                if (dtpUploadFrom.Checked == true)
                {
                    ConditionStatus += " and a.upload_date >= '" + dtpUploadFrom.Value.ToString("yyyy-MM-dd") + "' ";
                }
                if (dtpUploadTo.Checked == true)
                {
                    ConditionStatus += " and a.upload_date <= '" + dtpUploadTo.Value.ToString("yyyy-MM-dd") + "' ";
                    ConditionStatus += " and a.upload_gid =" + cmbUploadNo.Text ;
                }
                if (cmbUploadNo.Text == "" || cmbUploadNo.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select the UploadNo ", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbUploadNo.Focus();
                    btnload.Visible = false;
                    lblload.Visible = false;
                    return;
                }
                if (ConditionStatus == "")
                {
                    ConditionStatus = " and 1=2 ";
                }

                dgvDeposit.DataSource = null;
                ReportBusiness Obj = new ReportBusiness();
                DataTable dt = new DataTable();
                dt = Obj.GetFinnaxiaRpt(cmbUploadNo.Text);
                dgvDeposit.DataSource = dt;

                lblTotRec.Text = "Total Records : " + dt.Rows.Count.ToString();

                btnload.Visible = false;
                lblload.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnload.Visible = false;
                lblload.Visible = false;
            }
            btnload.Visible = false;
            lblload.Visible = false;
        }
        private void btncellleave_evt(object sender, EventArgs e)
        {
            GetUploadcode();
        }

        private void GetUploadcode()
        {
            DataTable dtupload = new DataTable();
            UploadBusiness ObjBusiness = new UploadBusiness();

            string UploadFromdt = dtpUploadFrom.Value.ToString("yyyy-MM-dd");
            string UploadTodt = dtpUploadTo.Value.ToString("yyyy-MM-dd");
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
        private void btnexport_Click(object sender, EventArgs e)
        {
            try
            {
                string d = DateTime.Now.ToString("ddMMyyyyhhmmss");              
                btnload.Visible = true;
                lblload.Visible = true;

                if (dgvDeposit.Rows.Count == 0)
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
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Finnaxia_Rpt";

                // storing header part in Excel  
                for (int i = 1; i < dgvDeposit.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvDeposit.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dgvDeposit.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvDeposit.Columns.Count; j++)
                    {
                        if (dgvDeposit.Rows[i].Cells[j].Value != null)
                            if (j == 5 || j == 4 || j == 7 || j == 22 || j == 2 || j == 3 || j == 17)
                            {
                                worksheet.Cells[i + 2, j + 1] = "'" + dgvDeposit.Rows[i].Cells[j].Value;
                            }
                            else
                            {
                                worksheet.Cells[i + 2, j + 1] =  dgvDeposit.Rows[i].Cells[j].Value;
                            }
                    }
                }
                string exePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
                root = exePath + "\\Reports\\";
                //string root = DestinationFile;
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }

                // save the application  
                workbook.SaveAs(root + "Finnaxia Report" + d + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                app.Quit();
                MessageBox.Show("Export Excel Completed..!", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblload.Visible = false;
                btnload.Visible = false;
            }
            catch (Exception ex)
            {
                //LogHelper.WriteLog(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnload.Visible = false;
                lblload.Visible = false;

                return;
            }
        }

        private void btncls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFinnaxiaRpt_Load(object sender, EventArgs e)
        {

        }

        private void frmFinnaxiaRpt_Resize(object sender, EventArgs e)
        {
            dgvDeposit.Height = this.Height - dgvDeposit.Top - 40;
            dgvDeposit.Width = this.Width - 32;
        }
    }
}
