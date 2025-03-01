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
                error = "Lỗi khi lấy dữ liệu học sinh: " + ex.Message; // Gán lỗi cho biến error
                                                                        // Ghi log lỗi (nếu cần)
                                                                        // ...
                return null; // Hoặc throw; nếu muốn lỗi lan lên ucQLTaiKhoan
            }
        }
        public DataTable HienThiDSFull(ref string error)
        {
            try
            {
                return process.HienThiDanhSachFull(ref error);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi lấy dữ liệu tài khoản: " + ex.Message; // Gán lỗi cho biến error
                                                                        // Ghi log lỗi (nếu cần)
                                                                        // ...
                return null; // Hoặc throw; nếu muốn lỗi lan lên ucQLTaiKhoan
            }
        }
        public bool XoaHocSinh(string MSHS, ref string error)
        {
            if (string.IsNullOrEmpty(MSHS)) // Kiểm tra null hoặc empty
            {
                error = "MSHS không được để trống.";
                return false;
            }
            return process.XoaHocSinh(MSHS, ref error);
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

        public bool UpdateHocSinh(int mshs, string ho, string ten, string gioiTinh, string ngaySinh,
                                  string noiSinh, string danToc, string quocTich, string TonGiao, string tinh, string huyen, string xa, string diaChi,
                                  string dcThuongTru, string dcTamTru, ref string error)
        {
            return process.UpdateHocSinh(mshs, ho, ten, gioiTinh, ngaySinh, noiSinh, danToc,
                                             quocTich, TonGiao,diaChi, tinh, huyen,xa, dcThuongTru, dcTamTru, ref error);
        }
        public string LayMaSoHS(string ngaySinhString, ref string error) // Correct: 2 arguments
        {
            return process.LayMaSoHS(ngaySinhString, ref error); // Call with 2 arguments
        }
        public bool ThemHocSinh(HocSinhEntity hs, ref string error)
        {
            try
            {
                // 1. Get MSHS using LayMaSoHS
                string mshs = LayMaSoHS(hs.NgaySinh, ref error); // Assuming hs.NgaySinh is a string

                if (mshs == null) // Check for errors during MSHS generation
                {
                    return false; // Or throw an exception
                }

                hs.MSHS = mshs; // Set the generated MSHS to the HocSinhEntity

                // 2. Call the repository to add the student
                return process.ThemHocSinh(hs, ref error);
            }
            catch (Exception ex)
            {
                error = "Error adding student: " + ex.Message;
                return false;
            }
        }


    }
}
