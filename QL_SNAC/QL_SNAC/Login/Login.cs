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
            if (string.IsNullOrEmpty(txtEmail.Text) == true || string.IsNullOrEmpty(txtMatkhau.Text) == true)
            {
                MessageBox.Show("Chua nhap Email hoac mat khau!");
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

                using (SqlCommand command = new SqlCommand("SELECT EMAIL FROM TAI_KHOAN WHERE EMAIL = @Email AND PASS = @Password", connect))
                {
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@Password", enteredPasswordHash);

                    object data = command.ExecuteScalar();

                    if (data == null)
                    {
                        MessageBox.Show("Lỗi tài khoản, đăng nhập không thành công");
                    }
                    else
                    {
                        CauHinhHeThong.Email = txtEmail.Text;
                        string tenDayDu = LayTenDayDu(connect, txtEmail.Text);
                        CauHinhHeThong.TenDayDu = tenDayDu;

                        // Lấy ID_TaiKhoan
                        using (SqlCommand getIdCommand = new SqlCommand("SELECT ID_TAIKHOAN FROM TAI_KHOAN WHERE EMAIL = @Email", connect))
                        {
                            getIdCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                            object idResult = getIdCommand.ExecuteScalar();
                            if (idResult != null && int.TryParse(idResult.ToString(), out int idTaiKhoan))
                            {
                                CauHinhHeThong.ID_TaiKhoan = idTaiKhoan;
                            }
                            else
                            {
                                MessageBox.Show("Không thể lấy ID tài khoản.");
                                return;
                            }
                        }

                        using (SqlCommand getQuyenCommand = new SqlCommand("SELECT Quyen FROM TAI_KHOAN WHERE EMAIL = @Email", connect))
                        {
                            getQuyenCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                            string quyen = (string)getQuyenCommand.ExecuteScalar();

                            if (!string.IsNullOrEmpty(quyen))
                            {
                                CauHinhHeThong.Quyen = GetQuyenAbbreviation(quyen);
                            }
                            else
                            {
                                MessageBox.Show("Quyền người dùng không được tìm thấy.");
                                return;
                            }
                        }

                        string message = $"Email: {CauHinhHeThong.Email}\n" +
                     $"ID_TaiKhoan: {CauHinhHeThong.ID_TaiKhoan}\n" +
                     $"Ten Day Du: {CauHinhHeThong.TenDayDu}\n" +
                     $"Quyen: {CauHinhHeThong.Quyen}";

                        MessageBox.Show(message, "Thông tin người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmMain frm = new frmMain(tenDayDu);
                        this.Hide(); // Hide, don't close, the login form
                        frm.ShowDialog(); // Show frmMain as a dialog
                        this.Close();
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
