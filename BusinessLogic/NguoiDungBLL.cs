using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class NguoiDungBLL
    {
        public NguoiDungDAL nguoidungDAL;

        public NguoiDungBLL()
        {
            nguoidungDAL = new NguoiDungDAL();
        }

        /// <summary>
        /// Lấy người dùng theo tên đăng nhập
        /// </summary>
        /// <param name="tenDangNhap"></param>
        /// <returns></returns>
        public NguoiDung layNguoiDungTheoTenDangNhap(string tenDangNhap)
        {
            return nguoidungDAL.layNguoiDungTheoTenDangNhap(tenDangNhap);
        }

    }
}
