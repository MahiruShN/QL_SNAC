namespace QL_SNAC.QLTaiKhoan
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
            lbMSNguoiDung = new Label();
            btnPH = new Button();
            btnHS = new Button();
            btnGV = new Button();
            lbIdTaiKhoan = new Label();
            txtQuyen = new TextBox();
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
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(554, 633);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lbTieuDe);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 57);
            panel1.TabIndex = 0;
            // 
            // lbTieuDe
            // 
            lbTieuDe.AutoSize = true;
            lbTieuDe.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTieuDe.Location = new Point(166, 17);
            lbTieuDe.Name = "lbTieuDe";
            lbTieuDe.Size = new Size(210, 31);
            lbTieuDe.TabIndex = 0;
            lbTieuDe.Text = "THÊM TÀI KHOẢN";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(lbMSNguoiDung);
            panel2.Controls.Add(btnPH);
            panel2.Controls.Add(btnHS);
            panel2.Controls.Add(btnGV);
            panel2.Controls.Add(lbIdTaiKhoan);
            panel2.Controls.Add(txtQuyen);
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
            panel2.Location = new Point(3, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(548, 437);
            panel2.TabIndex = 1;
            // 
            // lbMSNguoiDung
            // 
            lbMSNguoiDung.AutoSize = true;
            lbMSNguoiDung.Location = new Point(223, 269);
            lbMSNguoiDung.Name = "lbMSNguoiDung";
            lbMSNguoiDung.Size = new Size(60, 20);
            lbMSNguoiDung.TabIndex = 17;
            lbMSNguoiDung.Text = ".................";
            // 
            // btnPH
            // 
            btnPH.Location = new Point(426, 311);
            btnPH.Name = "btnPH";
            btnPH.Size = new Size(81, 31);
            btnPH.TabIndex = 16;
            btnPH.Text = "PH";
            btnPH.UseVisualStyleBackColor = true;
            // 
            // btnHS
            // 
            btnHS.Location = new Point(328, 311);
            btnHS.Name = "btnHS";
            btnHS.Size = new Size(81, 31);
            btnHS.TabIndex = 15;
            btnHS.Text = "Học Sinh";
            btnHS.UseVisualStyleBackColor = true;
            btnHS.Click += btnHS_Click;
            // 
            // btnGV
            // 
            btnGV.Location = new Point(223, 311);
            btnGV.Name = "btnGV";
            btnGV.Size = new Size(81, 31);
            btnGV.TabIndex = 14;
            btnGV.Text = "Giáo Viên";
            btnGV.UseVisualStyleBackColor = true;
            btnGV.Click += btnGV_Click;
            // 
            // lbIdTaiKhoan
            // 
            lbIdTaiKhoan.AutoSize = true;
            lbIdTaiKhoan.Location = new Point(223, 51);
            lbIdTaiKhoan.Name = "lbIdTaiKhoan";
            lbIdTaiKhoan.Size = new Size(45, 20);
            lbIdTaiKhoan.TabIndex = 11;
            lbIdTaiKhoan.Text = "............";
            // 
            // txtQuyen
            // 
            txtQuyen.Location = new Point(223, 363);
            txtQuyen.Name = "txtQuyen";
            txtQuyen.Size = new Size(284, 27);
            txtQuyen.TabIndex = 10;
            // 
            // txtRePass
            // 
            txtRePass.Location = new Point(223, 201);
            txtRePass.Name = "txtRePass";
            txtRePass.Size = new Size(284, 27);
            txtRePass.TabIndex = 8;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(223, 147);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(284, 27);
            txtPass.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(223, 99);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(284, 27);
            txtEmail.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(33, 363);
            label6.Name = "label6";
            label6.Size = new Size(150, 28);
            label6.TabIndex = 5;
            label6.Text = "Quyền Sử Dụng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(33, 261);
            label5.Name = "label5";
            label5.Size = new Size(154, 28);
            label5.TabIndex = 4;
            label5.Text = "Mã Người Dùng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(33, 197);
            label4.Name = "label4";
            label4.Size = new Size(178, 28);
            label4.TabIndex = 3;
            label4.Text = "Nhập Lại Mật Khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(33, 143);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 2;
            label3.Text = "Mật Khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(33, 95);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(33, 43);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
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
            panel3.Size = new Size(548, 121);
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
            // frmThemTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 633);
            Controls.Add(tableLayoutPanel1);
            Name = "frmThemTaiKhoan";
            Text = "frmThemTaiKhoan";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private TextBox txtQuyen;
        private TextBox txtRePass;
        private TextBox txtPass;
        private TextBox txtEmail;
        private Button btnThoat;
        private Button btnThem;
        private Button btnPH;
        private Button btnHS;
        private Button btnGV;
        private Label lbMSNguoiDung;
    }
}