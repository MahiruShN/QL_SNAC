using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.Responsitories;
using Microsoft.Data.SqlClient;
using System.Configuration;
using QL_SNAC.MainForm;
using System.Globalization;

namespace QL_SNAC.Login
{
    public partial class frmLogin : Form
    {
        private Database db = new Database();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            #region Kiem tra co nhap lieu vao textbox ko
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtMatkhau.Text) || string.IsNullOrEmpty(cboQuyen.Text)) // Check cboQuyen.Text
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Email, mật khẩu và chọn quyền!");
                return;
            }
            #endregion

            string connString = ConfigurationManager.ConnectionStrings["QL_SNAC_Connection"].ConnectionString;

            if (string.IsNullOrEmpty(connString))
            {
                MessageBox.Show("Connection string not found or invalid. Check your configuration.");
                return;
            }

            SqlConnection connect = null;
            try
            {
                connect = new SqlConnection(connString);
                connect.Open();

                string enteredPasswordHash = db.HashPassword(txtMatkhau.Text);
                string selectedQuyenFull = cboQuyen.Text; // Get full role name from combo box

                // Convert full role name to abbreviation
                string selectedQuyenAbbr = GetQuyenAbbreviation(selectedQuyenFull);

                using (SqlCommand command = new SqlCommand("SELECT EMAIL FROM TAI_KHOAN WHERE EMAIL = @Email AND PASS = @Password AND QUYEN = @Quyen", connect))
                {
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@Password", enteredPasswordHash);
                    command.Parameters.AddWithValue("@Quyen", selectedQuyenAbbr); // Use abbreviation in query

                    object data = command.ExecuteScalar();

                    if (data == null)
                    {
                        MessageBox.Show("Lỗi tài khoản hoặc quyền truy cập. Đăng nhập không thành công.");
                    }
                    else
                    {
                        CauHinhHeThong.Email = txtEmail.Text;
                        string tenDayDu = LayTenDayDu(connect, txtEmail.Text);
                        CauHinhHeThong.TenDayDu = tenDayDu;

                        // Lấy ID_TaiKhoan

                        using (SqlCommand getIdCommand = new SqlCommand("SELECT ID_TAIKHOAN, MS_NGUOI_DUNG, NGAY_TAO, NGUOI_TAO FROM TAI_KHOAN WHERE EMAIL = @Email AND PASS = @Password AND QUYEN = @Quyen", connect)) // Get all needed data in one query
                        {
                            getIdCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                            getIdCommand.Parameters.AddWithValue("@Password", enteredPasswordHash);
                            getIdCommand.Parameters.AddWithValue("@Quyen", selectedQuyenAbbr);

                            using (SqlDataReader reader = getIdCommand.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    int idTaiKhoan = reader.GetInt32(0);
                                    string msNguoiDung = reader.GetString(1);
                                    DateTime ngayTao = reader.GetDateTime(2);
                                    string nguoiTao = reader.GetString(3);

                                    CauHinhHeThong.ID_TaiKhoan = idTaiKhoan;
                                    CauHinhHeThong.MSNguoiDung = msNguoiDung;
                                    CauHinhHeThong.NgayTao = ngayTao;
                                    CauHinhHeThong.NguoiTao = nguoiTao;
                                    reader.Close();

                                    // ***CHECK TINH_TRANG IMMEDIATELY AFTER GETTING ID***
                                    using (SqlCommand checkTinhTrangCommand = new SqlCommand("SELECT TINH_TRANG FROM TAI_KHOAN WHERE ID_TAIKHOAN = @ID_TAIKHOAN", connect))
                                    {
                                        checkTinhTrangCommand.Parameters.AddWithValue("@ID_TAIKHOAN", idTaiKhoan);
                                        object tinhTrangResult = checkTinhTrangCommand.ExecuteScalar();

                                        if (tinhTrangResult == null || tinhTrangResult == DBNull.Value || !(bool)tinhTrangResult)
                                        {
                                            MessageBox.Show("Tài khoản này hiện đang bị khóa. Vui lòng liên hệ quản trị viên.");
                                            return; // Stop login if TINH_TRANG is false or null
                                        }
                                    }


                                    // *** NEW CODE TO GET Quyen based on cboQuyen.Text ***
                                    // Get full role name from combo box


                                    CauHinhHeThong.Quyen = selectedQuyenAbbr;  // Assign the abbreviated role to CauHinhHeThong.Quyen
                                    string ngayTaoFormatted = CauHinhHeThong.NgayTao.ToString("dd/MM/yyyy"); // Or your preferred 

                                    string ngaySinh = null;
                                    string gioiTinh = null;
                                    string error = null;

                                    // Determine the correct table and column based on the user's role
                                    string tableName = null;
                                    string maNguoiDungColumn = null;

                                    switch (CauHinhHeThong.Quyen.ToUpper()) // Use the stored Quyen
                                    {
                                        case "GV":
                                        case "GVCN":
                                            tableName = "THONG_TIN_GIAO_VIEN";
                                            maNguoiDungColumn = "MSGV";
                                            break;
                                        case "HS":
                                            tableName = "THONG_TIN_HOC_SINH";
                                            maNguoiDungColumn = "MSHS";
                                            break;
                                        case "PH": // If you have PhuHuynh
                                            tableName = "THONG_TIN_PHU_HUYNH";
                                            maNguoiDungColumn = "ID_PHU_HUYNH"; // Or the correct column name
                                            break;
                                        default:
                                            MessageBox.Show("Không hỗ trợ lấy thông tin cho loại tài khoản này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return; // Stop here if the role is not supported
                                    }


                                    // Now, use the correct table and column to get the info
                                    LayThongTinNguoiDung(connect, CauHinhHeThong.MSNguoiDung);

                                    string ngaySinhFormatted = CauHinhHeThong.NgaySinh != null ? CauHinhHeThong.NgaySinh.ToString() : "Chưa xác định";
                                    string gioiTinhFormatted = CauHinhHeThong.GioiTinh ?? "Chưa xác định"; // Sử dụng null-coalescing operator
                                    string message = $"Email: {CauHinhHeThong.Email}\n" +
                                                     $"ID_TaiKhoan: {CauHinhHeThong.ID_TaiKhoan}\n" +
                                                     $"Ten Day Du: {CauHinhHeThong.TenDayDu}\n" +
                                                     $"Quyen: {CauHinhHeThong.Quyen}\n" +
                                                     $"MS_Nguoi_Dung: {CauHinhHeThong.MSNguoiDung}\n" +
                                                     $"Ngay Tao: {CauHinhHeThong.NgayTao.ToString("dd/MM/yyyy")}\n" +
                                                     $"Nguoi Tao: {CauHinhHeThong.NguoiTao}\n" +
                                                     $"Ngày Sinh: {ngaySinhFormatted}\n" + // Sử dụng biến đã định dạng
                                                     $"Giới Tính: {gioiTinhFormatted}"; // Sử dụng biến đã định dạng


                                    MessageBox.Show(message, "Thông tin người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    frmMain frm = new frmMain(CauHinhHeThong.TenDayDu);
                                    this.Hide();
                                    frm.ShowDialog();
                                    this.Close();
                                }
                            }
                        }
                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
            finally
            {
                connect?.Close();
            }
        }

        private string LayTenDayDu(SqlConnection connection, string email)
        {
            string tenDayDu = null;

            // Try for GiaoVien
            tenDayDu = LayTenDayDuTheoVaiTro(connection, email, "THONG_TIN_GIAO_VIEN", "MSGV", "Ho", "Ten");
            if (!string.IsNullOrEmpty(tenDayDu)) return tenDayDu;

            // Try for HocSinh
            tenDayDu = LayTenDayDuTheoVaiTro(connection, email, "THONG_TIN_HOC_SINH", "MSHS", "Ho", "Ten");
            if (!string.IsNullOrEmpty(tenDayDu)) return tenDayDu;

            // Try for PhuHuynh
            tenDayDu = LayTenDayDuTheoVaiTro(connection, email, "THONG_TIN_PHU_HUYNH", "ID_PHU_HUYNH", "Ho", "Ten");
            if (!string.IsNullOrEmpty(tenDayDu)) return tenDayDu;

            return null; // Not found in any table
        }

        private void LayThongTinNguoiDung(SqlConnection connection, string msNguoiDung)
        {
            string sql = $@"SELECT HO, TEN, GIOITINH, NGAY_SINH
                           FROM THONG_TIN_HOC_SINH
                           WHERE MSHS = @MSNguoiDung

                           UNION

                           SELECT HO, TEN, GIOITINH, NGAY_SINH
                           FROM THONG_TIN_GIAO_VIEN
                           WHERE MSGV = @MSNguoiDung";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@MSNguoiDung", msNguoiDung);

                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CauHinhHeThong.TenDayDu = $"{reader.GetString(0)} {reader.GetString(1)}";
                            CauHinhHeThong.GioiTinh = reader.GetString(2);
                            // Store NGAY_SINH as string, handling DBNull
                            CauHinhHeThong.NgaySinh = reader.IsDBNull(3) ? null : reader.GetString(3);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy người dùng với mã số này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn: " + ex.Message);
                }
            }
        }
        private string LayTenDayDuTheoVaiTro(SqlConnection connection, string email, string tenBang, string cotKhoaNgoai, string cotHo, string cotTen)
        {
            string tenDayDu = null;
            string sql;
            if (!string.IsNullOrEmpty(cotTen))
            {
                sql = $"SELECT {cotHo} + ' ' + {cotTen} AS TenDayDu FROM TAI_KHOAN tk INNER JOIN {tenBang} nv ON nv.{cotKhoaNgoai} = tk.MS_NGUOI_DUNG WHERE tk.EMAIL = @Email";
            }
            else
            {
                sql = $"SELECT {cotHo} AS TenDayDu FROM TAI_KHOAN tk INNER JOIN {tenBang} nv ON nv.{cotKhoaNgoai} = tk.MS_NGUOI_DUNG WHERE tk.EMAIL = @Email";
            }


            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Email", email);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    tenDayDu = result.ToString();
                }
            }
            return tenDayDu;
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
                default: return quyen; 
            }
        }
    }
}
