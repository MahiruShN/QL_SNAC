using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entity;
using DataAccessLayer.Responsitories;

namespace BusinessLogicLayer.Manager
{
    public class TaiKhoanManager
    {
        private TaiKhoanResponsitory process;
        public TaiKhoanManager()
        {
            process = new TaiKhoanResponsitory();
        }
        public DataTable HienThiDanhSachTaiKhoan(ref string error)
        {
            try
            {
                return process.HienThiDanhSachTaiKhoan(ref error);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi lấy dữ liệu tài khoản: " + ex.Message; // Gán lỗi cho biến error
                                                                        // Ghi log lỗi (nếu cần)
                                                                        // ...
                return null; // Hoặc throw; nếu muốn lỗi lan lên ucQLTaiKhoan
            }
        }
        public bool ThemTaiKhoan(TaiKhoanEntity Entity, ref string error)
        {
            // 1. Validate input *before* calling the repository
            if (string.IsNullOrEmpty(Entity.EMAIL))
            {
                error = "Email không được để trống.";
                return false;
            }

            if (string.IsNullOrEmpty(Entity.PASS))
            {
                error = "Mật khẩu không được để trống.";
                return false;
            }

            //if (string.IsNullOrEmpty(Entity.MSNguoiDung))
            //{
            //    error = "Mã người dùng không được để trống.";
            //    return false;
            //}
            if (string.IsNullOrEmpty(Entity.Quyen))
            {
                error = "Quyền không được để trống.";
                return false;
            }
            if (string.IsNullOrEmpty(Entity.NguoiTao))
            {
                error = "Người tạo không được để trống.";
                return false;
            }


            // 2. Call the repository to add the account. The repository should handle setting the ID.
            return process.ThemTaiKhoan(Entity, ref error);
        }
        public bool XoaTaiKhoan(int idTaiKhoan, ref string error)
        {
            if (idTaiKhoan <=0)
            {
                error = " Khong the xoa";
                return false;
            }
            return process.XoaTaiKhoan(idTaiKhoan, ref error);
        }
        public bool CapNhatTaiKhoan(TaiKhoanEntity entity, ref string error)
        {
            return process.SuaTaiKhoan(entity, ref error); // Gọi repository
        }
    }
}
