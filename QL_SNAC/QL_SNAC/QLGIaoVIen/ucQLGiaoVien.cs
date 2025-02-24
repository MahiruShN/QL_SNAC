using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_SNAC.QLHocSinh;
using static System.Runtime.InteropServices.JavaScript.JSType;
using BusinessLogicLayer.Manager;
using DataAccessLayer.Entity;

namespace QL_SNAC.QLGIaoVIen
{
    public partial class ucQLGiaoVien : UserControl
    {
        private GiaoVienManager GvManager = new GiaoVienManager();
        private DataTable DsGiaoVien = null;
        private string error = "";

        public ucQLGiaoVien()
        {
            InitializeComponent();
            LayDSGiaoVien();
        }

        private void LayDSGiaoVien()
        {
            try
            {
                var data = GvManager.HienThiDSGVFull(ref error);
                if (data == null)
                {
                    MessageBox.Show(error);
                }
                else
                {
                    DsGiaoVien = data;
                    dgvGiaoVien.DataSource = DsGiaoVien;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbTieuDe_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            addGiaoVien frm = new addGiaoVien();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LayDSGiaoVien();
            }
        }

        private void dgvGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvGiaoVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một giáo viên trước khi cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvGiaoVien.SelectedRows[0];

            GiaoVienEntity gv = new GiaoVienEntity
            {
                MSGV = row.Cells["MSGV"].Value?.ToString() ?? "",
                Ho = row.Cells["HO"].Value?.ToString() ?? "",
                Ten = row.Cells["TEN"].Value?.ToString() ?? "",
                GioiTinh = row.Cells["GIOITINH"].Value?.ToString() ?? "",
                NgaySinh = row.Cells["NGAY_SINH"].Value != DBNull.Value ? DateOnly.FromDateTime(Convert.ToDateTime(row.Cells["NGAY_SINH"].Value)) : default,
                DanToc = row.Cells["DAN_TOC"].Value?.ToString() ?? "",
                QuocTich = row.Cells["QUOC_TICH"].Value?.ToString() ?? "",
                TonGiao = row.Cells["TON_GIAO"].Value?.ToString() ?? "",
                DiaChiThuongTru = row.Cells["DIA_CHI_THUONG_TRU"].Value?.ToString() ?? "",
                DiaChiTamTru = row.Cells["DIA_CHI_TAM_TRU"].Value?.ToString() ?? "",
                MaSoThue = row.Cells["MA_SO_THUE"].Value?.ToString() ?? "",
                BHXH = row.Cells["BHXH"].Value?.ToString() ?? "",
                CCCD = row.Cells["CCCD"].Value?.ToString() ?? "",
                SDT = row.Cells["SDT"].Value?.ToString() ?? "",
                NgayVaoLam = row.Cells["NGAY_VAO_LAM"].Value != DBNull.Value ? DateOnly.FromDateTime(Convert.ToDateTime(row.Cells["NGAY_VAO_LAM"].Value)) : default,
                Email = row.Cells["EMAIL"].Value?.ToString() ?? "",
                ChuyenNganhHoc = row.Cells["CHUYEN_NGANH_HOC"].Value?.ToString() ?? "",
                NamTotNghiep = row.Cells["NAM_TOT_NGHIEP"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["NAM_TOT_NGHIEP"].Value) : 0,
                LoaiBang = row.Cells["LOAI_BANG"].Value?.ToString() ?? "",
                Truong = row.Cells["TRUONG"].Value?.ToString() ?? "",
                ChuyenMonDay = row.Cells["CHUYEN_MON_DAY"].Value?.ToString() ?? "",
                ToChuyenMon = row.Cells["TO_CHUYEN_MON"].Value?.ToString() ?? "",
                ChucVu = row.Cells["CHUC_VU"].Value?.ToString() ?? "",
                TrinhDo = row.Cells["TRINHDO"].Value?.ToString() ?? ""
            };


            editGiaoVien updateForm = new editGiaoVien(gv);
            updateForm.ShowDialog();
            LayDSGiaoVien();
        }
    }
}
