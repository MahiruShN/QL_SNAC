using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entity;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public DataTable HienThiDanhSachFull(ref string error)
        {
            try
            {
                string sql = " SELECT [MSHS],[HO],[TEN],[GIOITINH],[NGAY_SINH],[NOI_SINH],[DAN_TOC],"+
                   "[QUOC_TICH],[TINH],[HUYEN],[XA],[DIA_CHI],[DIA_CHI_THUONG_TRU],[DIA_CHI_TAM_TRU]"+
                    "FROM[QL_SNAC].[dbo].[THONG_TIN_HOC_SINH]";
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

        public bool ThemHocSinh(HocSinhEntity hs, ref string error)
        {
            string sql = @"INSERT INTO THONG_TIN_HOC_SINH (MSHS, HO, TEN, GIOITINH, NGAY_SINH, NOI_SINH, DAN_TOC, QUOC_TICH, TINH, HUYEN, XA, DIA_CHI, DIA_CHI_THUONG_TRU, DIA_CHI_TAM_TRU)
                   VALUES (@MSHS, @HO, @TEN, @GIOITINH, @NGAY_SINH, @NOI_SINH, @DAN_TOC, @QUOC_TICH, @TINH, @HUYEN, @XA, @DIA_CHI, @DIA_CHI_THUONG_TRU, @DIA_CHI_TAM_TRU)";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MSHS", hs.MSHS),
        new SqlParameter("@HO", hs.Ho),
        new SqlParameter("@TEN", hs.Ten),
        new SqlParameter("@GIOITINH", hs.Gioitinh),
        new SqlParameter("@NGAY_SINH", hs.NgaySinh),
        new SqlParameter("@NOI_SINH", hs.NoiSinh),
        new SqlParameter("@DAN_TOC", hs.DanToc),
        new SqlParameter("@QUOC_TICH", hs.QuocTich),
        new SqlParameter("@TINH", hs.Tinh), // Assuming you have these properties in HocSinhEntity
        new SqlParameter("@HUYEN", hs.Huyen),
        new SqlParameter("@XA", hs.Xa),
        new SqlParameter("@DIA_CHI", hs.Diachi),
        new SqlParameter("@DIA_CHI_THUONG_TRU", hs.DCThuongTru),
        new SqlParameter("@DIA_CHI_TAM_TRU", hs.DCTamTru)
            };

            return DB.ProcessData(sql, CommandType.Text, ref error, parameters);
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



        public bool UpdateHocSinh(int mshs, string ho, string ten, string gioiTinh, string ngaySinh,
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

        public string LayMaSoHS(string ngaySinhString, ref string error)
        {
            //string error = "";
            try
            {
                // 1. Parse the date string to DateTime
                if (!DateTime.TryParseExact(ngaySinhString, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngaySinh))
                {
                    error = "Invalid date format. Please use dd-MM-yyyy.";
                    return null; // Or throw an exception
                }

                // 2. Get the last two digits of the current year
                string currentYearLastTwoDigits = DateTime.Now.Year.ToString().Substring(2, 2);

                // 3. Calculate the current grade level (approximate)
               
                string yearOfBirthLastTwoDigits = ngaySinh.Year.ToString().Substring(2, 2);

                byte[] currentYearBytes = Encoding.UTF8.GetBytes(currentYearLastTwoDigits);
                byte[] yearOfBirthBytes = Encoding.UTF8.GetBytes(yearOfBirthLastTwoDigits);
                int currentGrade = int.Parse(currentYearLastTwoDigits) - int.Parse(yearOfBirthLastTwoDigits) - 5; // Declare currentGrade HERE

                // Handle cases where the grade calculation is negative or unexpected
                if (currentGrade < 0)
                {
                    currentGrade = 0; // Or throw an exception, or handle it differently
                }
                if (currentGrade > 99)
                {
                    currentGrade = 99; // Or throw an exception, or handle it differently
                }

                string currentGradeStr = currentGrade.ToString("D2"); // Format with leading zero if needed


                // 4. Get the maximum existing MSHS for the current grade and year (CORRECTED)
                string sqlMaxMSHS = @"SELECT MAX(MSHS) FROM THONG_TIN_HOC_SINH
                              WHERE SUBSTRING(MSHS, 1, 2) = @Year AND SUBSTRING(MSHS, 3, 2) = @Grade";

                SqlParameter[] maxMSHSParams = new SqlParameter[]
                {
            new SqlParameter("@Year", currentYearLastTwoDigits),
            new SqlParameter("@Grade", currentGradeStr)
                };

                // *** KEY CHANGE: Handle DBNull ***
                object maxMSHSObj = DB.GetDataScalar(sqlMaxMSHS, CommandType.Text, ref error, maxMSHSParams);

                string maxMSHS = null;  // Initialize to null

                if (maxMSHSObj != DBNull.Value && maxMSHSObj != null) // Check for DBNull and null
                {
                    maxMSHS = (string)maxMSHSObj; // Cast only if it's NOT DBNull or null
                }

                // 5. Generate the new MSHS
                int nextNumber = 1;
                if (!string.IsNullOrEmpty(maxMSHS))
                {
                    if (int.TryParse(maxMSHS.Substring(4), out int lastNumber))
                    {
                        nextNumber = lastNumber + 1;
                    }
                }

                string newMSHS = $"{currentYearLastTwoDigits}{currentGradeStr}{nextNumber:D3}"; // Format with leading zeros

                return newMSHS;
            }
            catch (Exception ex)
            {
                error = "Error generating MSHS: " + ex.Message;
                // Handle the error appropriately (log, throw, etc.)
                return null; // Or throw the exception
            }
        }

        }

}

