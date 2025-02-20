namespace QL_SNAC.QLHocSinh
{
    partial class frmEditHocSinh
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
            btnSave = new Button();
            txtMSHS = new TextBox();
            txtHo = new TextBox();
            txtTen = new TextBox();
            txtGioiTinh = new TextBox();
            txtDCThuongTru = new TextBox();
            txtNoiSinh = new TextBox();
            txtDCTamTru = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtNgaySinh = new DateTimePicker();
            txtDanToc = new TextBox();
            txtQuocTich = new TextBox();
            txtDiaChi = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(142, 481);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // txtMSHS
            // 
            txtMSHS.Font = new Font("Segoe UI", 13F);
            txtMSHS.Location = new Point(241, 60);
            txtMSHS.Name = "txtMSHS";
            txtMSHS.Size = new Size(192, 31);
            txtMSHS.TabIndex = 1;
            // 
            // txtHo
            // 
            txtHo.Font = new Font("Segoe UI", 13F);
            txtHo.Location = new Point(241, 97);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(161, 31);
            txtHo.TabIndex = 2;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 13F);
            txtTen.Location = new Point(406, 97);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(202, 31);
            txtTen.TabIndex = 3;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Font = new Font("Segoe UI", 13F);
            txtGioiTinh.Location = new Point(241, 134);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(192, 31);
            txtGioiTinh.TabIndex = 4;
            txtGioiTinh.TextChanged += txtGioiTinh_TextChanged;
            // 
            // txtDCThuongTru
            // 
            txtDCThuongTru.Font = new Font("Segoe UI", 13F);
            txtDCThuongTru.Location = new Point(241, 350);
            txtDCThuongTru.Name = "txtDCThuongTru";
            txtDCThuongTru.Size = new Size(367, 31);
            txtDCThuongTru.TabIndex = 8;
            // 
            // txtNoiSinh
            // 
            txtNoiSinh.Font = new Font("Segoe UI", 13F);
            txtNoiSinh.Location = new Point(241, 208);
            txtNoiSinh.Name = "txtNoiSinh";
            txtNoiSinh.Size = new Size(367, 31);
            txtNoiSinh.TabIndex = 6;
            // 
            // txtDCTamTru
            // 
            txtDCTamTru.Font = new Font("Segoe UI", 13F);
            txtDCTamTru.Location = new Point(241, 387);
            txtDCTamTru.Name = "txtDCTamTru";
            txtDCTamTru.Size = new Size(367, 31);
            txtDCTamTru.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(127, 66);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 10;
            label1.Text = "MSSH";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(127, 100);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 11;
            label2.Text = "Họ và tên";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(127, 168);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 13;
            label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(127, 134);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 12;
            label4.Text = "Giới tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(127, 242);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 15;
            label5.Text = "Dân tộc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.Location = new Point(127, 208);
            label6.Name = "label6";
            label6.Size = new Size(77, 25);
            label6.TabIndex = 14;
            label6.Text = "Nơi sinh";
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.Location = new Point(241, 179);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new Size(200, 23);
            dtNgaySinh.TabIndex = 19;
            // 
            // txtDanToc
            // 
            txtDanToc.Font = new Font("Segoe UI", 12F);
            txtDanToc.Location = new Point(241, 245);
            txtDanToc.Name = "txtDanToc";
            txtDanToc.Size = new Size(100, 29);
            txtDanToc.TabIndex = 20;
            // 
            // txtQuocTich
            // 
            txtQuocTich.Font = new Font("Segoe UI", 12F);
            txtQuocTich.Location = new Point(241, 280);
            txtQuocTich.Name = "txtQuocTich";
            txtQuocTich.Size = new Size(100, 29);
            txtQuocTich.TabIndex = 21;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 12F);
            txtDiaChi.Location = new Point(241, 315);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(367, 29);
            txtDiaChi.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.Location = new Point(127, 282);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 23;
            label7.Text = "Quốc tịch";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13F);
            label8.Location = new Point(127, 317);
            label8.Name = "label8";
            label8.Size = new Size(65, 25);
            label8.TabIndex = 24;
            label8.Text = "Địa chỉ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F);
            label9.Location = new Point(127, 353);
            label9.Name = "label9";
            label9.Size = new Size(101, 25);
            label9.TabIndex = 25;
            label9.Text = "Thường trú";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13F);
            label10.Location = new Point(127, 390);
            label10.Name = "label10";
            label10.Size = new Size(73, 25);
            label10.TabIndex = 26;
            label10.Text = "Tạm trú";
            // 
            // frmEditHocSinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 642);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtDiaChi);
            Controls.Add(txtQuocTich);
            Controls.Add(txtDanToc);
            Controls.Add(dtNgaySinh);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDCTamTru);
            Controls.Add(txtDCThuongTru);
            Controls.Add(txtNoiSinh);
            Controls.Add(txtGioiTinh);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(txtMSHS);
            Controls.Add(btnSave);
            Name = "frmEditHocSinh";
            Text = "frmEditHocSinh";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtMSHS;
        private TextBox txtHo;
        private TextBox txtTen;
        private TextBox txtGioiTinh;
        private TextBox txtDCThuongTru;
        private TextBox txtNoiSinh;
        private TextBox txtDCTamTru;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
     
        
     
        private DateTimePicker dtNgaySinh;
        private TextBox txtDanToc;
        private TextBox txtQuocTich;
        private TextBox txtDiaChi;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}