﻿namespace QL_SNAC.QLTaiKhoan
{
    partial class frmThemTaiKhoan
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
            lbTieuDe = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            radNgungHD = new RadioButton();
            radHoatDong = new RadioButton();
            label7 = new Label();
            lbMSNguoiDung = new Label();
            btnHS = new Button();
            lbIdTaiKhoan = new Label();
            txtRePass = new TextBox();
            txtPass = new TextBox();
            txtEmail = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            btnThoat = new Button();
            btnThem = new Button();
            cboQuyen = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(562, 633);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lbTieuDe);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 57);
            panel1.TabIndex = 0;
            // 
            // lbTieuDe
            // 
            lbTieuDe.AutoSize = true;
            lbTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTieuDe.Location = new Point(148, 6);
            lbTieuDe.Name = "lbTieuDe";
            lbTieuDe.Size = new Size(277, 41);
            lbTieuDe.TabIndex = 0;
            lbTieuDe.Text = "THÊM TÀI KHOẢN";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(cboQuyen);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(lbMSNguoiDung);
            panel2.Controls.Add(btnHS);
            panel2.Controls.Add(lbIdTaiKhoan);
            panel2.Controls.Add(txtRePass);
            panel2.Controls.Add(txtPass);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Microsoft Sans Serif", 13.8F);
            panel2.Location = new Point(3, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(556, 437);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(radNgungHD);
            panel4.Controls.Add(radHoatDong);
            panel4.Location = new Point(240, 310);
            panel4.Name = "panel4";
            panel4.Size = new Size(299, 50);
            panel4.TabIndex = 21;
            // 
            // radNgungHD
            // 
            radNgungHD.AutoSize = true;
            radNgungHD.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radNgungHD.Location = new Point(119, 17);
            radNgungHD.Name = "radNgungHD";
            radNgungHD.Size = new Size(173, 29);
            radNgungHD.TabIndex = 1;
            radNgungHD.TabStop = true;
            radNgungHD.Text = "Ngưng Sử Dụng";
            radNgungHD.UseVisualStyleBackColor = true;
            // 
            // radHoatDong
            // 
            radHoatDong.AutoSize = true;
            radHoatDong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radHoatDong.Location = new Point(3, 17);
            radHoatDong.Name = "radHoatDong";
            radHoatDong.Size = new Size(110, 29);
            radHoatDong.TabIndex = 0;
            radHoatDong.TabStop = true;
            radHoatDong.Text = "Sử Dụng";
            radHoatDong.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F);
            label7.Location = new Point(9, 331);
            label7.Name = "label7";
            label7.Size = new Size(143, 29);
            label7.TabIndex = 20;
            label7.Text = "Tình Trạng :";
            // 
            // lbMSNguoiDung
            // 
            lbMSNguoiDung.AutoSize = true;
            lbMSNguoiDung.Font = new Font("Microsoft Sans Serif", 13.8F);
            lbMSNguoiDung.Location = new Point(240, 268);
            lbMSNguoiDung.Name = "lbMSNguoiDung";
            lbMSNguoiDung.Size = new Size(85, 29);
            lbMSNguoiDung.TabIndex = 19;
            lbMSNguoiDung.Text = "............";
            // 
            // btnHS
            // 
            btnHS.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnHS.Location = new Point(493, 261);
            btnHS.Name = "btnHS";
            btnHS.Size = new Size(46, 36);
            btnHS.TabIndex = 15;
            btnHS.Text = "...";
            btnHS.UseVisualStyleBackColor = true;
            btnHS.Click += btnHS_Click;
            // 
            // lbIdTaiKhoan
            // 
            lbIdTaiKhoan.AutoSize = true;
            lbIdTaiKhoan.Font = new Font("Microsoft Sans Serif", 13.8F);
            lbIdTaiKhoan.Location = new Point(240, 45);
            lbIdTaiKhoan.Name = "lbIdTaiKhoan";
            lbIdTaiKhoan.Size = new Size(85, 29);
            lbIdTaiKhoan.TabIndex = 11;
            lbIdTaiKhoan.Text = "............";
            // 
            // txtRePass
            // 
            txtRePass.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtRePass.Location = new Point(240, 208);
            txtRePass.Name = "txtRePass";
            txtRePass.Size = new Size(299, 34);
            txtRePass.TabIndex = 8;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtPass.Location = new Point(240, 152);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(299, 34);
            txtPass.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtEmail.Location = new Point(240, 95);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(299, 34);
            txtEmail.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F);
            label6.Location = new Point(9, 384);
            label6.Name = "label6";
            label6.Size = new Size(181, 29);
            label6.TabIndex = 5;
            label6.Text = "Quyền Sử Dụng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F);
            label5.Location = new Point(9, 268);
            label5.Name = "label5";
            label5.Size = new Size(180, 29);
            label5.TabIndex = 4;
            label5.Text = "Mã Người Dùng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F);
            label4.Location = new Point(9, 213);
            label4.Name = "label4";
            label4.Size = new Size(215, 29);
            label4.TabIndex = 3;
            label4.Text = "Nhập Lại Mật Khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F);
            label3.Location = new Point(9, 157);
            label3.Name = "label3";
            label3.Size = new Size(113, 29);
            label3.TabIndex = 2;
            label3.Text = "Mật Khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F);
            label2.Location = new Point(9, 100);
            label2.Name = "label2";
            label2.Size = new Size(74, 29);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F);
            label1.Location = new Point(9, 45);
            label1.Name = "label1";
            label1.Size = new Size(148, 29);
            label1.TabIndex = 0;
            label1.Text = "ID Tài khoản";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(btnThoat);
            panel3.Controls.Add(btnThem);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 509);
            panel3.Name = "panel3";
            panel3.Size = new Size(556, 121);
            panel3.TabIndex = 2;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(328, 41);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(154, 41);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(57, 41);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(154, 41);
            btnThem.TabIndex = 0;
            btnThem.Text = "THÊM";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cboQuyen
            // 
            cboQuyen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboQuyen.FormattingEnabled = true;
            cboQuyen.Items.AddRange(new object[] { "Giáo Viên", "ADMIN", "Học Sinh", "Giáo Viên Chủ Nhiệm", "Phụ Huynh", "Tuyển Sinh", "Quản Sinh" });
            cboQuyen.Location = new Point(240, 384);
            cboQuyen.Name = "cboQuyen";
            cboQuyen.Size = new Size(299, 36);
            cboQuyen.TabIndex = 23;
            // 
            // frmThemTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 633);
            Controls.Add(tableLayoutPanel1);
            Name = "frmThemTaiKhoan";
            Text = "frmThemTaiKhoan";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label lbTieuDe;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lbIdTaiKhoan;
        private TextBox txtRePass;
        private TextBox txtPass;
        private TextBox txtEmail;
        private Button btnThoat;
        private Button btnThem;
        private Button btnHS;
        private Label lbMSNguoiDung;
        private Label label7;
        private Panel panel4;
        private RadioButton radNgungHD;
        private RadioButton radHoatDong;
        private ComboBox cboQuyen;
    }
}