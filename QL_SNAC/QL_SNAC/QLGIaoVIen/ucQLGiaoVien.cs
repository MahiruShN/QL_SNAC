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

namespace QL_SNAC.QLGIaoVIen
{
    public partial class ucQLGiaoVien : UserControl
    {
        private GiaoVienManager GvManager = new GiaoVienManager();
        private DataTable DsGiaoVien = null;
        private string error = "";
        private ImgManager imgManager = new ImgManager();
        public ucQLGiaoVien()
        {
            InitializeComponent();
            LayDSGiaoVien();
            dgvGiaoVien.Columns["NGAY_SINH"].DefaultCellStyle.Format = "ddMMyyyy";
            dgvGiaoVien.Columns["NGAY_VAO_LAM"].DefaultCellStyle.Format = "ddMMyyyy";
        }

        private void LayDSGiaoVien()
        {
            try
            {
                var data = GvManager.HienThiDSGVFull(ref error);
                if (data == null)
                {
                    MessageBox.Show(error);
                }
                else
                {
                    DsGiaoVien = data;
                    foreach (DataRow row in DsGiaoVien.Rows)
                    {
                        if (DateTime.TryParse(row["NGAY_SINH"].ToString(), out DateTime dateValue))
                        {
                            row["NGAY_SINH"] = dateValue.ToString("dd/MM/yyyy");
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
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvGiaoVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một giáo viên trước khi cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvGiaoVien.SelectedRows[0];

            GiaoVienEntity gv = new GiaoVienEntity
            {
                
                MSGV = row.Cells["MSGV"].Value?.ToString() ?? "",
                Ho = row.Cells["HO"].Value?.ToString() ?? "",
                Ten = row.Cells["TEN"].Value?.ToString() ?? "",
                GioiTinh = row.Cells["GIOITINH"].Value?.ToString() ?? "",
                NgaySinh = DateTime.TryParseExact(
    row.Cells["NGAY_SINH"].Value?.ToString(),
    new[] { "dd/MM/yyyy", "d/M/yyyy", "yyyy-MM-dd", "MM-dd-yyyy" }, // Các định dạng có thể có
    CultureInfo.InvariantCulture,
    DateTimeStyles.None,
    out DateTime ngaySinhValue
) ? DateOnly.FromDateTime(ngaySinhValue) : default,
                DanToc = row.Cells["DAN_TOC"].Value?.ToString() ?? "",
                QuocTich = row.Cells["QUOC_TICH"].Value?.ToString() ?? "",
                TonGiao = row.Cells["TON_GIAO"].Value?.ToString() ?? "",
                DiaChiThuongTru = row.Cells["DIA_CHI_THUONG_TRU"].Value?.ToString() ?? "",
                DiaChiTamTru = row.Cells["DIA_CHI_TAM_TRU"].Value?.ToString() ?? "",
                MaSoThue = row.Cells["MA_SO_THUE"].Value?.ToString() ?? "",
                BHXH = row.Cells["BHXH"].Value?.ToString() ?? "",
                CCCD = row.Cells["CCCD"].Value?.ToString() ?? "",
                SDT = row.Cells["SDT"].Value?.ToString() ?? "",
                NgayVaoLam = DateTime.TryParseExact(
    row.Cells["NGAY_VAO_LAM"].Value?.ToString(),
    new[] { "dd/MM/yyyy", "d/M/yyyy", "yyyy-MM-dd", "MM-dd-yyyy" }, // Các định dạng có thể có
    CultureInfo.InvariantCulture,
    DateTimeStyles.None,
    out DateTime ngayVaoLamValue
) ? DateOnly.FromDateTime(ngayVaoLamValue) : default,

                Email = row.Cells["EMAIL"].Value?.ToString() ?? "",
                ChuyenNganhHoc = row.Cells["CHUYEN_NGANH_HOC"].Value?.ToString() ?? "",
                NamTotNghiep = row.Cells["NAM_TOT_NGHIEP"].Value != DBNull.Value
                ? Convert.ToInt32(row.Cells["NAM_TOT_NGHIEP"].Value)
                : 0,
                LoaiBang = row.Cells["LOAI_BANG"].Value?.ToString() ?? "",
                Truong = row.Cells["TRUONG"].Value?.ToString() ?? "",
                ChuyenMonDay = row.Cells["CHUYEN_MON_DAY"].Value?.ToString() ?? "",
                ToChuyenMon = row.Cells["TO_CHUYEN_MON"].Value?.ToString() ?? "",
                ChucVu = row.Cells["CHUC_VU"].Value?.ToString() ?? "",
                TrinhDo = row.Cells["TRINHDO"].Value?.ToString() ?? ""
            };


            editGiaoVien updateForm = new editGiaoVien(gv);
            updateForm.ShowDialog();
            LayDSGiaoVien();
        }

        public void SetAvatarFromBase64(string base64String)
        {
            try
            {
                // Chuyển đổi Base64 thành mảng byte
                byte[] imageBytes = Convert.FromBase64String(base64String);

                // Đọc mảng byte thành hình ảnh
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    pbAvatar.Image = Image.FromStream(ms);
                    pbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị ảnh: " + ex.Message);
            }
        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không chọn tiêu đề
            {
                DataGridViewRow row = dgvGiaoVien.Rows[e.RowIndex];

                // Lấy dữ liệu từ DataGridView
                string msgv = row.Cells["MSGV"].Value?.ToString() ?? "";
                string hoTen = $"{row.Cells["HO"].Value?.ToString()} {row.Cells["TEN"].Value?.ToString()}";
                string gioiTinh = row.Cells["GIOITINH"].Value?.ToString() ?? "";
                string toChuyenMon = row.Cells["TO_CHUYEN_MON"].Value?.ToString() ?? "";
                string chuyenMonDay = row.Cells["CHUYEN_MON_DAY"].Value?.ToString() ?? "";
                string chucVu = row.Cells["CHUC_VU"].Value?.ToString() ?? "";

                // Xử lý ngày sinh (nếu null thì chọn ngày ngẫu nhiên)
                string ngaySinh = row.Cells["NGAY_SINH"].Value?.ToString() ?? "";
                // Hiển thị dữ liệu lên các panel hoặc label
                lblMaGiaoVien.Text = msgv;
                lblHoTen.Text = hoTen;
                lblGioiTinh.Text = gioiTinh;
                lblToCuyenMon.Text = toChuyenMon;
                lblChuyenMonDay.Text = chuyenMonDay;
                lblChucVu.Text = chucVu;

                // Hiển thị ngày sinh vào DateTimePicker
                lblNgaySinh.Text = ngaySinh;
                SetAvatarFromBase64(imgManager.LayAnh(int.Parse(msgv), ref error));

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGiaoVien.SelectedRows.Count > 0) // Kiểm tra có chọn dòng chưa
            {
                string msgv = dgvGiaoVien.SelectedRows[0].Cells["MSGV"].Value?.ToString();

                if (!string.IsNullOrEmpty(msgv))
                {
                    DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa giáo viên này?",
                                                           "Xác nhận",
                                                           MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        string error = "";
                        bool isDeleted = GvManager.XoaGiaoVien(msgv, ref error); // Gọi hàm xóa

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
    }
}
