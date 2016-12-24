using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace Presentation.Helper
{
    public class AccountHelper
    {
        private static NguoiDungBLL nguoidungBLL = new NguoiDungBLL();

        private static NguoiDung loginUser = null;

        /// <summary>
        /// Kiểm tra người dùng đã đăng nhập chưa.
        /// </summary>
        /// <returns></returns>
        public static bool isLogin()
        {
            return ( loginUser != null );
        }

        /// <summary>
        /// Đăng nhập
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="remember"></param>
        /// <returns></returns>
        public static bool Login(string username, string password, bool remember)
        {
            NguoiDung nd = nguoidungBLL.layNguoiDungTheoTenDangNhap(username);
            // Nếu không tìm thấy người dùng trong CSDL
            if ( nd == null )
            {
                return false;
            } 
            // Nếu tìm thấy
            // Kiểm tra mật khẩu có khớp hay không?
            if( md5( password ) != nd.MatKhau.ToUpper() )
            {
                return false;
            }
            loginUser = nd;
            return true;
        }

        /// <summary>
        /// Sinh mã MD5
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string md5(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

    }
}
