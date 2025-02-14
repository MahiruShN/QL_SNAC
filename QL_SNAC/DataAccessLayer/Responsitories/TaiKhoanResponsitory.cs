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
            try
            {
                string sql = " select ID_TAIKHOAN, EMAIL,Matkhau, TINH_TRANG,MS_NGUOI_DUNG,QUYEN , NGAY_TAO, NGUOI_TAO " +
                             " from TAI_KHOAN where TINH_TRANG = 'true' ";
                var rs = DB.GetDataFromDB(sql, CommandType.Text, ref error);
                return rs;
            }
            catch (Exception ex)
            {
                error = "Kết nối lỗi: " + ex.Message;
                return null;
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
                    INSERT INTO TAI_KHOAN (ID_TAIKHOAN, EMAIL, [Matkhau], TINH_TRANG, MS_NGUOI_DUNG, QUYEN, NGUOI_TAO, NGAY_TAO)
                    VALUES (@ID_TAIKHOAN, @email, @pass, 'true', @msNguoidung, @Quyen, @NguoiTao, GETDATE());
                ";

                bool insertResult = DB.ProcessData(sqlInsert, CommandType.Text, ref error,
                    new SqlParameter("@ID_TAIKHOAN", nextID), // Sử dụng ID đã tính toán
                    new SqlParameter("@email", Entity.EMAIL),
                    new SqlParameter("@pass", Entity.MatKhau),
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
            try
            {
                string sql = " delete from TAI_KHOAN where ID_TAIKHOAN like @idtaikhoan";
                var rs = DB.ProcessData(sql, CommandType.Text, ref error,
                                        new SqlParameter("@idtaikhoan", idTaiKhoan));
                return rs;
            }
            catch (Exception ex)
            {
                error = "Ket noi lôi: " + ex.Message;
                return false;
            }
        }
        public bool SuaTaiKhoan(TaiKhoanEntity Entity, ref string error)
        {
            try
            {
                string sql = @"
                    UPDATE TAI_KHOAN 
                    SET EMAIL = @email, [Matkhau] = @pass, TINH_TRANG = @TinhTrang, 
                        MS_NGUOI_DUNG = @msnguoidung, QUYEN = @Quyen, NGUOI_TAO = @NguoiTao, NGAY_TAO = GETDATE()
                    WHERE ID_TAIKHOAN = @idTaiKhoan";

                // Use your DB class's ProcessData method:
                return DB.ProcessData(sql, CommandType.Text, ref error,
                    new SqlParameter("@email", Entity.EMAIL),
                    new SqlParameter("@pass", Entity.MatKhau), // Make sure Entity.MatKhau is hashed!
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
    }
    

}