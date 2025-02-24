using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entity;
using DataAccessLayer.Responsitories;

namespace BusinessLogicLayer.Manager
{
    public class ImgManager
    {
        private ImgResponsitory process;
        public ImgManager()
        {
            process = new ImgResponsitory();
        }
        public bool ThemAnh(ImgEntity Img, ref string error)
        {
            try
            {
                return process.ThemAnh(Img, ref error);
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
                return process.CapNhatAnh(img, ref error);
            }
            catch (Exception ex)
            {
                error = "Lỗi khi cập nhật ảnh: " + ex.Message;
                return false;
            }

        }

        public bool XoaAnh(int id, ref string error)
        {
            try
            {
                return process.XoaAnh(id, ref error);

            }
            catch (Exception ex)
            {
                error = "Lỗi khi xóa ảnh: " + ex.Message;
                return false;
            }
        }
    }
}
