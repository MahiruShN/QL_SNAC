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

            //Buoc 1: xac định CSDL sẽ lam việc
            //Buớc 2: Xac đinh chuoi ket noi
            //string connString = "Data Source=NHAT\\SQLEXPRESS;Initial Catalog=QL_SNAC;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
            string connString = "Data Source=.;Initial Catalog=QL_SNAC;Integrated Security=True;Trust Server Certificate=True";
            //Buoc 3: Tao doi tuong ket noi
            SqlConnection connect = null;
            try
            {
                connect = new SqlConnection(connString);
                connect.Open();

                // 1. Hash the entered password using the same method as during registration
                string enteredPasswordHash = db.HashPassword(txtMatkhau.Text); // Hash the input

                // 2. Query the database using the hashed password
                string sql = "SELECT EMAIL FROM TAI_KHOAN WHERE EMAIL = @Email AND PASS = @Password"; // Use parameters!
                SqlCommand command = new SqlCommand(sql, connect); // Combine query and connection

                // 3. Add parameters to prevent SQL injection
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                command.Parameters.AddWithValue("@Password", enteredPasswordHash); // Use the hashed password

                object data = command.ExecuteScalar();

                if (data == null)
                {
                    MessageBox.Show("Lỗi tài khoản, đăng nhập không thành công");
                }
                else
                {
                    frmMain frm = new frmMain();
                    frm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
            finally
            {
                connect.Close(); // Use null-conditional operator to avoid potential null exceptions
            }


        }
    }
}
