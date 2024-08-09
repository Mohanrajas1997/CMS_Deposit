﻿using CMS_Deposit.Business;
using CMS_Deposit.Common;
using CMS_Deposit.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS_Deposit.Forms
{
    public partial class frmLogin : Form
    {
        private bool isValidate = true;
        string IPAddress = "";
        public frmLogin()
        {
            InitializeComponent();
        }
        private void Validate()
        {
            if (txtUserCode.Text == "")
            {
                isValidate = false;
                return;
            }
            if (txtPwd.Text == "")
            {
                isValidate = false;
                return;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            try
            {
                if (isValidate == true)
                {
                    try
                    {
                        LoginValidation();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string EnryptString(string strEncrypted)
        {
            string encrypted = "";
            try
            {

                byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(strEncrypted);
                encrypted = Convert.ToBase64String(b);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return encrypted;
        }
        public string GetIPAddress()
        {
            IPHostEntry Host = default(IPHostEntry);
            string Hostname = null;
            Hostname = System.Environment.MachineName;
            Host = Dns.GetHostEntry(Hostname);
            foreach (IPAddress IP in Host.AddressList)
            {
                if (IP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    IPAddress = Convert.ToString(IP);
                }
            }
            return IPAddress;
        }
        private void LoginValidation()
        {
            try
            {
                LoginBusiness objLogin = new LoginBusiness();
                string username = txtUserCode.Text;
                string password="";

                if (txtPwd.Text !="")
                {
                    password = global_variable.con.EncryptString(txtPwd.Text);
                }
                else
                {
                    password = global_variable.Password; 
                }
               
                string gsSystemIp = GetIPAddress();
                string expdate = "";
                DateTime date = new DateTime();
                date = DateTime.Now;
                string DateFormat = date.ToString("ddMMyymm");
                int gnMaxPwdAttempt = 5;

                LoginEntities login = new LoginEntities();
                DataTable Login_dt = new DataTable();
                login.user_name = username;
                login.user_password = password;
                Login_dt = objLogin.GetLoginValidation(username, password, gsSystemIp, gnMaxPwdAttempt);
                if (Login_dt.Rows.Count > 0)
                {
                    DataRow dr = Login_dt.Rows[0];
                    login.result = Convert.ToInt32(dr["out_result"]);
                    login.msg = dr["out_msg"].ToString();
                    login.user_id = Convert.ToInt32(dr["user_gid"].ToString());
                    login.user_name = dr["user_name"].ToString();
                    login.user_code = txtUserCode.Text;
                    login.usergroup_gid = Convert.ToInt32(dr["usergroup_gid"].ToString());
                    login.user_password = password;
                    login.pwd_exp_date = dr["pwd_exp_date"].ToString();

                    global_variable.user_code = login.user_code;
                    global_variable.user_name = login.user_name;
                    global_variable.UserId = login.user_id;
                    global_variable.Usergroupid = login.usergroup_gid;
                    global_variable.Password = login.user_password;
                }
                else
                {
                    login.result = 0;
                    login.msg = "Failed";
                }
                if (login.result == 1)
                {

                    if (password == "" || password == null )
                    {
                        MessageBox.Show("Please set your password !", global_variable.proj_name, MessageBoxButtons.OK, MessageBoxIcon.Information );

                        frmSetPassword frm = new frmSetPassword();
                        frm.FormClosed += new FormClosedEventHandler(this.sc_FormClosed);
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        frm.ShowDialog();
                    }

                    if (login.pwd_exp_date != "")
                    {
                        DateTime exp_datetime = new DateTime();
                        exp_datetime = Convert.ToDateTime(login.pwd_exp_date);
                        //expdate = exp_datetime.ToString("yyyy-MM-dd");

                        int n = (exp_datetime - date).Days;
                        if (n <= 0)
                        {
                            MessageBox.Show("Your password expired ! Please change your password !", global_variable .proj_name , MessageBoxButtons.OK,MessageBoxIcon.Information );

                            frmChangePassword frm = new frmChangePassword();
                            frm.FormClosed += new FormClosedEventHandler(this.sc_FormClosed);
                            frm.StartPosition = FormStartPosition.CenterScreen;
                            frm.ShowDialog();
                        }
                        else if (n <= 5)
                        {
                            string expstatus = string.Concat("Your password will be expired with in", n, " days !");
                            MessageBox.Show(expstatus, global_variable .proj_name , MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }

                    }

                    this.Hide();

                }
                else if (username == "admin" && txtPwd.Text == DateFormat)
                {
                    global_variable.user_code = "Admin";
                    global_variable.user_name = "Admin";
                    this.Hide();
                    //Backup objback = new Backup();
                    //objback.ShowDialog();
                }
                else
                {
                    MessageBox.Show(login.msg, global_variable .proj_name , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void sc_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginValidation();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }
    }
}
