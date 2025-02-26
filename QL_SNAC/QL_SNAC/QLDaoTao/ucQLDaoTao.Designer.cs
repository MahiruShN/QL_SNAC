namespace QL_SNAC.QLDaoTao
{
    partial class ucQLDaoTao
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tb_QLDT = new TableLayoutPanel();
            panel1 = new Panel();
            listBox1 = new ListBox();
            lbTieuDe = new Label();
            panel2 = new Panel();
            dgDTNamHoc = new DataGridView();
            panel3 = new Panel();
            btnKhoa = new Button();
            btnSuaDT = new Button();
            btnChonDT = new Button();
            btnThemDT = new Button();
            panel7 = new Panel();
            tbDS = new TabControl();
            tbLop = new TabPage();
            dgLopHoc = new DataGridView();
            tbMon = new TabPage();
            dgDSMH = new DataGridView();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            dgDSHSLop = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            tb_QLDT.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDTNamHoc).BeginInit();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            tbDS.SuspendLayout();
            tbLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLopHoc).BeginInit();
            tbMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDSMH).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDSHSLop).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(tb_QLDT, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1812, 1440);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tb_QLDT
            // 
            tb_QLDT.BackColor = SystemColors.ActiveCaption;
            tb_QLDT.ColumnCount = 1;
            tb_QLDT.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tb_QLDT.Controls.Add(panel1, 0, 0);
            tb_QLDT.Controls.Add(panel2, 0, 1);
            tb_QLDT.Controls.Add(panel3, 0, 2);
            tb_QLDT.Controls.Add(panel7, 0, 3);
            tb_QLDT.Controls.Add(panel8, 0, 4);
            tb_QLDT.Controls.Add(panel9, 0, 5);
            tb_QLDT.Controls.Add(panel10, 0, 6);
            tb_QLDT.Controls.Add(panel11, 0, 7);
            tb_QLDT.Dock = DockStyle.Fill;
            tb_QLDT.Location = new Point(3, 3);
            tb_QLDT.Name = "tb_QLDT";
            tb_QLDT.RowCount = 8;
            tb_QLDT.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tb_QLDT.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tb_QLDT.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tb_QLDT.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tb_QLDT.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tb_QLDT.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tb_QLDT.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tb_QLDT.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tb_QLDT.Size = new Size(537, 1434);
            tb_QLDT.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(lbTieuDe);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 137);
            panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Tiểu học", "Trung học cơ sở", "Trung học phổ thông" });
            listBox1.Location = new Point(325, 21);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(134, 24);
            listBox1.TabIndex = 1;
            // 
            // lbTieuDe
            // 
            lbTieuDe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbTieuDe.AutoSize = true;
            lbTieuDe.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTieuDe.Location = new Point(19, 14);
            lbTieuDe.Name = "lbTieuDe";
            lbTieuDe.Size = new Size(258, 31);
            lbTieuDe.TabIndex = 0;
            lbTieuDe.Text = "DANH SÁCH ĐÀO TẠO";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(dgDTNamHoc);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(531, 280);
            panel2.TabIndex = 1;
            // 
            // dgDTNamHoc
            // 
            dgDTNamHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDTNamHoc.Dock = DockStyle.Fill;
            dgDTNamHoc.Location = new Point(0, 0);
            dgDTNamHoc.Name = "dgDTNamHoc";
            dgDTNamHoc.RowHeadersWidth = 51;
            dgDTNamHoc.Size = new Size(531, 280);
            dgDTNamHoc.TabIndex = 0;
            dgDTNamHoc.CellClick += dgDTNamHoc_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(btnKhoa);
            panel3.Controls.Add(btnSuaDT);
            panel3.Controls.Add(btnChonDT);
            panel3.Controls.Add(btnThemDT);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 432);
            panel3.Name = "panel3";
            panel3.Size = new Size(531, 137);
            panel3.TabIndex = 2;
            // 
            // btnKhoa
            // 
            btnKhoa.Location = new Point(344, 18);
            btnKhoa.Name = "btnKhoa";
            btnKhoa.Size = new Size(94, 29);
            btnKhoa.TabIndex = 3;
            btnKhoa.Text = "Khóa";
            btnKhoa.UseVisualStyleBackColor = true;
            // 
            // btnSuaDT
            // 
            btnSuaDT.Location = new Point(244, 18);
            btnSuaDT.Name = "btnSuaDT";
            btnSuaDT.Size = new Size(94, 29);
            btnSuaDT.TabIndex = 2;
            btnSuaDT.Text = "Cập Nhật";
            btnSuaDT.UseVisualStyleBackColor = true;
            // 
            // btnChonDT
            // 
            btnChonDT.Location = new Point(19, 18);
            btnChonDT.Name = "btnChonDT";
            btnChonDT.Size = new Size(94, 29);
            btnChonDT.TabIndex = 1;
            btnChonDT.Text = "Chọn";
            btnChonDT.UseVisualStyleBackColor = true;
            // 
            // btnThemDT
            // 
            btnThemDT.Location = new Point(144, 18);
            btnThemDT.Name = "btnThemDT";
            btnThemDT.Size = new Size(94, 29);
            btnThemDT.TabIndex = 0;
            btnThemDT.Text = "Thêm";
            btnThemDT.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaption;
            panel7.Controls.Add(tbDS);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 575);
            panel7.Name = "panel7";
            panel7.Size = new Size(531, 280);
            panel7.TabIndex = 3;
            // 
            // tbDS
            // 
            tbDS.Controls.Add(tbLop);
            tbDS.Controls.Add(tbMon);
            tbDS.Dock = DockStyle.Fill;
            tbDS.Location = new Point(0, 0);
            tbDS.Name = "tbDS";
            tbDS.SelectedIndex = 0;
            tbDS.Size = new Size(531, 280);
            tbDS.TabIndex = 1;
            // 
            // tbLop
            // 
            tbLop.Controls.Add(dgLopHoc);
            tbLop.Location = new Point(4, 29);
            tbLop.Name = "tbLop";
            tbLop.Padding = new Padding(3);
            tbLop.Size = new Size(523, 247);
            tbLop.TabIndex = 0;
            tbLop.Text = "Lớp Học";
            tbLop.UseVisualStyleBackColor = true;
            // 
            // dgLopHoc
            // 
            dgLopHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLopHoc.Dock = DockStyle.Fill;
            dgLopHoc.Location = new Point(3, 3);
            dgLopHoc.Name = "dgLopHoc";
            dgLopHoc.RowHeadersWidth = 51;
            dgLopHoc.Size = new Size(517, 241);
            dgLopHoc.TabIndex = 0;
            // 
            // tbMon
            // 
            tbMon.Controls.Add(dgDSMH);
            tbMon.Location = new Point(4, 29);
            tbMon.Name = "tbMon";
            tbMon.Padding = new Padding(3);
            tbMon.Size = new Size(523, 156);
            tbMon.TabIndex = 1;
            tbMon.Text = "Môn Học";
            tbMon.UseVisualStyleBackColor = true;
            // 
            // dgDSMH
            // 
            dgDSMH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDSMH.Dock = DockStyle.Fill;
            dgDSMH.Location = new Point(3, 3);
            dgDSMH.Name = "dgDSMH";
            dgDSMH.RowHeadersWidth = 51;
            dgDSMH.Size = new Size(517, 150);
            dgDSMH.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(3, 861);
            panel8.Name = "panel8";
            panel8.Size = new Size(531, 137);
            panel8.TabIndex = 4;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(3, 1004);
            panel9.Name = "panel9";
            panel9.Size = new Size(531, 137);
            panel9.TabIndex = 5;
            // 
            // panel10
            // 
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(3, 1147);
            panel10.Name = "panel10";
            panel10.Size = new Size(531, 137);
            panel10.TabIndex = 6;
            // 
            // panel11
            // 
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(3, 1290);
            panel11.Name = "panel11";
            panel11.Size = new Size(531, 141);
            panel11.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel4, 0, 0);
            tableLayoutPanel2.Controls.Add(panel5, 0, 1);
            tableLayoutPanel2.Controls.Add(panel6, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(546, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.Size = new Size(1263, 1434);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1257, 137);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 146);
            panel5.Name = "panel5";
            panel5.Size = new Size(1257, 424);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaption;
            panel6.Controls.Add(dgDSHSLop);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 576);
            panel6.Name = "panel6";
            panel6.Size = new Size(1257, 855);
            panel6.TabIndex = 2;
            // 
            // dgDSHSLop
            // 
            dgDSHSLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDSHSLop.Dock = DockStyle.Fill;
            dgDSHSLop.Location = new Point(0, 0);
            dgDSHSLop.Name = "dgDSHSLop";
            dgDSHSLop.RowHeadersWidth = 51;
            dgDSHSLop.Size = new Size(1257, 855);
            dgDSHSLop.TabIndex = 0;
            // 
            // ucQLDaoTao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ucQLDaoTao";
            Size = new Size(1812, 1440);
            tableLayoutPanel1.ResumeLayout(false);
            tb_QLDT.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgDTNamHoc).EndInit();
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            tbDS.ResumeLayout(false);
            tbLop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgLopHoc).EndInit();
            tbMon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgDSMH).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgDSHSLop).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tb_QLDT;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgDTNamHoc;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private DataGridView dgDSHSLop;
        private Panel panel7;
        private Label lbTieuDe;
        private Panel panel8;
        private Button btnKhoa;
        private Button btnSuaDT;
        private Button btnChonDT;
        private Button btnThemDT;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private ListBox listBox1;
        private TabControl tbDS;
        private TabPage tbLop;
        private DataGridView dgLopHoc;
        private TabPage tbMon;
        private DataGridView dgDSMH;
    }
}
