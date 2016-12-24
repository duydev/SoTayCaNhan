﻿using System;
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
using Presentation.Helper;
using DevExpress.XtraBars.Ribbon;

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
            disableBtnDangXuat(true);
            disableRibbon(true);
            hideRibbonPage(0);
            frmDangNhap frm = new frmDangNhap();
            showChildForm(frm);
        }

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

        /// <summary>
        /// Tắt mở button Đăng Xuất
        /// </summary>
        /// <param name="b"></param>
        public void disableBtnDangXuat(bool b)
        {
            btnDangXuat.Enabled = !b;
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            AccountHelper.Logout();
            disableRibbon(true);
            hideRibbonPage(0);
            showChildForm(new frmDangNhap());
            disableBtnDangXuat(true);
            txtNguoiDung.Caption = "Chưa đăng nhập";
            txtPhanQuyen.Caption = "";
        }

        /// <summary>
        /// Thiêt lập một số thứ khi người dùng đăng nhập
        /// </summary>
        public void initLogin()
        {
            disableRibbon(false);
            disableBtnDangXuat(false);
            hideRibbonPage(AccountHelper.User().PhanQuyen.MaPhanQuyen);
            txtNguoiDung.Caption = AccountHelper.User().Ten;
            txtPhanQuyen.Caption = AccountHelper.User().PhanQuyen.Ten;
        }

        private void btnDSNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            showChildForm(new frmNguoiDung());
        }

        /// <summary>
        /// Ẩn Hiện Ribbon page.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="b"></param>
        public void hideRibbonPage(RibbonPage page, bool b)
        {
            page.Visible = !b;            
        }

        /// <summary>
        /// Ẩn Hiện Ribbon page theo phân quyền.
        /// </summary>
        /// <param name="phanquyen"></param>
        public void hideRibbonPage(int phanquyen)
        {
            // Chưa đăng nhập
            if(phanquyen == 0)
            {
                hideRibbonPage(ribQuanTri, true);
                hideRibbonPage(ribDanhba, true);
                hideRibbonPage(ribCongViec, true);
                hideRibbonPage(ribLichTrinh, true);
            }
            // Admin
            if(phanquyen == 1)
            {
                hideRibbonPage(ribQuanTri, false);
                hideRibbonPage(ribDanhba, false);
                hideRibbonPage(ribCongViec, false);
                hideRibbonPage(ribLichTrinh, false);
            }
            // Người dùng
            if(phanquyen == 2)
            {
                hideRibbonPage(ribQuanTri, true);
                hideRibbonPage(ribDanhba, false);
                hideRibbonPage(ribCongViec, false);
                hideRibbonPage(ribLichTrinh, false);
            }
        }
    }
}