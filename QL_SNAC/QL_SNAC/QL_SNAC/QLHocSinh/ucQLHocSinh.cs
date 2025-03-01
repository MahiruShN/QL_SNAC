using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.Manager;
using DataAccessLayer.Entity;
using DataAccessLayer.Responsitories;
using QL_SNAC.MainForm;
using QL_SNAC.QLTaiKhoan;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QL_SNAC.QLHocSinh
{
    public partial class ucQLHocSinh : UserControl
    {
        private HocSinhManager HsManager = null;
        private DataTable DSHocSinh = null;
        private string error = "";
        private Database DB = new Database();
        public ucQLHocSinh()
        {
            InitializeComponent();
            HsManager = new HocSinhManager();
            DSHocSinh = null;
            LayDSHocSinh();

        }
        private void LayDSHocSinh()
        {
            try
            {
                var data = HsManager.HienThiDSFull(ref error);
                if (data == null)
                {
                    MessageBox.Show(error);
                }
                else
                {
                    DSHocSinh = data;
                    dgvHocSinh.DataSource = DSHocSinh;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadHocSinhData()
        {
            var data = HsManager.HienThiDSFull(ref error);
            dgvHocSinh.DataSource = data;
            HandleDataLoadResult(dgvHocSinh, "Học Sinh"); // Centralized error handling
        }

        private HocSinhEntity HSDaChon = new HocSinhEntity();
        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvHocSinh.RowCount)
            {
                DataGridViewRow rowselected = dgvHocSinh.Rows[e.RowIndex];

                #region Gan gia tri vao entity tai khoan da chon
                HSDaChon.MSHS = rowselected.Cells["MSHS"].Value.ToString();
                HSDaChon.Ho = rowselected.Cells["HO"].Value.ToString();
                HSDaChon.Ten = rowselected.Cells["TEN"].Value.ToString();
                HSDaChon.Gioitinh = rowselected.Cells["GIOITINH"].Value.ToString();
                HSDaChon.NgaySinh = rowselected.Cells["NGAY_SINH"].Value.ToString();
                HSDaChon.NoiSinh = rowselected.Cells["NOI_SINH"].Value.ToString();
                HSDaChon.DanToc = rowselected.Cells["DAN_TOC"].Value.ToString();
                HSDaChon.QuocTich = rowselected.Cells["QUOC_TICH"].Value.ToString();
                HSDaChon.TonGiao = rowselected.Cells["TONGIAO"].Value.ToString();
                HSDaChon.Tinh = rowselected.Cells["TINH"].Value.ToString();
                HSDaChon.Huyen = rowselected.Cells["HUYEN"].Value.ToString();
                HSDaChon.Xa = rowselected.Cells["XA"].Value.ToString();
                HSDaChon.Diachi = rowselected.Cells["DIA_CHI"].Value.ToString();
                HSDaChon.DCThuongTru = rowselected.Cells["DIA_CHI_THUONG_TRU"].Value.ToString();
                HSDaChon.DCTamTru = rowselected.Cells["DIA_CHI_TAM_TRU"].Value.ToString();
                #endregion
                #region Hien thi gia tri len label
                lbMSHS.Text = HSDaChon.MSHS;
                lbHo.Text = HSDaChon.Ho;
                lbTen.Text = HSDaChon.Ten;
                lbGioiTinh.Text = HSDaChon.Gioitinh;
                lbNgaySinh.Text = HSDaChon.NgaySinh;
                lbNoiSinh.Text = HSDaChon.NoiSinh;
                lbQuocTich.Text = HSDaChon.QuocTich;
                lbDanToc.Text = HSDaChon.DanToc;

                #endregion
            }
        }
        private List<HocSinhEntity> danhSachHSDaChon = new List<HocSinhEntity>(); // Danh sách các học sinh đã chọn

        private void dgvHocSinh_SelectionChanged(object sender, EventArgs e)
        {
            danhSachHSDaChon.Clear(); // Xóa danh sách cũ

            foreach (DataGridViewRow row in dgvHocSinh.SelectedRows)
            {
                HocSinhEntity hs = new HocSinhEntity();

                // Kiểm tra giá trị null trước khi gán
                hs.MSHS = row.Cells["MSHS"].Value?.ToString();
                hs.Ho = row.Cells["HO"].Value?.ToString();
                hs.Ten = row.Cells["TEN"].Value?.ToString();
                hs.Gioitinh = row.Cells["GIOITINH"].Value?.ToString();
                hs.NgaySinh = row.Cells["NGAY_SINH"].Value?.ToString();
                hs.NoiSinh = row.Cells["NOI_SINH"].Value?.ToString();
                hs.DanToc = row.Cells["DAN_TOC"].Value?.ToString();
                hs.QuocTich = row.Cells["QUOC_TICH"].Value?.ToString();
                hs.TonGiao = row.Cells["TONGIAO"].Value?.ToString();
                hs.Tinh = row.Cells["TINH"].Value?.ToString();
                hs.Huyen = row.Cells["HUYEN"].Value?.ToString();
                hs.Xa = row.Cells["XA"].Value?.ToString();
                hs.Diachi = row.Cells["DIA_CHI"].Value?.ToString();
                hs.DCThuongTru = row.Cells["DIA_CHI_THUONG_TRU"].Value?.ToString();
                hs.DCTamTru = row.Cells["DIA_CHI_TAM_TRU"].Value?.ToString();


                danhSachHSDaChon.Add(hs);
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            addHocSinh frm = new addHocSinh();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LayDSHocSinh();
            }


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            addHocSinh frm = new addHocSinh(HSDaChon);
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LayDSHocSinh();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Xóa 1 học sinh
            DialogResult confirmation = MessageBox.Show("Bạn có chắc chắn muốn xóa học sinh này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                bool ketqua = HsManager.XoaHocSinh(HSDaChon.MSHS, ref error);

                if (ketqua)
                {
                    MessageBox.Show("Xóa học sinh thành công.");
                    LayDSHocSinh();
                    HSDaChon = new HocSinhEntity();
                }
                else
                {
                    MessageBox.Show("Lỗi xóa học sinh: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display the error message from tkManager
                }


            }
            ////Xóa nhiều học sinh
            //if (dgvHocSinh.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Vui lòng chọn ít nhất một học sinh để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //DialogResult confirmation = MessageBox.Show($"Bạn có chắc chắn muốn xóa {dgvHocSinh.SelectedRows.Count} học sinh đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (confirmation == DialogResult.Yes)
            //{
            //    string error = "";
            //    bool success = true;

            //    // Use danhSachHSDaChon (populated in dgvHocSinh_SelectionChanged)
            //    foreach (HocSinhEntity hs in danhSachHSDaChon)
            //    {
            //        if (!HsManager.XoaHocSinh(hs.MSHS, ref error))
            //        {
            //            success = false;
            //            // Consider accumulating errors for more detailed feedback
            //            // error += $"Lỗi xóa MSHS {hs.MSHS}: {error}\n";
            //        }
            //    }

            //    if (success)
            //    {
            //        MessageBox.Show("Xóa học sinh thành công.");
            //        LayDSHocSinh(); // Refresh the DataGridView
            //        danhSachHSDaChon.Clear(); // Clear the selected students list
            //        HSDaChon = new HocSinhEntity(); // Reset HSDaChon (if needed)

            //    }
            //    else
            //    {
            //        MessageBox.Show($"Lỗi xóa học sinh:\n{error}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvHocSinh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string mshs = dgvHocSinh.Rows[e.RowIndex].Cells["MSHS"].Value.ToString();
                string error = "";

                DataTable dt = HsManager.GetHocSinhByMSHS(mshs, ref error);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    frmThongTinHS detailsForm = new frmThongTinHS(row);
                    detailsForm.ShowDialog(); // Opens as a modal form
                }

            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin học sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void HandleDataLoadResult(DataGridView dataGridView, string userType)
        {
            if (dataGridView.DataSource == null)
            {
                MessageBox.Show($"Không có dữ liệu {userType}: {error}");
            }
        }
        private void FilterData(string searchText)
        {
            string error = "";
            DataTable data = null;


            data = DB.TimKiemNguoiDung("THONG_TIN_HOC_SINH", "HO", "TEN", "MSHS", searchText, ref error); // Sửa lỗi ở đây
            dgvHocSinh.DataSource = data;
            HandleDataLoadResult(dgvHocSinh, "Học Sinh");


            if (data == null)
            {
                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show($"Lỗi khi lấy dữ liệu: {error}");
                }

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim(); // No need to ToLower() here
            FilterData(searchText);
        }
    }
}
