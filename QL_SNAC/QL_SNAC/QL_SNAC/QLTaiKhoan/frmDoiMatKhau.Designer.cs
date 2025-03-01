namespace QL_SNAC.QLTaiKhoan
{
    partial class frmDoiMatKhau
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
            lbEmail = new Label();
            lbIdTaiKhoan = new Label();
            txtRePass = new TextBox();
            txtPassMoi = new TextBox();
            txtPassCu = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            btnThoat = new Button();
            btnCapNhat = new Button();
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(551, 500);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lbTieuDe);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(545, 94);
            panel1.TabIndex = 0;
            // 
            // lbTieuDe
            // 
            lbTieuDe.AutoSize = true;
            lbTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTieuDe.Location = new Point(171, 26);
            lbTieuDe.Name = "lbTieuDe";
            lbTieuDe.Size = new Size(242, 41);
            lbTieuDe.TabIndex = 0;
            lbTieuDe.Text = "ĐỔI MẬT KHẨU";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(lbEmail);
            panel2.Controls.Add(lbIdTaiKhoan);
            panel2.Controls.Add(txtRePass);
            panel2.Controls.Add(txtPassMoi);
            panel2.Controls.Add(txtPassCu);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(545, 294);
            panel2.TabIndex = 1;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(117, 67);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(76, 28);
            lbEmail.TabIndex = 10;
            lbEmail.Text = "................";
            // 
            // lbIdTaiKhoan
            // 
            lbIdTaiKhoan.AutoSize = true;
            lbIdTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbIdTaiKhoan.Location = new Point(117, 21);
            lbIdTaiKhoan.Name = "lbIdTaiKhoan";
            lbIdTaiKhoan.Size = new Size(76, 28);
            lbIdTaiKhoan.TabIndex = 9;
            lbIdTaiKhoan.Text = "................";
            // 
            // txtRePass
            // 
            txtRePass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRePass.Location = new Point(248, 236);
            txtRePass.Name = "txtRePass";
            txtRePass.Size = new Size(272, 34);
            txtRePass.TabIndex = 8;
            // 
            // txtPassMoi
            // 
            txtPassMoi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassMoi.Location = new Point(248, 169);
            txtPassMoi.Name = "txtPassMoi";
            txtPassMoi.Size = new Size(272, 34);
            txtPassMoi.TabIndex = 7;
            // 
            // txtPassCu
            // 
            txtPassCu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassCu.Location = new Point(248, 115);
            txtPassCu.Name = "txtPassCu";
            txtPassCu.Size = new Size(272, 34);
            txtPassCu.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F);
            label6.Location = new Point(20, 241);
            label6.Name = "label6";
            label6.Size = new Size(227, 29);
            label6.TabIndex = 5;
            label6.Text = "Nhập Lại Mật Khẩu :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F);
            label5.Location = new Point(20, 174);
            label5.Name = "label5";
            label5.Size = new Size(171, 29);
            label5.TabIndex = 4;
            label5.Text = "Mật Khẩu Mới :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F);
            label4.Location = new Point(20, 120);
            label4.Name = "label4";
            label4.Size = new Size(161, 29);
            label4.TabIndex = 3;
            label4.Text = "Mật Khẩu Cũ :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F);
            label2.Location = new Point(20, 67);
            label2.Name = "label2";
            label2.Size = new Size(86, 29);
            label2.TabIndex = 2;
            label2.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F);
            label3.Location = new Point(20, 20);
            label3.Name = "label3";
            label3.Size = new Size(48, 29);
            label3.TabIndex = 1;
            label3.Text = "ID :";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(btnThoat);
            panel3.Controls.Add(btnCapNhat);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 403);
            panel3.Name = "panel3";
            panel3.Size = new Size(545, 94);
            panel3.TabIndex = 2;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(353, 24);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(117, 51);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.Location = new Point(93, 24);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(117, 51);
            btnCapNhat.TabIndex = 0;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 500);
            Controls.Add(tableLayoutPanel1);
            Name = "frmDoiMatKhau";
            Text = "Đổi Mật Khẩu";
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
        private Button btnThoat;
        private Button btnCapNhat;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtPassCu;
        private Label lbEmail;
        private Label lbIdTaiKhoan;
        private TextBox txtRePass;
        private TextBox txtPassMoi;
    }
}