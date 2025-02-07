using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
