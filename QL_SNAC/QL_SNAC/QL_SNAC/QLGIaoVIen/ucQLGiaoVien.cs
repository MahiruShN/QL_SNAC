using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_SNAC.QLHocSinh;
using static System.Runtime.InteropServices.JavaScript.JSType;
using BusinessLogicLayer.Manager;
using DataAccessLayer.Entity;
using System.Globalization;
using static Azure.Core.HttpHeader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using OfficeOpenXml;

namespace QL_SNAC.QLGIaoVIen
{
    public partial class ucQLGiaoVien : UserControl
    {
        private NhanSuManager gvManager = new NhanSuManager();
        //private GiaoVienManager GvManager = new GiaoVienManager();
        private DataTable DsGiaoVien = null;
        private string error = "";
        private ImgManager imgManager = new ImgManager();
        ImgEntity imgEntity = new ImgEntity();
        public string msimg = "";
        public ucQLGiaoVien()
        {
            InitializeComponent();
            LayDSGiaoVien();
            FormatDgv();
            //dgvGiaoVien.Columns["Ngay_Sinh"].DefaultCellStyle.Format = "dd-MM-yyyy";
            //dgvGiaoVien.Columns["NGAY_VAO_LAM"].DefaultCellStyle.Format = "dd-MM-yyyy";
        }

        private void LayDSGiaoVien()
        {
            try
            {
                var data = gvManager.HienThiDSGVFull(ref error);
                if (data == null)
                {
                    MessageBox.Show(error);
                }
                else
                {
                    DsGiaoVien = data;
                    foreach (DataRow row in DsGiaoVien.Rows)
                    {
                        if (DateTime.TryParse(row["Ngay_Sinh"].ToString(), out DateTime dateValue))
                        {
                            row["Ngay_Sinh"] = dateValue.ToString("dd-MM-yyyy");
                        }
                    }
                    dgvGiaoVien.DataSource = DsGiaoVien;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbTieuDe_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            addGiaoVien frm = new addGiaoVien();
            DialogResult result = frm.ShowDialog();

            LayDSGiaoVien();

        }

        private void dgvGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //private void dgvGiaoVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (dgvGiaoVien.Columns[e.ColumnIndex].Name == "NGAY_SINH" && e.Value != null)
        //    {
        //        if (DateTime.TryParse(e.Value.ToString(), out DateTime dateValue))
        //        {
        //            e.Value = dateValue.ToString("dd/MM/yyyy");
        //            e.FormattingApplied = true;
        //        }
        //    }
        //}

        private void SuaThongTin()
        {
            if (dgvGiaoVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một giáo viên trước khi cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvGiaoVien.SelectedRows[0];

            NhanSuEntity gv = new NhanSuEntity
            {

                MSNV = row.Cells["MSNV"].Value?.ToString() ?? "",
                Ho = row.Cells["HO"].Value?.ToString() ?? "",
                Ten = row.Cells["TEN"].Value?.ToString() ?? "",
                NGAY_VAO_LAM = row.Cells["NGAY_VAO_LAM"].Value?.ToString() ?? "",
                NGAY_HET_THU_VIEC = row.Cells["NGAY_HET_THU_VIEC"].Value?.ToString() ?? "",
                HD_Lan1 = row.Cells["HD_Lan1"].Value?.ToString() ?? "",
                HD_Lan2 = row.Cells["HD_Lan2"].Value?.ToString() ?? "",
                HD_Lan3 = row.Cells["HD_Lan3"].Value?.ToString() ?? "",
                NamHD = row.Cells["NamHD"].Value?.ToString() ?? "",
                MaPhongBan = row.Cells["MaPhongBan"].Value?.ToString() ?? "",
                MAChucVu = row.Cells["MAChucVu"].Value?.ToString() ?? "",
                NgaySinh = row.Cells["Ngay_Sinh"].Value?.ToString() ?? "",
                GioiTinh = row.Cells["GIOITINH"].Value?.ToString() ?? "",
                CCCD = row.Cells["CCCD"].Value?.ToString() ?? "",
                NgayCap = row.Cells["NgayCap"].Value?.ToString() ?? "",
                NoiCap = row.Cells["NoiCap"].Value?.ToString() ?? "",
                SDT = row.Cells["SDT"].Value?.ToString() ?? "",
                NguyenQuan = row.Cells["Nguyen_Quan"].Value?.ToString() ?? "",
                DanToc = row.Cells["DanToc"].Value?.ToString() ?? "",
                QuocTich = row.Cells["QuocTich"].Value?.ToString() ?? "",
                TonGiao = row.Cells["TonGiao"].Value?.ToString() ?? "",
                HocVan = row.Cells["HocVan"].Value?.ToString() ?? "",
                ChuyenMon = row.Cells["ChuyenMon"].Value?.ToString() ?? "",
                DiaChi = row.Cells["DiaChi"].Value?.ToString() ?? "",
                Email = row.Cells["Email"].Value?.ToString() ?? "",
                TruongTN = row.Cells["Truong_TotNghiep"].Value?.ToString() ?? "",
                NamTotNghiep = row.Cells["NamTotNghiep"].Value != DBNull.Value
                ? Convert.ToInt32(row.Cells["NamTotNghiep"].Value)
                : 0,
                NamVaoNganh = row.Cells["NamVaoNganh"].Value != DBNull.Value
                ? Convert.ToInt32(row.Cells["NamVaoNganh"].Value)
                : 0,
                MaSoThue = row.Cells["MST"].Value?.ToString() ?? "",

            };


            editGiaoVien updateForm = new editGiaoVien(gv);
            updateForm.ShowDialog();
            LayDSGiaoVien();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            SuaThongTin();

        }
        public void SetAvatarFromBase64(string base64String)
        {
            try
            {
                // Chuyển đổi Base64 thành mảng byte


                if (base64String != null)
                {
                    byte[] imageBytes = Convert.FromBase64String(base64String);

                    // Đọc mảng byte thành hình ảnh
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pbAvatar.Image = Image.FromStream(ms);
                        pbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị ảnh: " + ex.Message);
            }
        }
        private void FormatDgv()
        {
            foreach (DataGridViewColumn col in dgvGiaoVien.Columns)
            {
                col.Visible = false;
            }
            dgvGiaoVien.Columns["MSNV"].HeaderText = "Mã số nhân viên";
            dgvGiaoVien.Columns["MSNV"].Visible = true;
            dgvGiaoVien.Columns["HO"].HeaderText = "Họ";
            dgvGiaoVien.Columns["HO"].Visible = true;
            dgvGiaoVien.Columns["TEN"].HeaderText = "Tên";
            dgvGiaoVien.Columns["TEN"].Visible = true;
            dgvGiaoVien.Columns["Ngay_Sinh"].HeaderText = "Ngày sinh";
            dgvGiaoVien.Columns["Ngay_Sinh"].Visible = true;
            dgvGiaoVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvGiaoVien.Columns["GioiTinh"].Visible = true;
            dgvGiaoVien.Columns["CCCD"].HeaderText = "CCCD";
            dgvGiaoVien.Columns["CCCD"].Visible = true;

            dgvGiaoVien.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvGiaoVien.Columns["SDT"].Visible = true;
            dgvGiaoVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvGiaoVien.Columns["DiaChi"].Visible = true;
            dgvGiaoVien.Columns["PhongBan"].HeaderText = "Phòng ban";
            dgvGiaoVien.Columns["PhongBan"].Visible = true;
            dgvGiaoVien.Columns["ChucVu"].HeaderText = "Chức vụ";
            dgvGiaoVien.Columns["ChucVu"].Visible = true;
            dgvGiaoVien.Columns["NGAY_VAO_LAM"].HeaderText = "Ngày vào làm";
            dgvGiaoVien.Columns["NGAY_VAO_LAM"].Visible = true;

        }
        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không chọn tiêu đề
            {
                DataGridViewRow row = dgvGiaoVien.Rows[e.RowIndex];

                // Lấy dữ liệu từ DataGridView
                string MSNV = row.Cells["MSNV"].Value?.ToString() ?? "";
                string hoTen = $"{row.Cells["HO"].Value?.ToString()} {row.Cells["TEN"].Value?.ToString()}";
                string NGAY_VAO_LAM = row.Cells["NGAY_VAO_LAM"].Value?.ToString() ?? "";
                string PhongBan = row.Cells["PhongBan"].Value?.ToString() ?? "";
                string ChucVu = row.Cells["ChucVu"].Value?.ToString() ?? "";
                string gioiTinh = row.Cells["GioiTinh"].Value?.ToString() ?? "";
                string CCCD = row.Cells["CCCD"].Value?.ToString() ?? "";
                string ngayCap = row.Cells["NgayCap"].Value?.ToString() ?? "";
                string noiCap = row.Cells["NoiCap"].Value?.ToString() ?? "";
                string sodienthoai = row.Cells["SDT"].Value?.ToString() ?? "";
                string nguyenquan = row.Cells["Nguyen_Quan"].Value?.ToString() ?? "";
                string diachi = row.Cells["DiaChi"].Value?.ToString() ?? "";
                // Xử lý ngày sinh (nếu null thì chọn ngày ngẫu nhiên)
                string ngaySinh = row.Cells["Ngay_Sinh"].Value?.ToString() ?? "";
                // Hiển thị dữ liệu lên các panel hoặc label
                lbMaGiaoVien.Text = MSNV;
                lbHoten.Text = hoTen;
                lbGioiTinh.Text = gioiTinh;
                lbPhongBan.Text = PhongBan;
                lbNgayLam.Text = NGAY_VAO_LAM;
                lbChucVu.Text = ChucVu;
                lbCCCD.Text = CCCD;
                lbDiaChi.Text = diachi;
                lbNgayCap.Text = ngayCap;
                lbNoiCap.Text = noiCap;
                lbSDT.Text = sodienthoai;
                lbQueQuan.Text = nguyenquan;



                // Hiển thị ngày sinh vào DateTimePicker
                lbNgaySinh.Text = ngaySinh;
                SetAvatarFromBase64(imgManager.LayAnh(MSNV, ref error));

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGiaoVien.SelectedRows.Count > 0) // Kiểm tra có chọn dòng chưa
            {
                string MSNV = dgvGiaoVien.SelectedRows[0].Cells["MSNV"].Value?.ToString();

                if (!string.IsNullOrEmpty(MSNV))
                {
                    DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa giáo viên này?",
                                                           "Xác nhận",
                                                           MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        string error = "";
                        imgManager.XoaAnh(MSNV, ref error);
                        bool isDeleted = gvManager.XoaGiaoVien(MSNV, ref error); // Gọi hàm xóa
                        if (isDeleted)
                        {
                            MessageBox.Show("Xóa giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LayDSGiaoVien(); // Load lại DataGridView sau khi xóa
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi xóa giáo viên, có thể giáo viễn vẫn đang đứng lớp hoặc có vai trò khác, vui lòng xóa hết vai trò của giáo viên để tiêp tục!);");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một giáo viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một giáo viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvGiaoVien_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SuaThongTin();

        }

        private void ExportToExcel()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Files|*.xlsx", FileName = "Data.xlsx" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (ExcelPackage pck = new ExcelPackage())
                        {
                            ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Sheet1");

                            // Xuất tiêu đề cột
                            for (int col = 0; col < dgvGiaoVien.Columns.Count; col++)
                            {
                                ws.Cells[1, col + 1].Value = dgvGiaoVien.Columns[col].HeaderText;
                            }

                            // Xuất dữ liệu
                            for (int row = 0; row < dgvGiaoVien.Rows.Count; row++)
                            {
                                for (int col = 0; col < dgvGiaoVien.Columns.Count; col++)
                                {
                                    ws.Cells[row + 2, col + 1].Value = dgvGiaoVien.Rows[row].Cells[col].Value?.ToString();
                                }
                            }

                            // Lưu file Excel
                            File.WriteAllBytes(sfd.FileName, pck.GetAsByteArray());

                            MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim();
            string filter = $"Ho LIKE '%{searchValue}%' OR Ten LIKE '%{searchValue}%' OR MSNV LIKE '%{searchValue}%'";
            (dgvGiaoVien.DataSource as DataTable).DefaultView.RowFilter = filter;
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
    }
}
