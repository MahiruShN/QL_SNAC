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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvHocSinh).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHocSinh
            // 
            dgvHocSinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHocSinh.Location = new Point(3, 3);
            dgvHocSinh.Name = "dgvHocSinh";
            dgvHocSinh.Size = new Size(1671, 802);
            dgvHocSinh.TabIndex = 0;
            dgvHocSinh.CellClick += dgvHocSinh_CellClick;
            dgvHocSinh.CellContentClick += dgvHocSinh_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 166);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 911);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(3, 163);
            button3.Name = "button3";
            button3.Size = new Size(231, 74);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 83);
            button2.Name = "button2";
            button2.Size = new Size(231, 74);
            button2.TabIndex = 1;
            button2.Text = "Thêm học sinh";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(231, 74);
            button1.TabIndex = 0;
            button1.Text = "Thêm học sinh";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvHocSinh);
            panel2.Location = new Point(246, 166);
            panel2.Name = "panel2";
            panel2.Size = new Size(1671, 911);
            panel2.TabIndex = 2;
            // 
            // ucQLHocSinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ucQLHocSinh";
            Size = new Size(1920, 1080);
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
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
