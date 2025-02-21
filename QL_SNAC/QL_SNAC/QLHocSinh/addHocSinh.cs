using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.Manager;
using DataAccessLayer.Entity;

namespace QL_SNAC.QLHocSinh
{
    public partial class addHocSinh : Form
    {
        private HocSinhManager HSManager;
        private DataRow _hocSinhRow;
        private HocSinhEntity HSDaChon = null;
        private string error = "";
        private bool DangSua = false;
        public addHocSinh()
        {
            InitializeComponent();
            lbTieuDe.Text = "THÊM HỌC SINH";
            btnSave.Text = "Thêm";
            DangSua = false;
            HSManager = new HocSinhManager();
        }
        public addHocSinh(DataRow hocSinhRow)
        {
            InitializeComponent();
            lbTieuDe.Text = "CẬP NHẬT HỌC SINH";
            btnSave.Text = "Cập Nhật";
            HSManager = new HocSinhManager();
            _hocSinhRow = hocSinhRow;
            DangSua = true;
            LoadData();
        }
        public addHocSinh(HocSinhEntity _HSDaChon )
        {

            InitializeComponent();
            lbTieuDe.Text = "CẬP NHẬT HỌC SINH";
            btnSave.Text = "Cập Nhật";
            HSManager = new HocSinhManager();
            HSDaChon = _HSDaChon;
            txtMSHS.Text = HSDaChon.MSHS.ToString();
            txtHo.Text = HSDaChon.Ho.ToString();
            txtTen.Text = HSDaChon.Ten.ToString();
            txtGioiTinh.Text = HSDaChon.Gioitinh.ToString();
            // *** Convert and set dtNgaySinh.Value ***
            if (DateTime.TryParseExact(HSDaChon.NgaySinh, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngaySinh))
            {
                dtNgaySinh.Value = ngaySinh;
            }
            else
            {
                // Handle parsing error (e.g., log, show message, set default date)
                MessageBox.Show("Lỗi chuyển đổi ngày sinh từ HSDaChon.NgaySinh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Example: Set a default date
                dtNgaySinh.Value = DateTime.Now;
            }
            txtNoiSinh.Text = HSDaChon.NoiSinh.ToString();
            txtDanToc.Text = HSDaChon.DanToc.ToString();
            txtQuocTich.Text = HSDaChon.QuocTich.ToString();
            txtTonGiao.Text = HSDaChon.TonGiao.ToString();
            txtDiaChi.Text = HSDaChon.Diachi.ToString();
            txtTinh.Text =  HSDaChon.Tinh.ToString();
            txtHuyen.Text = HSDaChon.Huyen.ToString();
            txtXa.Text = HSDaChon.Xa.ToString();
            txtDCThuongTru.Text = HSDaChon.DCThuongTru.ToString();
            txtDCTamTru.Text = HSDaChon.DCTamTru.ToString();
            DangSua = true;
            //LoadData();

        }
        private void LoadData()
        {
            if (_hocSinhRow != null)
            {
                txtMSHS.Text = _hocSinhRow["MSHS"].ToString();
                txtHo.Text = _hocSinhRow["HO"].ToString();
                txtTen.Text = _hocSinhRow["TEN"].ToString();
                txtGioiTinh.Text = _hocSinhRow["GIOITINH"].ToString();

                // **Correct Date Handling**
                string ngaySinhString = _hocSinhRow["NGAY_SINH"].ToString();
                if (DateTime.TryParseExact(ngaySinhString, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngaySinh))
                {
                    dtNgaySinh.Value = ngaySinh;
                }
                else if (DateTime.TryParse(ngaySinhString, out ngaySinh)) // Try other formats if needed
                {
                    dtNgaySinh.Value = ngaySinh;
                }
                else
                {
                    // Handle parsing failure (e.g., log an error, display a message)
                    MessageBox.Show($"Lỗi: Không thể chuyển đổi '{ngaySinhString}' sang ngày.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Consider setting a default date or disabling the save button.
                }

                txtNoiSinh.Text = _hocSinhRow["NOI_SINH"].ToString();
                txtDanToc.Text = _hocSinhRow["DAN_TOC"].ToString();
                txtQuocTich.Text = _hocSinhRow["QUOC_TICH"].ToString();
                txtTonGiao.Text = _hocSinhRow["TONGIAO"].ToString();
                txtDiaChi.Text = _hocSinhRow["DIA_CHI"].ToString();
                txtTinh.Text = _hocSinhRow["TINH"].ToString();
                txtHuyen.Text = _hocSinhRow["HUYEN"].ToString();
                txtXa.Text = _hocSinhRow["XA"].ToString();
                txtDCThuongTru.Text = _hocSinhRow["DIA_CHI_THUONG_TRU"].ToString();
                txtDCTamTru.Text = _hocSinhRow["DIA_CHI_TAM_TRU"].ToString();

                txtMSHS.ReadOnly = true;

            }
        }
        private void ThemHocSinh()
        {
            HocSinhEntity hs = new HocSinhEntity();
            hs.Ho = txtHo.Text;
            hs.Ten = txtTen.Text;
            hs.Gioitinh = txtGioiTinh.Text;
            hs.NgaySinh = dtNgaySinh.Value.ToString("dd-MM-yyyy");
            hs.NoiSinh = txtNoiSinh.Text;
            hs.DanToc = txtDanToc.Text;
            hs.QuocTich = txtQuocTich.Text;
            hs.TonGiao = txtTonGiao.Text;
            hs.Tinh = txtTinh.Text; // Get values from UI controls
            hs.Huyen = txtHuyen.Text;
            hs.Xa = txtXa.Text;
            hs.Diachi = txtDiaChi.Text;
            hs.DCThuongTru = txtDCThuongTru.Text;
            hs.DCTamTru = txtDCTamTru.Text;

            string error = "";
            bool success = HSManager.ThemHocSinh(hs, ref error);

            if (success)
            {
                MessageBox.Show("Thêm Học Sinh thành công!");
                this.DialogResult = DialogResult.OK; // Set dialog result for parent form
                this.Close();
            }
            else
            {
                MessageBox.Show("Error adding student: " + error);
            }
        }
        private void CapNhatHocSinh()
        {
            string error = "";
            // Format the DateTime to dd-MM-yyyy string
            string formattedNgaySinh = dtNgaySinh.Value.ToString("dd-MM-yyyy");
            // Call manager to update student data
            bool success = HSManager.UpdateHocSinh(
                Convert.ToInt32(txtMSHS.Text), txtHo.Text, txtTen.Text,
                txtGioiTinh.Text, formattedNgaySinh, txtNoiSinh.Text,
                txtDanToc.Text, txtQuocTich.Text, txtTonGiao.Text, txtTinh.Text, txtHuyen.Text, txtXa.Text, txtDiaChi.Text,
                txtDCThuongTru.Text, txtDCTamTru.Text, ref error
            );

            if (success)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Notify frmThongTinHocSinh to reload data
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi cập nhật: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DangSua) // Chế độ cập nhật
            {
                CapNhatHocSinh();
            }
            else // Chế độ thêm mới
            {
                ThemHocSinh();
            }
        }
    }
}
