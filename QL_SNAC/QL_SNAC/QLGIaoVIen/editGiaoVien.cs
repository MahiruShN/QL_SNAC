using BusinessLogicLayer.Manager;
using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SNAC.QLGIaoVIen
{
    public partial class editGiaoVien : Form
    {
        private GiaoVienEntity giaoVien;
        private GiaoVienManager giaoVienManager = new GiaoVienManager();
        public editGiaoVien(GiaoVienEntity gv)
        {
            InitializeComponent();
            this.giaoVien = gv;
            LoadThongTinGiaoVien();
        }
        private void LoadThongTinGiaoVien()
        {
            txtMSGV.Text = giaoVien.MSGV;
            txtHo.Text = giaoVien.Ho;
            txtTen.Text = giaoVien.Ten;
            cbGender.Text = giaoVien.GioiTinh;
            dtNgaySinh.Value = giaoVien.NgaySinh.ToDateTime(TimeOnly.MinValue);
            txtDanToc.Text = giaoVien.DanToc;
            txtQuocTich.Text = giaoVien.QuocTich;
            txtTonGiao.Text = giaoVien.TonGiao;
            txtDCThuongTru.Text = giaoVien.DiaChiThuongTru;
            txtDCTamTru.Text = giaoVien.DiaChiTamTru;
            txtMst.Text = giaoVien.MaSoThue;
            txtBHXH.Text = giaoVien.BHXH;
            txtCCCD.Text = giaoVien.CCCD;
            txtSDT.Text = giaoVien.SDT;
            dtNgayVaoLam.Value = giaoVien.NgayVaoLam.ToDateTime(TimeOnly.MinValue);

            txtEmail.Text = giaoVien.Email;
            txtChuyenNganh.Text = giaoVien.ChuyenNganhHoc;
            cbNamtotnghiep.Text = giaoVien.NamTotNghiep.ToString();
            txtLoaiBang.Text = giaoVien.LoaiBang;
            txtTruong.Text = giaoVien.Truong;
            txtChuyenMon.Text = giaoVien.ChuyenMonDay;
            txtToChuyenMon.Text = giaoVien.ToChuyenMon;
            txtChucVu.Text = giaoVien.ChucVu;
            txtTrinhDo.Text = giaoVien.TrinhDo;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string error = "";
            giaoVien.Ho = txtHo.Text;
            giaoVien.Ten = txtTen.Text;
            giaoVien.GioiTinh = cbGender.Text;
            giaoVien.NgaySinh = DateOnly.FromDateTime(dtNgaySinh.Value);
            giaoVien.DanToc = txtDanToc.Text;
            giaoVien.QuocTich = txtQuocTich.Text;
            giaoVien.TonGiao = txtTonGiao.Text;
            giaoVien.DiaChiThuongTru = txtDCThuongTru.Text;
            giaoVien.DiaChiTamTru = txtDCTamTru.Text;
            giaoVien.MaSoThue = txtMst.Text;
            giaoVien.BHXH = txtBHXH.Text;
            giaoVien.CCCD = txtCCCD.Text;
            giaoVien.SDT = txtSDT.Text;
            giaoVien.NgayVaoLam = DateOnly.FromDateTime(dtNgayVaoLam.Value);
            giaoVien.Email = txtEmail.Text;
            giaoVien.ChuyenNganhHoc = txtChuyenNganh.Text;
            giaoVien.NamTotNghiep = int.Parse(cbNamtotnghiep.Text);
            giaoVien.LoaiBang = txtLoaiBang.Text;
            giaoVien.Truong = txtTruong.Text;
            giaoVien.ChuyenMonDay = txtChuyenMon.Text;
            giaoVien.ToChuyenMon = txtToChuyenMon.Text;
            giaoVien.ChucVu = txtChucVu.Text;
            giaoVien.TrinhDo = txtTrinhDo.Text;

            bool success = giaoVienManager.CapNhatGiaoVien(giaoVien, ref error);

            if (success)
            {
                MessageBox.Show("Cập nhật giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Đóng form sau khi cập nhật thành công
            }
            else
            {
                MessageBox.Show("Lỗi: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
