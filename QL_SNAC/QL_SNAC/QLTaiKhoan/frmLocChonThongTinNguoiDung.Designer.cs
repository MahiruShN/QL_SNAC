namespace QL_SNAC.QLTaiKhoan
{
    partial class frmLocChonThongTinNguoiDung
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            lbTen = new Label();
            lbHo = new Label();
            lbMSNguoiDung = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbTieuDe = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            TabControl = new TabControl();
            tbHocSinh = new TabPage();
            dgDSHocSinh = new DataGridView();
            tbGiaoVien = new TabPage();
            dgDSGiaoVien = new DataGridView();
            tbPhuHuynh = new TabPage();
            dgDSPhuHuynh = new DataGridView();
            panel4 = new Panel();
            btnBack = new Button();
            btnThem = new Button();
            txtSearch = new TextBox();
            lbSearch = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            TabControl.SuspendLayout();
            tbHocSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDSHocSinh).BeginInit();
            tbGiaoVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDSGiaoVien).BeginInit();
            tbPhuHuynh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDSPhuHuynh).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Controls.Add(panel4, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(683, 515);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(lbTen);
            panel1.Controls.Add(lbHo);
            panel1.Controls.Add(lbMSNguoiDung);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbTieuDe);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(677, 148);
            panel1.TabIndex = 0;
            // 
            // lbTen
            // 
            lbTen.AutoSize = true;
            lbTen.Location = new Point(214, 115);
            lbTen.Name = "lbTen";
            lbTen.Size = new Size(75, 20);
            lbTen.TabIndex = 6;
            lbTen.Text = "......................";
            // 
            // lbHo
            // 
            lbHo.AutoSize = true;
            lbHo.Location = new Point(214, 80);
            lbHo.Name = "lbHo";
            lbHo.Size = new Size(75, 20);
            lbHo.TabIndex = 5;
            lbHo.Text = "......................";
            // 
            // lbMSNguoiDung
            // 
            lbMSNguoiDung.AutoSize = true;
            lbMSNguoiDung.Location = new Point(214, 48);
            lbMSNguoiDung.Name = "lbMSNguoiDung";
            lbMSNguoiDung.Size = new Size(75, 20);
            lbMSNguoiDung.TabIndex = 4;
            lbMSNguoiDung.Text = "......................";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 115);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 3;
            label3.Text = "Tên :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 80);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 2;
            label2.Text = "Họ :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 48);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã Số Người Dùng :";
            // 
            // lbTieuDe
            // 
            lbTieuDe.AutoSize = true;
            lbTieuDe.Location = new Point(319, 18);
            lbTieuDe.Name = "lbTieuDe";
            lbTieuDe.Size = new Size(54, 20);
            lbTieuDe.TabIndex = 0;
            lbTieuDe.Text = "...............";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(lbSearch);
            panel2.Controls.Add(txtSearch);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 157);
            panel2.Name = "panel2";
            panel2.Size = new Size(677, 45);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(TabControl);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 208);
            panel3.Name = "panel3";
            panel3.Size = new Size(677, 251);
            panel3.TabIndex = 2;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tbHocSinh);
            TabControl.Controls.Add(tbGiaoVien);
            TabControl.Controls.Add(tbPhuHuynh);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(677, 251);
            TabControl.TabIndex = 1;
            TabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // tbHocSinh
            // 
            tbHocSinh.Controls.Add(dgDSHocSinh);
            tbHocSinh.Location = new Point(4, 29);
            tbHocSinh.Name = "tbHocSinh";
            tbHocSinh.Padding = new Padding(3);
            tbHocSinh.Size = new Size(669, 218);
            tbHocSinh.TabIndex = 0;
            tbHocSinh.Text = "Học Sinh";
            tbHocSinh.UseVisualStyleBackColor = true;
            // 
            // dgDSHocSinh
            // 
            dgDSHocSinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDSHocSinh.Dock = DockStyle.Fill;
            dgDSHocSinh.Location = new Point(3, 3);
            dgDSHocSinh.Name = "dgDSHocSinh";
            dgDSHocSinh.RowHeadersWidth = 51;
            dgDSHocSinh.Size = new Size(663, 212);
            dgDSHocSinh.TabIndex = 0;
            dgDSHocSinh.CellClick += dgDSHocSinh_CellClick;
            dgDSHocSinh.CellDoubleClick += dgDSHocSinh_CellDoubleClick;
            // 
            // tbGiaoVien
            // 
            tbGiaoVien.Controls.Add(dgDSGiaoVien);
            tbGiaoVien.Location = new Point(4, 29);
            tbGiaoVien.Name = "tbGiaoVien";
            tbGiaoVien.Padding = new Padding(3);
            tbGiaoVien.Size = new Size(669, 218);
            tbGiaoVien.TabIndex = 1;
            tbGiaoVien.Text = "Giáo Viên";
            tbGiaoVien.UseVisualStyleBackColor = true;
            // 
            // dgDSGiaoVien
            // 
            dgDSGiaoVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDSGiaoVien.Dock = DockStyle.Fill;
            dgDSGiaoVien.Location = new Point(3, 3);
            dgDSGiaoVien.Name = "dgDSGiaoVien";
            dgDSGiaoVien.RowHeadersWidth = 51;
            dgDSGiaoVien.Size = new Size(663, 212);
            dgDSGiaoVien.TabIndex = 0;
            dgDSGiaoVien.CellClick += dgDSGiaoVien_CellClick;
            dgDSGiaoVien.CellDoubleClick += dgDSGiaoVien_CellDoubleClick;
            // 
            // tbPhuHuynh
            // 
            tbPhuHuynh.Controls.Add(dgDSPhuHuynh);
            tbPhuHuynh.Location = new Point(4, 29);
            tbPhuHuynh.Name = "tbPhuHuynh";
            tbPhuHuynh.Padding = new Padding(3);
            tbPhuHuynh.Size = new Size(669, 218);
            tbPhuHuynh.TabIndex = 2;
            tbPhuHuynh.Text = "Phụ Huynh";
            tbPhuHuynh.UseVisualStyleBackColor = true;
            // 
            // dgDSPhuHuynh
            // 
            dgDSPhuHuynh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDSPhuHuynh.Dock = DockStyle.Fill;
            dgDSPhuHuynh.Location = new Point(3, 3);
            dgDSPhuHuynh.Name = "dgDSPhuHuynh";
            dgDSPhuHuynh.RowHeadersWidth = 51;
            dgDSPhuHuynh.Size = new Size(663, 212);
            dgDSPhuHuynh.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.Controls.Add(btnBack);
            panel4.Controls.Add(btnThem);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 465);
            panel4.Name = "panel4";
            panel4.Size = new Size(677, 47);
            panel4.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(568, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 39);
            btnBack.TabIndex = 1;
            btnBack.Text = "TRỞ LẠI";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(442, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 39);
            btnThem.TabIndex = 0;
            btnThem.Text = "THÊM";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(35, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(385, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSearch.Location = new Point(442, 3);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(75, 28);
            lbSearch.TabIndex = 1;
            lbSearch.Text = "Search";
            // 
            // frmLocChonThongTinNguoiDung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 515);
            Controls.Add(tableLayoutPanel1);
            Name = "frmLocChonThongTinNguoiDung";
            Text = "THÔNG TIN NGƯỜI DÙNG";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            TabControl.ResumeLayout(false);
            tbHocSinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgDSHocSinh).EndInit();
            tbGiaoVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgDSGiaoVien).EndInit();
            tbPhuHuynh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgDSPhuHuynh).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label lbTen;
        private Label lbHo;
        private Label lbMSNguoiDung;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbTieuDe;
        private Panel panel2;
        private Panel panel3;
        private Button btnBack;
        private Button btnThem;
        private DataGridView dgDSHocSinh;
        private TabControl TabControl;
        private TabPage tbHocSinh;
        private TabPage tbGiaoVien;
        private TabPage tbPhuHuynh;
        private DataGridView dgDSGiaoVien;
        private DataGridView dgDSPhuHuynh;
        private Panel panel4;
        private Label lbSearch;
        private TextBox txtSearch;
    }
}