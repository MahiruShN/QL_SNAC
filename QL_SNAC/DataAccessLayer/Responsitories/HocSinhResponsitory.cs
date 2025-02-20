using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entity;
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


        public DataTable GetHocSinhByMSHS(string mshs, ref string error)
        {
            try
            {
                string sql = "SELECT * FROM THONG_TIN_HOC_SINH WHERE MSHS = @MSHS";
                SqlParameter[] parameters = { new SqlParameter("@MSHS", mshs) };

                return DB.GetDataFromDB(sql, CommandType.Text, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Error retrieving student: " + ex.Message;
                return null;
            }
        }



        public bool UpdateHocSinh(int mshs, string ho, string ten, string gioiTinh, DateTime ngaySinh,
                                  string noiSinh, string danToc, string quocTich, string diaChi,
                                  string dcThuongTru, string dcTamTru, ref string error)
        {
            string sql = @"UPDATE THONG_TIN_HOC_SINH 
                           SET HO = @HO, TEN = @TEN, GIOITINH = @GIOITINH, NGAY_SINH = @NGAY_SINH, 
                               NOI_SINH = @NOI_SINH, DAN_TOC = @DAN_TOC, QUOC_TICH = @QUOC_TICH, 
                               DIA_CHI = @DIA_CHI, DIA_CHI_THUONG_TRU = @DIA_CHI_THUONG_TRU, DIA_CHI_TAM_TRU = @DIA_CHI_TAM_TRU
                           WHERE MSHS = @MSHS";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MSHS", mshs),
                new SqlParameter("@HO", ho),
                new SqlParameter("@TEN", ten),
                new SqlParameter("@GIOITINH", gioiTinh),
                new SqlParameter("@NGAY_SINH", ngaySinh),
                new SqlParameter("@NOI_SINH", noiSinh),
                new SqlParameter("@DAN_TOC", danToc),
                new SqlParameter("@QUOC_TICH", quocTich),
                new SqlParameter("@DIA_CHI", diaChi),
                new SqlParameter("@DIA_CHI_THUONG_TRU", dcThuongTru),
                new SqlParameter("@DIA_CHI_TAM_TRU", dcTamTru)
            };

            return DB.ProcessData(sql, CommandType.Text, ref error, parameters);
        }



    }

}

