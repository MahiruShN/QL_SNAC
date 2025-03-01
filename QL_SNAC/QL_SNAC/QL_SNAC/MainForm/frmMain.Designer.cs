namespace QL_SNAC.MainForm
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuTaiKhoan = new ToolStripMenuItem();
            QLTaiKhoanMenuTool = new ToolStripMenuItem();
            ThongTinTaiKhoanMenuTool = new ToolStripMenuItem();
            DoiMatKhauMenuTool = new ToolStripMenuItem();
            Thoat_menuTools = new ToolStripMenuItem();
            QLDT_menutools = new ToolStripMenuItem();
            quảnLýĐàoTạoToolStripMenuItem = new ToolStripMenuItem();
            QLMH_menutools = new ToolStripMenuItem();
            QLLop_menutools = new ToolStripMenuItem();
            gvToolStripMenuItem = new ToolStripMenuItem();
            quảnLýThôngTinToolStripMenuItem = new ToolStripMenuItem();
            họcSinhToolStripMenuItem = new ToolStripMenuItem();
            QLThongTinHocSinh_menutool = new ToolStripMenuItem();
            ThongtinChitiet_menutool = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnMain = new Panel();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuTaiKhoan, QLDT_menutools, gvToolStripMenuItem, họcSinhToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(989, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuTaiKhoan
            // 
            menuTaiKhoan.DropDownItems.AddRange(new ToolStripItem[] { QLTaiKhoanMenuTool, ThongTinTaiKhoanMenuTool, DoiMatKhauMenuTool, Thoat_menuTools });
            menuTaiKhoan.Name = "menuTaiKhoan";
            menuTaiKhoan.Size = new Size(100, 24);
            menuTaiKhoan.Text = "TÀI KHOẢN";
            // 
            // QLTaiKhoanMenuTool
            // 
            QLTaiKhoanMenuTool.Name = "QLTaiKhoanMenuTool";
            QLTaiKhoanMenuTool.Size = new Size(226, 26);
            QLTaiKhoanMenuTool.Text = "Quản Lý Tài Khoản";
            QLTaiKhoanMenuTool.Click += QLTaiKhoanMenuTool_Click;
            // 
            // ThongTinTaiKhoanMenuTool
            // 
            ThongTinTaiKhoanMenuTool.Name = "ThongTinTaiKhoanMenuTool";
            ThongTinTaiKhoanMenuTool.Size = new Size(226, 26);
            ThongTinTaiKhoanMenuTool.Text = "Thông Tin Tài Khoản";
            ThongTinTaiKhoanMenuTool.Click += ThongTinTaiKhoanMenuTool_Click;
            // 
            // DoiMatKhauMenuTool
            // 
            DoiMatKhauMenuTool.Name = "DoiMatKhauMenuTool";
            DoiMatKhauMenuTool.Size = new Size(226, 26);
            DoiMatKhauMenuTool.Text = "Đổi Mật Khẩu";
            DoiMatKhauMenuTool.Click += DoiMatKhauMenuTool_Click;
            // 
            // Thoat_menuTools
            // 
            Thoat_menuTools.Name = "Thoat_menuTools";
            Thoat_menuTools.Size = new Size(226, 26);
            Thoat_menuTools.Text = "Thoát";
            Thoat_menuTools.Click += Thoat_menuTools_Click;
            // 
            // QLDT_menutools
            // 
            QLDT_menutools.DropDownItems.AddRange(new ToolStripItem[] { quảnLýĐàoTạoToolStripMenuItem, QLMH_menutools, QLLop_menutools });
            QLDT_menutools.Name = "QLDT_menutools";
            QLDT_menutools.Size = new Size(88, 24);
            QLDT_menutools.Text = "ĐÀO TẠO";
            // 
            // quảnLýĐàoTạoToolStripMenuItem
            // 
            quảnLýĐàoTạoToolStripMenuItem.Name = "quảnLýĐàoTạoToolStripMenuItem";
            quảnLýĐàoTạoToolStripMenuItem.Size = new Size(224, 26);
            quảnLýĐàoTạoToolStripMenuItem.Text = "Quản lý Đào Tạo";
            quảnLýĐàoTạoToolStripMenuItem.Click += quảnLýĐàoTạoToolStripMenuItem_Click;
            // 
            // QLMH_menutools
            // 
            QLMH_menutools.Name = "QLMH_menutools";
            QLMH_menutools.Size = new Size(224, 26);
            QLMH_menutools.Text = "Quản lý Môn Học";
            // 
            // QLLop_menutools
            // 
            QLLop_menutools.Name = "QLLop_menutools";
            QLLop_menutools.Size = new Size(224, 26);
            QLLop_menutools.Text = "Quản lý Lớp Học";
            // 
            // gvToolStripMenuItem
            // 
            gvToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýThôngTinToolStripMenuItem });
            gvToolStripMenuItem.Name = "gvToolStripMenuItem";
            gvToolStripMenuItem.Size = new Size(94, 24);
            gvToolStripMenuItem.Text = "GIÁO VIÊN";
            // 
            // quảnLýThôngTinToolStripMenuItem
            // 
            quảnLýThôngTinToolStripMenuItem.Name = "quảnLýThôngTinToolStripMenuItem";
            quảnLýThôngTinToolStripMenuItem.Size = new Size(224, 26);
            quảnLýThôngTinToolStripMenuItem.Text = "Quản lý thông tin";
            quảnLýThôngTinToolStripMenuItem.Click += quảnLýThôngTinToolStripMenuItem_Click;
            // 
            // họcSinhToolStripMenuItem
            // 
            họcSinhToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { QLThongTinHocSinh_menutool, ThongtinChitiet_menutool });
            họcSinhToolStripMenuItem.Name = "họcSinhToolStripMenuItem";
            họcSinhToolStripMenuItem.Size = new Size(92, 24);
            họcSinhToolStripMenuItem.Text = "HỌC SINH";
            // 
            // QLThongTinHocSinh_menutool
            // 
            QLThongTinHocSinh_menutool.Name = "QLThongTinHocSinh_menutool";
            QLThongTinHocSinh_menutool.Size = new Size(224, 26);
            QLThongTinHocSinh_menutool.Text = "Quản Lý Thông Tin";
            QLThongTinHocSinh_menutool.Click += QLThongTinHocSinh_menutool_Click;
            // 
            // ThongtinChitiet_menutool
            // 
            ThongtinChitiet_menutool.Name = "ThongtinChitiet_menutool";
            ThongtinChitiet_menutool.Size = new Size(224, 26);
            ThongtinChitiet_menutool.Text = "Thông Tin Chi Tiết";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pnMain, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(989, 509);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // pnMain
            // 
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(3, 3);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(983, 503);
            pnMain.TabIndex = 0;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 539);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuTaiKhoan;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnMain;
        private ToolStripMenuItem họcSinhToolStripMenuItem;
        private ToolStripMenuItem QLTaiKhoanMenuTool;
        private ToolStripMenuItem ThongTinTaiKhoanMenuTool;
        private ToolStripMenuItem DoiMatKhauMenuTool;
        private ToolStripMenuItem QLThongTinHocSinh_menutool;
        private ToolStripMenuItem ThongtinChitiet_menutool;
        private ToolStripMenuItem gvToolStripMenuItem;
        private ToolStripMenuItem quảnLýThôngTinToolStripMenuItem;
        private ToolStripMenuItem QLDT_menutools;
        private ToolStripMenuItem quảnLýĐàoTạoToolStripMenuItem;
        private ToolStripMenuItem QLMH_menutools;
        private ToolStripMenuItem QLLop_menutools;
        private ToolStripMenuItem Thoat_menuTools;
    }
}