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
    public partial class frmPickupPoint : Form
    {
        public PickupPoint_Model.PickupPointDtls ObjPickupPoint = new PickupPoint_Model.PickupPointDtls();

        public frmPickupPoint(PickupPoint_Model.PickupPointDtls _PickupEntry)
        {
            InitializeComponent();
            ObjPickupPoint = _PickupEntry;
            Dropdownload();

            CmbClientCode.Text = ObjPickupPoint.client_code;
            txtclientname.Text = ObjPickupPoint.client_name;          
            cmbpickuppoint.Text = ObjPickupPoint.pickup_point;
            txtNoofChq.Text = Convert.ToInt32(ObjPickupPoint.tot_chq).ToString();
            cmbclientack.Text = ObjPickupPoint.client_ack;
        }
      
        private void EntityAddress_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }
      
        public void Dropdownload()
        {
            PickupBusiness objpickup = new PickupBusiness();
            DataSet dslist = new DataSet();
            DataTable dtclient = new DataTable();
            DataTable dtpickup = new DataTable();

            dtclient = objpickup.GetClientCode();
            if (dtclient.Rows.Count > 0)
            {
                CmbClientCode.DataSource = dtclient;
                CmbClientCode.DisplayMember = "qcd_short_code";
                CmbClientCode.ValueMember = "qcd_code";

                CmbClientCode.Text = "";
                CmbClientCode.SelectedIndex = -1;
            }
            else
            {
                CmbClientCode.Text = " ";
            }

            dtpickup = objpickup.GetPickupDtls();
            if (dtpickup.Rows.Count > 0)
            {
                cmbpickuppoint.DataSource = dtpickup;
                cmbpickuppoint.DisplayMember = "qcd_name";
                cmbpickuppoint.ValueMember = "qcd_code";

                cmbpickuppoint.Text = "";
                cmbpickuppoint.SelectedIndex = -1;
            }
            else
            {
                cmbpickuppoint.Text = " ";
            }

            cmbclientack.Items.Add("YES");
            cmbclientack.Items.Add("NO");
        }

        public void clear()
        {
            CmbClientCode.ResetText();
            txtclientname.Clear();
            txtNoofChq .Clear();
            cmbpickuppoint.ResetText();           
            cmbclientack.ResetText();
        }

        private void btnadd1_Click(object sender, EventArgs e)
        {
            #region VALIDATION
            int c = 0;

            if (CmbClientCode.SelectedItem == null)
            {
                MessageBox.Show("Please select client code !", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbClientCode.Focus();
                return;
            }
            if (cmbpickuppoint.SelectedItem == null)
            {
                MessageBox.Show("Please select pickup point !", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbpickuppoint.Focus();
                return;
            }

            Int32.TryParse(txtNoofChq.Text, out c);

            if (c <= 0)
            {
                MessageBox.Show("Please enter no of cheques !", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNoofChq.Focus();
                return;
            }

            if (cmbclientack.Text == "" || cmbclientack.SelectedIndex == -1)
            {
                MessageBox.Show("Please select client ack status !", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbclientack.Focus();
                return;
            }

            #endregion

            //Pickup Entry grid Value Binding area..
            ObjPickupPoint.qcd_client_code = CmbClientCode.SelectedValue.ToString();
            ObjPickupPoint.client_code  = CmbClientCode.Text.ToString();
            ObjPickupPoint.client_name  = txtclientname.Text.ToString();
            ObjPickupPoint.qcd_pickup_code = cmbpickuppoint.SelectedValue.ToString();
            ObjPickupPoint.pickup_point  = cmbpickuppoint.Text.ToString();
            ObjPickupPoint.tot_chq  = Convert.ToInt32 (txtNoofChq .Text.ToString());
            ObjPickupPoint.client_ack  = cmbclientack.Text.ToString();
            ObjPickupPoint.save_flag = "Y";

            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtNoofChq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void CmbClientCode_Leave(object sender, EventArgs e)
        {

        }

        private void frmPickupPoint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void CmbClientCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            PickupBusiness ObjPickup = new PickupBusiness();
            if (CmbClientCode.SelectedIndex > -1 && CmbClientCode.Text != "")
            {
                txtclientname.Text = ObjPickup.GetClientName(CmbClientCode.SelectedValue.ToString());
            }
            else
            {
                txtclientname.Text = "";
            }
        }

    }
}
