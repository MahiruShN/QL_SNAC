using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entity;
using Microsoft.Data.SqlClient;

namespace DataAccessLayer.Responsitories
{
    public class ImgResponsitory
    {
        private Database DB = new Database();
        //private ImgEntity img = new ImgEntity();
        public bool ThemAnh(ImgEntity eImg, ref string error)
        {
            try
            {
                string sql = @"INSERT INTO ImgData (id, ImgBase32) VALUES (@id, @ImgBase32)";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@id", eImg.Id),
                    new SqlParameter("@ImgBase32", eImg.ImgBase32)
                };

                return DB.ProcessData(sql, CommandType.Text, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi thêm ảnh: " + ex.Message;
                return false;
            }
        }

        public bool CapNhatAnh(ImgEntity img, ref string error)
        {
            try
            {
                string sql = @"UPDATE ImgData SET ImgBase32 = @ImgBase32 WHERE id = @id";
                SqlParameter[] parameters =
                {
            new SqlParameter("@id", img.Id),
            new SqlParameter("@ImgBase32", img.ImgBase32)
        };

                return DB.ProcessData(sql, CommandType.Text, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi cập nhật ảnh: " + ex.Message;
                return false;
            }
        }

        public bool XoaAnh(string id, ref string error)
        {
            try
            {
                string sql = "DELETE FROM ImgData WHERE id = @id";
                SqlParameter[] parameters = { new SqlParameter("@id", id) };

                return DB.ProcessData(sql, CommandType.Text, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi xóa ảnh: " + ex.Message;
                return false;
            }

        }

        public string LayAnh(string id, ref string error)
        {
            try
            {
                string sql = "SELECT ImgBase32 FROM ImgData WHERE id = @id";
                SqlParameter[] parameters = { new SqlParameter("@id", id) };
                DataTable dt = DB.GetDataFromDB(sql, CommandType.Text, ref error, parameters);
                if (dt != null && dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["ImgBase32"].ToString();
                }
                return null;
            }
            catch (Exception ex)
            {
                error = "Lỗi khi lấy ảnh: " + ex.Message;
                return null;
            }
        }

       
    }
}
