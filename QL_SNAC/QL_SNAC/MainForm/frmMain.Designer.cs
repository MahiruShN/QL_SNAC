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
            họcSinhToolStripMenuItem = new ToolStripMenuItem();
            QLThongTinHocSinh_menutool = new ToolStripMenuItem();
            ThongtinChitiet_menutool = new ToolStripMenuItem();
            gToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnMain = new Panel();
            quảnLýThôngTinToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuTaiKhoan, họcSinhToolStripMenuItem, gToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(865, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuTaiKhoan
            // 
            menuTaiKhoan.DropDownItems.AddRange(new ToolStripItem[] { QLTaiKhoanMenuTool, ThongTinTaiKhoanMenuTool, DoiMatKhauMenuTool });
            menuTaiKhoan.Name = "menuTaiKhoan";
            menuTaiKhoan.Size = new Size(80, 20);
            menuTaiKhoan.Text = "TÀI KHOẢN";
            // 
            // QLTaiKhoanMenuTool
            // 
            QLTaiKhoanMenuTool.Name = "QLTaiKhoanMenuTool";
            QLTaiKhoanMenuTool.Size = new Size(181, 22);
            QLTaiKhoanMenuTool.Text = "Quản Lý Tài Khoản";
            QLTaiKhoanMenuTool.Click += QLTaiKhoanMenuTool_Click;
            // 
            // ThongTinTaiKhoanMenuTool
            // 
            ThongTinTaiKhoanMenuTool.Name = "ThongTinTaiKhoanMenuTool";
            ThongTinTaiKhoanMenuTool.Size = new Size(181, 22);
            ThongTinTaiKhoanMenuTool.Text = "Thông Tin Tài Khoản";
            ThongTinTaiKhoanMenuTool.Click += ThongTinTaiKhoanMenuTool_Click;
            // 
            // DoiMatKhauMenuTool
            // 
            DoiMatKhauMenuTool.Name = "DoiMatKhauMenuTool";
            DoiMatKhauMenuTool.Size = new Size(181, 22);
            DoiMatKhauMenuTool.Text = "Đổi Mật Khẩu";
            DoiMatKhauMenuTool.Click += DoiMatKhauMenuTool_Click;
            // 
            // họcSinhToolStripMenuItem
            // 
            họcSinhToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { QLThongTinHocSinh_menutool, ThongtinChitiet_menutool });
            họcSinhToolStripMenuItem.Name = "họcSinhToolStripMenuItem";
            họcSinhToolStripMenuItem.Size = new Size(75, 20);
            họcSinhToolStripMenuItem.Text = "HỌC SINH";
            // 
            // QLThongTinHocSinh_menutool
            // 
            QLThongTinHocSinh_menutool.Name = "QLThongTinHocSinh_menutool";
            QLThongTinHocSinh_menutool.Size = new Size(180, 22);
            QLThongTinHocSinh_menutool.Text = "Quản Lý Thông Tin";
            QLThongTinHocSinh_menutool.Click += QLThongTinHocSinh_menutool_Click;
            // 
            // ThongtinChitiet_menutool
            // 
            ThongtinChitiet_menutool.Name = "ThongtinChitiet_menutool";
            ThongtinChitiet_menutool.Size = new Size(180, 22);
            ThongtinChitiet_menutool.Text = "Thông Tin Chi Tiết";
            // 
            // gToolStripMenuItem
            // 
            gToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýThôngTinToolStripMenuItem });
            gToolStripMenuItem.Name = "gToolStripMenuItem";
            gToolStripMenuItem.Size = new Size(75, 20);
            gToolStripMenuItem.Text = "GIÁO VIÊN";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pnMain, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(865, 380);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // pnMain
            // 
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(3, 2);
            pnMain.Margin = new Padding(3, 2, 3, 2);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(859, 376);
            pnMain.TabIndex = 0;
            // 
            // quảnLýThôngTinToolStripMenuItem
            // 
            quảnLýThôngTinToolStripMenuItem.Name = "quảnLýThôngTinToolStripMenuItem";
            quảnLýThôngTinToolStripMenuItem.Size = new Size(180, 22);
            quảnLýThôngTinToolStripMenuItem.Text = "Quản lý thông tin";
            quảnLýThôngTinToolStripMenuItem.Click += quảnLýThôngTinToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 404);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
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
        private ToolStripMenuItem gToolStripMenuItem;
        private ToolStripMenuItem quảnLýThôngTinToolStripMenuItem;
    }
}