using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SNAC.QLTaiKhoan
{
    public partial class frmThongTinTaiKhoan : Form
    {
        private string _tenDayDu;
        private int _idTaiKhoan;
        private string _email;
        private string _ngayTao;
        private string _maNguoiDung;
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
        }
        public frmThongTinTaiKhoan(string tenDayDu, int idTaiKhoan, string email, string ngayTao, string maNguoiDung)
        {
            InitializeComponent();
            // Gán dữ liệu vào các biến hoặc control trên form
            _tenDayDu = tenDayDu;
            _idTaiKhoan = idTaiKhoan;
            _email = email;
            _ngayTao = ngayTao;
            _maNguoiDung = maNguoiDung;

            lbHoTen.Text = _tenDayDu;
            lbIdTaiKhoan.Text = _idTaiKhoan.ToString();
            lbMa.Text = _maNguoiDung;
            lbEmail.Text = _email;
            lbNgayTao.Text = _ngayTao; // Format the date
            
        }
    }
}
