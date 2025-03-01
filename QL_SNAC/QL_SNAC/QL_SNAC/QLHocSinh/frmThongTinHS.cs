using BusinessLogicLayer.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SNAC.QLHocSinh
{
    public partial class frmThongTinHS : Form
    {
        private DataRow _hocSinhRow;
        public frmThongTinHS(DataRow hocSinhRow)
        {
            InitializeComponent();
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
                txtNgaySinh.Text = _hocSinhRow["NGAY_SINH"].ToString();
                txtNoiSinh.Text = _hocSinhRow["NOI_SINH"].ToString();
                txtDanToc.Text = _hocSinhRow["DAN_TOC"].ToString();
                txtQuocTich.Text = _hocSinhRow["QUOC_TICH"].ToString();
                txtTonGiao.Text = _hocSinhRow["TONGIAO"].ToString();
                string diaChi = $"{_hocSinhRow["DIA_CHI"]}, {_hocSinhRow["XA"]}, {_hocSinhRow["HUYEN"]}, {_hocSinhRow["TINH"]}";
                string thuongTru = _hocSinhRow["DIA_CHI_THUONG_TRU"].ToString();
                string tamTru = _hocSinhRow["DIA_CHI_TAM_TRU"].ToString();

                txtDiaChi.Text = $"🏠 Địa chỉ: {diaChi}\n📌 Thường trú: {thuongTru}\n📍 Tạm trú: {tamTru}";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            addHocSinh editForm = new addHocSinh(_hocSinhRow);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Reload data after editing
                LoadData();
            }
        }
    }
}




