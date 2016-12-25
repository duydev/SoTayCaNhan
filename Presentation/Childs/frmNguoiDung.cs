using BusinessLogic;
using DataAccess;
using Presentation.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Presentation.Childs
{
    public partial class frmNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        private PhanQuyenBLL phanquyenBLL;
        private NguoiDungBLL nguoidungBLL;
        private int maNguoiDung = 0;

        public frmNguoiDung()
        {
            InitializeComponent();
            phanquyenBLL = new PhanQuyenBLL();
            nguoidungBLL = new NguoiDungBLL();
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            disableInput(true);
            disableButton(true);
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

        /// <summary>
        /// Tắt mở button
        /// </summary>
        /// <param name="b"></param>
        private void disableButton(bool b)
        {
            btnThem.Enabled = b;
            btnSua.Enabled = b;
            btnXoa.Enabled = b;
            btnLuu.Enabled = !b;
            btnKhongLuu.Enabled = !b;
        }

        /// <summary>
        /// Tắt mở input
        /// </summary>
        /// <param name="b"></param>
        private void disableInput(bool b)
        {
            txtHoTen.Enabled = !b;
            txtDienThoai.Enabled = !b;
            txtDiaChi.Enabled = !b;
            txtEmail.Enabled = !b;
            txtTenDangNhap.Enabled = !b;
            txtMatKhau.Enabled = !b;
            cbbLoaiTaiKhoan.Enabled = !b;
        }

        /// <summary>
        /// Cập nhật combobox loại tài khoản
        /// </summary>
        public void capnhatLoaiTaiKhoan()
        {
            List<PhanQuyen> list = phanquyenBLL.layDanhSachPhanQuyen();
            BindingSource src = new BindingSource();
            src.DataSource = list;
            cbbLoaiTaiKhoan.Properties.DataSource = src;
            cbbLoaiTaiKhoan.Properties.DisplayMember = "Ten";
            cbbLoaiTaiKhoan.Properties.ValueMember = "MaPhanQuyen";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            maNguoiDung = 0;
            clearInput();
            disableInput(false);
            disableButton(false);
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            clearInput();
            disableInput(true);
            disableButton(true);
        }

        private void tblNguoiDungView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                int[] selectedRows = tblNguoiDungView.GetSelectedRows();
                if( selectedRows.Length > 0 )
                {
                    int row = selectedRows[0];
                    maNguoiDung = int.Parse(tblNguoiDungView.GetRowCellDisplayText(row, "MaNguoiDung"));
                    txtHoTen.Text = tblNguoiDungView.GetRowCellDisplayText(row, "Ten");
                    txtDienThoai.Text = tblNguoiDungView.GetRowCellDisplayText(row, "SoDienThoai"); 
                    txtDiaChi.Text = tblNguoiDungView.GetRowCellDisplayText(row, "DiaChi");
                    txtEmail.Text = tblNguoiDungView.GetRowCellDisplayText(row, "Email");
                    txtTenDangNhap.Text = tblNguoiDungView.GetRowCellDisplayText(row, "TenDangNhap");
                    cbbLoaiTaiKhoan.EditValue = cbbLoaiTaiKhoan.Properties.GetKeyValueByDisplayText(tblNguoiDungView.GetRowCellDisplayText(row, "PhanQuyen.Ten"));
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi...");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            disableInput(false);
            disableButton(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string msg = "";
            string hoTen = txtHoTen.Text;
            string dienThoai = txtDienThoai.Text;
            string diaChi = txtDiaChi.Text;
            string email = txtEmail.Text;
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            int maPhanQuyen = (int) cbbLoaiTaiKhoan.EditValue;
            if (string.IsNullOrEmpty(hoTen))
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
            if (!AccountHelper.isEmail(email))
            {
                MessageBox.Show("Email không hợp lệ.", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(tenDangNhap))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Thông báo");
                return;
            }
            // Kiểm tra xem là đang thêm hay sửa
            if (maNguoiDung == 0)
            {
                if (AccountHelper.isRegistered(tenDangNhap))
                {
                    MessageBox.Show("Tên đăng nhập đã được sử dụng.", "Thông báo");
                    return;
                }
                if (string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu.", "Thông báo");
                    return;
                }
                NguoiDung nd = new NguoiDung
                {
                    Ten = hoTen,
                    SoDienThoai = dienThoai,
                    DiaChi = diaChi,
                    Email = email,
                    TenDangNhap = tenDangNhap,
                    MatKhau = AccountHelper.md5(matKhau),
                    MaPhanQuyen = maPhanQuyen
                };
                nguoidungBLL.them(nd);
                msg = "Thêm người dùng thành công.";
            } else {
                NguoiDung nd = nguoidungBLL.layNguoiDungTheoMa(maNguoiDung);
                if (tenDangNhap != nd.TenDangNhap && AccountHelper.isRegistered(tenDangNhap))
                {
                    MessageBox.Show("Tên đăng nhập đã được sử dụng.", "Thông báo");
                    return;
                }
                nd.Ten = hoTen;
                nd.SoDienThoai = dienThoai;
                nd.DiaChi = diaChi;
                nd.Email = email;
                nd.TenDangNhap = tenDangNhap;
                nd.MaPhanQuyen = maPhanQuyen;
                if( ! string.IsNullOrEmpty( matKhau ))
                {
                    nd.MatKhau = AccountHelper.md5(matKhau);
                }
                nguoidungBLL.sua(nd);
                msg = "Sửa thông tin người dùng thành công.";
            }
            clearInput();
            capnhatBang();
            disableInput(true);
            disableButton(true);
            MessageBox.Show(msg, "Thông báo");
        }
    }
}