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
    public partial class frmCreateUser : Form
    {
        public int UserGid = 0;
        public string Action = "";
        string user_name = string.Empty;
        DataTable dtentity = new DataTable();

        public frmCreateUser(string UserName)
        {
            InitializeComponent();
            user_name = UserName;
            pnlSave.Visible = true;
        }

        public void Clear()
        {
            txtusergid.Text = "";
            txtCode.Text = "";
            txtName.Text = "";
            cboSex.Text = "";
            txtAddr1.Text = "";
            //dtentity.Rows.Clear();
            //txtAddr2.Text = "";
            //txtAddr3.Text = "";
            //txtAddr4.Text = "";
            txtCity.Text = "";
            txtMobileNo.Text = "";
            txtMailId.Text = "";
            txtDept.Text = "";
            txtDesig.Text = "";
            txtPincode.Text = "";
            txtUserStatus.Text = "";
            chkActivate.Checked = false;
        }

        public void LoadMasterDetails()
        {
          
            try
            {
                AdminBusiness obj = new AdminBusiness();
                DataTable dtgroup = new DataTable();
                dtgroup = obj.GetUserGroup();
                DataRow rows = dtgroup.NewRow();
                rows["usergroup_name"] = "--Select--";
                dtgroup.Rows.InsertAt(rows, 0);
                cboUserGrp.DataSource = dtgroup;
                cboUserGrp.DisplayMember = "usergroup_name";
                cboUserGrp.ValueMember = "usergroup_gid";


                ////Datagridview dataloading area..
                //QuickCodeMasterBusiness objentyselect = new QuickCodeMasterBusiness();
                //DataSet dslist = new DataSet();
                //dslist = objentyselect.GetEntitySelect();

                //if (dslist.Tables[0].Rows.Count > 0)
                //{
                //    dtentity = dslist.Tables[0];
                //}

                //DataRow row = dtentity.NewRow();
                //dgventity.DataSource = dtentity;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCreateUser_Load(object sender, EventArgs e)
        {
            try
            {

                cboSex.Items.Clear();
                cboSex.Items.Add("Male");
                cboSex.Items.Add("Female");
                LoadMasterDetails();
                LoadMasterDetails();
                pnlButtons.Visible = true;
                pnlSave.Visible = false;

                pnlMain.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnsve_Click(object sender, EventArgs e)
        {
            try
            {

                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to save the record?", global_variable.proj_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (txtCode.Text == "")
                    {
                        MessageBox.Show("User code cannot be empty ! ", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCode.Focus();
                        return;
                    }
                    if (cboSex.Text == "")
                    {
                        MessageBox.Show("Gender cannot be empty ! ", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cboSex.Focus();
                        return;
                    }
                    if (txtName.Text == "")
                    {
                        MessageBox.Show("user name cannot be empty ! ", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtName.Focus();
                        return;
                    }
                    if (txtAddr1.Text == "")
                    {
                        MessageBox.Show("Address cannot be empty !", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAddr1.Focus();
                        return;
                    }
                    if (txtCity.Text == "")
                    {
                        MessageBox.Show("City name cannot be empty !", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCity.Focus();
                        return;
                    }
                    if (txtDesig.Text == "")
                    {
                        MessageBox.Show("Designation cannot be empty !", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDesig.Focus();
                        return;
                    }
                    if (txtDept.Text == "")
                    {
                        MessageBox.Show("Department name cannot be empty !", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDept.Focus();
                        return;
                    }
                    if (cboSex.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select valid gender !", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cboSex.Focus();
                        return;
                    }
                    if (cboUserGrp.Text == "--Select--" || cboUserGrp.Text == "")
                    {
                        MessageBox.Show("Please select valid User Group !", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cboUserGrp.Focus();
                        return;
                    }

                    if (txtMobileNo.Text == "" || txtMobileNo.Text.Length != 10)
                    {
                        MessageBox.Show("Please enter valid mobile no !", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMobileNo.Focus();
                        return;
                    }

                    if (txtMailId.Text == "")
                    {
                        MessageBox.Show("Please enter valid mail id !", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMailId.Focus();
                        return;
                    }

                    //UserMaster
                    AdminEntities.UserMaster Obj_UserMaster = new AdminEntities.UserMaster();
                    if (txtusergid.Text.ToString() == "") UserGid = 0; else UserGid = Int32.Parse(txtusergid.Text.ToString());
                    if (UserGid == 0)
                    {
                        Obj_UserMaster.user_gid = UserGid;
                        Obj_UserMaster.user_code = txtCode.Text.Trim();
                        Obj_UserMaster.user_name = txtName.Text.Trim();
                        Obj_UserMaster.addr1 = txtAddr1.Text.Trim();
                        //Obj_UserMaster.addr2 = txtAddr2.Text.Trim();
                        //Obj_UserMaster.addr3 = txtAddr3.Text.Trim();
                        //Obj_UserMaster.addr4 = txtAddr4.Text.Trim();
                        Obj_UserMaster.city = txtCity.Text.Trim();
                        Obj_UserMaster.pincode = txtPincode.Text.Trim();
                        Obj_UserMaster.mobile_no = txtMobileNo.Text.Trim();
                        Obj_UserMaster.mail_id = txtMailId.Text.Trim();
                        Obj_UserMaster.sex = cboSex.Text;
                        Obj_UserMaster.dob = dtpDob.Value.ToString("yyyy-MM-dd");
                        Obj_UserMaster.doj = dtpDoj.Value.ToString("yyyy-MM-dd");
                        Obj_UserMaster.desig_name = txtDesig.Text.Trim();
                        Obj_UserMaster.dept_name = txtDept.Text.Trim();
                        Obj_UserMaster.user_status = txtUserStatus.Text.Trim();
                        Obj_UserMaster.pwd_flag = false;
                        Obj_UserMaster.usergroup_gid = Convert.ToInt16(cboUserGrp.SelectedValue.ToString());
                        Obj_UserMaster.action = global_variable.action_insert;
                    }
                    else
                    {
                        Obj_UserMaster.user_gid = UserGid;
                        Obj_UserMaster.user_code = txtCode.Text.Trim();
                        Obj_UserMaster.user_name = txtName.Text.Trim();
                        Obj_UserMaster.addr1 = txtAddr1.Text.Trim();
                        //Obj_UserMaster.addr2 = txtAddr2.Text.Trim();
                        //Obj_UserMaster.addr3 = txtAddr3.Text.Trim();
                        //Obj_UserMaster.addr4 = txtAddr4.Text.Trim();
                        Obj_UserMaster.city = txtCity.Text.Trim();
                        Obj_UserMaster.pincode = txtPincode.Text.Trim();
                        Obj_UserMaster.mobile_no = txtMobileNo.Text.Trim();
                        Obj_UserMaster.mail_id = txtMailId.Text.Trim();
                        Obj_UserMaster.sex = cboSex.Text;
                        Obj_UserMaster.dob = dtpDob.Value.ToString("yyyy-MM-dd");
                        Obj_UserMaster.doj = dtpDoj.Value.ToString("yyyy-MM-dd");
                        Obj_UserMaster.desig_name = txtDesig.Text.Trim();
                        Obj_UserMaster.dept_name = txtDept.Text.Trim();
                        Obj_UserMaster.user_status = txtUserStatus.Text.Trim();

                        Obj_UserMaster.pwd_flag = false;

                        if (chkActivate.Checked == true)
                        {
                            if (MessageBox.Show("Do you want to reset the password ?", "Password Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                            {
                                Obj_UserMaster.pwd_flag = true;
                            }
                        }
                        else

                        Obj_UserMaster.usergroup_gid = Convert.ToInt16(cboUserGrp.SelectedValue.ToString());
                        Obj_UserMaster.action = global_variable.action_update;
                    }
                    AdminBusiness objBusiness = new AdminBusiness();
                    string[] result = objBusiness.SaveUserMaster(Obj_UserMaster);              
                   
                    MessageBox.Show(result[0].ToString(), global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result[1].ToString() == "1")
                    {
                        if (DialogResult.Yes == MessageBox.Show("Do you want to add the record?", global_variable.proj_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            bntnew_Click(sender, e);
                            //Clear();
                            //frmCreateUser_Load(sender, e);
                            //pnlButtons.Hide();
                            //pnlMain.Enabled = true;
                            //LoadMasterDetails();
                            //pnlSave.Show();
                        }
                        else
                        {
                            btncancel.PerformClick();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            pnlButtons.Show();
            pnlSave.Hide();
            Clear();
            LoadMasterDetails();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntnew_Click(object sender, EventArgs e)
        {
            pnlMain.Enabled = true;
            pnlButtons.Hide();
            pnlSave.Show();
            Clear();
            LoadMasterDetails();
            txtCode.Focus();
        }

        private void btnedt_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                MessageBox.Show("select some Record to Edit", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            pnlMain.Enabled = true;
            pnlButtons.Hide();
            pnlSave.Show();
        }

        private void EmpCode_Leave(object sender, EventArgs e)
        {
            try
            {
                string empcode = txtCode.Text.Trim();
                if (empcode != "")
                {
                    DataTable dt = new DataTable();
                    AdminBusiness objBusiness = new AdminBusiness();
                    dt = objBusiness.GetUserDetails(empcode);
                    if (dt.Rows.Count > 0)
                    {
                        if (DialogResult.Yes == MessageBox.Show("Emp Code already is there, Are you sure you want to edit the record?", "", MessageBoxButtons.YesNo))
                        {
                            pnlButtons.Visible = true;
                            pnlSave.Visible = false;
                            UserGid = Convert.ToInt16(dt.Rows[0]["user_gid"]);
                            txtCode.Text = dt.Rows[0]["user_code"].ToString();
                            txtName.Text = dt.Rows[0]["user_name"].ToString();
                            cboSex.Text = dt.Rows[0]["sex"].ToString();
                            txtAddr1.Text = dt.Rows[0]["addr1"].ToString();
                            //txtAddr2.Text = dt.Rows[0]["addr2"].ToString();
                            //txtAddr3.Text = dt.Rows[0]["addr3"].ToString();
                            //txtAddr4.Text = dt.Rows[0]["addr4"].ToString();
                            txtCity.Text = dt.Rows[0]["city"].ToString();
                            txtMobileNo.Text = dt.Rows[0]["contact_no"].ToString();
                            txtDept.Text = dt.Rows[0]["dept_name"].ToString();
                            txtDesig.Text = dt.Rows[0]["desig_name"].ToString();
                            txtPincode.Text = dt.Rows[0]["pincode"].ToString();
                            txtUserStatus.Text = dt.Rows[0]["user_status"].ToString();
                            cboUserGrp.Text = dt.Rows[0]["usergroup_name"].ToString();

                            if (dt.Rows[0]["user_status"].ToString() == "Y")
                            {
                                chkActivate.Checked = true;
                            }
                            else
                            {
                                chkActivate.Checked = false;
                            }

                            dtpDob.Text = dt.Rows[0]["dob"].ToString();
                            dtpDoj.Text = dt.Rows[0]["doj"].ToString();
                            dtpDor.Text = dt.Rows[0]["dor"].ToString();

                            Action = "Update";

                        }
                        else
                        {
                            Clear();
                            LoadMasterDetails();
                            Action = "Insert";
                        }
                    }
                    else
                    {
                        Action = "Insert";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCode.Text == "")
                {
                    MessageBox.Show("select some Record to Delete", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DialogResult Dialog = MessageBox.Show("Are you sure delete the record?", global_variable.proj_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dialog == DialogResult.Yes)
                {
                    AdminEntities.UserMaster Obj_UserMaster = new AdminEntities.UserMaster();
                    if (txtusergid.Text.ToString() == "") UserGid = 0; else UserGid = Int32.Parse(txtusergid.Text.ToString());
                    if (UserGid != 0)
                    {
                        Obj_UserMaster.user_gid = UserGid;
                        Obj_UserMaster.user_code = "";
                        Obj_UserMaster.user_name = "";
                        Obj_UserMaster.addr1 = "";
                        Obj_UserMaster.addr2 = "";
                        Obj_UserMaster.addr3 = "";
                        Obj_UserMaster.addr4 = "";
                        Obj_UserMaster.city = "";
                        Obj_UserMaster.pincode = "";
                        Obj_UserMaster.mobile_no = "";
                        Obj_UserMaster.mail_id = "";
                        Obj_UserMaster.sex = "";
                        Obj_UserMaster.dob = dtpDob.Value.ToString("yyyy-MM-dd");
                        Obj_UserMaster.doj = dtpDoj.Value.ToString("yyyy-MM-dd");
                        Obj_UserMaster.desig_name = "";
                        Obj_UserMaster.dept_name = "";
                        Obj_UserMaster.user_status = "";
                        Obj_UserMaster.pwd_flag = false;
                        Obj_UserMaster.usergroup_gid = 0;
                        Obj_UserMaster.action = global_variable.action_delete;
                    }
                    AdminBusiness objBusiness = new AdminBusiness();
                    string[] result = objBusiness.SaveUserMaster(Obj_UserMaster);
                    MessageBox.Show(result[0].ToString(), global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result[1].ToString() == "1")
                    {
                        if (DialogResult.Yes == MessageBox.Show("Do you want to add the record?", global_variable.proj_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            Clear();
                            LoadMasterDetails();
                            frmCreateUser_Load(sender, e);
                            pnlButtons.Hide();
                            pnlMain.Enabled = true;
                            pnlSave.Show();
                        }
                        else
                        {
                            Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                string tablename = "soft_mst_tuser";
                string fieldname = "user_gid as Id,user_code,user_name";
                string Where_condition = "delete_flag='N'";
                string oderby = "user_gid asc";
                string returnfld = "Id";

                DataTable dtUser;
                
                frmFind formfind = new frmFind(tablename, fieldname, Where_condition, oderby, returnfld);
                formfind.ShowDialog();
                
                int gid = Convert.ToInt32(formfind.txt);

                AdminBusiness objBusiness = new AdminBusiness();
                dtUser = objBusiness.GetUserById(gid);

                if (dtUser.Rows.Count >0)
                {
                    txtusergid.Text = dtUser.Rows[0]["user_gid"].ToString();
                    txtCode.Text = dtUser.Rows[0]["user_code"].ToString();
                    cboSex.Text = dtUser.Rows[0]["sex"].ToString();
                    txtName.Text = dtUser.Rows[0]["user_name"].ToString();
                    txtAddr1.Text = dtUser.Rows[0]["addr1"].ToString();
                    txtCity.Text = dtUser.Rows[0]["city"].ToString();
                    txtPincode.Text = dtUser.Rows[0]["pincode"].ToString();
                    txtMobileNo.Text = dtUser.Rows[0]["mobile_no"].ToString();
                    txtMailId.Text = dtUser.Rows[0]["mail_id"].ToString();
                    dtpDob.Text = dtUser.Rows[0]["dob"].ToString();
                    dtpDoj.Text = dtUser.Rows[0]["doj"].ToString();
                    txtDesig.Text = dtUser.Rows[0]["desig_name"].ToString();
                    txtDept.Text = dtUser.Rows[0]["dept_name"].ToString();
                    cboUserGrp.SelectedValue = dtUser.Rows[0]["usergroup_gid"].ToString();
                    dtpDor.Text = dtUser.Rows[0]["dor"].ToString();

                    if (dtUser.Rows[0]["user_status"].ToString() == "Y") 
                        chkActivate.Checked = true;
                    else 
                        chkActivate.Checked = false;

                    chkActivate.Text = "Activate User";

                    txtUserStatus.Text = dtUser.Rows[0]["user_status"].ToString();                 
                }

                pnlMain.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void dtpDob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void dtpDoj_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
