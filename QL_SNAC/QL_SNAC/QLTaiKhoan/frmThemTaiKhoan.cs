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
            // Set radHoatDong as default for adding
            radHoatDong.Checked = true;
            radNgungHD.Checked = false;

        }

        public frmThemTaiKhoan(TaiKhoanEntity _TKDaChon)
        {
            InitializeComponent();
            lbTieuDe.Text = "CẬP NHẬT TÀI KHOẢN";
            btnThem.Text = "Cập Nhật";
            TKManager = new TaiKhoanManager();
            TKDaChon = _TKDaChon;
            lbIdTaiKhoan.Text = TKDaChon.ID_TAIKHOAN.ToString();
            txtEmail.Text = TKDaChon.EMAIL;
            lbMSNguoiDung.Text = TKDaChon.MSNguoiDung;
            string quyenAbbr = GetQuyenAbbreviation(cboQuyen.Text); // Assuming txtQuyen is your ComboBox
            _TKDaChon.Quyen = quyenAbbr;
            DangSua = true;
            // Ẩn textbox mật khẩu và re-pass khi cập nhật
            txtPass.Visible = false;
            txtRePass.Visible = false;
            if (TKDaChon.TinhTrang == true) // Assuming TinhTrang is a boolean in your entity
            {
                radHoatDong.Checked = true;
                radNgungHD.Checked = false;
            }
            else
            {
                radHoatDong.Checked = false;
                radNgungHD.Checked = true;
            }

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
            entity.Quyen = cboQuyen.Text.Replace(" ", "");
            entity.NguoiTao = CauHinhHeThong.Email;
            entity.TinhTrang = radHoatDong.Checked;
            string quyenAbbr = GetQuyenAbbreviation(cboQuyen.SelectedItem.ToString()); // Get selected item text.
            entity.Quyen = quyenAbbr;

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
            string quyenAbbr = GetQuyenAbbreviation(cboQuyen.SelectedItem.ToString()); // Get selected item text.
            TKDaChon.Quyen = quyenAbbr;

            // Set TinhTrang as string "true" or "false"
            if (radHoatDong.Checked)
            {
                TKDaChon.TinhTrang = true;
            }
            else if (radNgungHD.Checked)
            {
                TKDaChon.TinhTrang = false;
            }
            else
            {
                // Handle the case where neither radio button is checked (optional, but good practice)
                MessageBox.Show("Vui lòng chọn trạng thái hoạt động.");
                return; // Stop the update if no status is selected
            }
            // *** Check if new password is provided ***
            if (!string.IsNullOrEmpty(txtPass.Text) && !string.IsNullOrEmpty(txtRePass.Text))
            {
                if (txtPass.Text != txtRePass.Text)
                {
                    MessageBox.Show("Mật khẩu nhập chưa khớp!");
                    return;
                }

                string hashedPassword = db.HashPassword(txtPass.Text);
                TKDaChon.PASS = hashedPassword; // Update the password only if new one is given
            }

            bool ketqua = TKManager.CapNhatTaiKhoan(TKDaChon, ref error);
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
        public string GetQuyenAbbreviation(string quyen)
        {
            switch (quyen.ToLower())
            {
                case "giáo viên": return "GV";
                case "admin": return "AD";
                case "học sinh": return "HS";
                case "giáo viên chủ nhiệm": return "GVCN";
                case "phụ huynh": return "PH";
                case "tuyển sinh": return "TS";
                case "quản sinh": return "QS";
                default: return quyen; // Or handle the default case as needed
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}