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
    public class TaiKhoanResponsitory
    {
        private Database DB = new Database();

        public DataTable HienThiDanhSachTaiKhoan(ref string error)
        {
            //try
            //{
            //    string sql = " select ID_TAIKHOAN, EMAIL,PASS, TINH_TRANG,MS_NGUOI_DUNG,QUYEN , NGAY_TAO, NGUOI_TAO " +
            //                 " from TAI_KHOAN  ";
            //    var rs = DB.GetDataFromDB(sql, CommandType.Text, ref error);
            //    return rs;
            //}
            //catch (Exception ex)
            //{
            //    error = "Kết nối lỗi: " + ex.Message;
            //    return null;
            //}
            return DB.GetTableData("TAI_KHOAN", ref error);
        }
        public bool KiemTraMatKhauCu(int idTaiKhoan, string matKhauCu, ref string error)
        {
            //try
            //{
            //    // Hash mật khẩu cũ trước khi so sánh
            //    string hashedMatKhauCu = DB.HashPassword(matKhauCu);

            //    string sql = "SELECT 1 FROM TAI_KHOAN WHERE ID_TAIKHOAN = @idTaiKhoan AND PASS = @matKhauCu";
            //    SqlParameter[] parameters = new SqlParameter[]
            //    {
            //new SqlParameter("@idTaiKhoan", idTaiKhoan),
            //new SqlParameter("@matKhauCu", hashedMatKhauCu)
            //    };

            //    object result = DB.GetValueFromDB(sql, CommandType.Text, ref error, parameters);

            //    return result != null && result != DBNull.Value && Convert.ToInt32(result) == 1;
            //}
            //catch (Exception ex)
            //{
            //    error = "Lỗi kiểm tra mật khẩu cũ: " + ex.Message;
            //    return false;
            //}
            try
            {
                string hashedMatKhauCu = DB.HashPassword(matKhauCu);
                string whereClause = $"ID_TAIKHOAN = {idTaiKhoan} AND PASS = '{hashedMatKhauCu}'";
                string result = DB.GetValueFromTable("TAI_KHOAN", "1", whereClause, ref error);

                return result != null && result == "1";
            }
            catch (Exception ex)
            {
                error = "Lỗi kiểm tra mật khẩu cũ: " + ex.Message;
                return false;
            }
        }
        public bool DoiMatKhau(int idTaiKhoan, string matKhauMoi, ref string error)
        {
            //try
            //{
            //    string hashedMatKhauMoi = DB.HashPassword(matKhauMoi); // Hash mật khẩu mới

            //    string sql = "UPDATE TAI_KHOAN SET PASS = @matKhauMoi WHERE ID_TAIKHOAN = @idTaiKhoan";
            //    SqlParameter[] parameters = new SqlParameter[]
            //    {
            //new SqlParameter("@idTaiKhoan", idTaiKhoan),
            //new SqlParameter("@matKhauMoi", hashedMatKhauMoi)
            //    };

            //    return DB.ProcessData(sql, CommandType.Text, ref error, parameters);
            //}
            //catch (Exception ex)
            //{
            //    error = "Lỗi đổi mật khẩu: " + ex.Message;
            //    return false;
            //}
            try
            {
                string hashedMatKhauMoi = DB.HashPassword(matKhauMoi);
                string sql = "UPDATE TAI_KHOAN SET PASS = @matKhauMoi WHERE ID_TAIKHOAN = @idTaiKhoan";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@idTaiKhoan", idTaiKhoan),
                    new SqlParameter("@matKhauMoi", hashedMatKhauMoi)
                };

                return DB.ProcessData(sql, CommandType.Text, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Lỗi đổi mật khẩu: " + ex.Message;
                return false;
            }
        }
        public bool ThemTaiKhoan(TaiKhoanEntity Entity, ref string error)
        {
            try
            {
                // 1. Lấy ID lớn nhất hiện có trong bảng
                string sqlGetMaxID = "SELECT MAX(ID_TAIKHOAN) FROM TAI_KHOAN;";
                object maxIDObj = DB.GetValueFromDB(sqlGetMaxID, CommandType.Text, ref error);

                int nextID = 1; // ID mặc định nếu bảng trống
                if (maxIDObj != null && maxIDObj != DBNull.Value && int.TryParse(maxIDObj.ToString(), out int maxID))
                {
                    nextID = maxID + 1; // ID tiếp theo sẽ là ID lớn nhất + 1
                }

                // 2. Thêm tài khoản với ID tự động tăng
                string sqlInsert = @"
                    INSERT INTO TAI_KHOAN (ID_TAIKHOAN, EMAIL, [PASS], TINH_TRANG, MS_NGUOI_DUNG, QUYEN, NGUOI_TAO, NGAY_TAO)
                    VALUES (@ID_TAIKHOAN, @email, @pass, 'true', @msNguoidung, @Quyen, @NguoiTao, GETDATE());
                ";

                bool insertResult = DB.ProcessData(sqlInsert, CommandType.Text, ref error,
                    new SqlParameter("@ID_TAIKHOAN", nextID), // Sử dụng ID đã tính toán
                    new SqlParameter("@email", Entity.EMAIL),
                    new SqlParameter("@pass", Entity.PASS),
                    new SqlParameter("@msNguoidung", Entity.MSNguoiDung),
                    new SqlParameter("@Quyen", Entity.Quyen),
                    new SqlParameter("@NguoiTao", Entity.NguoiTao));

                if (insertResult)
                {
                    Entity.ID_TAIKHOAN = nextID; // Gán ID cho entity
                    return true;
                }
                else
                {
                    return false; // Lỗi insert
                }
            }
            catch (Exception ex)
            {
                error = "Lỗi thêm tài khoản: " + ex.Message;
                return false;
            }
        }
        public bool XoaTaiKhoan(int idTaiKhoan, ref string error)
        {
            string sql = "DELETE FROM TAI_KHOAN WHERE ID_TAIKHOAN = @idtaikhoan";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@idtaikhoan", idTaiKhoan)
            };
            return DB.ProcessData(sql, CommandType.Text, ref error, parameters);
        }
        public bool SuaTaiKhoan(TaiKhoanEntity Entity, ref string error)
        {
            try
            {
                string sql = @"
                    UPDATE TAI_KHOAN 
                    SET EMAIL = @email, [PASS] = @pass, TINH_TRANG = @TinhTrang, 
                        MS_NGUOI_DUNG = @msnguoidung, QUYEN = @Quyen, NGUOI_TAO = @NguoiTao, NGAY_TAO = GETDATE()
                    WHERE ID_TAIKHOAN = @idTaiKhoan";

                // Use your DB class's ProcessData method:
                return DB.ProcessData(sql, CommandType.Text, ref error,
                    new SqlParameter("@email", Entity.EMAIL),
                    new SqlParameter("@pass", Entity.PASS), // Make sure Entity.MatKhau is hashed!
                    new SqlParameter("@TinhTrang", Entity.TinhTrang),
                    new SqlParameter("@msnguoidung", Entity.MSNguoiDung),
                    new SqlParameter("@Quyen", Entity.Quyen),
                    new SqlParameter("@NguoiTao", Entity.NguoiTao),
                    new SqlParameter("@idTaiKhoan", Entity.ID_TAIKHOAN));
            }
            catch (Exception ex)
            {
                error = "Lỗi cập nhật tài khoản: " + ex.Message;
                return false;
            }
        }
        //public bool LayThongTinNguoiDung(int idTaiKhoan, ref string ngaySinh, ref string gioiTinh, ref string loaiTaiKhoan, ref string error)
        //{
        //    try
        //    {
        //        string quyen = LayQuyenTaiKhoan(idTaiKhoan, ref error);
        //        if (string.IsNullOrEmpty(quyen)) return false;

        //        loaiTaiKhoan = GetFullRoleName(quyen);

        //        string tableName = "";
        //        string maNguoiDungColumn = "";
        //        string ngaySinhColumn = "";
        //        string gioiTinhColumn = "";

        //        switch (quyen.ToUpper())
        //        {
        //            case "GV":
        //                tableName = "THONG_TIN_GIAO_VIEN";
        //                maNguoiDungColumn = "MSGV";
        //                ngaySinhColumn = "NgaySinh";
        //                gioiTinhColumn = "GioiTinh";
        //                break;
        //            case "HS":
        //                tableName = "THONG_TIN_HOC_SINH";
        //                maNguoiDungColumn = "MSHS";
        //                ngaySinhColumn = "NgaySinh";
        //                gioiTinhColumn = "GioiTinh";
        //                break;
        //            default:
        //                error = "Không hỗ trợ lấy thông tin cho loại tài khoản này.";
        //                return false;
        //        }

        //        if (string.IsNullOrEmpty(tableName)) return true;

        //        string msNguoiDung = LayMSNguoiDung(idTaiKhoan, ref error);
        //        if (string.IsNullOrEmpty(msNguoiDung)) return false;

        //        string sql = $"SELECT {ngaySinhColumn}, {gioiTinhColumn} FROM {tableName} WHERE {maNguoiDungColumn} = @MSNguoiDung";

        //        SqlParameter[] parameters = new SqlParameter[]
        //        {
        //    new SqlParameter("@MSNguoiDung", msNguoiDung)
        //        };

        //        using (DataTable dataTable = DB.GetDataFromDB(sql, CommandType.Text, ref error, parameters))
        //        {
        //            if (dataTable != null && dataTable.Rows.Count > 0)
        //            {
        //                using (DataTableReader reader = dataTable.CreateDataReader())
        //                {
        //                    if (reader.Read())
        //                    {
        //                        if (!reader.IsDBNull(0)) ngaySinh = reader.GetDateTime(0).ToString("dd/MM/yyyy");
        //                        if (!reader.IsDBNull(1)) gioiTinh = reader.GetString(1);

        //                        return true;
        //                    }
        //                    else
        //                    {
        //                        error = "Không tìm thấy thông tin người dùng.";
        //                        return false;
        //                    }
        //                }
        //            }
        //            else if (dataTable == null)
        //            {
        //                error = "Lỗi khi truy vấn dữ liệu: " + error;
        //                return false;
        //            }
        //            else
        //            {
        //                error = "Không tìm thấy thông tin người dùng.";
        //                return false;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        error = "Lỗi lấy thông tin người dùng: " + ex.Message;
        //        return false; // Return false if an exception occurs
        //    }
        //}

        private string LayQuyenTaiKhoan(int idTaiKhoan, ref string error)
        {
            string sql = "SELECT QUYEN FROM TAI_KHOAN WHERE ID_TAIKHOAN = @ID_TAIKHOAN";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID_TAIKHOAN", idTaiKhoan)
            };
            object result = DB.GetValueFromDB(sql, CommandType.Text, ref error, parameters);
            return result?.ToString(); // Use null-conditional operator
        }
        public bool LayThongTinNguoiDung(int idTaiKhoan, ref string ngaySinh, ref string gioiTinh, ref string loaiTaiKhoan, ref string error)
        {
            try
            {
                string quyen = LayQuyenTaiKhoan(idTaiKhoan, ref error);
                if (string.IsNullOrEmpty(quyen)) return false;

                loaiTaiKhoan = GetFullRoleName(quyen);

                string msNguoiDung = LayMSNguoiDung(idTaiKhoan, ref error);
                if (string.IsNullOrEmpty(msNguoiDung)) return false;

                switch (quyen.ToUpper())
                {
                    case "GV":
                    case "GVCN":  // Treat GVCN the same as GV for now
                        return LayThongTinNguoiDungTuBang(msNguoiDung, "THONG_TIN_GIAO_VIEN", "MSGV", ref ngaySinh, ref gioiTinh, ref error);
                    case "HS":
                        return LayThongTinNguoiDungTuBang(msNguoiDung, "THONG_TIN_HOC_SINH", "MSHS", ref ngaySinh, ref gioiTinh, ref error);
                    // ... other cases if needed (AD, PH, etc.)
                    default:
                        error = "Không hỗ trợ lấy thông tin cho loại tài khoản này.";
                        return false;
                }
            }
            catch (Exception ex)
            {
                error = "Lỗi lấy thông tin người dùng: " + ex.Message;
                return false;
            }
        }


        private bool LayThongTinNguoiDungTuBang(string msNguoiDung, string tableName, string maNguoiDungColumn, ref string ngaySinh, ref string gioiTinh, ref string error)
        {
            string sql = $"SELECT NgaySinh, GioiTinh FROM {tableName} WHERE {maNguoiDungColumn} = @MSNguoiDung";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MSNguoiDung", msNguoiDung)
            };

            using (DataTable dataTable = DB.GetDataFromDB(sql, CommandType.Text, ref error, parameters))
            {
                if (dataTable == null) // Check for DB error first
                {
                    error = "Lỗi truy vấn dữ liệu từ bảng " + tableName + ": " + error;
                    return false;
                }
                if (dataTable.Rows.Count == 0)
                {
                    error = "Không tìm thấy thông tin người dùng " + msNguoiDung + " trong bảng " + tableName;
                    return false;
                }
            }
            return false; // Not found in this table
        }
        private string LayMSNguoiDung(int idTaiKhoan, ref string error)
        {
            string sql = "SELECT MS_NGUOI_DUNG FROM TAI_KHOAN WHERE ID_TAIKHOAN = @ID_TAIKHOAN";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID_TAIKHOAN", idTaiKhoan)
            };
            object result = DB.GetValueFromDB(sql, CommandType.Text, ref error, parameters);
            return result?.ToString(); // Use null-conditional operator
        }

        private string GetFullRoleName(string quyenAbbr)
        {
            switch (quyenAbbr.ToUpper())
            {
                case "GV": return "Giáo viên";
                case "AD": return "Admin";
                case "HS": return "Học sinh";
                case "GVCN": return "Giáo viên chủ nhiệm";
                case "PH": return "Phụ huynh";
                case "TS": return "Tuyển sinh";
                case "QS": return "Quản sinh";
                default: return quyenAbbr; // Or handle the default case as needed
            }
        }
    }
}
    
    
