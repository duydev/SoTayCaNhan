using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Presentation.Childs;

namespace Presentation
{
    public partial class frmChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            ribbon.Enabled = false;
            frmDangNhap frm = new frmDangNhap();
            showChildForm(frm);
        }
        
        //private 

        /// <summary>
        /// Hiển thị form con lên trên form cha.
        /// </summary>
        /// <param name="frm"></param>
        private void showChildForm(Form frm)
        {
            if( ! isFormActivated( frm ) )
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        /// <summary>
        /// Kiểm tra form con đã được mở chưa.
        /// </summary>
        /// <param name="frm"></param>
        /// <returns></returns>
        private bool isFormActivated(Form frm)
        {
            Form[] childs = this.MdiChildren;
            if(childs.Count() > 0 )
            {
                foreach( Form c in childs )
                {
                    if( c.Name == frm.Name )
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Tắt mở ribbon
        /// </summary>
        /// <param name="b"></param>
        public void disableRibbon(bool b)
        {
            ribbon.Enabled = !b;
        }
        
    }
}