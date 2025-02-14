using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
//using System.Data.SqlClient;


namespace DataAccessLayer.Responsitories
{
    public class Database //tuong tac vs csdl
    {
        private SqlConnection connect = null;
        private SqlCommand command = null;
        private string connString = "";
        public Database()
        {
            try
            {
                connString = "Data Source=NHAT\\SQLEXPRESS;Initial Catalog=QL_SNAC;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
                //connString = "Data Source=.;Initial Catalog=QL_SNAC;Integrated Security=True;Trust Server Certificate=True";
                connect = new SqlConnection(connString);
                command = new SqlCommand();
                command.Connection = connect;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable GetDataFromDB(string sql, CommandType commandtype, ref string error, params SqlParameter[] paramlist)
        {
            try
            {
                connect.Open();
                command.CommandText = sql;
                command.CommandType = commandtype;
                command.Parameters.Clear();
                if (paramlist != null)
                {
                    foreach (var paraitem in paramlist)
                    {
                        command.Parameters.Add(paraitem);
                    }
                }
                SqlDataReader reader = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(reader);
                error = "";
                return data;
            }
            catch (Exception ex)
            {
                error = "Ket noi lôi: " + ex.Message;
                return null;
            }
            finally
            {
                connect.Close();
            }
        }

        public object GetValueFromDB(string sql, CommandType commandtype, ref string error, params SqlParameter[] paramlist)
        {
            try
            {
                connect.Open();
                command.CommandText = sql;
                command.CommandType = commandtype;
                command.Parameters.Clear();
                if (paramlist != null)
                {
                    foreach (var paraitem in paramlist)
                    {
                        command.Parameters.Add(paraitem);
                    }
                }
                var data = command.ExecuteScalar();
                error = "";
                return data;
            }
            catch (Exception ex)
            {
                error = "Ket noi lôi: " + ex.Message;
                return null;
            }
            finally
            {
                connect.Close();
            }
        }
        public bool ProcessData(string sql,CommandType commandtype, ref string error, params SqlParameter[] paramlist)
        {
            try
            {
                connect.Open();
                command.CommandText = sql;
                command.CommandType = commandtype;
                command.Parameters.Clear();
                if (paramlist != null)
                {
                    foreach(var paraitem in paramlist)
                    {
                        command.Parameters.Add(paraitem);
                    }
                }
                int row = command.ExecuteNonQuery();
                if (row == 0)
                {
                    error = "";
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = "Ket noi lôi: " + ex.Message;
                return false;
            }
            finally
            {
                connect.Close();
            }
        }
        public int GetIdentity(string sql, CommandType commandtype, ref string error, params SqlParameter[] paramlist)
        {
            try
            {
                connect.Open();
                command.CommandText = sql;
                command.CommandType = commandtype;
                command.Parameters.Clear();
                if (paramlist != null)
                {
                    foreach (var paraitem in paramlist)
                    {
                        command.Parameters.Add(paraitem);
                    }
                }

                object result = command.ExecuteScalar(); // Lấy giá trị duy nhất

                if (result != null && int.TryParse(result.ToString(), out int newId))
                {
                    return newId;
                }
                else
                {
                    error = "Không thể lấy ID.";
                    return -1;
                }
            }
            catch (Exception ex)
            {
                error = "Lỗi kết nối hoặc truy vấn CSDL: " + ex.Message;
                return -1;
            }
            finally
            {
                connect.Close();
            }
        }

        public string HashPassword(string password) // Changed to public
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}

