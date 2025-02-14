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
            btnBack = new Button();
            btnThem = new Button();
            panel3 = new Panel();
            TabControl = new TabControl();
            tabPage1 = new TabPage();
            dgDSHocSinh = new DataGridView();
            tabPage2 = new TabPage();
            dgDSGiaoVien = new DataGridView();
            tabPage3 = new TabPage();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            TabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDSHocSinh).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDSGiaoVien).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
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
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(btnThem);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 157);
            panel2.Name = "panel2";
            panel2.Size = new Size(677, 45);
            panel2.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(544, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 39);
            btnBack.TabIndex = 1;
            btnBack.Text = "TRỞ LẠI";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(412, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 39);
            btnThem.TabIndex = 0;
            btnThem.Text = "THÊM";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(TabControl);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 208);
            panel3.Name = "panel3";
            panel3.Size = new Size(677, 304);
            panel3.TabIndex = 2;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabPage1);
            TabControl.Controls.Add(tabPage2);
            TabControl.Controls.Add(tabPage3);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(677, 304);
            TabControl.TabIndex = 1;
            TabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgDSHocSinh);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(669, 271);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgDSHocSinh
            // 
            dgDSHocSinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDSHocSinh.Dock = DockStyle.Fill;
            dgDSHocSinh.Location = new Point(3, 3);
            dgDSHocSinh.Name = "dgDSHocSinh";
            dgDSHocSinh.RowHeadersWidth = 51;
            dgDSHocSinh.Size = new Size(663, 265);
            dgDSHocSinh.TabIndex = 0;
            dgDSHocSinh.CellClick += dgDSHocSinh_CellClick;
            dgDSHocSinh.CellDoubleClick += dgDSHocSinh_CellDoubleClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgDSGiaoVien);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(669, 271);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgDSGiaoVien
            // 
            dgDSGiaoVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDSGiaoVien.Dock = DockStyle.Fill;
            dgDSGiaoVien.Location = new Point(3, 3);
            dgDSGiaoVien.Name = "dgDSGiaoVien";
            dgDSGiaoVien.RowHeadersWidth = 51;
            dgDSGiaoVien.Size = new Size(663, 265);
            dgDSGiaoVien.TabIndex = 0;
            dgDSGiaoVien.CellClick += dgDSGiaoVien_CellClick;
            dgDSGiaoVien.CellDoubleClick += dgDSGiaoVien_CellDoubleClick;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(669, 271);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
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
            panel3.ResumeLayout(false);
            TabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgDSHocSinh).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgDSGiaoVien).EndInit();
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
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dgDSGiaoVien;
    }
}