namespace QL_SNAC.Login
{
    partial class frmLogin
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            btnThoat = new Button();
            btnLogin = new Button();
            cboQuyen = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtMatkhau = new TextBox();
            txtEmail = new TextBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(794, 84);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(194, 3);
            label1.Name = "label1";
            label1.Size = new Size(400, 81);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(btnThoat);
            panel3.Controls.Add(btnLogin);
            panel3.Controls.Add(cboQuyen);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtMatkhau);
            panel3.Controls.Add(txtEmail);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(794, 354);
            panel3.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(477, 262);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(117, 42);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(153, 262);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(117, 42);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // cboQuyen
            // 
            cboQuyen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboQuyen.FormattingEnabled = true;
            cboQuyen.Items.AddRange(new object[] { "Giáo Viên", "ADMIN", "Học Sinh", "Giáo Viên Chủ Nhiệm", "Phụ Huynh", "Tuyển Sinh", "Quản Sinh" });
            cboQuyen.Location = new Point(254, 174);
            cboQuyen.Name = "cboQuyen";
            cboQuyen.Size = new Size(175, 36);
            cboQuyen.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(56, 170);
            label4.Name = "label4";
            label4.Size = new Size(118, 38);
            label4.TabIndex = 4;
            label4.Text = "Quyền :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 119);
            label3.Name = "label3";
            label3.Size = new Size(159, 38);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 65);
            label2.Name = "label2";
            label2.Size = new Size(105, 38);
            label2.TabIndex = 2;
            label2.Text = "Email :";
            // 
            // txtMatkhau
            // 
            txtMatkhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatkhau.Location = new Point(254, 123);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(307, 34);
            txtMatkhau.TabIndex = 1;
            txtMatkhau.Text = "1234";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(254, 69);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(307, 34);
            txtEmail.TabIndex = 0;
            txtEmail.Text = "caoanhnhat2107@gmail.com";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "frmLogin";
            Text = "Login";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private TextBox txtMatkhau;
        private TextBox txtEmail;
        private ComboBox cboQuyen;
        private Label label4;
        private Button btnLogin;
        private Button btnThoat;
    }
}