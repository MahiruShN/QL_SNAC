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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QL_SNAC.QLTaiKhoan
{
    public partial class ucQLTaiKhoan : UserControl
    {
        private TaiKhoanManager tkManager = null;
        private DataTable DSTaiKhoan = null;
        private string error = "";
        private Database DB = new Database();
        public ucQLTaiKhoan()
        {
            InitializeComponent();
            tkManager = new TaiKhoanManager();
            DSTaiKhoan = null;
            LayDanhSachTaiKhoan();
        }
        private void LayDanhSachTaiKhoan()
        {
            try
            {
                var data = tkManager.HienThiDanhSachTaiKhoan(ref error);
                if (data == null)
                {
                    MessageBox.Show(error);
                }
                else
                {
                    DSTaiKhoan = data;
                    dgDSTaiKhoan.DataSource = DSTaiKhoan;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ucQLTaiKhoan_Resize(object sender, EventArgs e)
        {
            // Lấy kích thước mới của ucQLTaiKhoan
            int newWidth = this.Width;
            int newHeight = this.Height;

            // Tính toán kích thước phông chữ mới dựa trên kích thước của ucQLTaiKhoan
            // Bạn có thể điều chỉnh công thức này để có kết quả phù hợp với mong muốn của bạn
            float newFontSize = (float)Math.Sqrt(newWidth * newHeight) / 60;

            // Thay đổi kích thước phông chữ của lbQLTaiKhoan
            lbQLTaiKhoan.Font = new Font("Segoe UI", newFontSize, FontStyle.Bold);

            // Canh giữa nhãn theo chiều ngang
            lbQLTaiKhoan.Location = new Point((this.Width - lbQLTaiKhoan.Width) / 20, 10);


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int addedAccountId = -1; // Khai báo biến
            frmThemTaiKhoan frm = new frmThemTaiKhoan(out addedAccountId); // Truyền tham số out
            frm.StartPosition = FormStartPosition.CenterScreen;
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // addedAccountId đã chứa ID, nhưng lbIdTaiKhoan đã được cập nhật bên trong frmThemTaiKhoan rồi
                LayDanhSachTaiKhoan(); // Refresh datagridview
            }
        }
        private TaiKhoanEntity TaiKhoanDaChon = new TaiKhoanEntity();
        private void dgDSTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgDSTaiKhoan.RowCount)
            {
                DataGridViewRow rowselected = dgDSTaiKhoan.Rows[e.RowIndex];
                #region Hien thi gia tri len label

                #endregion

                #region Gan gia tri vao entity tai khoan da chon
                TaiKhoanDaChon.ID_TAIKHOAN = int.Parse(rowselected.Cells["ID_TAIKHOAN"].Value.ToString());
                TaiKhoanDaChon.EMAIL = rowselected.Cells["EMAIL"].Value.ToString();
                TaiKhoanDaChon.PASS = rowselected.Cells["PASS"].Value.ToString();
                TaiKhoanDaChon.MSNguoiDung = rowselected.Cells["MS_NGUOI_DUNG"].Value.ToString();
                TaiKhoanDaChon.TinhTrang = bool.Parse(rowselected.Cells["TINH_TRANG"].Value.ToString());
                TaiKhoanDaChon.Quyen = rowselected.Cells["QUYEN"].Value.ToString();
                TaiKhoanDaChon.NguoiTao = rowselected.Cells["NGUOI_TAO"].Value.ToString();
                #endregion
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 1. Check if an account is selected
            if (TaiKhoanDaChon.ID_TAIKHOAN <= 0) // Or any other appropriate check for a valid ID
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); // More user-friendly message
                return; // Exit the event handler
            }

            // 2. Confirm deletion with the user (important!)
            DialogResult confirmation = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                bool ketqua = tkManager.XoaTaiKhoan(TaiKhoanDaChon.ID_TAIKHOAN, ref error); // Use TaiKhoanDaChon.ID_TAIKHOAN

                if (ketqua)
                {
                    MessageBox.Show("Xóa tài khoản thành công.");
                    LayDanhSachTaiKhoan(); // Refresh the DataGridView
                                           // Reset TaiKhoanDaChon (optional, but good practice)
                    TaiKhoanDaChon = new TaiKhoanEntity(); // Or clear individual properties
                }
                else
                {
                    MessageBox.Show("Lỗi xóa tài khoản: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display the error message from tkManager
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan frm = new frmThemTaiKhoan(TaiKhoanDaChon);
            frm.ShowDialog();
            LayDanhSachTaiKhoan();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // 1. Check if an account is selected
            if (TaiKhoanDaChon.ID_TAIKHOAN <= 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần đặt lại mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Confirm password reset with the user (important!)
            DialogResult confirmation = MessageBox.Show($"Bạn có chắc chắn muốn đặt lại mật khẩu cho tài khoản {TaiKhoanDaChon.EMAIL} về mặc định?", "Xác nhận đặt lại mật khẩu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    // Hash the default password
                    string defaultPassword = "1234";
                    string hashedPassword = DB.HashPassword(defaultPassword); // Assuming DB is your Database class instance

                    // Update the TaiKhoanDaChon object with the new hashed password
                    TaiKhoanDaChon.PASS = hashedPassword;

                    // Call the update method in your manager/repository
                    bool ketqua = tkManager.CapNhatTaiKhoan(TaiKhoanDaChon, ref error);

                    if (ketqua)
                    {
                        MessageBox.Show("Đặt lại mật khẩu thành công.");
                        LayDanhSachTaiKhoan(); // Refresh the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Lỗi đặt lại mật khẩu: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
