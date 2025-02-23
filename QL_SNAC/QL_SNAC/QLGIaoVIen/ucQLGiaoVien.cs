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
    }
}
