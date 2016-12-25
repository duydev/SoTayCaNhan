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
using DataAccess;
using BusinessLogic;
using Presentation.Helper;

namespace Presentation.Childs
{
    public partial class frmDanhBa : DevExpress.XtraEditors.XtraForm
    {

        private DanhBaBLL danhbaBLL;
        private int maDanhBa = 0;

        public frmDanhBa()
        {
            InitializeComponent();
            danhbaBLL = new DanhBaBLL();
        }

        private void frmDanhBa_Load(object sender, EventArgs e)
        {
            disableInput(true);
            disableButton(true);
            capnhatBang();
        }

        /// <summary>
        /// Cập nhật lại dữ liệu trong bảng người dùng.
        /// </summary>
        private void capnhatBang()
        {
            List<DanhBa> list = danhbaBLL.layDanhSachDanhBa();
            tblDanhBa.DataSource = list;
        }

        /// <summary>
        /// Xóa input
        /// </summary>
        private void clearInput()
        {
            txtHoTen.ResetText();
            txtDienThoai.ResetText();
            txtDiDong.ResetText();
            txtEmail.ResetText();
            txtDiaChi.ResetText();
            txtGhiChu.ResetText();
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
            txtDiDong.Enabled = !b;
            txtEmail.Enabled = !b;
            txtDiaChi.Enabled = !b;
            txtGhiChu.Enabled = !b;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            maDanhBa = 0;
            clearInput();
            disableInput(false);
            disableButton(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            disableInput(false);
            disableButton(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int[] selectedRows = tblDanhBaView.GetSelectedRows();
            foreach (int i in selectedRows)
            {
                int maDanhBa = int.Parse(tblDanhBaView.GetRowCellDisplayText(i, "MaDanhBa"));
                danhbaBLL.xoa(maDanhBa);
            }
            capnhatBang();
            MessageBox.Show("Xóa thành công.", "Thông báo");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string msg = "";
            string hoTen = txtHoTen.Text;
            string dienThoai = txtDienThoai.Text;
            string diDong = txtDiDong.Text;
            string email = txtEmail.Text;
            string diaChi = txtDiaChi.Text;
            string ghiChu = txtGhiChu.Text;
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
            if (string.IsNullOrEmpty(diDong))
            {
                MessageBox.Show("Vui lòng nhập số di động.", "Thông báo");
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
            if (string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Thông báo");
                return;
            }
            // Kiểm tra xem là đang thêm hay sửa
            if (maDanhBa == 0)
            {
                DanhBa dba = new DanhBa
                {
                    Ten = hoTen,
                    DienThoai = dienThoai,
                    DiDong = diDong,
                    Email = email,
                    DiaChi = diaChi,
                    GhiChu = ghiChu,
                    HinhAnh = "",
                    MaNguoiDung = AccountHelper.User().MaNguoiDung,                    
                };
                danhbaBLL.them(dba);
                msg = "Thêm thành công.";
            }
            else
            {
                DanhBa dba = danhbaBLL.layDanhBaTheoMa(maDanhBa);
                dba.Ten = hoTen;
                dba.DienThoai = dienThoai;
                dba.DiDong = diDong;
                dba.Email = email;
                dba.DiaChi = diaChi;
                dba.GhiChu = ghiChu;
                danhbaBLL.sua(dba);
                msg = "Sửa thông tin thành công.";
            }
            clearInput();
            capnhatBang();
            disableInput(true);
            disableButton(true);
            MessageBox.Show(msg, "Thông báo");
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            clearInput();
            disableInput(true);
            disableButton(true);
        }

        public void Them()
        {
            btnThem.PerformClick();
        }

        private void tblDanhBaView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                int[] selectedRows = tblDanhBaView.GetSelectedRows();
                if (selectedRows.Length > 0)
                {
                    int row = selectedRows[0];
                    maDanhBa = int.Parse(tblDanhBaView.GetRowCellDisplayText(row, "MaDanhBa"));
                    txtHoTen.Text = tblDanhBaView.GetRowCellDisplayText(row, "Ten");
                    txtDienThoai.Text = tblDanhBaView.GetRowCellDisplayText(row, "DienThoai");
                    txtDiDong.Text = tblDanhBaView.GetRowCellDisplayText(row, "DiDong");
                    txtEmail.Text = tblDanhBaView.GetRowCellDisplayText(row, "Email");
                    txtDiaChi.Text = tblDanhBaView.GetRowCellDisplayText(row, "DiaChi");
                    txtGhiChu.Text = tblDanhBaView.GetRowCellDisplayText(row, "GhiChu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi...");
            }
        }
    }
}