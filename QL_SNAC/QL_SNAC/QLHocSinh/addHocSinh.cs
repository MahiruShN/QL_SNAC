using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.Manager;
using DataAccessLayer.Entity;

namespace QL_SNAC.QLHocSinh
{
    public partial class addHocSinh : Form
    {
        private HocSinhManager HSManager;
        private string error = "";
        public addHocSinh()
        {
            InitializeComponent();
            HSManager = new HocSinhManager();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            HocSinhEntity hs = new HocSinhEntity();
            hs.Ho = txtHo.Text;
            hs.Ten = txtTen.Text;
            hs.Gioitinh = txtGioiTinh.Text;
            hs.NgaySinh = dtNgaySinh.Value.ToString("dd-MM-yyyy");
            hs.NoiSinh = txtNoiSinh.Text;
            hs.DanToc = txtDanToc.Text;
            hs.QuocTich = txtQuocTich.Text;
            hs.Tinh = txtTinh.Text; // Get values from UI controls
            hs.Huyen = txtHuyen.Text;
            hs.Xa = txtXa.Text;
            hs.Diachi = txtDiaChi.Text;
            hs.DCThuongTru = txtDCThuongTru.Text;
            hs.DCTamTru = txtDCTamTru.Text;

            string error = "";
            bool success = HSManager.ThemHocSinh(hs, ref error);

            if (success)
            {
                MessageBox.Show("Student added successfully!");
                this.DialogResult = DialogResult.OK; // Set dialog result for parent form
                this.Close();
            }
            else
            {
                MessageBox.Show("Error adding student: " + error);
            }
        }
    }
}
