using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Presentation.Helper;
using DataAccess;

namespace Presentation.Childs
{
    public partial class frmDangKy : DevExpress.XtraEditors.XtraForm
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            string dienThoai = txtDienThoai.Text;
            string diaChi = txtDiaChi.Text;
            string email = txtEmail.Text;
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            if( string.IsNullOrEmpty( hoTen ) )
            {
                MessageBox.Show("Vui lòng nhập họ tên.", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(dienThoai))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập email.", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(tenDangNhap))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Thông báo");
                return;
            }
            if( AccountHelper.isRegistered(tenDangNhap))
            {
                MessageBox.Show("Tên đăng nhập đã được sử dụng.", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Thông báo");
                return;
            }
            NguoiDung nd = new NguoiDung {
                Ten = hoTen,
                SoDienThoai = dienThoai,
                DiaChi = diaChi,
                Email = email,
                TenDangNhap = tenDangNhap,
                MatKhau = matKhau
            };
            AccountHelper.Register(nd);
            clearInput();
            MessageBox.Show("Đăng ký thành công. Vui lòng đăng nhập.", "Thông báo");
        }

        /// <summary>
        /// Xóa input
        /// </summary>
        private void clearInput()
        {
            txtHoTen.ResetText();
            txtDienThoai.ResetText();
            txtDiaChi.ResetText();
            txtEmail.ResetText();
            txtTenDangNhap.ResetText();
            txtMatKhau.ResetText();
        }
    }
}