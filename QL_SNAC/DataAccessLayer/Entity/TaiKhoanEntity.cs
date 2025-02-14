using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public class TaiKhoanEntity
    {
        public int ID_TAIKHOAN { get; set; }
        public string EMAIL { get; set; }
        public string PASS {  get; set; }
        public bool TinhTrang { get; set; }
        public string MSNguoiDung { get; set; }
        public string Quyen {  get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }

    }
}
