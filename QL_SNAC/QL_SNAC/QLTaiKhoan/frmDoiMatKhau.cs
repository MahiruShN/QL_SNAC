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
using DataAccessLayer.Responsitories;

namespace QL_SNAC.QLTaiKhoan
{
    public partial class frmDoiMatKhau : Form
    {
        private int _idTaiKhoan;

        private string _email;

        private Database _db;
        public frmDoiMatKhau()
        {
            InitializeComponent();
            _db = new Database();
        }
        public frmDoiMatKhau(int idTaiKhoan, string email)
        {
            InitializeComponent();
            _idTaiKhoan = idTaiKhoan;
            _email = email;
            lbEmail.Text = email;
            lbIdTaiKhoan.Text = idTaiKhoan.ToString();
            _db = new Database();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string passCu = txtPassCu.Text;
            string passMoi = txtPassMoi.Text;
            string rePass = txtRePass.Text;
            string error = "";

            if (string.IsNullOrEmpty(passCu))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (passMoi != rePass)
            {
                MessageBox.Show("Mật khẩu mới và nhập lại không khớp. Mời nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassMoi.Clear();
                txtRePass.Clear();
                txtPassMoi.Focus();
                return;
            }

            TaiKhoanManager tkManager = new TaiKhoanManager();

            if (!tkManager.KiemTraMatKhauCu(_idTaiKhoan, passCu, ref error))
            {
                MessageBox.Show("Mật khẩu cũ không chính xác. Xin hãy nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassCu.Clear();
                txtPassCu.Focus();
                return;
            }

            if (tkManager.DoiMatKhau(_idTaiKhoan, passMoi, ref error))
            {
                MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi khi đổi mật khẩu: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
