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
    public partial class frmCreateGroup : Form
    {
        int groupid = 0;
        public frmCreateGroup()
        {
            InitializeComponent();
        }

        private void btnsve_Click(object sender, EventArgs e)
        {
            try
            {
                string groupname = txtName.Text.Trim();
                if (txtName.Text == "")
                {
                    MessageBox.Show("Group Name cannot be empty!", "Validation", MessageBoxButtons.OK);
                    txtName.Focus();
                    return;
                }
                else
                {

                    AdminBusiness objSaveMaster = new AdminBusiness();
                    if (txtusergrpgid.Text.ToString() == "") groupid = 0; else groupid = Int32.Parse(txtusergrpgid.Text.ToString());
                    if (groupid == 0)
                    {
                        string[] result = objSaveMaster.SaveUserGroup(groupid, groupname, global_variable.action_insert);
                        MessageBox.Show(result[0].ToString(), global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (DialogResult.Yes == MessageBox.Show("Do you want to add the record?", global_variable.proj_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            bntnew_Click(sender, e);
                        }
                        else
                        {
                            btncancel_Click(sender, e);
                        }

                    }
                    else
                    {
                        string[] result = objSaveMaster.SaveUserGroup(groupid, groupname, global_variable.action_update);
                        MessageBox.Show(result[0].ToString(), global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (DialogResult.Yes == MessageBox.Show("Do you want to add the record?", global_variable.proj_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            txtName.Clear();
                            txtusergrpgid.Clear();
                            pnlButtons.Hide();
                            pnlMain.Enabled = true;
                            pnlSave.Show();
                            txtName.Focus();
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
                throw (ex);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            pnlButtons.Show();
            pnlSave.Hide();
            txtusergrpgid.Clear();
            txtName.Clear();
        }

        private void bntnew_Click(object sender, EventArgs e)
        {
            pnlMain.Enabled = true;
            pnlButtons.Hide();
            pnlSave.Show();
            txtName.Clear();
            txtusergrpgid.Clear();
            txtName.Focus();
        }

        private void btnedt_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("select some Record to Edit", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            pnlMain.Enabled = true;
            pnlButtons.Hide();
            pnlSave.Show();
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            DataTable dtedit = new DataTable();
            try
            {
                string tablename = "soft_mst_tusergroup";
                string fieldname = "usergroup_gid as Id,usergroup_name";
                string Where_condition = "delete_flag='N'";
                string oderby = "usergroup_gid asc";
                string returnfld = "Id";
                frmFind formfind = new frmFind(tablename, fieldname, Where_condition, oderby, returnfld);
                formfind.ShowDialog();
                int gid = Convert.ToInt32(formfind.txt);
                AdminEntities.UserMaster objusergrpedit = new AdminEntities.UserMaster();
                if (gid > 0)
                {
                    objusergrpedit.user_gid = gid;
                    objusergrpedit.action = global_variable.action_select;
                }
                AdminBusiness objBusiness = new AdminBusiness();
                dtedit = objBusiness.UserGroupEdit(objusergrpedit);
                if (dtedit.Rows.Count > 0)
                {
                    DataRow rows = dtedit.NewRow();
                    txtusergrpgid.Text = dtedit.Rows[0]["usergroup_gid"].ToString();
                    txtName.Text = dtedit.Rows[0]["usergroup_name"].ToString();

                }
                pnlMain.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCreateGroup_Load(object sender, EventArgs e)
        {
            pnlButtons.Visible = true;
            pnlSave.Visible = false;
            pnlMain.Enabled = false;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            try
            {
                string groupname = txtName.Text.Trim();
                if (txtName.Text == "")
                {
                    MessageBox.Show("select some Record to Delete", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DialogResult Dialog = MessageBox.Show("Are you sure delete the record?", global_variable.proj_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dialog == DialogResult.Yes)
                {
                    AdminBusiness objSaveMaster = new AdminBusiness();
                    if (txtusergrpgid.Text.ToString() == "") groupid = 0; else groupid = Int32.Parse(txtusergrpgid.Text.ToString());
                    if (groupid != 0)
                    {
                        string[] result = objSaveMaster.SaveUserGroup(groupid, groupname, global_variable.action_delete);
                        if (result[1].ToString() == "1")
                        {
                            MessageBox.Show(result[0].ToString(), global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(result[0].ToString());
                        }
                        if (result[1].ToString() == "1")
                        {
                            if (DialogResult.Yes == MessageBox.Show("Do you want to add the record?", global_variable.proj_name, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                            {
                                txtName.Clear();
                                txtusergrpgid.Clear();
                                pnlButtons.Hide();
                                pnlMain.Enabled = true;
                                pnlSave.Show();
                                txtName.Focus();
                            }
                            else
                            {
                                Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
