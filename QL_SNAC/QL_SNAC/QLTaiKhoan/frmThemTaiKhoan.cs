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

namespace QL_SNAC.QLTaiKhoan
{
    public partial class frmThemTaiKhoan : Form
    {
        private int addedAccountId;
        private TaiKhoanManager TKManager;
        private TaiKhoanEntity TKDaChon = null;
        private string error = "";
        private Database db;
        private bool DangSua = false;

        public frmThemTaiKhoan(out int addedAccountId)
        {
            InitializeComponent();
            lbTieuDe.Text = "THÊM TÀI KHOẢN";
            TKManager = new TaiKhoanManager();
            db = new Database();
            this.addedAccountId = -1;
            addedAccountId = -1;
            DangSua = false;
            // Ẩn textbox mật khẩu và re-pass khi thêm mới
            txtPass.Visible = true;
            txtRePass.Visible = true;


        }

        public frmThemTaiKhoan(TaiKhoanEntity _TKDaChon)
        {
            InitializeComponent();
            lbTieuDe.Text = "CẬP NHẬT TÀI KHOẢN";
            TKManager = new TaiKhoanManager();
            TKDaChon = _TKDaChon;
            lbIdTaiKhoan.Text = TKDaChon.ID_TAIKHOAN.ToString();
            txtEmail.Text = TKDaChon.EMAIL;
            lbMSNguoiDung.Text = TKDaChon.MSNguoiDung;
            txtQuyen.Text = TKDaChon.Quyen;
            DangSua = true;
            // Ẩn textbox mật khẩu và re-pass khi cập nhật
            txtPass.Visible = false;
            txtRePass.Visible = false;

        }

        public string MSNguoiDunglabelText
        {
            get { return lbMSNguoiDung.Text; }
            set { lbMSNguoiDung.Text = value; }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (DangSua) // Chế độ cập nhật
            {
                CapNhatTaiKhoan();
            }
            else // Chế độ thêm mới
            {
                ThemTaiKhoan();
            }
        }

        private void ThemTaiKhoan()
        {
            if (txtPass.Text != txtRePass.Text)
            {
                MessageBox.Show("Mật khẩu nhập chưa khớp!");
                return;
            }

            TaiKhoanEntity entity = new TaiKhoanEntity();
            entity.EMAIL = txtEmail.Text.Replace(" ", "");

            string hashedPassword = db.HashPassword(txtPass.Text);
            entity.PASS = hashedPassword;

            entity.MSNguoiDung = lbMSNguoiDung.Text.Replace(" ", "");
            entity.Quyen = txtQuyen.Text.Replace(" ", "");
            entity.NguoiTao = txtEmail.Text.Replace(" ", "");

            bool ketqua = TKManager.ThemTaiKhoan(entity, ref error);
            if (ketqua)
            {
                MessageBox.Show("Thêm thành công");

                addedAccountId = entity.ID_TAIKHOAN;
                lbIdTaiKhoan.Text = addedAccountId.ToString();

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
            }
        }

        private void CapNhatTaiKhoan()
        {
            TKDaChon.EMAIL = txtEmail.Text.Replace(" ", "");
            TKDaChon.MSNguoiDung = lbMSNguoiDung.Text.Replace(" ", "");
            TKDaChon.Quyen = txtQuyen.Text.Replace(" ", "");

            bool ketqua = TKManager.CapNhatTaiKhoan(TKDaChon, ref error); // Gọi hàm cập nhật
            if (ketqua)
            {
                MessageBox.Show("Cập nhật thành công");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
            }
        }


        private void btnHS_Click(object sender, EventArgs e)
        {
            frmLocChonThongTinNguoiDung frm = new frmLocChonThongTinNguoiDung(this);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

            MSNguoiDunglabelText = lbMSNguoiDung.Text;
        }

        private void btnGV_Click(object sender, EventArgs e)
        {
            frmLocChonThongTinNguoiDung frm = new frmLocChonThongTinNguoiDung(this);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
    }
}