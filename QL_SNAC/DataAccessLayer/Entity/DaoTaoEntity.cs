using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public class DaoTaoEntity
    {
        public string ID_DAOTAO { get; set; }
        public string NOIDUNG { get; set; }
        public int NAM_BAT_DAU { get; set; }
        public int NAM_KET_THUC { get; set; }
        public string NGAY_BAT_DAU { get; set; }
        public string NGAY_KET_THUC { get; set; }
    }
}
