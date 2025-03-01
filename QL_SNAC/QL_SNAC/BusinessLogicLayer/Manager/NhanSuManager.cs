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
    public class NhanSuManager
    {
        private NhanSuResponsitory process;
        public NhanSuManager()
        {
            process = new NhanSuResponsitory();
        }
        public DataTable HienThiLocDSGVRutGon(ref string error)
        {
            try
            {
                return process.HienThiDSGiaoVienRutGon(ref error);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi lấy dữ liệu tài khoản: " + ex.Message; // Gán lỗi cho biến error
                                                                        // Ghi log lỗi (nếu cần)
                                                                        // ...
                return null; // Hoặc throw; nếu muốn lỗi lan lên ucQLTaiKhoan
            }
        }
        public DataTable HienThiLocDSNSRutGon(ref string error)
        {
            try
            {
                return process.HienThiDSNhanSuRutGon(ref error);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi lấy dữ liệu tài khoản: " + ex.Message; // Gán lỗi cho biến error
                                                                        // Ghi log lỗi (nếu cần)
                                                                        // ...
                return null; // Hoặc throw; nếu muốn lỗi lan lên ucQLTaiKhoan
            }
        }
        public DataTable LoadComboxPhongBan(ref string error)
        {
            try
            {
                return process.LoadComboBoxPhongBan(ref error);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi lấy dữ liệu phòng ban: " + ex.Message; // Gán lỗi cho biến error
                                                                        // Ghi log lỗi (nếu cần)
                                                                        // ...
                return null; // Hoặc throw; nếu muốn lỗi lan lên ucQLTaiKhoan
            }
        }
        public DataTable LoadComboBoxToChuyenMon(ref string error)
        {
            try
            {
                return process.LoadComboBoxToCM(ref error);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi lấy dữ liệu tổ chuyên môn: " + ex.Message; // Gán lỗi cho biến error
                                                                        // Ghi log lỗi (nếu cần)
                                                                        // ...
                return null; // Hoặc throw; nếu muốn lỗi lan lên ucQLTaiKhoan
            }
        }
        public DataTable LoadComboBoxChucVu(string maPhongBan, ref string error)
        {
            try
            {
                return process.LoadComboBoxChucVu(maPhongBan, ref error);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi lấy dữ liệu chức vụ: " + ex.Message;
                return null;
            }
        }

        public bool XoaGiaoVien(string msgv, ref string error)
        {
            try
            {
                return process.XoaGiaoVien(msgv, ref error);
            }
            catch { return false; }

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
                return process.LayMaSoNhanVien(ref error);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi lấy mã giáo viên: " + ex.Message; // Gán lỗi cho biến error
                                                                   // Ghi log lỗi (nếu cần)
                                                                   // ...
                return null; // Hoặc throw; nếu muốn lỗi lan lên ucQLTaiKhoan
            }
        }

        public bool ThemGiaoVien(NhanSuEntity gv, ref string error)
        {
            try
            {

                string msgv = LayMaSogv(ref error);

                if (msgv == null)
                {
                    return false;
                }

                gv.MSNV = msgv;

                // 2. Call the repository to add the student
                return process.ThemGiaoVien(gv, ref error);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi thêm giáo viên: " + ex.Message;
                return false;
            }
        }

        public bool CapNhatGiaoVien(NhanSuEntity gv, ref string error)
        {
            return process.CapNhatGiaoVien(gv, ref error);
        }
        public int LaySoTuMSNV(string msnv)
        {
            try
            {
                return process.LaySoTuMSNV(msnv);
            }
            catch (Exception ex)
            {
                // Xử lý hoặc ghi log lỗi nếu cần
                Console.WriteLine($"Lỗi khi lấy số từ MSNV: {ex.Message}");
                return -1; // Hoặc giá trị mặc định khác để chỉ ra lỗi
            }
        }
    }
}
