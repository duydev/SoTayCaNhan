using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PhanQuyenBLL
    {
        PhanQuyenDAL phanquyenDAL;

        public PhanQuyenBLL()
        {
            phanquyenDAL = new PhanQuyenDAL();
        }

        /// <summary>
        /// Lấy danh sách phân quyền.
        /// </summary>
        /// <returns></returns>
        public List<PhanQuyen> layDanhSachPhanQuyen()
        {
            return phanquyenDAL.layDanhSachPhanQuyen();
        }
    }
}
