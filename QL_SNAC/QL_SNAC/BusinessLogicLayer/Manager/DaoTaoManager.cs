using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Responsitories;

namespace BusinessLogicLayer.Manager
{
    public class DaoTaoManager
    {
        private DaoTaoResponsitory process;
        public DaoTaoManager()
        {
            process = new DaoTaoResponsitory();
        }
        public DataTable HienThiDSDaoTao(ref string error)
        {
            try
            {
                return process.HienThiDaoTao(ref error);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi lấy dữ liệu Đào Tạo: " + ex.Message; // Gán lỗi cho biến error
                                                                      // Ghi log lỗi (nếu cần)
                                                                      // ...
                return null; // Hoặc throw; nếu muốn lỗi lan lên ucQLTaiKhoan
            }
        }
    }
}
