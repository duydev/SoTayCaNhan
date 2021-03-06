﻿using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using System.Text.RegularExpressions;

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
        /// Đăng xuất
        /// </summary>
        public static void Logout()
        {
            loginUser = null;
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

        /// <summary>
        /// Lấy thông tin người dùng đang đăng nhập.
        /// </summary>
        /// <returns></returns>
        public static NguoiDung User()
        {
            return loginUser;
        }

        /// <summary>
        /// Cập nhật lại thông tin người dùng đang đăng nhập.
        /// </summary>
        public static void UpdateUserData()
        {
            NguoiDungBLL ndBLL = new NguoiDungBLL();
            NguoiDung nd = ndBLL.layNguoiDungTheoMa(loginUser.MaNguoiDung);
            if(nd != null)
            {
                loginUser = nd;
            }
        }

        /// <summary>
        /// Đăng ký 
        /// </summary>
        /// <param name="nd"></param>
        public static void Register(NguoiDung nd)
        {
            NguoiDungBLL ndBLL = new NguoiDungBLL();
            nd.MatKhau = md5(nd.MatKhau);
            nd.MaPhanQuyen = 2;
            ndBLL.them(nd);
        }

        /// <summary>
        /// Kiểm tra xem đã đăng nhập chưa.
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static bool isRegistered(string username)
        {
            NguoiDungBLL ndBLL = new NguoiDungBLL();
            NguoiDung nd = ndBLL.layNguoiDungTheoTenDangNhap(username);
            return (nd != null);
        }

        /// <summary>
        /// Kiểm tra xem có phải là email hợp lệ.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool isEmail(string input)
        {
            return Regex.IsMatch(input, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);              
        }

    }
}
