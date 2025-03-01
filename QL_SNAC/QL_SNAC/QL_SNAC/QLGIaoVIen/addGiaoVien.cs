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

        NhanSuEntity NSEntity = new NhanSuEntity();
        NhanSuManager GVManager = new NhanSuManager();
        GiaoVienEntity GiaoVienEntity = new GiaoVienEntity();
        GiaoVienManager GiaoVienManager = new GiaoVienManager();
        ImgManager ImgManager = new ImgManager();
        ImgEntity ImgEntity = new ImgEntity();

        private string error = "";
        public addGiaoVien()
        {
            InitializeComponent();
            //LoadYearComboBox();
            LoadComboxToChuyenMon();
            cbGender.Text = "Nam";
        }



        //private void LoadYearComboBox()
        //{
        //    int currentYear = DateTime.Now.Year;
        //    for (int year = 1900; year <= currentYear; year++)
        //    {
        //        cbNamtotnghiep.Items.Add(year);
        //    }
        //    cbNamtotnghiep.SelectedIndex = cbNamtotnghiep.Items.Count - 1;
        //}
        private void LoadComboxToChuyenMon()
        {
            string error = "";
            DataTable toChuyenMonData = GVManager.LoadComboBoxToChuyenMon(ref error);

            if (toChuyenMonData != null)
            {
                cboPhongBan.DataSource = toChuyenMonData;
                cboPhongBan.DisplayMember = "PhongBan";
                cboPhongBan.ValueMember = "MaPhongBan";
                cboPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;

                // Load chức vụ khi phòng ban được chọn
                if (toChuyenMonData.Rows.Count > 0)
                {
                    LoadComboBoxChucVu(toChuyenMonData.Rows[0]["MaPhongBan"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Lỗi tải dữ liệu tổ chuyên môn: " + error);
            }
        }
        private void LoadComboBoxChucVu(string maPhongBan)
        {
            string error = "";
            DataTable chucVuData = GVManager.LoadComboBoxChucVu(maPhongBan, ref error);

            if (chucVuData != null)
            {
                cboChucVu.DataSource = chucVuData;
                cboChucVu.DisplayMember = "ChucVu";
                cboChucVu.ValueMember = "MAChucVu";
                cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else
            {
                MessageBox.Show("Lỗi tải dữ liệu chức vụ: " + error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHo.Text) ||
                string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Vui lòng điền Họ và tên ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop execution if any field is empty
            }

            try
            {
                NSEntity.Ho = txtHo.Text;
                NSEntity.Ten = txtTen.Text;
                NSEntity.GioiTinh = cbGender.Text;
                NSEntity.NgaySinh = dtNgaySinh.Value.ToString("dd-MM-yyyy");
                NSEntity.TonGiao = txtTonGiao.Text;
                NSEntity.SDT = txtSDT.Text;
                NSEntity.NguyenQuan = txtNguyenQuan.Text;
                NSEntity.QuocTich = txtQuocTich.Text;
                NSEntity.DanToc = txtDanToc.Text;
                NSEntity.CCCD = txtCCCD.Text;
                NSEntity.NgayCap = txtNgayCap.Text;
                NSEntity.NoiCap = txtNoiCap.Text;
                NSEntity.MaSoThue = txtMst.Text;
                NSEntity.DiaChi = txtDC.Text;
                NSEntity.Email = txtEmail.Text;
                NSEntity.TruongTN = txtTruong.Text;
                NSEntity.ChuyenMon = txtChuyenMon.Text;
                NSEntity.HocVan = txtHocVan.Text;
                NSEntity.LoaiNS = "GV";
                NSEntity.NamTotNghiep = Convert.ToInt32(txtNamTN.Text);
                NSEntity.NamVaoNganh = Convert.ToInt32(txtNamNganh.Text);
                NSEntity.MaPhongBan = cboPhongBan.SelectedValue.ToString();
                NSEntity.MAChucVu = cboChucVu.SelectedValue.ToString();
                NSEntity.NGAY_VAO_LAM = dtNgayVaoLam.Value.ToString("dd/MM/yyyy");
                NSEntity.HD_Lan1 = dt_HD1.Value.ToString("dd/MM/yyyy");
                NSEntity.HD_Lan2 = dt_HD2.Value.ToString("dd/MM/yyyy");
                NSEntity.HD_Lan3 = dt_HD3.Value.ToString("dd/MM/yyyy");

                NSEntity.MSNV = GVManager.LayMaSogv(ref error);
                if (NSEntity.MSNV == null)
                {
                    MessageBox.Show("Lỗi khi lấy mã giáo viên: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lưu hình ảnh vào ImgData
                if (!string.IsNullOrEmpty(base64))
                {
                    ImgEntity.Id = NSEntity.MSNV; // Sử dụng MSNV làm Id
                    ImgEntity.ImgBase32 = base64;

                    if (!ImgManager.ThemAnh(ImgEntity, ref error))
                    {
                        MessageBox.Show($"Lỗi khi lưu ảnh vào bảng ImgData: {error}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Dừng nếu lưu ảnh thất bại
                    }
                }


                //Thêm Nhân sự
                if (GVManager.ThemGiaoVien(NSEntity, ref error))
                {
                    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Lỗi khi thêm giáo viên vào bảng NhanSu: {error}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        string base64 = "";
        private async void btnChon_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Chọn ảnh giáo viên";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = ofd.FileName;
                    byte[] imageBytes = File.ReadAllBytes(imagePath);
                    string base64String = Convert.ToBase64String(imageBytes);
                    base64 = base64String;
                    ImgEntity.ImgBase32 = base64String;

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

                    await Task.Delay(new Random().Next(3000, 5000));

                    byte[] decodedBytes = Convert.FromBase64String(base64String);
                    using (MemoryStream ms = new MemoryStream(decodedBytes))
                    {
                        Image img = Image.FromStream(ms);
                        pnHinh.BackgroundImage = img;
                        pnHinh.BackgroundImageLayout = ImageLayout.Zoom;
                    }

                    pnHinh.Controls.Clear();
                }
            }
        }

        private void cboPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhongBan.SelectedValue != null)
            {
                LoadComboBoxChucVu(cboPhongBan.SelectedValue.ToString());
            }
        }
    }
}
