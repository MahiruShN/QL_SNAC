using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_SNAC.Login;
using QL_SNAC.QLDaoTao;
using QL_SNAC.QLGIaoVIen;
using QL_SNAC.QLHocSinh;
using QL_SNAC.QLTaiKhoan;


namespace QL_SNAC.MainForm
{
    public partial class frmMain : Form
    {
        private string _tenDayDu;
        private string _quyen;
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(string tenDayDu, string quyen) // Constructor with TenDayDu and Quyen
        {
            InitializeComponent();
            _tenDayDu = tenDayDu;
            _quyen = quyen; // Initialize the role field
            this.Text = "Chào mừng, " + _tenDayDu;
            PhanQuyen(); // Call the method to handle permissions
        }
        public frmMain(string tenDayDu) // Constructor with TenDayDu
        {
            InitializeComponent();
            _tenDayDu = tenDayDu; // Initialize the field
            this.Text = "Chào mừng, " + _tenDayDu; // Set form title
        }

        private ucQLTaiKhoan ucQLTK;
        private ucQLHocSinh ucQLHocSinh;
        private ucQLGiaoVien ucQLGiaoVien;
        private ucQLDaoTao ucQLDaoTao;


        //private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void QLTaiKhoanMenuTool_Click(object sender, EventArgs e)
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

        private void DoiMatKhauMenuTool_Click(object sender, EventArgs e)
        {
            int idTaiKhoan = CauHinhHeThong.ID_TaiKhoan;

            string email = CauHinhHeThong.Email;



            frmDoiMatKhau frm = new frmDoiMatKhau(idTaiKhoan, email);

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
        }

        private void ThongTinTaiKhoanMenuTool_Click(object sender, EventArgs e)
        {
            int idTaiKhoan = CauHinhHeThong.ID_TaiKhoan;
            string email = CauHinhHeThong.Email;
            string tenDayDu = CauHinhHeThong.TenDayDu;
            string maNguoiDung = CauHinhHeThong.MSNguoiDung;
            DateTime ngayTao = CauHinhHeThong.NgayTao;
            string NgaySinh = CauHinhHeThong.NgaySinh;
            string Gioitinh = CauHinhHeThong.GioiTinh;
            string Quyen = CauHinhHeThong.Quyen;
            frmThongTinTaiKhoan frm = new frmThongTinTaiKhoan(tenDayDu, idTaiKhoan, email, ngayTao, maNguoiDung, NgaySinh, Gioitinh, Quyen);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void QLThongTinHocSinh_menutool_Click(object sender, EventArgs e)
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

        private void quảnLýThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ucQLGiaoVien == null)
            {
                ucQLGiaoVien = new ucQLGiaoVien();
                ucQLGiaoVien.Dock = DockStyle.Fill;
                pnMain.Controls.Add(ucQLGiaoVien);
            }


            if (ucQLGiaoVien.Visible)
            {
                ucQLGiaoVien.Hide();
            }
            else
            {
                ucQLGiaoVien.Show();
                ucQLGiaoVien.BringToFront();
            }
        }

        private void quảnLýĐàoTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ucQLDaoTao == null)
            {
                ucQLDaoTao = new ucQLDaoTao();
                ucQLDaoTao.Dock = DockStyle.Fill;
                pnMain.Controls.Add(ucQLDaoTao);
            }


            if (ucQLDaoTao.Visible)
            {
                ucQLDaoTao.Hide();
            }
            else
            {
                ucQLDaoTao.Show();
                ucQLDaoTao.BringToFront();
            }
        }
        private void PhanQuyen()
        {
            // Disable all menu items by default
            QLTaiKhoanMenuTool.Enabled = false;
            gvToolStripMenuItem.Enabled = false;
            QLThongTinHocSinh_menutool.Enabled = false;
            quảnLýThôngTinToolStripMenuItem.Enabled = false;
            quảnLýĐàoTạoToolStripMenuItem.Enabled = false;
            QLDT_menutools.Enabled = false;

            // Enable menu items based on the user's role
            if (_quyen.ToUpper().Trim() == "AD") // Sử dụng Trim() để loại bỏ khoảng trắng
            {
                // Admin has full access
                QLTaiKhoanMenuTool.Enabled = true;
                gvToolStripMenuItem.Enabled=true;
                QLThongTinHocSinh_menutool.Enabled = true;
                quảnLýThôngTinToolStripMenuItem.Enabled = true;
                quảnLýĐàoTạoToolStripMenuItem.Enabled = true;
                QLDT_menutools.Enabled = true;
            }
            else if (_quyen.ToUpper().Trim() == "GV" || _quyen.ToUpper().Trim() == "GVCN") // Sử dụng Trim() ở đây nữa
            {
                // Teachers can manage students and themselves
                gvToolStripMenuItem.Enabled = true;
                QLThongTinHocSinh_menutool.Enabled = true;
                quảnLýThôngTinToolStripMenuItem.Enabled = true;
            }
            else if (_quyen.ToUpper().Trim() == "HS") // Sử dụng Trim() ở đây nữa
            {
                // Students can only view their own information
                ThongTinTaiKhoanMenuTool.Enabled = true;
            }
            // Add more role-based permissions as needed
        }

        private void Thoat_menuTools_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
