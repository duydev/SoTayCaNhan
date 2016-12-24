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

        /// <summary>
        /// Lấy người dùng theo mã người dùng.
        /// </summary>
        /// <param name="maNguoiDung"></param>
        /// <returns></returns>
        public NguoiDung layNguoiDungTheoMa(int maNguoiDung)
        {
            return nguoidungDAL.layNguoiDungTheoMa(maNguoiDung);
        }

        /// <summary>
        /// Lấy tất cả người dùng.
        /// </summary>
        /// <returns></returns>
        public List<NguoiDung> layTatCaNguoiDung()
        {
            return nguoidungDAL.layTatCaNguoiDung();
        }

        /// <summary>
        /// Thêm người dùng.
        /// </summary>
        /// <param name="nd"></param>
        public void them(NguoiDung nd)
        {
            nguoidungDAL.them(nd);
        }

        /// <summary>
        /// Sửa người dùng.
        /// </summary>
        /// <param name="nd"></param>
        public void sua(NguoiDung nd)
        {
            nguoidungDAL.sua(nd);
        }

        /// <summary>
        /// Xóa người dùng theo mã người dùng
        /// </summary>
        /// <param name="maNguoiDung"></param>
        public void xoa(int maNguoiDung)
        {
            nguoidungDAL.xoa(maNguoiDung);
        }

    }
}
