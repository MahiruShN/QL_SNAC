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
using QL_SNAC.MainForm;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QL_SNAC.QLTaiKhoan
{
    public partial class ucQLTaiKhoan : UserControl
    {
        private TaiKhoanManager tkManager = null;
        private DataTable DSTaiKhoan = null;
        private string error = "";
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
    }
}
