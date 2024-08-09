using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using System.Configuration;
using System.Security.Cryptography;
using System.IO; 

namespace CMS_Deposit.Common
{
   public class Dataconnection
    {
        private MySqlConnection con;

        string connectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

        public Dataconnection()
        {
            con = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"].ToString());

            if (con.State == ConnectionState.Closed) con.Open();
        }

        public Dataconnection(string db)
        {
            con = new MySqlConnection();
            if (con.State == ConnectionState.Closed) con.Open();
        }

        public DataTable RunProc(string command, Dictionary<string, Object> values = null)
        {
            MySqlCommand cmd = new MySqlCommand();
            DataTable temp = new DataTable();
            
            if (con.State == ConnectionState.Closed) con.Open();

            cmd.Connection = con;
            cmd.CommandText = command;
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                if (values != null)
                {
                    foreach (string key in values.Keys)
                    {
                        if (values[key] == "out")
                        {
                            cmd.Parameters.Add(key, MySqlDbType.VarChar);
                            cmd.Parameters[key].Direction = ParameterDirection.Output;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(key, values[key]);
                        }
                    }
                }
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(temp);
                return temp;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return temp;
        }

        public string RunScalar(string command, Dictionary<string, Object> values = null)
        {
            MySqlCommand cmd = new MySqlCommand();
            DataTable temp = new DataTable();

            if (con.State == ConnectionState.Closed) con.Open();

            cmd.Connection = con;
            cmd.CommandText = command;
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                if (values != null)
                {
                    foreach (string key in values.Keys)
                    {
                        cmd.Parameters.AddWithValue(key, values[key]);
                    }
                }

                return cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public DataSet RunProc_ds(string command, Dictionary<string, Object> values = null)
        {
            MySqlCommand cmd = new MySqlCommand();
            DataSet temp = new DataSet();

            if (con.State == ConnectionState.Closed) con.Open();

            cmd.Connection = con;
            cmd.CommandText = command;
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                if (values != null)
                {
                    foreach (string key in values.Keys)
                    {
                        cmd.Parameters.AddWithValue(key, values[key]);
                    }
                }
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(temp);
                return temp;
            }
            catch (Exception ex)
            {
                return temp;
            }

        }
        public string[] RunDmlProc(string command, Dictionary<string, Object> values = null)
        {
            MySqlCommand cmd = new MySqlCommand();
            int rowsChanged = 0;

            if (con.State == ConnectionState.Closed) con.Open();

            cmd.Connection = con;
            cmd.CommandText = command;
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.StoredProcedure;

            string retmsg = string.Empty;
            string retresult = string.Empty; ;
            try
            {
                if (values != null)
                {

                    foreach (string key in values.Keys)
                    {

                        if (values[key] == "out")
                        {
                            cmd.Parameters.Add(key, MySqlDbType.VarChar);
                            cmd.Parameters[key].Direction = ParameterDirection.Output;
                        }
                        else
                        {
                            if (values[key] == null)
                            {
                                cmd.Parameters.AddWithValue(key, null);
                            }
                            else if (values[key].ToString() != "null")
                            {
                                cmd.Parameters.AddWithValue(key, values[key]);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue(key, null);
                            }
                        }
                    }
                }
                //con.Open();
                rowsChanged = cmd.ExecuteNonQuery();
                retmsg = (string)cmd.Parameters["out_msg"].Value;
                retresult = (string)cmd.Parameters["out_result"].Value;

                string[] returnvalues = { retmsg, retresult };
                //con.Close();
                return returnvalues;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string[] returnvalues = { "failed", "0" };
                return returnvalues;
            }
        }
        public string[] RunGUIDProc(string command, Dictionary<string, Object> values = null)
        {
            MySqlCommand cmd = new MySqlCommand();
            int rowsChanged = 0;

            if (con.State == ConnectionState.Closed) con.Open();

            cmd.Connection = con;
            cmd.CommandText = command;
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.StoredProcedure;

            string retmsg = string.Empty;
            string retresult = string.Empty;
            string retguid = string.Empty;

            try
            {
                if (values != null)
                {

                    foreach (string key in values.Keys)
                    {

                        if (values[key] == "out")
                        {
                            cmd.Parameters.Add(key, MySqlDbType.VarChar);
                            cmd.Parameters[key].Direction = ParameterDirection.Output;
                        }
                        else
                        {
                            if (values[key] == null)
                            {
                                cmd.Parameters.AddWithValue(key, null);
                            }
                            else if (values[key].ToString() != "null")
                            {
                                cmd.Parameters.AddWithValue(key, values[key]);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue(key, null);
                            }
                        }
                    }
                }
                //con.Open();
                rowsChanged = cmd.ExecuteNonQuery();
                retmsg = (string)cmd.Parameters["out_msg"].Value;
                retresult = (string)cmd.Parameters["out_result"].Value;
                retguid = (string)cmd.Parameters["out_gid"].Value;
                string[] returnvalues = { retmsg, retresult, retguid };
                //con.Close();
                return returnvalues;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string[] returnvalues = { "failed", "0" };
                return returnvalues;
            }
        }
        public DataTable Runeditdt(string command, Dictionary<string, Object> values = null)
        {
            MySqlCommand cmd = new MySqlCommand();
            int rowsChanged = 0;

            if (con.State == ConnectionState.Closed) con.Open();

            cmd.Connection = con;
            cmd.CommandText = command;
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable temp = new DataTable();
            try
            {
                if (values != null)
                {

                    foreach (string key in values.Keys)
                    {

                        if (values[key] == "out")
                        {
                            cmd.Parameters.Add(key, MySqlDbType.VarChar);
                            cmd.Parameters[key].Direction = ParameterDirection.Output;
                        }
                        else
                        {
                            if (values[key] == null)
                            {
                                cmd.Parameters.AddWithValue(key, null);
                            }
                            else if (values[key].ToString() != "null")
                            {
                                cmd.Parameters.AddWithValue(key, values[key]);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue(key, null);
                            }
                        }
                    }
                }
                //if (con.State == ConnectionState.Closed)
                //{
                //    con.Open();
                //}               

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(temp);
                return temp;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return temp;
            }
        }
        public DataSet Runeditds(string command, Dictionary<string, Object> values = null)
        {
            MySqlCommand cmd = new MySqlCommand();
            int rowsChanged = 0;

            if (con.State == ConnectionState.Closed) con.Open();

            cmd.Connection = con;
            cmd.CommandText = command;
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.StoredProcedure;

            DataSet temp = new DataSet();
            try
            {
                if (values != null)
                {

                    foreach (string key in values.Keys)
                    {

                        if (values[key] == "out")
                        {
                            cmd.Parameters.Add(key, MySqlDbType.VarChar);
                            cmd.Parameters[key].Direction = ParameterDirection.Output;
                        }
                        else
                        {
                            if (values[key] == null)
                            {
                                cmd.Parameters.AddWithValue(key, null);
                            }
                            else if (values[key].ToString() != "null")
                            {
                                cmd.Parameters.AddWithValue(key, values[key]);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue(key, null);
                            }
                        }
                    }
                }
                //if (con.State == ConnectionState.Closed)
                //{
                //    con.Open();
                //}               

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(temp);
                return temp;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return temp;
            }
        }
        public string[] Runsaveheadr(string command, Dictionary<string, Object> values = null)
        {
            MySqlCommand cmd = new MySqlCommand();
            int rowsChanged = 0;

            if (con.State == ConnectionState.Closed) con.Open();

            cmd.Connection = con;
            cmd.CommandText = command;
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.StoredProcedure;

            string retmsg = string.Empty;
            string retgid = string.Empty;
            string retresult = string.Empty; ;
            try
            {
                if (values != null)
                {

                    foreach (string key in values.Keys)
                    {

                        if (values[key] == "out")
                        {
                            cmd.Parameters.Add(key, MySqlDbType.VarChar);
                            cmd.Parameters[key].Direction = ParameterDirection.Output;
                        }
                        else
                        {
                            if (values[key] == null)
                            {
                                cmd.Parameters.AddWithValue(key, null);
                            }
                            else if (values[key].ToString() != "null")
                            {
                                cmd.Parameters.AddWithValue(key, values[key]);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue(key, null);
                            }
                        }
                    }
                }
                //if (con.State == ConnectionState.Closed)
                //{
                //    con.Open();
                //}               

                rowsChanged = cmd.ExecuteNonQuery();
                retmsg = (string)cmd.Parameters["out_msg"].Value.ToString();
                retresult = (string)cmd.Parameters["out_result"].Value.ToString();
                retgid = (string)cmd.Parameters["out_gid"].Value.ToString();

                string[] returnvalues = { retgid, retmsg, retresult };
                //con.Close();
                return returnvalues;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string[] returnvalues = { "0", "failed", "0" };
                con.Close();
                return returnvalues;
            }
        }

        public int RunIntProc(string command, Dictionary<string, Object> values = null)
        {
            MySqlCommand cmd = new MySqlCommand();
            int rowsChanged = 0;

            if (con.State == ConnectionState.Closed) con.Open();

            cmd.Connection = con;
            cmd.CommandText = command;
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.StoredProcedure;

            string retmsg = string.Empty;
            string retresult = string.Empty; ;
            try
            {
                if (values != null)
                {

                    foreach (string key in values.Keys)
                    {

                        if (values[key] == "out")
                        {
                            cmd.Parameters.Add(key, MySqlDbType.VarChar);
                            cmd.Parameters[key].Direction = ParameterDirection.Output;
                        }
                        else
                        {
                            if (values[key] == null)
                            {
                                cmd.Parameters.AddWithValue(key, null);
                            }
                            else if (values[key].ToString() != "null")
                            {
                                cmd.Parameters.AddWithValue(key, values[key]);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue(key, null);
                            }
                        }
                    }
                }
                //con.Open();
                object rowsChangeds = cmd.ExecuteScalar();
                rowsChanged = Convert.ToInt16(rowsChangeds);
                //retmsg = (string)cmd.Parameters["out_msg"].Value;
                //retresult = (string)cmd.Parameters["out_result"].Value;

                //string[] returnvalues = { retmsg, retresult };
                //con.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rowsChanged;
        }

        public string EncryptString(string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(global_variable.SymmetricKey);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public string DecryptString(string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(global_variable.SymmetricKey);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
