using System;

namespace DataAccessLayer.Entity
{
    public class GiaoVienEntity
    {
        public string MSGV { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public DateOnly NgaySinh { get; set; }
        public string DanToc { get; set; }
        public string QuocTich { get; set; }
        public string TonGiao { get; set; }
        public string DiaChiThuongTru { get; set; }
        public string DiaChiTamTru { get; set; }
        public string MaSoThue { get; set; }
        public string BHXH { get; set; }
        public string CCCD { get; set; }
        public string SDT { get; set; }
        public DateOnly NgayVaoLam { get; set; }
        public string Email { get; set; }
        public string ChuyenNganhHoc { get; set; }
        public int NamTotNghiep { get; set; }
        public string LoaiBang { get; set; }
        public string Truong { get; set; }
        public string ChuyenMonDay { get; set; }
        public string ToChuyenMon { get; set; }
        public string ChucVu { get; set; }
        public string TrinhDo { get; set; }
    }
}
