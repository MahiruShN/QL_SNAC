using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using QL_SNAC.MainForm;

namespace QL_SNAC.Login
{
    public partial class frmLogin : Form
    {
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
            string connString = "Data Source=NHAT\\SQLEXPRESS;Initial Catalog=QL_SNAC;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
            //Buoc 3: Tao doi tuong ket noi
            SqlConnection connect = null;
            try
            {
                //ket noi csdl
                connect = new SqlConnection(connString);
                connect.Open();
                //Xử lý truy van
                #region Xu ly du lieu
                string sql = "select EMAIL from TAI_KHOAN where EMAIL like '" + txtEmail.Text + "' and PASS like '" + txtMatkhau.Text + "'";
                SqlCommand command = new SqlCommand();
                command.Connection = connect;
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                object data = command.ExecuteScalar();

                if (data == null)
                {
                    MessageBox.Show("Loi tai khoan, dang nhap khong thanh cong");
                }
                else
                {
                    //MessageBox.Show("Dan nhap thanh cong, ten nguoi dang la: "+data.ToString());
                    //clsCauHinhHeThong.TenDangNhap = txtDangNhap.Text;
                    //clsCauHinhHeThong.TenDayDu = data.ToString();
                    frmMain frm = new frmMain();
                    frm.Show();
                    this.Hide();
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ket noi lôi: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        
    }
    }
}
