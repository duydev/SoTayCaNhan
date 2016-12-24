using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class NguoiDungDAL
    {
        DBSoTayCaNhan db;

        public NguoiDungDAL()
        {
            db = new DBSoTayCaNhan();
        }

        /// <summary>
        /// Lấy người dùng theo tên đăng nhập
        /// </summary>
        /// <param name="tenDangNhap"></param>
        /// <returns></returns>
        public NguoiDung layNguoiDungTheoTenDangNhap(string tenDangNhap)
        {
            return db.NguoiDung.Where(a => a.TenDangNhap == tenDangNhap).FirstOrDefault();
        }
    }
}
