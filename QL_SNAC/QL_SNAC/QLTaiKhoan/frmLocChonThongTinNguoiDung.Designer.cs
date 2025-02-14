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
            dgDSNguoiDung = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDSNguoiDung).BeginInit();
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
            panel3.Controls.Add(dgDSNguoiDung);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 208);
            panel3.Name = "panel3";
            panel3.Size = new Size(677, 304);
            panel3.TabIndex = 2;
            // 
            // dgDSNguoiDung
            // 
            dgDSNguoiDung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDSNguoiDung.Dock = DockStyle.Fill;
            dgDSNguoiDung.Location = new Point(0, 0);
            dgDSNguoiDung.Name = "dgDSNguoiDung";
            dgDSNguoiDung.RowHeadersWidth = 51;
            dgDSNguoiDung.Size = new Size(677, 304);
            dgDSNguoiDung.TabIndex = 0;
            dgDSNguoiDung.CellClick += dgDSNguoiDung_CellClick;
            dgDSNguoiDung.CellDoubleClick += dgDSNguoiDung_CellDoubleClick;
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
            ((System.ComponentModel.ISupportInitialize)dgDSNguoiDung).EndInit();
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
        private DataGridView dgDSNguoiDung;
        private Button btnBack;
        private Button btnThem;
    }
}