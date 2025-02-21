namespace QL_SNAC.QLHocSinh
{
    partial class ucQLHocSinh
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvHocSinh = new DataGridView();
            panel1 = new Panel();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvHocSinh).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHocSinh
            // 
            dgvHocSinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHocSinh.Location = new Point(3, 4);
            dgvHocSinh.Margin = new Padding(3, 4, 3, 4);
            dgvHocSinh.Name = "dgvHocSinh";
            dgvHocSinh.RowHeadersWidth = 51;
            dgvHocSinh.Size = new Size(1910, 1069);
            dgvHocSinh.TabIndex = 0;
            dgvHocSinh.CellClick += dgvHocSinh_CellClick;
            dgvHocSinh.CellContentClick += dgvHocSinh_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Location = new Point(3, 221);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 1215);
            panel1.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(7, 426);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(264, 99);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(3, 217);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(264, 99);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa Học Sinh";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(3, 111);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(264, 99);
            btnSua.TabIndex = 1;
            btnSua.Text = "Cập Nhật Học Sinh";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(3, 4);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(264, 99);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm học sinh";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvHocSinh);
            panel2.Location = new Point(281, 221);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1910, 1215);
            panel2.TabIndex = 2;
            // 
            // ucQLHocSinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ucQLHocSinh";
            Size = new Size(2194, 1440);
            Load += ucQLHocSinh_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHocSinh).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHocSinh;
        private Panel panel1;
        private Panel panel2;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnThoat;
    }
}
