using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Responsitories
{
    public class DaoTaoResponsitory
    {
        private Database DB = new Database();
        public DataTable HienThiDaoTao(ref string error)
        {
            try
            {
                string sql = " select ID_DAOTAO,NOIDUNG, NAM_BAT_DAU, NAM_KET_THUC,NGAY_BAT_DAU, NGAY_KET_THUC " +
                             " from DAO_TAO";
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
