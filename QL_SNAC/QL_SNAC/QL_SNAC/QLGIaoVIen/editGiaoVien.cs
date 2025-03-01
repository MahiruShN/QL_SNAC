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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QL_SNAC.QLGIaoVIen
{
    public partial class editGiaoVien : Form
    {
        private NhanSuEntity NSEntity = new NhanSuEntity();
        private NhanSuManager NhanSuManager = new NhanSuManager();
        private string error = "";
        private string base64 = "";
        public editGiaoVien(NhanSuEntity gv)
        {
            InitializeComponent();
            this.NSEntity = gv;
            LoadThongTinGiaoVien();
            LoadComboxToChuyenMon();
            LoadComboBoxChucVu(NSEntity.MaPhongBan);
            LoadPicture();
        }

        private void LoadPicture ()
        {
            string error = "";
            string img = ImgManager.LayAnh(NSEntity.MSNV, ref error);
            if (img != null)
            {
                byte[] imageBytes = Convert.FromBase64String(img);
                using (var ms = new System.IO.MemoryStream(imageBytes))
                {
                    pnHinh.BackgroundImage = Image.FromStream(ms);
                    pnHinh.BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
        }
        private void LoadComboxToChuyenMon()
        {
            string error = "";
            DataTable toChuyenMonData = NhanSuManager.LoadComboBoxToChuyenMon(ref error);

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
            DataTable chucVuData = NhanSuManager.LoadComboBoxChucVu(maPhongBan, ref error);

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


        private void LoadThongTinGiaoVien()
        {
            txtCCCD.Text = NSEntity.CCCD;
            txtChuyenMon.Text = NSEntity.ChuyenMon;
            txtDanToc.Text = NSEntity.DanToc;
            txtDC.Text = NSEntity.DiaChi;
            txtEmail.Text = NSEntity.Email;
            txtHo.Text = NSEntity.Ho;
            txtMst.Text = NSEntity.MaSoThue;
            txtNamNganh.Text = NSEntity.NamVaoNganh.ToString();
            txtNamTN.Text = NSEntity.NamTotNghiep.ToString();
            txtNgayCap.Text = NSEntity.NgayCap;
            txtNguyenQuan.Text = NSEntity.NguyenQuan;
            txtNoiCap.Text = NSEntity.NoiCap;
            txtQuocTich.Text = NSEntity.QuocTich;
            txtSDT.Text = NSEntity.SDT;
            txtTen.Text = NSEntity.Ten;
            txtTonGiao.Text = NSEntity.TonGiao;
            txtTruong.Text = NSEntity.TruongTN;
            txtHocVan.Text = NSEntity.HocVan;
            txtNamHD.Text = NSEntity.NamHD;

            txtNgayHetThuViec.Text = NSEntity.NGAY_HET_THU_VIEC;

            if (string.IsNullOrWhiteSpace(NSEntity.NgaySinh))
            {
                dtNgaySinh.Value = DateTime.Now;
            }
            else
            {
                dtNgaySinh.Value = DateTime.ParseExact(NSEntity.NgaySinh, "d-M-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            cbGender.Text = NSEntity.GioiTinh;
            cboPhongBan.SelectedValue = NSEntity.MaPhongBan;
            cboChucVu.SelectedValue = NSEntity.MAChucVu;
            dtNgayVaoLam.Value = DateTime.ParseExact(NSEntity.NGAY_VAO_LAM, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            if (string.IsNullOrWhiteSpace(NSEntity.HD_Lan1))
            {
                dt_HD1.Value = DateTime.Now; 
            }
            else
            {                          
                    dt_HD1.Value = DateTime.ParseExact(NSEntity.HD_Lan1, "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture);                              
            }

            if (string.IsNullOrWhiteSpace(NSEntity.HD_Lan2))
            {
                dt_HD2.Value = DateTime.Now;
            }
            else
            {
                dt_HD2.Value = DateTime.ParseExact(NSEntity.HD_Lan2, "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }

            if (string.IsNullOrWhiteSpace(NSEntity.HD_Lan3))
            {
                dt_HD3.Value = DateTime.Now;
            }
            else
            {
                dt_HD3.Value = DateTime.ParseExact(NSEntity.HD_Lan3, "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture);
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
                NSEntity.NGAY_HET_THU_VIEC = txtNgayHetThuViec.Text;

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
                NSEntity.NamHD = txtNamHD.Text;

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
                    if (ImgManager.LayAnh(NSEntity.MSNV, ref error) == null)
                    {
                        ImgManager.ThemAnh(ImgEntity, ref error);
                    }
                    else
                    {
                        ImgManager.CapNhatAnh(ImgEntity, ref error);

                    }

                }
                    //Thêm Nhân sự
                    if (NhanSuManager.CapNhatGiaoVien(NSEntity, ref error))
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
                    base64 = base32String;
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
