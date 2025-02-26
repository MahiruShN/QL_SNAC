using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Diagnostics;
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
                connString = "Data Source=Nhat\\SQLEXPRESS01;Initial Catalog=QL_SNAC;Integrated Security=True;Encrypt=False";
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
        public DataTable TimKiemNguoiDung(string tenBang, string tenCotHo, string tenCotTen, string tenCotMaSo, string searchText, ref string error)
        {
            try
            {
                string sql = $@"
            SELECT * -- Chọn tất cả các cột
            FROM {tenBang}
            WHERE {tenCotHo} + ' ' + {tenCotTen} LIKE @TenDayDu  -- Tìm kiếm theo tên đầy đủ
               OR {tenCotMaSo} LIKE @MaSo;
        ";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@TenDayDu", "%" + searchText + "%"), // Tìm kiếm gần đúng theo tên đầy đủ
            new SqlParameter("@MaSo", "%" + searchText + "%") // Tìm kiếm gần đúng theo mã số
                };

                return GetDataFromDB(sql, CommandType.Text, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi tìm kiếm người dùng: " + ex.Message;
                return null;
            }
        }
        public DataTable GetTableData(string tableName, ref string error)
        {
            try
            {
                string sql = $"SELECT * FROM {tableName}";
                return GetDataFromDB(sql, CommandType.Text, ref error);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi lấy dữ liệu bảng: " + ex.Message;
                return null;
            }
        }

        public string GetValueFromTable(string tableName, string columnName, string whereClause, ref string error)
        {
            try
            {
                string sql = $"SELECT {columnName} FROM {tableName} WHERE {whereClause}";
                object result = GetValueFromDB(sql, CommandType.Text, ref error);
                return result?.ToString(); // Use null-conditional operator
            }
            catch (Exception ex)
            {
                error = "Lỗi khi lấy giá trị từ bảng: " + ex.Message;
                return null;
            }
        }

        public object GetDataScalar(string sql, CommandType commandtype, ref string error, params SqlParameter[] paramlist)
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

                object result = command.ExecuteScalar();
                error = "";
                return result;
            }
            catch (Exception ex)
            {
                error = "Error executing scalar query: " + ex.Message;
                return null;
            }
            finally
            {
                connect.Close();
            }
        }
        public DataTable GetDataFromTableWithJoin(string sql, ref string error, params SqlParameter[] paramlist)
        {
            try
            {
                return GetDataFromDB(sql, CommandType.Text, ref error, paramlist);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi lấy dữ liệu từ bảng với JOIN: " + ex.Message;
                return null;
            }
        }

    }
}

