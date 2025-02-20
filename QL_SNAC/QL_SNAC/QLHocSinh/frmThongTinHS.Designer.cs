namespace QL_SNAC.QLHocSinh
{
    partial class frmThongTinHS
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
            txtMSHS = new Label();
            txtHo = new Label();
            txtTen = new Label();
            txtNgaySinh = new Label();
            txtGioiTinh = new Label();
            txtDanToc = new Label();
            txtNoiSinh = new Label();
            txtDiaChi = new Label();
            txtQuocTich = new Label();
            btnEdit = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtMSHS
            // 
            txtMSHS.AutoSize = true;
            txtMSHS.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMSHS.Location = new Point(124, 66);
            txtMSHS.Name = "txtMSHS";
            txtMSHS.Size = new Size(83, 25);
            txtMSHS.TabIndex = 0;
            txtMSHS.Text = "txtMSHS";
            // 
            // txtHo
            // 
            txtHo.AutoSize = true;
            txtHo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHo.Location = new Point(124, 105);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(57, 25);
            txtHo.TabIndex = 1;
            txtHo.Text = "txtHo";
            // 
            // txtTen
            // 
            txtTen.AutoSize = true;
            txtTen.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTen.Location = new Point(244, 105);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(62, 25);
            txtTen.TabIndex = 2;
            txtTen.Text = "txtTen";
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.AutoSize = true;
            txtNgaySinh.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNgaySinh.Location = new Point(244, 152);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(114, 25);
            txtNgaySinh.TabIndex = 4;
            txtNgaySinh.Text = "txtNgaySinh";
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.AutoSize = true;
            txtGioiTinh.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGioiTinh.Location = new Point(124, 152);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(64, 25);
            txtGioiTinh.TabIndex = 3;
            txtGioiTinh.Text = "txtLop";
            // 
            // txtDanToc
            // 
            txtDanToc.AutoSize = true;
            txtDanToc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDanToc.Location = new Point(244, 199);
            txtDanToc.Name = "txtDanToc";
            txtDanToc.Size = new Size(95, 25);
            txtDanToc.TabIndex = 6;
            txtDanToc.Text = "txtDanToc";
            // 
            // txtNoiSinh
            // 
            txtNoiSinh.AutoSize = true;
            txtNoiSinh.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNoiSinh.Location = new Point(124, 199);
            txtNoiSinh.Name = "txtNoiSinh";
            txtNoiSinh.Size = new Size(100, 25);
            txtNoiSinh.TabIndex = 5;
            txtNoiSinh.Text = "txtNoiSinh";
            // 
            // txtDiaChi
            // 
            txtDiaChi.AutoSize = true;
            txtDiaChi.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiaChi.Location = new Point(125, 291);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(89, 25);
            txtDiaChi.TabIndex = 8;
            txtDiaChi.Text = "txtDiaChi";
            txtDiaChi.Click += label8_Click;
            // 
            // txtQuocTich
            // 
            txtQuocTich.AutoSize = true;
            txtQuocTich.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuocTich.Location = new Point(125, 245);
            txtQuocTich.Name = "txtQuocTich";
            txtQuocTich.Size = new Size(113, 25);
            txtQuocTich.TabIndex = 7;
            txtQuocTich.Text = "txtQuocTich";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(95, 388);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(119, 23);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Sửa thông tin";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(301, 388);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 10;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // frmThongTinHS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 580);
            Controls.Add(btnExit);
            Controls.Add(btnEdit);
            Controls.Add(txtDiaChi);
            Controls.Add(txtQuocTich);
            Controls.Add(txtDanToc);
            Controls.Add(txtNoiSinh);
            Controls.Add(txtNgaySinh);
            Controls.Add(txtGioiTinh);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(txtMSHS);
            Name = "frmThongTinHS";
            Text = "frmThongTinHS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtMSHS;
        private Label txtHo;
        private Label txtTen;
        private Label txtNgaySinh;
        private Label txtGioiTinh;
        private Label txtDanToc;
        private Label txtNoiSinh;
        private Label txtDiaChi;
        private Label txtQuocTich;
        private Button btnEdit;
        private Button btnExit;
    }
}