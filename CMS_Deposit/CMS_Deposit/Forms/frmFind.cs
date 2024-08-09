using CMS_Deposit.Common;
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
    public partial class frmFind : Form
    {
        string tb_name;
        string fld_name;
        string condition;
        string order_by;
        string return_fld;
        DataTable dt = new DataTable();
        public string txt = "0";

        public frmFind(string _tb_name, string _fld_name, string _condition, string _order_by, string _return_fld)
        {
            InitializeComponent();

            fld_name = _fld_name;
            tb_name = _tb_name;
            condition = _condition;
            order_by = _order_by;
            return_fld = _return_fld;
        }

        private void Find_Load(object sender, EventArgs e)
        {

            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                
                values.Add("fieldname", fld_name);
                values.Add("tablename", tb_name);
                values.Add("wcondition", condition);
                values.Add("orderby", order_by);

                dt = global_variable.con.RunProc("pr_soft_get_find", values);

                dgvsearch.DataSource = dt;
                lblTotRec.Text = "Total Records : " + dt.Rows.Count.ToString();

                foreach (DataColumn column in dt.Columns)
                {
                    cmbheader.Items.Add(column.ColumnName);
                }

                cmbcondition.Items.Add("Like");
                cmbcondition.Items.Add("Not Like");
                cmbcondition.Items.Add("=");
                cmbcondition.Items.Add(">");
                cmbcondition.Items.Add(">=");
                cmbcondition.Items.Add("<");
                cmbcondition.Items.Add("<=");
                cmbcondition.Items.Add("<>");
                cmbcondition.Text = "=";
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string header = cmbheader.Text.ToString().Trim();
                string condition = cmbcondition.Text.ToString().Trim();
                string text = condtext.Text;
                if (condition == "Like" || condition == "Not Like")
                {
                    DataRow[] dr = dt.Select("[" + header + "] " + condition + " " + "'%" + text + "%'");
                    DataTable dt1 = dr.CopyToDataTable();
                    dgvsearch.DataSource = dt1;
                }
                else
                {
                    if (text != null && text != "")
                    {
                        DataRow[] dr = dt.Select("[" + header + "] " + condition + " " + "'" + text + "'");

                        if (dr.Length > 0)
                        {
                            DataTable dt1 = dr.CopyToDataTable();
                            dgvsearch.DataSource = dt1;
                            lblTotRec.Text = "Total Records : " + dt1.Rows.Count.ToString();
                        }
                        else
                        {
                            dgvsearch.DataSource = dt.Select("[" + header + "] " + condition + " " + "'" + text + "'");
                            lblTotRec.Text = "Total Records : 0";
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (dgvsearch.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvsearch.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvsearch.Rows[selectedrowindex];
                txt = Convert.ToString(selectedRow.Cells[return_fld].Value);
                this.Close();
            }
        }

        private void dgvsearch_DoubleClick(object sender, EventArgs e)
        {
            if (dgvsearch.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvsearch.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvsearch.Rows[selectedrowindex];
                txt = Convert.ToString(selectedRow.Cells[return_fld].Value);
                this.Close();

            }
        }

        private void btncls_Click(object sender, EventArgs e)
        {
            txt = "0";
            this.Close();
        }
    }
}
