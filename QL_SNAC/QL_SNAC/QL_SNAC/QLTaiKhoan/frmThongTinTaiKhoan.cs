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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QL_SNAC.QLTaiKhoan
{
    public partial class frmThongTinTaiKhoan : Form
    {
        private string _tenDayDu;
        private int _idTaiKhoan;
        private string _email;
        private DateTime _ngayTao;
        private string _maNguoiDung;
        private string _NgaySinh;
        private string _GioiTinh;
        private string _Quyen;
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
        }
        public frmThongTinTaiKhoan(string tenDayDu, int idTaiKhoan, string email, DateTime ngayTao, string maNguoiDung, string NgaySinh, string GioiTinh , string Quyen)
        {
            InitializeComponent();
            _tenDayDu = tenDayDu;
            _idTaiKhoan = idTaiKhoan;
            _email = email;
            _ngayTao = ngayTao;
            _maNguoiDung = maNguoiDung;
            _NgaySinh = NgaySinh;
            _GioiTinh = GioiTinh;  
            _Quyen = Quyen; 
            lbHoTen.Text = tenDayDu;
            lbIdTaiKhoan.Text = idTaiKhoan.ToString();
            lbMa.Text = maNguoiDung;
            lbEmail.Text = email;
            lbQuyen.Text = Quyen;
            lbNgayTao.Text = ngayTao.ToString("dd/MM/yyyy");
            lbNgaySinh.Text = NgaySinh;
            lbGioiTinh.Text = GioiTinh;
            //LoadThongTinTaiKhoan(_idTaiKhoan);

        }
        //private void LoadThongTinTaiKhoan(int idTaiKhoan) // Assuming you have the idTaiKhoan
        //{
        //    string ngaySinh = "";
        //    string gioiTinh = "";
        //    string loaiTaiKhoan = "";
        //    string error = "";

        //    TaiKhoanManager manager = new TaiKhoanManager();
        //    if (manager.LayThongTinNguoiDung(idTaiKhoan, ref ngaySinh, ref gioiTinh, ref loaiTaiKhoan, ref error))
        //    {
        //        lbNgaySinh.Text = ngaySinh;
        //        lbGioiTinh.Text = gioiTinh;
        //        lbQuyen.Text = loaiTaiKhoan;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Lỗi lấy thông tin: " + error);
        //    }
        //}
    }
}
