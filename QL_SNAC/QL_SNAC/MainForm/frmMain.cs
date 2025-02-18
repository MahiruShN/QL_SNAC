using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_SNAC.QLHocSinh;
using QL_SNAC.QLTaiKhoan;
using QL_SNAC.QLTaiKhoan;

namespace QL_SNAC.MainForm
{
    public partial class frmMain : Form
    {
        private string _tenDayDu;
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(string tenDayDu) // Constructor with TenDayDu
        {
            InitializeComponent();
            _tenDayDu = tenDayDu; // Initialize the field
            this.Text = "Chào mừng, " + _tenDayDu; // Set form title
        }
        private ucQLTaiKhoan ucQLTK;
        private ucQLHocSinh ucQLHocSinh;

        private void menuTaiKhoan_Click(object sender, EventArgs e)
        {

            if (ucQLTK == null) // Kiểm tra xem ucQLTK có null không (chưa bao giờ được tạo)
            {
                ucQLTK = new ucQLTaiKhoan();
                ucQLTK.Dock = DockStyle.Fill;
                pnMain.Controls.Add(ucQLTK);
            }

            // Bây giờ, ucQLTK đã tồn tại. Hiển thị hoặc ẩn tùy theo nhu cầu.
            if (ucQLTK.Visible)
            {
                ucQLTK.Hide(); // Ẩn nếu nó hiện đang hiển thị
            }
            else
            {
                ucQLTK.Show(); // Hiển thị nếu nó hiện đang ẩn
                ucQLTK.BringToFront(); // Đảm bảo nó ở trên cùng
            }
        }

        private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ucQLHocSinh == null) // Kiểm tra xem ucQLTK có null không (chưa bao giờ được tạo)
            {
                ucQLHocSinh = new ucQLHocSinh();
                ucQLHocSinh.Dock = DockStyle.Fill;
                pnMain.Controls.Add(ucQLHocSinh);
            }

            // Bây giờ, ucQLTK đã tồn tại. Hiển thị hoặc ẩn tùy theo nhu cầu.
            if (ucQLHocSinh.Visible)
            {
                ucQLHocSinh.Hide(); // Ẩn nếu nó hiện đang hiển thị
            }
            else
            {
                ucQLHocSinh.Show(); // Hiển thị nếu nó hiện đang ẩn
                ucQLHocSinh.BringToFront(); // Đảm bảo nó ở trên cùng
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
