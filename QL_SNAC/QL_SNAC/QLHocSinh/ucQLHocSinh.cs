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
using DataAccessLayer.Responsitories;
using QL_SNAC.MainForm;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QL_SNAC.QLHocSinh
{
    public partial class ucQLHocSinh : UserControl
    {
        private HocSinhManager hocSinhManager = new HocSinhManager();


        public ucQLHocSinh()
        {
            InitializeComponent();
        }

        private void ucQLHocSinh_Load(object sender, EventArgs e)
        {
            string error = "";
            var dataTable = hocSinhManager.HienThiLocDSHSRutGon(ref error);

            if (dataTable != null)
            {
                dgvHocSinh.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Lỗi: " + error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
