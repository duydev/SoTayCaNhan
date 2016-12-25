using DataAccess;
using System.Collections.Generic;

namespace BusinessLogic
{
    class LichTrinhBLL
    {

        LichTrinhDAL lichtrinhDAL;

        public LichTrinhBLL()
        {
            lichtrinhDAL = new LichTrinhDAL();
        }

        /// <summary>
        /// Lấy lịch trình theo mã
        /// </summary>
        /// <param name="maLichTrinh"></param>
        /// <returns></returns>
        public LichTrinh layLichTrinhTheoMa(int maLichTrinh)
        {
            return lichtrinhDAL.layLichTrinhTheoMa(maLichTrinh);
        }

        /// <summary>
        /// Lấy danh sách lịch trình
        /// </summary>
        /// <returns></returns>
        public List<LichTrinh> layDanhSachLichTrinh()
        {
            return lichtrinhDAL.layDanhSachLichTrinh();
        }

        /// <summary>
        /// Thêm lịch trình mới.
        /// </summary>
        /// <param name="lt"></param>
        public void them(LichTrinh lt)
        {
            lichtrinhDAL.them(lt);
        }

        /// <summary>
        /// Sửa lịch trình.
        /// </summary>
        /// <param name="lt"></param>
        public void sua(LichTrinh lt)
        {
            lichtrinhDAL.sua(lt);
        }

        /// <summary>
        /// Xóa lịch trình.
        /// </summary>
        /// <param name="maLichTrinh"></param>
        public void xoa(int maLichTrinh)
        {
            lichtrinhDAL.xoa(maLichTrinh);
        }

    }
}
