using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess
{
    public class LichTrinhDAL
    {
        DBSoTayCaNhan db;

        public LichTrinhDAL()
        {
            db = new DBSoTayCaNhan();
        }

        /// <summary>
        /// Lấy lịch trình theo mã
        /// </summary>
        /// <param name="maLichTrinh"></param>
        /// <returns></returns>
        public LichTrinh layLichTrinhTheoMa(int maLichTrinh)
        {
            return db.LichTrinh.Where(a => a.MaLichTrinh == maLichTrinh).SingleOrDefault();
        }

        /// <summary>
        /// Lấy danh sách lịch trình
        /// </summary>
        /// <returns></returns>
        public List<LichTrinh> layDanhSachLichTrinh()
        {
            return db.LichTrinh.ToList();
        }

        /// <summary>
        /// Thêm lịch trình mới.
        /// </summary>
        /// <param name="lt"></param>
        public void them(LichTrinh lt)
        {
            db.LichTrinh.Add(lt);
            db.SaveChanges();
        }

        /// <summary>
        /// Sửa lịch trình.
        /// </summary>
        /// <param name="lt"></param>
        public void sua(LichTrinh lt)
        {
            db.Entry(lt).State = EntityState.Modified;
            db.SaveChanges();
        }

        /// <summary>
        /// Xóa lịch trình.
        /// </summary>
        /// <param name="maLichTrinh"></param>
        public void xoa(int maLichTrinh)
        {
            LichTrinh lt = db.LichTrinh.Where(a => a.MaLichTrinh == maLichTrinh).SingleOrDefault();
            if (lt == null)
            {
                return;
            }
            db.LichTrinh.Remove(lt);
            db.SaveChanges();
        }
    }
}
