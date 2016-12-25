using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess
{
    public class CongViecDAL
    {

        DBSoTayCaNhan db;

        public CongViecDAL()
        {
            db = new DBSoTayCaNhan();
        }

        /// <summary>
        /// Lấy công việc theo mã.
        /// </summary>
        /// <param name="maCongViec"></param>
        /// <returns></returns>
        public CongViec layCongViecTheoMa(int maCongViec)
        {
            return db.CongViec.Where(a => a.MaCongViec == maCongViec).SingleOrDefault();
        }

        /// <summary>
        /// Lấy danh sách công việc.
        /// </summary>
        /// <returns></returns>
        public List<CongViec> layDanhSachCongViec()
        {
            return db.CongViec.ToList();
        }

        /// <summary>
        /// Thêm công việc mới.
        /// </summary>
        /// <param name="cv"></param>
        public void them(CongViec cv)
        {
            db.CongViec.Add(cv);
            db.SaveChanges();
        }

        /// <summary>
        /// Sửa công việc.
        /// </summary>
        /// <param name="cv"></param>
        public void sua(CongViec cv)
        {
            db.Entry(cv).State = EntityState.Modified;
            db.SaveChanges();
        }

        /// <summary>
        /// Xóa công việc.
        /// </summary>
        /// <param name="maCongViec"></param>
        public void xoa(int maCongViec)
        {
            CongViec cv = db.CongViec.Where(a => a.MaCongViec == maCongViec).SingleOrDefault();
            if (cv == null)
            {
                return;
            }
            db.CongViec.Remove(cv);
            db.SaveChanges();
        }

    }
}
