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
using QL_SNAC.QLHocSinh;

namespace QL_SNAC.QLDaoTao
{
    public partial class ucQLDaoTao : UserControl
    {
        private DaoTaoManager DTManager = null;
        private DataTable DSDaoTao = null;
        private string error = "";
        private Database DB = new Database();
        public ucQLDaoTao()
        {
            InitializeComponent();
            DTManager = new DaoTaoManager();
            DSDaoTao = null;
            LayDSDaoTao();
            
        }
        private void LayDSDaoTao()
        {
            try
            {
                var data = DTManager.HienThiDSDaoTao(ref error);
                if (data == null)
                {
                    MessageBox.Show(error);
                }
                else
                {
                    DSDaoTao = data;
                    dgDTNamHoc.DataSource = DSDaoTao;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private DaoTaoEntity DTDaChon = new DaoTaoEntity();
        private void dgDTNamHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgDTNamHoc.RowCount)
            {
                DataGridViewRow rowselected = dgDTNamHoc.Rows[e.RowIndex];

                #region Gan gia tri vao entity tai khoan da chon
                DTDaChon.ID_DAOTAO = rowselected.Cells["ID_DAOTAO"].Value.ToString();
                DTDaChon.NOIDUNG = rowselected.Cells["NOIDUNG"].Value.ToString();
                DTDaChon.NAM_BAT_DAU = int.Parse(rowselected.Cells["NAM_BAT_DAU"].Value.ToString());
                DTDaChon.NAM_KET_THUC = int.Parse(rowselected.Cells["NAM_KET_THUC"].Value.ToString());
                DTDaChon.NGAY_BAT_DAU = rowselected.Cells["NGAY_BAT_DAU"].Value.ToString();
                DTDaChon.NGAY_KET_THUC = rowselected.Cells["NGAY_KET_THUC"].Value.ToString();
              
                #endregion
                #region Hien thi gia tri len label
             

                #endregion
            }
        }

    }
}
