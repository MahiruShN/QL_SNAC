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
    public class GiaoVienManager
    {
        private GiaoVienResponsitory process;
        public GiaoVienManager()
        {
            process = new GiaoVienResponsitory();
        }
        public DataTable HienThiLocDSGVRutGon(ref string error)
        {
            try
            {
                return process.HienThiDSGiaoVienRutgon(ref error);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi lấy dữ liệu tài khoản: " + ex.Message; // Gán lỗi cho biến error
                                                                        // Ghi log lỗi (nếu cần)
                                                                        // ...
                return null; // Hoặc throw; nếu muốn lỗi lan lên ucQLTaiKhoan
            }
        }

        public DataTable HienThiDSGVFull(ref string error)
        {
            try
            {
                return process.HienThiDSGVFull(ref error);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi lấy dữ liệu giáo viên: " + ex.Message; // Gán lỗi cho biến error
                                                                        // Ghi log lỗi (nếu cần)
                                                                        // ...
                return null; // Hoặc throw; nếu muốn lỗi lan lên ucQLTaiKhoan
            }
        }

        public string LayMaSogv(ref string error)
        {
            try
            {
                return process.LayMaSogv(ref error);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi lấy mã giáo viên: " + ex.Message; // Gán lỗi cho biến error
                                                                   // Ghi log lỗi (nếu cần)
                                                                   // ...
                return null; // Hoặc throw; nếu muốn lỗi lan lên ucQLTaiKhoan
            }
        }

        public bool ThemGiaoVien(GiaoVienEntity gv, ref string error)
        {
            try
            {
                // 1. Get MSHS using LayMaSoHS
                string msgv = LayMaSogv(ref error); // Assuming hs.NgaySinh is a string

                if (msgv == null) // Check for errors during MSHS generation
                {
                    return false; // Or throw an exception
                }

                gv.MSGV = msgv; // Set the generated MSHS to the HocSinhEntity

                // 2. Call the repository to add the student
                return process.ThemGiaoVien(gv, ref error);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi thêm giáo viên: " + ex.Message;
                return false;
            }
        }

        public bool CapNhatGiaoVien(GiaoVienEntity gv, ref string error)
        {
            return process.CapNhatGiaoVien(gv, ref error);
        }

    }
}
