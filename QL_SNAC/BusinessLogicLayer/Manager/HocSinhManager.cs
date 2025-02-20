using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Responsitories;
using DataAccessLayer.Entity;
using System.Data;

namespace BusinessLogicLayer.Manager
{
    public class HocSinhManager
    {
        private HocSinhResponsitory process;
        public HocSinhManager()
        {
            process = new HocSinhResponsitory();
        }
        public DataTable HienThiLocDSHSRutGon(ref string error)
        {
            try
            {
                return process.HienThiDSHocsinhRutgon(ref error);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi lấy dữ liệu tài khoản: " + ex.Message; // Gán lỗi cho biến error
                                                                        // Ghi log lỗi (nếu cần)
                                                                        // ...
                return null; // Hoặc throw; nếu muốn lỗi lan lên ucQLTaiKhoan
            }
        }

        public DataTable GetHocSinhByMSHS(string mshs, ref string error)
        {
            try
            {
                return process.GetHocSinhByMSHS(mshs, ref error);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi lấy thông tin học sinh: " + ex.Message;
                return null;
            }
        }

        public bool UpdateHocSinh(int mshs, string ho, string ten, string gioiTinh, DateTime ngaySinh,
                                  string noiSinh, string danToc, string quocTich, string diaChi,
                                  string dcThuongTru, string dcTamTru, ref string error)
        {
            return process.UpdateHocSinh(mshs, ho, ten, gioiTinh, ngaySinh, noiSinh, danToc,
                                             quocTich, diaChi, dcThuongTru, dcTamTru, ref error);
        }



    }
}
