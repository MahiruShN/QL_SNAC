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

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string mshs = dgvHocSinh.Rows[e.RowIndex].Cells["MSHS"].Value.ToString();
                string error = "";

                DataTable dt = hocSinhManager.GetHocSinhByMSHS(mshs, ref error);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    // Open the new form and pass the selected row data
                    frmThongTinHS detailsForm = new frmThongTinHS(row);
                    detailsForm.ShowDialog(); // Opens as a modal form
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin học sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
