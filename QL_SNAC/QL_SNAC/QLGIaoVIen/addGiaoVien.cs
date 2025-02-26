using BusinessLogicLayer.Manager;
using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SNAC.QLGIaoVIen
{
    public partial class addGiaoVien : Form
    {
        public addGiaoVien()
        {
            InitializeComponent();
            LoadYearComboBox();
            cbGender.Text = "Nam";
        }



        private void LoadYearComboBox()
        {
            int currentYear = DateTime.Now.Year;
            for (int year = 1900; year <= currentYear; year++)
            {
                cbNamtotnghiep.Items.Add(year);
            }
            cbNamtotnghiep.SelectedIndex = cbNamtotnghiep.Items.Count - 1;
        }


        GiaoVienEntity GiaoVienEntity = new GiaoVienEntity();
        GiaoVienManager GiaoVienManager = new GiaoVienManager();
        ImgManager ImgManager = new ImgManager();
        ImgEntity ImgEntity = new ImgEntity();

        private string error = "";
        private void btnSave_Click(object sender, EventArgs e)
        {           
            if (string.IsNullOrWhiteSpace(txtHo.Text) ||
                string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(cbGender.Text) ||
                string.IsNullOrWhiteSpace(txtTonGiao.Text) ||
                string.IsNullOrWhiteSpace(txtQuocTich.Text) ||
                string.IsNullOrWhiteSpace(txtDanToc.Text) ||
                string.IsNullOrWhiteSpace(txtDCTamTru.Text) ||
                string.IsNullOrWhiteSpace(txtDCThuongTru.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtCCCD.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTrinhDo.Text) ||
                string.IsNullOrWhiteSpace(txtChuyenNganh.Text) ||
                string.IsNullOrWhiteSpace(cbNamtotnghiep.Text) ||
                string.IsNullOrWhiteSpace(txtLoaiBang.Text) ||
                string.IsNullOrWhiteSpace(txtTruong.Text) ||
                string.IsNullOrWhiteSpace(txtChuyenMon.Text) ||
                string.IsNullOrWhiteSpace(txtToChuyenMon.Text) ||
                string.IsNullOrWhiteSpace(txtChucVu.Text) ||
                string.IsNullOrWhiteSpace(txtBHXH.Text) ||
                string.IsNullOrWhiteSpace(txtMst.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop execution if any field is empty
            }

            try
            {
                GiaoVienEntity.Ho = txtHo.Text;
                GiaoVienEntity.Ten = txtTen.Text;
                GiaoVienEntity.GioiTinh = cbGender.Text;
                GiaoVienEntity.TonGiao = txtTonGiao.Text;
                GiaoVienEntity.QuocTich = txtQuocTich.Text;
                GiaoVienEntity.DanToc = txtDanToc.Text;
                GiaoVienEntity.NgaySinh = DateOnly.FromDateTime(dtNgaySinh.Value);
                GiaoVienEntity.DiaChiTamTru = txtDCTamTru.Text;
                GiaoVienEntity.DiaChiThuongTru = txtDCThuongTru.Text;
                GiaoVienEntity.SDT = txtSDT.Text;
                GiaoVienEntity.CCCD = txtCCCD.Text;
                GiaoVienEntity.Email = txtEmail.Text;
                GiaoVienEntity.NgayVaoLam = DateOnly.FromDateTime(dtNgayVaoLam.Value);
                GiaoVienEntity.TrinhDo = txtTrinhDo.Text;
                GiaoVienEntity.ChuyenNganhHoc = txtChuyenNganh.Text;
                GiaoVienEntity.NamTotNghiep = int.Parse(cbNamtotnghiep.Text);
                GiaoVienEntity.LoaiBang = txtLoaiBang.Text;
                GiaoVienEntity.Truong = txtTruong.Text;
                GiaoVienEntity.ChuyenMonDay = txtChuyenMon.Text;
                GiaoVienEntity.ToChuyenMon = txtToChuyenMon.Text;
                GiaoVienEntity.ChucVu = txtChucVu.Text;
                GiaoVienEntity.BHXH = txtBHXH.Text;
                GiaoVienEntity.MaSoThue = txtMst.Text;
                GiaoVienEntity.MSGV = GiaoVienManager.LayMaSogv(ref error);
                

                ImgEntity.Id = GiaoVienEntity.MSGV;
                ImgManager.ThemAnh(ImgEntity, ref error);
                GiaoVienManager.ThemGiaoVien(GiaoVienEntity, ref error);

                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
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
                    await Task.Delay(new Random().Next(3000, 5000));

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
