using DataAccess;
using System.Collections.Generic;

namespace BusinessLogic
{
    class CongViecBLL
    {

        public CongViecDAL congviecDAL;

        public CongViecBLL()
        {
            congviecDAL = new CongViecDAL();
        }

        /// <summary>
        /// Lấy công việc theo mã.
        /// </summary>
        /// <param name="maCongViec"></param>
        /// <returns></returns>
        public CongViec layCongViecTheoMa(int maCongViec)
        {
            return congviecDAL.layCongViecTheoMa(maCongViec);
        }

        /// <summary>
        /// Lấy danh sách công việc.
        /// </summary>
        /// <returns></returns>
        public List<CongViec> layDanhSachCongViec()
        {
            return congviecDAL.layDanhSachCongViec();
        }

        /// <summary>
        /// Thêm công việc mới.
        /// </summary>
        /// <param name="cv"></param>
        public void them(CongViec cv)
        {
            congviecDAL.them(cv);
        }

        /// <summary>
        /// Sửa công việc.
        /// </summary>
        /// <param name="cv"></param>
        public void sua(CongViec cv)
        {
            congviecDAL.sua(cv);
        }

        /// <summary>
        /// Xóa công việc.
        /// </summary>
        /// <param name="maCongViec"></param>
        public void xoa(int maCongViec)
        {
            congviecDAL.xoa(maCongViec);
        }

    }
}
