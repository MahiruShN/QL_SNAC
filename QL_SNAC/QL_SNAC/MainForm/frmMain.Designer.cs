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
            tableLayoutPanel1 = new TableLayoutPanel();
            pnMain = new Panel();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuTaiKhoan, họcSinhToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(989, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuTaiKhoan
            // 
            menuTaiKhoan.DropDownItems.AddRange(new ToolStripItem[] { QLTaiKhoanMenuTool, ThongTinTaiKhoanMenuTool, DoiMatKhauMenuTool });
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
            // 
            // DoiMatKhauMenuTool
            // 
            DoiMatKhauMenuTool.Name = "DoiMatKhauMenuTool";
            DoiMatKhauMenuTool.Size = new Size(226, 26);
            DoiMatKhauMenuTool.Text = "Đổi Mật Khẩu";
            DoiMatKhauMenuTool.Click += DoiMatKhauMenuTool_Click;
            // 
            // họcSinhToolStripMenuItem
            // 
            họcSinhToolStripMenuItem.Name = "họcSinhToolStripMenuItem";
            họcSinhToolStripMenuItem.Size = new Size(80, 24);
            họcSinhToolStripMenuItem.Text = "Học sinh";
            họcSinhToolStripMenuItem.Click += họcSinhToolStripMenuItem_Click;
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
    }
}