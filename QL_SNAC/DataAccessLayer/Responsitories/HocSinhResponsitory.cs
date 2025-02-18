using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Responsitories
{
    public class HocSinhResponsitory
    {
        private Database DB = new Database();
        public DataTable HienThiDSHocsinhRutgon(ref string error)
        {
            try
            {
                string sql = " select MSHS,HO, TEN,GIOITINH,NGAY_SINH " +
                             " from THONG_TIN_HOC_SINH";
                var rs = DB.GetDataFromDB(sql, CommandType.Text, ref error);
                return rs;
            }
            catch (Exception ex)
            {
                error = "Kết nối lỗi: " + ex.Message;
                return null;
            }
        }



    }
}
