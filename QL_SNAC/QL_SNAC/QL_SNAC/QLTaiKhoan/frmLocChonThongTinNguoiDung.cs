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
using Microsoft.Data.SqlClient;

namespace QL_SNAC.QLTaiKhoan
{
    public partial class frmLocChonThongTinNguoiDung : Form
    {
        private frmThemTaiKhoan frmThongTinNguoiDungInstance;
        private HocSinhManager HSManager;
        private NhanSuManager NSManager;
        private NhanSuManager GVManager;
        private TaiKhoanManager TKManager;
        private Database DB = new Database();
        //private HocSinhResponsitory HSRespository;

        private string error = "";

        public TaiKhoanEntity SelectedNguoiDung { get; set; }
        public string SelectedMaSo { get; set; }

        public frmLocChonThongTinNguoiDung()
        {
            InitializeComponent();
        }

        public frmLocChonThongTinNguoiDung(frmThemTaiKhoan frmThongTinNguoiDungInstance)
        {
            InitializeComponent();
            this.frmThongTinNguoiDungInstance = frmThongTinNguoiDungInstance;

            HSManager = new HocSinhManager();
            GVManager = new NhanSuManager();
            NSManager = new NhanSuManager();
            TKManager = new TaiKhoanManager();
            //HSRespository = new HocSinhResponsitory();

            this.TabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            LoadData(0); // Load Hoc Sinh data initially
        }
        private TaiKhoanEntity TKDuocChon = new TaiKhoanEntity();
        public frmLocChonThongTinNguoiDung(TaiKhoanEntity taiKhoan)
        {
            InitializeComponent();
            TKDuocChon = taiKhoan;
            HSManager = new HocSinhManager();
            GVManager = new NhanSuManager();
            NSManager = new NhanSuManager();
            TKManager = new TaiKhoanManager();
            LoadData(0); // Load Hoc Sinh data initially
        }


        private void LoadData(int tabIndex)
        {
            if (tabIndex == 0) // Hoc Sinh
            {
                LoadHocSinhData();
                lbTieuDe.Text = "THÔNG TIN HỌC SINH";
            }
            else if (tabIndex == 1) // Giao Vien
            {
                LoadGiaoVienData();
                lbTieuDe.Text = "THÔNG TIN GIÁO VIÊN";
            }
            else if (tabIndex == 2) // Nhan Su
            {
                LoadNhanSuData();
                lbTieuDe.Text = "THÔNG TIN NHÂN VIÊN";
            }
        }

        private void LoadHocSinhData()
        {
            var data = HSManager.HienThiLocDSHSRutGon(ref error);
            dgDSHocSinh.DataSource = data;
            HandleDataLoadResult(dgDSHocSinh, "Học Sinh"); // Centralized error handling
        }

        private void LoadGiaoVienData()
        {
            var data = GVManager.HienThiLocDSGVRutGon(ref error);
            dgDSGiaoVien.DataSource = data;
            HandleDataLoadResult(dgDSGiaoVien, "Giáo Viên"); // Centralized error handling
        }
        private void LoadNhanSuData()
        {
            var data = NSManager.HienThiLocDSNSRutGon(ref error);
            dgDSNhanSu.DataSource = data;
            HandleDataLoadResult(dgDSNhanSu, "Nhân Sự"); // Centralized error handling
        }

        private void HandleDataLoadResult(DataGridView dataGridView, string userType)
        {
            if (dataGridView.DataSource == null)
            {
                MessageBox.Show($"Không có dữ liệu {userType}: {error}");
            }
        }


        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData(TabControl.SelectedIndex);
        }

        private void dgDSHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleCellClick(dgDSHocSinh, e, "MSHS");
        }
        private void dgDSGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleCellClick(dgDSGiaoVien, e, "MSNV");
        }
        private void dgDSNhanSu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleCellClick(dgDSNhanSu, e, "MSNV");
        }

        private void dgDSHocSinh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleCellDoubleClick(dgDSHocSinh, e, "MSHS");
        }
        private void dgDSGiaoVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleCellDoubleClick(dgDSGiaoVien, e, "MSNV");
        }
        private void dgDSNhanSu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleCellDoubleClick(dgDSNhanSu, e, "MSNV");
        }

        private void HandleCellClick(DataGridView dataGridView, DataGridViewCellEventArgs e, string maSoColumnName)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView.RowCount)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                string maNguoiDung = row.Cells[maSoColumnName].Value?.ToString();
                string ho = row.Cells["HO"].Value?.ToString();
                string ten = row.Cells["TEN"].Value?.ToString();

                lbMSNguoiDung.Text = maNguoiDung;
                lbHo.Text = ho;
                lbTen.Text = ten;

                SelectedNguoiDung = new TaiKhoanEntity
                {
                    MSNguoiDung = maNguoiDung,
                };
            }
        }

        private void HandleCellDoubleClick(DataGridView dataGridView, DataGridViewCellEventArgs e, string maSoColumnName)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView.RowCount)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                SelectedMaSo = row.Cells[maSoColumnName].Value?.ToString();
                frmThongTinNguoiDungInstance.MSNguoiDunglabelText = SelectedMaSo;
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim(); // No need to ToLower() here
            FilterData(searchText);
        }

        private void FilterData(string searchText)
        {
            string error = "";
            DataTable data = null;

            if (TabControl.SelectedIndex == 0) // Hoc Sinh
            {
                data = DB.TimKiemNguoiDung("THONG_TIN_HOC_SINH", "HO", "TEN", "MSHS", searchText, ref error); // Sửa lỗi ở đây
                dgDSHocSinh.DataSource = data;
                HandleDataLoadResult(dgDSHocSinh, "Học Sinh");
            }
            else if (TabControl.SelectedIndex == 1) // Giao Vien
            {
                data = DB.TimKiemNguoiDung("NHAN_SU", "HO", "TEN", "MSNV", searchText, ref error); // Sửa lỗi ở đây
                dgDSGiaoVien.DataSource = data;
                HandleDataLoadResult(dgDSGiaoVien, "Giáo Viên");
            }
            else if (TabControl.SelectedIndex == 2) // NhanSu
            {
                data = DB.TimKiemNguoiDung("NHAN_SU", "HO", "TEN", "MSNV", searchText, ref error); // Sửa lỗi ở đây
                dgDSNhanSu.DataSource = data;
                HandleDataLoadResult(dgDSNhanSu, "Nhân Viên");
            }

            if (data == null)
            {
                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show($"Lỗi khi lấy dữ liệu: {error}");
                }
                if (TabControl.SelectedIndex == 0) dgDSHocSinh.DataSource = null;
                else if (TabControl.SelectedIndex == 1) dgDSGiaoVien.DataSource = null;
            }
        }

       
    }
}