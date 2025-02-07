using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Responsitories
{
    public class TaiKhoanResponsitory
    {
        private Database DB = new Database();
        public DataTable HienThiDanhSachTaiKhoan(ref string error)
        {
            try
            {
                string sql = " select EMAIL,PASS, TINH_TRANG,MS_NGUOI_DUNG,QUYEN , NGAY_TAO, NGUOI_TAO " +
                             " from TAI_KHOAN where TINH_TRANG = 'true' ";
                var rs = DB.GetDataFromDB(sql, CommandType.Text, ref error);
                return rs;
            }
            catch (Exception ex)
            {
                error = "Ket noi lôi: " + ex.Message;
                return null;
            }
        }
    }
}
