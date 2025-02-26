using BusinessLogicLayer.Manager;
using DataAccessLayer.Entity;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            if (giaoVien.NgaySinh.ToDateTime(TimeOnly.MinValue) >= dtNgaySinh.MinDate &&
            giaoVien.NgaySinh.ToDateTime(TimeOnly.MinValue) <= dtNgaySinh.MaxDate)
            {
                dtNgaySinh.Value = giaoVien.NgaySinh.ToDateTime(TimeOnly.MinValue);
            }
            else
            {
                dtNgaySinh.Value = dtNgaySinh.MinDate; // or set to a default valid date
            }
            //dtNgaySinh.Value = giaoVien.NgaySinh.ToDateTime(TimeOnly.MinValue);
            txtDanToc.Text = giaoVien.DanToc;
            txtQuocTich.Text = giaoVien.QuocTich;
            txtTonGiao.Text = giaoVien.TonGiao;
            txtDCThuongTru.Text = giaoVien.DiaChiThuongTru;
            txtDCTamTru.Text = giaoVien.DiaChiTamTru;
            txtMst.Text = giaoVien.MaSoThue;
            txtBHXH.Text = giaoVien.BHXH;
            txtCCCD.Text = giaoVien.CCCD;
            txtSDT.Text = giaoVien.SDT;
            //dtNgayVaoLam.Value = giaoVien.NgayVaoLam.ToDateTime(TimeOnly.MinValue);
            if (giaoVien.NgayVaoLam.ToDateTime(TimeOnly.MinValue) >= dtNgayVaoLam.MinDate &&
            giaoVien.NgayVaoLam.ToDateTime(TimeOnly.MinValue) <= dtNgayVaoLam.MaxDate)
            {
                dtNgayVaoLam.Value = giaoVien.NgayVaoLam.ToDateTime(TimeOnly.MinValue);
            }
            else
            {
                dtNgayVaoLam.Value = dtNgayVaoLam.MinDate; // or set to a default valid date
            }
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
            // Kiểm tra tất cả các ô nhập liệu
            if (string.IsNullOrWhiteSpace(txtHo.Text) ||
                string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(cbGender.Text) ||
                string.IsNullOrWhiteSpace(txtDanToc.Text) ||
                string.IsNullOrWhiteSpace(txtQuocTich.Text) ||
                string.IsNullOrWhiteSpace(txtTonGiao.Text) ||
                string.IsNullOrWhiteSpace(txtDCThuongTru.Text) ||
                string.IsNullOrWhiteSpace(txtDCTamTru.Text) ||
                string.IsNullOrWhiteSpace(txtMst.Text) ||
                string.IsNullOrWhiteSpace(txtBHXH.Text) ||
                string.IsNullOrWhiteSpace(txtCCCD.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtChuyenNganh.Text) ||
                string.IsNullOrWhiteSpace(cbNamtotnghiep.Text) ||
                string.IsNullOrWhiteSpace(txtLoaiBang.Text) ||
                string.IsNullOrWhiteSpace(txtTruong.Text) ||
                string.IsNullOrWhiteSpace(txtChuyenMon.Text) ||
                string.IsNullOrWhiteSpace(txtToChuyenMon.Text) ||
                string.IsNullOrWhiteSpace(txtChucVu.Text) ||
                string.IsNullOrWhiteSpace(txtTrinhDo.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            ImgEntity.Id = giaoVien.MSGV;
            ImgManager.CapNhatAnh(ImgEntity, ref error);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        ImgManager ImgManager = new ImgManager();
        ImgEntity ImgEntity = new ImgEntity();
        string base32 = "";
        private async void btnChon_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Chọn ảnh học sinh";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = ofd.FileName;

                    // Read image and encode to Base32
                    byte[] imageBytes = File.ReadAllBytes(imagePath);
                    string base32String = Convert.ToBase64String(imageBytes); // Simulating Base32 with Base64 for simplicity
                    base32 = base32String;
                    ImgEntity.ImgBase32 = base32String;
                    // Show "Loading..." text
                    pnHinh.BackgroundImage = null;
                    pnHinh.Controls.Clear();
                    Label loadingLabel = new Label
                    {
                        Text = "Loading...",
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill,
                        Font = new Font("Arial", 14, FontStyle.Bold)
                    };
                    pnHinh.Controls.Add(loadingLabel);

                    // Simulate processing time (3-5 seconds)
                    await Task.Delay(new Random().Next(500, 1000));

                    // Decode from Base32 (Base64 in this case)
                    byte[] decodedBytes = Convert.FromBase64String(base32String);
                    using (MemoryStream ms = new MemoryStream(decodedBytes))
                    {
                        Image img = Image.FromStream(ms);
                        pnHinh.BackgroundImage = img;
                        pnHinh.BackgroundImageLayout = ImageLayout.Zoom;
                    }

                    // Remove loading text
                    pnHinh.Controls.Clear();
                }
            }
        }
    }
}
