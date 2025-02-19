using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DataAccessLayer.Responsitories
{
    public class HocSinhResponsitory
    {
        private Database DB = new Database();
        public DataTable HienThiDSHocsinhRutgon(ref string error)
        {
            try
            {
                string sql = " select MSHS,HO, TEN,GIOITINH,NGAY_SINH " +
                             " from THONG_TIN_HOC_SINH";
                var rs = DB.GetDataFromDB(sql, CommandType.Text, ref error);
                return rs;
            }
            catch (Exception ex)
            {
                error = "Kết nối lỗi: " + ex.Message;
                return null;
            }
        }
        public DataTable TimKiemHocSinh(string searchText, ref string error)
        {
            try
            {
                // SQL query with parameterized query
                string sql = @"
                    SELECT MSHS AS 'Mã Học Sinh',
                           CONCAT(LTRIM(RTRIM(HO)), ' ', LTRIM(RTRIM(TEN))) AS 'Họ và Tên'
                    FROM THONG_TIN_HOC_SINH
                    WHERE (LTRIM(RTRIM(HO)) LIKE @SearchText AND LTRIM(RTRIM(TEN)) LIKE @SearchText)
                       OR LTRIM(RTRIM(MSHS)) LIKE @SearchText;
                ";

                // Create parameters
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@SearchText", "%" + searchText + "%")
                };


                var rs = DB.GetDataFromDB(sql, CommandType.Text, ref error, parameters);
                return rs;

            }
            catch (Exception ex)
            {
                error = "Lỗi khi tìm kiếm học sinh: " + ex.Message;
                return null;
            }
        }
    }




}

