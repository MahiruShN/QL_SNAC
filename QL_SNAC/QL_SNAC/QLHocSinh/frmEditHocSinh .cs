using BusinessLogicLayer.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SNAC.QLHocSinh
{
    public partial class frmEditHocSinh : Form
    {
        private HocSinhManager _manager;
        private DataRow _hocSinhRow;
        public frmEditHocSinh(DataRow hocSinhRow)
        {

            InitializeComponent();

            _manager = new HocSinhManager();
            _hocSinhRow = hocSinhRow;
            LoadData();
        }

        private void LoadData()
        {
            if (_hocSinhRow != null)
            {
                txtMSHS.Text = _hocSinhRow["MSHS"].ToString();
                txtHo.Text = _hocSinhRow["HO"].ToString();
                txtTen.Text = _hocSinhRow["TEN"].ToString();
                txtGioiTinh.Text = _hocSinhRow["GIOITINH"].ToString();
                dtNgaySinh.Value = DateTime.ParseExact(_hocSinhRow["NGAY_SINH"].ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                txtNoiSinh.Text = _hocSinhRow["NOI_SINH"].ToString();
                txtDanToc.Text = _hocSinhRow["DAN_TOC"].ToString();
                txtQuocTich.Text = _hocSinhRow["QUOC_TICH"].ToString();
                txtDiaChi.Text = _hocSinhRow["DIA_CHI"].ToString();
                txtDCThuongTru.Text = _hocSinhRow["DIA_CHI_THUONG_TRU"].ToString();
                txtDCTamTru.Text = _hocSinhRow["DIA_CHI_TAM_TRU"].ToString();

                // Disable editing of MSHS
                txtMSHS.ReadOnly = true;
            }
        }

        private HocSinhManager hocSinhManager = new HocSinhManager();

        private void button1_Click(object sender, EventArgs e)
        {
            string error = "";

            // Call manager to update student data
            bool success = _manager.UpdateHocSinh(
                Convert.ToInt32(txtMSHS.Text), txtHo.Text, txtTen.Text,
                txtGioiTinh.Text, dtNgaySinh.Value, txtNoiSinh.Text,
                txtDanToc.Text, txtQuocTich.Text, txtDiaChi.Text,
                txtDCThuongTru.Text, txtDCTamTru.Text, ref error
            );

            if (success)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Notify frmThongTinHocSinh to reload data
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi cập nhật: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtGioiTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
