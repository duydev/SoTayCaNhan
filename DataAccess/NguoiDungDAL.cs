using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

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
            return db.NguoiDung.Where(a => a.TenDangNhap == tenDangNhap).SingleOrDefault();
        }

        /// <summary>
        /// Lấy người dùng theo mã người dùng.
        /// </summary>
        /// <param name="maNguoiDung"></param>
        /// <returns></returns>
        public NguoiDung layNguoiDungTheoMa(int maNguoiDung)
        {
            return db.NguoiDung.Where(a => a.MaNguoiDung == maNguoiDung).SingleOrDefault();
        }

        /// <summary>
        /// Lấy tất cả người dùng.
        /// </summary>
        /// <returns></returns>
        public List<NguoiDung> layTatCaNguoiDung()
        {
            return db.NguoiDung.ToList();
        }

        /// <summary>
        /// Thêm người dùng.
        /// </summary>
        /// <param name="nd"></param>
        public void them(NguoiDung nd)
        {
            db.NguoiDung.Add(nd);
            db.SaveChanges();
        }

        /// <summary>
        /// Sửa người dùng.
        /// </summary>
        /// <param name="nd"></param>
        public void sua(NguoiDung nd)
        {
            db.Entry(nd).State = EntityState.Modified;
            db.SaveChanges();
        }

        /// <summary>
        /// Xóa người dùng theo mã người dùng
        /// </summary>
        /// <param name="maNguoiDung"></param>
        public void xoa(int maNguoiDung)
        {
            NguoiDung nd = db.NguoiDung.Where(a => a.MaNguoiDung == maNguoiDung).SingleOrDefault();
            if( nd == null )
            {
                return;
            }
            db.NguoiDung.Remove(nd);
            db.SaveChanges();
        }
    }
}
