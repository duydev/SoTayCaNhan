using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class PhanQuyenDAL
    {
        DBSoTayCaNhan db;

        public PhanQuyenDAL()
        {
            db = new DBSoTayCaNhan();
        }

        /// <summary>
        /// Lấy danh sách phân quyền.
        /// </summary>
        /// <returns></returns>
        public List<PhanQuyen> layDanhSachPhanQuyen()
        {
            return db.PhanQuyen.ToList();
        }
    }
}
