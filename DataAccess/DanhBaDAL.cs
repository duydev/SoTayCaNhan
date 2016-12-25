using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess
{
    public class DanhBaDAL
    {

        DBSoTayCaNhan db;

        public DanhBaDAL()
        {
            db = new DBSoTayCaNhan();
        }

        /// <summary>
        /// Lấy danh bạn theo mã danh bạ.
        /// </summary>
        /// <param name="maDanhBa"></param>
        /// <returns></returns>
        public DanhBa layDanhBaTheoMa(int maDanhBa)
        {
            return db.DanhBa.Where(a => a.MaDanhBa == maDanhBa).SingleOrDefault();
        }

        /// <summary>
        /// Lấy danh sách danh bạ.
        /// </summary>
        /// <returns></returns>
        public List<DanhBa> layDanhSachDanhBa()
        {
            return db.DanhBa.ToList();
        }

        /// <summary>
        /// Thêm danh bạ mới.
        /// </summary>
        /// <param name="dba"></param>
        public void them(DanhBa dba)
        {
            db.DanhBa.Add(dba);
            db.SaveChanges();
        }


        /// <summary>
        /// Sửa danh bạ.
        /// </summary>
        /// <param name="dba"></param>
        public void sua(DanhBa dba)
        {
            db.Entry(dba).State = EntityState.Modified;
            db.SaveChanges();
        }

        /// <summary>
        /// Xóa danh bạ.
        /// </summary>
        /// <param name="maDanhBa"></param>
        public void xoa(int maDanhBa)
        {
            DanhBa dba = db.DanhBa.Where(a => a.MaDanhBa == maDanhBa).SingleOrDefault();
            if (dba == null)
            {
                return;
            }
            db.DanhBa.Remove(dba);
            db.SaveChanges();
        }

    }
}
