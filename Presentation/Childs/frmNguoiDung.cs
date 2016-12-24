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
using BusinessLogic;
using DataAccess;

namespace Presentation.Childs
{
    public partial class frmNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        private NguoiDungBLL nguoidungBLL;

        public frmNguoiDung()
        {
            InitializeComponent();
            nguoidungBLL = new NguoiDungBLL();
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
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

        
    }
}