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

namespace QL_SNAC.QLTaiKhoan
{
    public partial class frmLocChonThongTinNguoiDung : Form
    {
        private frmThemTaiKhoan frmThongTinNguoiDungInstance;
        private HocSinhManager HSManager;
        private GiaoVienManager GVManager;
        private TaiKhoanManager TKManager;
      
        private DataTable data = null;
        private string error = "";
        private bool DangSua = false;

        public Action<string> AddressSelected { get; set; }
        public TaiKhoanEntity SelectedHocSinh { get; set; }
        public frmLocChonThongTinNguoiDung()
        {
            InitializeComponent();
        }
        public frmLocChonThongTinNguoiDung(frmThemTaiKhoan frmThongTinNguoiDungInstance)
        {
            InitializeComponent();
            lbTieuDe.Text = "THÔNG TIN HỌC SINH";
            this.frmThongTinNguoiDungInstance = frmThongTinNguoiDungInstance;
            HSManager = new HocSinhManager();
            TKManager = new TaiKhoanManager();
            HienThiDSHS();


        }
        //public frmLocChonThongTinNguoiDung(frmThemTaiKhoan frmThongTinNguoiDungInstance)
        //{
        //    InitializeComponent();
        //    lbTieuDe.Text = "THÔNG TIN GIÁO VIÊN";
        //    this.frmThongTinNguoiDungInstance = frmThongTinNguoiDungInstance;
        //    GiaoVienManager = new HocSinhManager();
        //    TKManager = new TaiKhoanManager();
        //    HienThiDSHS();


        //}
        public frmLocChonThongTinNguoiDung(TaiKhoanEntity taiKhoan)
        {
            InitializeComponent();
            lbTieuDe.Text = "THÔNG TIN HỌC SINH";
            TKDuocChon = taiKhoan;
            HSManager = new HocSinhManager();
            TKManager = new TaiKhoanManager();
            HienThiDSHS();


        }

        private void HienThiDSHS()
        {
            var data = HSManager.HienThiLocDSHSRutGon(ref error);
            dgDSNguoiDung.DataSource = data;
            if (data == null)
            {
                MessageBox.Show("Khong co du lieu: " + error);
            }
            else
            {
                dgDSNguoiDung.DataSource = data;
            }
        }
        private TaiKhoanEntity TKDuocChon = new TaiKhoanEntity();
        private void dgDSNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rowselected = dgDSNguoiDung.Rows[e.RowIndex];

            if (e.RowIndex >= 0 && e.RowIndex < dgDSNguoiDung.RowCount)
            {
                rowselected = dgDSNguoiDung.Rows[e.RowIndex];
                #region Hien thi gia tri len label
                lbMSNguoiDung.Text = rowselected.Cells["MSHS"].Value.ToString();
                lbHo.Text = rowselected.Cells["HO"].Value.ToString();
                lbTen.Text = rowselected.Cells["TEN"].Value.ToString();

                #endregion


                #region Gan gia tri vao entity tai khoan da chon        
                string maHocSinh = rowselected.Cells["MSHS"].Value.ToString();
                string Ho = rowselected.Cells["HO"].Value.ToString();
                string Ten = rowselected.Cells["TEN"].Value.ToString();
                string Gioitinh = rowselected.Cells["GIOITINH"].Value.ToString();
                string NgaySinh = rowselected.Cells["NGAY_SINH"].Value.ToString();

                // Assign the selected customer information to KHDuocChon
                TKDuocChon.MSNguoiDung = maHocSinh;


                // Create a new DonDatHangEntity object with the selected customer information
                SelectedHocSinh = new TaiKhoanEntity
                {
                    MSNguoiDung = maHocSinh,

                };
                //frmChiTietDonDatHang frm = new frmChiTietDonDatHang(KHDuocChon);
                //frm.ShowDialog();
                //this.DialogResult = DialogResult.OK;  // Set the dialog result
                //this.Close();  // Close the form

                #endregion

            }
        }

        private void dgDSNguoiDung_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgDSNguoiDung.RowCount)
            {
                DataGridViewRow rowselected = dgDSNguoiDung.Rows[e.RowIndex];

                frmThongTinNguoiDungInstance.MSNguoiDunglabelText = rowselected.Cells["MSHS"].Value.ToString();
                this.Close();
            }
        }
    }
}
