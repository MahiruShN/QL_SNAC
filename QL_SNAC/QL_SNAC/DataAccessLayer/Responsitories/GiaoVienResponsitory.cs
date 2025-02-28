﻿using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace DataAccessLayer.Responsitories
{
    public class GiaoVienResponsitory
    {
        private Database DB = new Database();
        public DataTable HienThiDSGiaoVienRutgon(ref string error)
        {
            try
            {
                string sql = " select MSGV,HO, TEN, GIOITINH,NGAY_SINH " +
                             " from THONG_TIN_GIAO_VIEN";
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
                string sql = " select [MSGV],[HO],[TEN],[GIOITINH],[NGAY_SINH],[DAN_TOC],[QUOC_TICH],[TON_GIAO],[DIA_CHI_THUONG_TRU],[DIA_CHI_TAM_TRU],[MA_SO_THUE],[BHXH],[CCCD],[SDT],[NGAY_VAO_LAM],[EMAIL],[CHUYEN_NGANH_HOC],[NAM_TOT_NGHIEP],[LOAI_BANG],[TRUONG],[CHUYEN_MON_DAY],[TO_CHUYEN_MON],[CHUC_VU],[TRINHDO] " +
                             " from THONG_TIN_GIAO_VIEN";
                var rs = DB.GetDataFromDB(sql, CommandType.Text, ref error);
                return rs;
            }
            catch (Exception ex)
            {
                error = "Kết nối lỗi: " + ex.Message;
                return null;
            }
        }

        public string LayMaSogv(ref string error)
        {
            try
            {
                string sql = "SELECT MAX(MSGV) FROM THONG_TIN_GIAO_VIEN";
                var rs = DB.GetDataFromDB(sql, CommandType.Text, ref error);
                if (rs.Rows.Count == 0)
                {
                    return "00000001";
                }
                string msgv = rs.Rows[0][0].ToString();
                int so = int.Parse(msgv.Substring(2)) + 1;
                return so.ToString("00000000");
            }
            catch (Exception ex)
            {
                error = "Kết nối lỗi: " + ex.Message;
                return null;
            }
        }

        public bool ThemGiaoVien(GiaoVienEntity gv, ref string error)
        {
            try
            {
                string sql = @"INSERT INTO THONG_TIN_GIAO_VIEN 
                   (MSGV, HO, TEN, GIOITINH, NGAY_SINH, DAN_TOC, QUOC_TICH, TON_GIAO, DIA_CHI_THUONG_TRU, DIA_CHI_TAM_TRU, 
                    MA_SO_THUE, BHXH, CCCD, SDT, NGAY_VAO_LAM, EMAIL, CHUYEN_NGANH_HOC, NAM_TOT_NGHIEP, LOAI_BANG, TRUONG, 
                    CHUYEN_MON_DAY, TO_CHUYEN_MON, CHUC_VU, TRINHDO)
                   VALUES 
                   (@MSGV, @HO, @TEN, @GIOITINH, @NGAY_SINH, @DAN_TOC, @QUOC_TICH, @TON_GIAO, @DIA_CHI_THUONG_TRU, @DIA_CHI_TAM_TRU, 
                    @MA_SO_THUE, @BHXH, @CCCD, @SDT, @NGAY_VAO_LAM, @EMAIL, @CHUYEN_NGANH_HOC, @NAM_TOT_NGHIEP, @LOAI_BANG, @TRUONG, 
                    @CHUYEN_MON_DAY, @TO_CHUYEN_MON, @CHUC_VU, @TRINHDO)";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MSGV", gv.MSGV),
                    new SqlParameter("@HO", gv.Ho),
                    new SqlParameter("@TEN", gv.Ten),
                    new SqlParameter("@GIOITINH", gv.GioiTinh),
                    //new SqlParameter("@NGAY_SINH", gv.NgaySinh),
                    new SqlParameter("@NGAY_SINH", gv.NgaySinh != default ? gv.NgaySinh.ToString("dd-MM-yyyy") : (object)DBNull.Value),

                    new SqlParameter("@DAN_TOC", gv.DanToc),
                    new SqlParameter("@QUOC_TICH", gv.QuocTich),
                    new SqlParameter("@TON_GIAO", gv.TonGiao),
                    new SqlParameter("@DIA_CHI_THUONG_TRU", gv.DiaChiThuongTru),
                    new SqlParameter("@DIA_CHI_TAM_TRU", gv.DiaChiTamTru),
                    new SqlParameter("@MA_SO_THUE", gv.MaSoThue),
                    new SqlParameter("@BHXH", gv.BHXH),
                    new SqlParameter("@CCCD", gv.CCCD),
                    new SqlParameter("@SDT", gv.SDT),
                    new SqlParameter("@NGAY_VAO_LAM", gv.NgayVaoLam != default ? gv.NgayVaoLam.ToString("dd-MM-yyyy") : (object)DBNull.Value),
                    //new SqlParameter("@NGAY_VAO_LAM", gv.NgayVaoLam),
                    new SqlParameter("@EMAIL", gv.Email),
                    new SqlParameter("@CHUYEN_NGANH_HOC", gv.ChuyenNganhHoc),
                    new SqlParameter("@NAM_TOT_NGHIEP", gv.NamTotNghiep),
                    new SqlParameter("@LOAI_BANG", gv.LoaiBang),
                    new SqlParameter("@TRUONG", gv.Truong),
                    new SqlParameter("@CHUYEN_MON_DAY", gv.ChuyenMonDay),
                    new SqlParameter("@TO_CHUYEN_MON", gv.ToChuyenMon),
                    new SqlParameter("@CHUC_VU", gv.ChucVu),
                    new SqlParameter("@TRINHDO", gv.TrinhDo)
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

        public bool XoaGiaoVien (string msgv, ref string error)
        {
            try
            {
                string sql = "DELETE FROM THONG_TIN_GIAO_VIEN WHERE MSGV = @MSGV";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MSGV", msgv)
                };
                return DB.ProcessData(sql, CommandType.Text, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi xóa giáo viên: " + ex.Message;
                return false;
            }
        }


        public bool CapNhatGiaoVien(GiaoVienEntity gv, ref string error)
        {
            try
            {
                string sql = @"UPDATE THONG_TIN_GIAO_VIEN 
                       SET HO = @HO, TEN = @TEN, GIOITINH = @GIOITINH, NGAY_SINH = @NGAY_SINH, 
                           DAN_TOC = @DAN_TOC, QUOC_TICH = @QUOC_TICH, TON_GIAO = @TON_GIAO, 
                           DIA_CHI_THUONG_TRU = @DIA_CHI_THUONG_TRU, DIA_CHI_TAM_TRU = @DIA_CHI_TAM_TRU, 
                           MA_SO_THUE = @MA_SO_THUE, BHXH = @BHXH, CCCD = @CCCD, SDT = @SDT, 
                           NGAY_VAO_LAM = @NGAY_VAO_LAM, EMAIL = @EMAIL, CHUYEN_NGANH_HOC = @CHUYEN_NGANH_HOC, 
                           NAM_TOT_NGHIEP = @NAM_TOT_NGHIEP, LOAI_BANG = @LOAI_BANG, TRUONG = @TRUONG, 
                           CHUYEN_MON_DAY = @CHUYEN_MON_DAY, TO_CHUYEN_MON = @TO_CHUYEN_MON, 
                           CHUC_VU = @CHUC_VU, TRINHDO = @TRINHDO
                       WHERE MSGV = @MSGV";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@MSGV", gv.MSGV),
            new SqlParameter("@HO", gv.Ho),
            new SqlParameter("@TEN", gv.Ten),
            new SqlParameter("@GIOITINH", gv.GioiTinh),
            new SqlParameter("@NGAY_SINH", gv.NgaySinh),
            //new SqlParameter("@NGAY_SINH", gv.NgaySinh != default ? gv.NgaySinh.ToString("dd-MM-yyyy") : (object)DBNull.Value),
            new SqlParameter("@DAN_TOC", gv.DanToc),
            new SqlParameter("@QUOC_TICH", gv.QuocTich),
            new SqlParameter("@TON_GIAO", gv.TonGiao),
            new SqlParameter("@DIA_CHI_THUONG_TRU", gv.DiaChiThuongTru),
            new SqlParameter("@DIA_CHI_TAM_TRU", gv.DiaChiTamTru),
            new SqlParameter("@MA_SO_THUE", gv.MaSoThue),
            new SqlParameter("@BHXH", gv.BHXH),
            new SqlParameter("@CCCD", gv.CCCD),
            new SqlParameter("@SDT", gv.SDT),
            new SqlParameter("@NGAY_VAO_LAM", gv.NgayVaoLam),
            //new SqlParameter("@NGAY_VAO_LAM", gv.NgayVaoLam != default ? gv.NgayVaoLam.ToString("dd-MM-yyyy") : (object)DBNull.Value),
            new SqlParameter("@EMAIL", gv.Email),
            new SqlParameter("@CHUYEN_NGANH_HOC", gv.ChuyenNganhHoc),
            new SqlParameter("@NAM_TOT_NGHIEP", gv.NamTotNghiep),
            new SqlParameter("@LOAI_BANG", gv.LoaiBang),
            new SqlParameter("@TRUONG", gv.Truong),
            new SqlParameter("@CHUYEN_MON_DAY", gv.ChuyenMonDay),
            new SqlParameter("@TO_CHUYEN_MON", gv.ToChuyenMon),
            new SqlParameter("@CHUC_VU", gv.ChucVu),
            new SqlParameter("@TRINHDO", gv.TrinhDo)
                };

                return DB.ProcessData(sql, CommandType.Text, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi cập nhật giáo viên: " + ex.Message;
                return false;
            }
        }
      

    }
}
