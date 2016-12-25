using DataAccess;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class DanhBaBLL
    {

        public DanhBaDAL danhbaDAL;

        public DanhBaBLL()
        {
            danhbaDAL = new DanhBaDAL();
        }

        /// <summary>
        /// Lấy danh bạn theo mã danh bạ.
        /// </summary>
        /// <param name="maDanhBa"></param>
        /// <returns></returns>
        public DanhBa layDanhBaTheoMa(int maDanhBa)
        {
            return danhbaDAL.layDanhBaTheoMa(maDanhBa);
        }

        /// <summary>
        /// Lấy danh sách danh bạ.
        /// </summary>
        /// <returns></returns>
        public List<DanhBa> layDanhSachDanhBa()
        {
            return danhbaDAL.layDanhSachDanhBa();
        }

        /// <summary>
        /// Thêm danh bạ mới.
        /// </summary>
        /// <param name="dba"></param>
        public void them(DanhBa dba)
        {
            danhbaDAL.them(dba);
        }


        /// <summary>
        /// Sửa danh bạ.
        /// </summary>
        /// <param name="dba"></param>
        public void sua(DanhBa dba)
        {
            danhbaDAL.sua(dba);
        }

        /// <summary>
        /// Xóa danh bạ.
        /// </summary>
        /// <param name="maDanhBa"></param>
        public void xoa(int maDanhBa)
        {
            danhbaDAL.xoa(maDanhBa);
        }

    }
}
