﻿using System;
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
    public partial class frmChequeRpt : Form
    {
        string root = string.Empty;
        public frmChequeRpt()
        {
            InitializeComponent();
            dgvDeposit.AutoGenerateColumns = true;
            dgvDeposit.EnableHeadersVisualStyles = false;
            dgvDeposit.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dgvDeposit.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnref_Click(object sender, EventArgs e)
        {
            btnload.Visible = true;
            lblload.Visible = true;
            try
            {
                string ConditionStatus = "";


                if (dtpChqFrom.Checked == true)
                {
                    ConditionStatus += " and a.chq_date >= '" + dtpChqFrom.Value.ToString("yyyy-MM-dd") + "' ";
                }
                if (dtpChqTo.Checked == true)
                {
                    ConditionStatus += " and a.chq_date <= '" + dtpChqTo.Value.ToString("yyyy-MM-dd") + "' ";
                }
                if (txtChequeNo.Text != "")
                {
                    ConditionStatus += " and a.chq_no = '" + txtChequeNo.Text + "' ";
                }
                if (txtChequeAmt.Text != "")
                {
                    ConditionStatus += " and a.chq_amount = '" + txtChequeAmt.Text + "' ";
                }
                if (dtpDepositFrom.Checked == true)
                {
                    ConditionStatus += " and b.deposit_date >= '" + dtpDepositFrom.Value.ToString("yyyy-MM-dd") + "' ";
                }
                if (dtpDepositTo.Checked == true)
                {
                    ConditionStatus += " and b.deposit_date <= '" + dtpDepositTo.Value.ToString("yyyy-MM-dd") + "' ";
                }
                if (txtDepositSlipNo.Text != "")
                {
                    ConditionStatus += " and b.deposit_slip_no = '" + txtDepositSlipNo.Text + "' ";
                }
                if (txtDepositAmt.Text != "")
                {
                    ConditionStatus += " and b.deposit_amount = '" + txtDepositAmt.Text + "' ";
                }
                if (txtDepositId.Text != "")
                {
                    ConditionStatus += " and b.deposit_gid = '" + txtDepositId.Text + "' ";
                }
                if (txtChqId.Text != "")
                {
                    ConditionStatus += " and a.chq_gid = '" + txtChqId.Text + "' ";
                }
                if (cmbStatus.Text != "")
                {
                    if (cmbStatus.Text.ToUpper() == "POSTED")
                    {
                        ConditionStatus += " and a.clearing_gid >0 ";
                    }
                    else if (cmbStatus.Text.ToUpper() == "NOT POSTED")
                    {
                        ConditionStatus += " and a.clearing_gid =0 ";
                    }
                    else if (cmbStatus.Text.ToUpper() == "ENRICHMENT COMPLETED")
                    {
                        ConditionStatus += " and a.chq_amount =a.mapped_amount ";
                    }
                    else if (cmbStatus.Text.ToUpper() == "ENRICHMENT PENDING")
                    {
                        ConditionStatus += " and a.chq_amount <> a.mapped_amount ";
                    }
                    else if (cmbStatus.Text.ToUpper() == "PULLOUT")
                    {
                        ConditionStatus += " and a.pullout_gid > 0 ";
                    }
                    else if (cmbStatus.Text.ToUpper() == "VALID")
                    {
                        ConditionStatus += " and a.pullout_gid = 0 ";
                    }
                }

                if (txtClearingId.Text != "")
                {
                    ConditionStatus += " and a.clearing_gid  = '" + txtClearingId.Text + "' ";
                }




                if (ConditionStatus == "")
                {
                    ConditionStatus = " and 1=2 ";
                }

                dgvDeposit.DataSource = null;
                ReportBusiness Obj = new ReportBusiness();
                DataTable dt = new DataTable();
                dt = Obj.GetChequeNewRpt(ConditionStatus);
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

        private void btnexport_Click(object sender, EventArgs e)
        {
            try
            {
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
                worksheet.Name = "Cheque_Rpt";

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
                            worksheet.Cells[i + 2, j + 1] = dgvDeposit.Rows[i].Cells[j].Value;
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
                workbook.SaveAs(root + "Cheque Report" + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
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

        private void frmDepositRpt_Resize(object sender, EventArgs e)
        {
            dgvDeposit.Height = this.Height - dgvDeposit.Top - 40;
            dgvDeposit.Width = this.Width - 32;
        }

        private void frmChequeRpt_Load(object sender, EventArgs e)
        {

            cmbStatus.Items.Add("All");
            cmbStatus.Items.Add("Posted");
            cmbStatus.Items.Add("Not Posted");
            cmbStatus.Items.Add("Enrichment Completed");
            cmbStatus.Items.Add("Enrichment Pending");
            cmbStatus.Items.Add("Enrichment Pending");
            cmbStatus.Items.Add("Pullout");
            cmbStatus.Items.Add("Valid");
        }
    }
}
