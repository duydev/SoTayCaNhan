using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentation.Childs
{
    public partial class frmNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        private PhanQuyenBLL phanquyenBLL;
        private NguoiDungBLL nguoidungBLL;

        public frmNguoiDung()
        {
            InitializeComponent();
            phanquyenBLL = new PhanQuyenBLL();
            nguoidungBLL = new NguoiDungBLL();
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            capnhatLoaiTaiKhoan();
            capnhatBang();
        }

        /// <summary>
        /// Cập nhật lại dữ liệu trong bảng người dùng.
        /// </summary>
        private void capnhatBang()
        {
            List<NguoiDung> list = nguoidungBLL.layTatCaNguoiDung();
            tblNguoiDung.DataSource = list;
        }

        private void clearInput()
        {

        }

        public void capnhatLoaiTaiKhoan()
        {
            List<PhanQuyen> list = phanquyenBLL.layDanhSachPhanQuyen();
            BindingSource src = new BindingSource();
            src.DataSource = list;
            cbbLoaiTaiKhoan.Properties.DataSource = src;
            cbbLoaiTaiKhoan.Properties.DisplayMember = "Ten";
            cbbLoaiTaiKhoan.Properties.ValueMember = "MaPhanQuyen";
        }

        
    }
}