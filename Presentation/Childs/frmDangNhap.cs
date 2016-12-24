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

namespace Presentation.Childs
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            bool giuDangNhap = chkGiuDangNhap.Checked;
            if( tenDangNhap.Length == 0 )
            {
                MessageBox.Show( "Vui lòng nhập tên đăng nhập.", "Thông báo" );
                return;
            }
            if (matKhau.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Thông báo");
                return;
            }
            if( ! AccountHelper.Login( tenDangNhap, matKhau, giuDangNhap ) )
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng đăng nhập lại.", "Thông báo");
                return;
            }
            frmChinh frmChinh = (frmChinh)this.MdiParent;
            frmChinh.disableRibbon(false);
            this.Close();
        }
    }
}