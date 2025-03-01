using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entity;
using Microsoft.Data.SqlClient;
using static Azure.Core.HttpHeader;

namespace DataAccessLayer.Responsitories
{
    public class NhanSuResponsitory
    {
        private Database DB = new Database();
        public DataTable HienThiDSGiaoVienRutGon(ref string error)
        {
            try
            {
                string sql = " select MSNV,HO, TEN, GioiTinh,Ngay_Sinh " +
                             " from NHAN_SU"+
                             " where NHAN_SU.LOAI_NHANSU = 'GV'";
                var rs = DB.GetDataFromDB(sql, CommandType.Text, ref error);
                return rs;
            }
            catch (Exception ex)
            {
                error = "Kết nối lỗi: " + ex.Message;
                return null;
            }
        }
        public DataTable HienThiDSNhanSuRutGon(ref string error)
        {
            try
            {
                string sql = " select MSNV,HO, TEN, GioiTinh,Ngay_Sinh " +
                             " from NHAN_SU" ;
                var rs = DB.GetDataFromDB(sql, CommandType.Text, ref error);
                return rs;
            }
            catch (Exception ex)
            {
                error = "Kết nối lỗi: " + ex.Message;
                return null;
            }
        }



        public DataTable HienThiDSGVFull(ref string error)
        {
            try
            {
                string sql = " SELECT [MSNV],[HO],[TEN],[NGAY_VAO_LAM],[NGAY_HET_THU_VIEC],[HD_Lan1],[HD_Lan2],[HD_Lan3] , " +
                              "[NamHD],ns.[MaPhongBan],pb.PhongBan,ns.[MAChucVu],cv.ChucVu,[Ngay_Sinh],[GioiTinh],[CCCD],[NgayCap],[NoiCap],[DiaChi],[Email] ," +
                              "[SDT],[Nguyen_Quan],[DanToc],[QuocTich],[TonGiao],[HocVan],[ChuyenMon],[Truong_TotNghiep] , " +
                              "[NamTotNghiep],[NamVaoNganh],[MST] " +
                              "FROM[QL_SNAC].[dbo].[NHAN_SU] ns " +
                              "   inner join QL_PhongBan pb on pb.MaPhongBan = ns.MaPhongBan " +
                              "   inner join QL_ChucVu cv on cv.MAChucVu = ns.MAChucVu "+

                              "Where ns.[LOAI_NHANSU] = 'GV'";
                var rs = DB.GetDataFromDB(sql, CommandType.Text, ref error);
                return rs;
            }
            catch (Exception ex)
            {
                error = "Kết nối lỗi: " + ex.Message;
                return null;
            }
        }

        public string LayMaSoNhanVien(ref string error)
        {
            try
            {
                string sql = "SELECT MAX(MSNV) FROM NHAN_SU WHERE MSNV LIKE 'ABC%'";
                var rs = DB.GetDataFromDB(sql, CommandType.Text, ref error);
                if (rs.Rows.Count == 0 || rs.Rows[0][0] == DBNull.Value)
                {
                    return "ABC0001";
                }
                string msnv = rs.Rows[0][0].ToString();
                int so = int.Parse(msnv.Substring(3)) + 1;
                return "ABC" + so.ToString("0000");
            }
            catch (Exception ex)
            {
                error = "Kết nối lỗi: " + ex.Message;
                return null;
            }
        }

        public bool ThemGiaoVien(NhanSuEntity gv, ref string error)
        {
            try
            {
                string sql = @"INSERT INTO NHAN_SU 
            ([MSNV],[HO],[TEN],[NGAY_VAO_LAM],[NGAY_HET_THU_VIEC],[HD_Lan1],[HD_Lan2],[HD_Lan3],
             [NamHD],[MaPhongBan],[MAChucVu],[Ngay_Sinh],[GioiTinh] ,[CCCD],[NgayCap] ,[NoiCap],
             [DiaChi],[Email],[SDT],[Nguyen_Quan],[DanToc],[QuocTich],[TonGiao],[HocVan],
             [ChuyenMon],[Truong_TotNghiep] ,[NamTotNghiep],[NamVaoNganh],[MST],[LOAI_NHANSU])
            VALUES 
            (@MSNV, @HO, @TEN, @NGAY_VAO_LAM, @NGAY_HET_THU_VIEC, @HD_Lan1, @HD_Lan2, @HD_Lan3, @NamHD, @MaPhongBan, 
             @MAChucVu, @Ngay_Sinh, @GioiTinh, @CCCD, @NgayCap, @NoiCap, @DiaChi, @Email, @SDT, @Nguyen_Quan, @DanToc, 
             @QuocTich, @TonGiao, @HocVan, @ChuyenMon, @Truong_TotNghiep, @NamTotNghiep, @NamVaoNganh, @MST, 'GV')";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MSNV", gv.MSNV),
                    new SqlParameter("@HO", string.IsNullOrWhiteSpace(gv.Ho) ? DBNull.Value : (object)gv.Ho),
                    new SqlParameter("@TEN", string.IsNullOrWhiteSpace(gv.Ten) ? DBNull.Value : (object)gv.Ten),
                    new SqlParameter("@NGAY_VAO_LAM",string.IsNullOrWhiteSpace(gv.NGAY_VAO_LAM) ? DBNull.Value : (object)gv.NGAY_VAO_LAM),
                    new SqlParameter("@NGAY_HET_THU_VIEC", string.IsNullOrWhiteSpace(gv.NGAY_HET_THU_VIEC) ? DBNull.Value : (object)gv.NGAY_HET_THU_VIEC),
                    new SqlParameter("@HD_Lan1",string.IsNullOrWhiteSpace(gv.HD_Lan1) ? DBNull.Value : (object)gv.HD_Lan1),
                    new SqlParameter("@HD_Lan2",string.IsNullOrWhiteSpace(gv.HD_Lan2) ? DBNull.Value : (object)gv.HD_Lan2),
                    new SqlParameter("@HD_Lan3",string.IsNullOrWhiteSpace(gv.HD_Lan3) ? DBNull.Value : (object)gv.HD_Lan3),
                    new SqlParameter("@NamHD", string.IsNullOrWhiteSpace(gv.NamHD) ? DBNull.Value : (object)gv.NamHD),
                    new SqlParameter("@MaPhongBan", string.IsNullOrWhiteSpace(gv.MaPhongBan) ? DBNull.Value : (object)gv.MaPhongBan),
                    new SqlParameter("@MAChucVu", string.IsNullOrWhiteSpace(gv.MAChucVu) ? DBNull.Value : (object)gv.MAChucVu),
                    new SqlParameter("@Ngay_Sinh",string.IsNullOrWhiteSpace(gv.NgaySinh) ? DBNull.Value : (object)gv.NgaySinh),
                    new SqlParameter("@GioiTinh", string.IsNullOrWhiteSpace(gv.GioiTinh) ? DBNull.Value : (object)gv.GioiTinh),
                    new SqlParameter("@CCCD", string.IsNullOrWhiteSpace(gv.CCCD) ? DBNull.Value : (object)gv.CCCD),
                    new SqlParameter("@NgayCap", string.IsNullOrWhiteSpace(gv.NgayCap) ? DBNull.Value : (object)gv.NgayCap),
                    new SqlParameter("@NoiCap", string.IsNullOrWhiteSpace(gv.NoiCap) ? DBNull.Value : (object)gv.NoiCap),
                    new SqlParameter("@DiaChi", string.IsNullOrWhiteSpace(gv.DiaChi) ? DBNull.Value : (object)gv.DiaChi),
                    new SqlParameter("@Email", string.IsNullOrWhiteSpace(gv.Email) ? DBNull.Value : (object)gv.Email),
                    new SqlParameter("@SDT", string.IsNullOrWhiteSpace(gv.SDT) ? DBNull.Value : (object)gv.SDT),
                    new SqlParameter("@Nguyen_Quan", string.IsNullOrWhiteSpace(gv.NguyenQuan) ? DBNull.Value : (object)gv.NguyenQuan),
                    new SqlParameter("@DanToc", string.IsNullOrWhiteSpace(gv.DanToc) ? DBNull.Value : (object)gv.DanToc),
                    new SqlParameter("@QuocTich", string.IsNullOrWhiteSpace(gv.QuocTich) ? DBNull.Value : (object)gv.QuocTich),
                    new SqlParameter("@TonGiao", string.IsNullOrWhiteSpace(gv.TonGiao) ? DBNull.Value : (object)gv.TonGiao),
                    new SqlParameter("@HocVan", string.IsNullOrWhiteSpace(gv.HocVan) ? DBNull.Value : (object)gv.HocVan),
                    new SqlParameter("@ChuyenMon", string.IsNullOrWhiteSpace(gv.ChuyenMon) ? DBNull.Value : (object)gv.ChuyenMon),
                    new SqlParameter("@Truong_TotNghiep", string.IsNullOrWhiteSpace(gv.TruongTN) ? DBNull.Value : (object)gv.TruongTN),
                    new SqlParameter("@NamTotNghiep", gv.NamTotNghiep > 0 ? (object)gv.NamTotNghiep : DBNull.Value),
                    new SqlParameter("@NamVaoNganh", gv.NamVaoNganh > 0 ? (object)gv.NamVaoNganh : DBNull.Value),
                    new SqlParameter("@MST", string.IsNullOrWhiteSpace(gv.MaSoThue) ? DBNull.Value : (object)gv.MaSoThue),
                    new SqlParameter("@LOAI_NHANSU", "GV")
                };

                Debug.Print(sql);
                return DB.ProcessData(sql, CommandType.Text, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi thêm giáo viên: " + ex.Message;
                return false;
            }
        }


        public bool CapNhatGiaoVien(NhanSuEntity gv, ref string error)
        {
            try
            {
                string sql = @"UPDATE NHAN_SU SET 
                            HO = @HO,
                            TEN = @TEN,
                            NGAY_VAO_LAM = @NGAY_VAO_LAM,
                            NGAY_HET_THU_VIEC = @NGAY_HET_THU_VIEC,
                            HD_Lan1 = @HD_Lan1,
                            HD_Lan2 = @HD_Lan2,
                            HD_Lan3 = @HD_Lan3,
                            NamHD = @NamHD,
                            MaPhongBan = @MaPhongBan,
                            MAChucVu = @MAChucVu,
                            Ngay_Sinh = @Ngay_Sinh,
                            GioiTinh = @GioiTinh,
                            CCCD = @CCCD,
                            NgayCap = @NgayCap,
                            NoiCap = @NoiCap,
                            DiaChi = @DiaChi,
                            Email = @Email,
                            SDT = @SDT,
                            Nguyen_Quan = @Nguyen_Quan,
                            DanToc = @DanToc,
                            QuocTich = @QuocTich,
                            TonGiao = @TonGiao,
                            HocVan = @HocVan,
                            ChuyenMon = @ChuyenMon,
                            Truong_TotNghiep = @Truong_TotNghiep,
                            NamTotNghiep = @NamTotNghiep,
                            NamVaoNganh = @NamVaoNganh,
                            MST = @MST,
                            LOAI_NHANSU = @LOAI_NHANSU
                            WHERE MSNV = @MSNV"; 

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MSNV", gv.MSNV),
                    new SqlParameter("@HO", string.IsNullOrWhiteSpace(gv.Ho) ? DBNull.Value : (object)gv.Ho),
                    new SqlParameter("@TEN", string.IsNullOrWhiteSpace(gv.Ten) ? DBNull.Value : (object)gv.Ten),
                    new SqlParameter("@NGAY_VAO_LAM", string.IsNullOrWhiteSpace(gv.NGAY_VAO_LAM) ? DBNull.Value : (object)gv.NGAY_VAO_LAM),
                    new SqlParameter("@NGAY_HET_THU_VIEC", string.IsNullOrWhiteSpace(gv.NGAY_HET_THU_VIEC) ? DBNull.Value : (object)gv.NGAY_HET_THU_VIEC),
                    new SqlParameter("@HD_Lan1", string.IsNullOrWhiteSpace(gv.HD_Lan1) ? DBNull.Value : (object)gv.HD_Lan1),
                    new SqlParameter("@HD_Lan2", string.IsNullOrWhiteSpace(gv.HD_Lan2) ? DBNull.Value : (object)gv.HD_Lan2),
                    new SqlParameter("@HD_Lan3", string.IsNullOrWhiteSpace(gv.HD_Lan3) ? DBNull.Value : (object)gv.HD_Lan3),
                    new SqlParameter("@NamHD", string.IsNullOrWhiteSpace(gv.NamHD) ? DBNull.Value : (object)gv.NamHD),
                    new SqlParameter("@MaPhongBan", string.IsNullOrWhiteSpace(gv.MaPhongBan) ? DBNull.Value : (object)gv.MaPhongBan),
                    new SqlParameter("@MAChucVu", string.IsNullOrWhiteSpace(gv.MAChucVu) ? DBNull.Value : (object)gv.MAChucVu),
                    new SqlParameter("@Ngay_Sinh", string.IsNullOrWhiteSpace(gv.NgaySinh) ? DBNull.Value : (object)gv.NgaySinh),
                    new SqlParameter("@GioiTinh", string.IsNullOrWhiteSpace(gv.GioiTinh) ? DBNull.Value : (object)gv.GioiTinh),
                    new SqlParameter("@CCCD", string.IsNullOrWhiteSpace(gv.CCCD) ? DBNull.Value : (object)gv.CCCD),
                    new SqlParameter("@NgayCap", string.IsNullOrWhiteSpace(gv.NgayCap) ? DBNull.Value : (object)gv.NgayCap),
                    new SqlParameter("@NoiCap", string.IsNullOrWhiteSpace(gv.NoiCap) ? DBNull.Value : (object)gv.NoiCap),
                    new SqlParameter("@DiaChi", string.IsNullOrWhiteSpace(gv.DiaChi) ? DBNull.Value : (object)gv.DiaChi),
                    new SqlParameter("@Email", string.IsNullOrWhiteSpace(gv.Email) ? DBNull.Value : (object)gv.Email),
                    new SqlParameter("@SDT", string.IsNullOrWhiteSpace(gv.SDT) ? DBNull.Value : (object)gv.SDT),
                    new SqlParameter("@Nguyen_Quan", string.IsNullOrWhiteSpace(gv.NguyenQuan) ? DBNull.Value : (object)gv.NguyenQuan),
                    new SqlParameter("@DanToc", string.IsNullOrWhiteSpace(gv.DanToc) ? DBNull.Value : (object)gv.DanToc),
                    new SqlParameter("@QuocTich", string.IsNullOrWhiteSpace(gv.QuocTich) ? DBNull.Value : (object)gv.QuocTich),
                    new SqlParameter("@TonGiao", string.IsNullOrWhiteSpace(gv.TonGiao) ? DBNull.Value : (object)gv.TonGiao),
                    new SqlParameter("@HocVan", string.IsNullOrWhiteSpace(gv.HocVan) ? DBNull.Value : (object)gv.HocVan),
                    new SqlParameter("@ChuyenMon", string.IsNullOrWhiteSpace(gv.ChuyenMon) ? DBNull.Value : (object)gv.ChuyenMon),
                    new SqlParameter("@Truong_TotNghiep", string.IsNullOrWhiteSpace(gv.TruongTN) ? DBNull.Value : (object)gv.TruongTN),
                    new SqlParameter("@NamTotNghiep", gv.NamTotNghiep > 0 ? (object)gv.NamTotNghiep : DBNull.Value),
                    new SqlParameter("@NamVaoNganh", gv.NamVaoNganh > 0 ? (object)gv.NamVaoNganh : DBNull.Value),
                    new SqlParameter("@MST", string.IsNullOrWhiteSpace(gv.MaSoThue) ? DBNull.Value : (object)gv.MaSoThue),
                    new SqlParameter("@LOAI_NHANSU", gv.LoaiNS)
                };

                Debug.Print(sql);
                return DB.ProcessData(sql, CommandType.Text, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi cập nhật giáo viên: " + ex.Message;
                return false;
            }
        }
        public bool XoaGiaoVien(string msgv, ref string error)
        {
            try
            {
                string sql = "DELETE FROM NHAN_SU WHERE MSNV = @MSNV";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MSNV", msgv)
                };
                return DB.ProcessData(sql, CommandType.Text, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi xóa giáo viên: " + ex.Message;
                return false;
            }
        }
        public int LaySoTuMSNV(string msnv)
        {
            if (string.IsNullOrEmpty(msnv) || msnv.Length < 7)
            {
                return -1; // Hoặc ném một ngoại lệ, tùy thuộc vào yêu cầu của bạn
            }

            string soChuoi = msnv.Substring(3); // Lấy 4 ký tự cuối

            if (int.TryParse(soChuoi, out int so))
            {
                return so; // Chuyển đổi thành số nguyên thành công
            }
            else
            {
                return -1; // Hoặc ném một ngoại lệ nếu chuyển đổi thất bại
            }
        }
        public DataTable LoadComboBoxPhongBan(ref string error)
        {
            try
            {
                string sql = "SELECT MaPhongBan, PhongBan FROM QL_PhongBan";
                return DB.GetDataFromDB(sql, CommandType.Text, ref error);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi tải dữ liệu phòng ban: " + ex.Message;
                return null;
            }
        }
        public DataTable LoadComboBoxToCM(ref string error)
        {
            try
            {
                string sql = "SELECT MaPhongBan, PhongBan FROM QL_PhongBan where QL_PhongBan.[LOAI_NHANSU] = 'GV'";
                return DB.GetDataFromDB(sql, CommandType.Text, ref error);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi tải dữ liệu phòng ban: " + ex.Message;
                return null;
            }
        }
        public DataTable LoadComboBoxChucVu(string maPhongBan, ref string error)
        {
            try
            {
                string sql = "SELECT MAChucVu, ChucVu FROM QL_ChucVu WHERE MAPHONGBAN = @MaPhongBan";
                SqlParameter[] parameters = new SqlParameter[]
                    {
                    new SqlParameter("@MaPhongBan", maPhongBan)
                    };

                return DB.GetDataFromDB(sql, CommandType.Text, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi tải dữ liệu chức vụ: " + ex.Message;
                return null;
            }
        }
    }
}
