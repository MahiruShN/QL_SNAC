using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Responsitories
{
    public class GiaoVienResponsitory
    {
        private Database DB = new Database();
        public DataTable HienThiDSGiaoVienRutgon(ref string error)
        {
            try
            {
                string sql = " select MSGV,HO, TEN,NGAYSINH " +
                             " from THONG_TIN_GIAO_VIEN";
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
