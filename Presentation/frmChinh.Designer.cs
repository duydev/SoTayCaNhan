namespace Presentation
{
    partial class frmChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.appMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.btnDSNguoiDung = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemND = new DevExpress.XtraBars.BarButtonItem();
            this.txtNguoiDung = new DevExpress.XtraBars.BarHeaderItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.txtPhanQuyen = new DevExpress.XtraBars.BarStaticItem();
            this.btnCNDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnCNDangKy = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribDanhba = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribCongViec = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribLichTrinh = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribQuanTri = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribPGThongTin = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribPGChucNang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.appMenu;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnDSNguoiDung,
            this.btnThemND,
            this.txtNguoiDung,
            this.btnDangXuat,
            this.txtPhanQuyen,
            this.btnCNDangNhap,
            this.btnCNDangKy,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribDanhba,
            this.ribCongViec,
            this.ribLichTrinh,
            this.ribQuanTri,
            this.ribTaiKhoan});
            this.ribbon.Size = new System.Drawing.Size(1304, 168);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // appMenu
            // 
            this.appMenu.Name = "appMenu";
            this.appMenu.Ribbon = this.ribbon;
            // 
            // btnDSNguoiDung
            // 
            this.btnDSNguoiDung.Caption = "Danh Sách";
            this.btnDSNguoiDung.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDSNguoiDung.Glyph")));
            this.btnDSNguoiDung.Id = 1;
            this.btnDSNguoiDung.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDSNguoiDung.LargeGlyph")));
            this.btnDSNguoiDung.Name = "btnDSNguoiDung";
            this.btnDSNguoiDung.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDSNguoiDung.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSNguoiDung_ItemClick);
            // 
            // btnThemND
            // 
            this.btnThemND.Caption = "Thêm Mới";
            this.btnThemND.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThemND.Glyph")));
            this.btnThemND.Id = 2;
            this.btnThemND.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThemND.LargeGlyph")));
            this.btnThemND.Name = "btnThemND";
            this.btnThemND.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThemND.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemND_ItemClick);
            // 
            // txtNguoiDung
            // 
            this.txtNguoiDung.Caption = "Chưa đăng nhập";
            this.txtNguoiDung.Id = 3;
            this.txtNguoiDung.Name = "txtNguoiDung";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 4;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // txtPhanQuyen
            // 
            this.txtPhanQuyen.Id = 5;
            this.txtPhanQuyen.Name = "txtPhanQuyen";
            this.txtPhanQuyen.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnCNDangNhap
            // 
            this.btnCNDangNhap.Caption = "Đăng Nhập";
            this.btnCNDangNhap.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCNDangNhap.Glyph")));
            this.btnCNDangNhap.Id = 6;
            this.btnCNDangNhap.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCNDangNhap.LargeGlyph")));
            this.btnCNDangNhap.Name = "btnCNDangNhap";
            this.btnCNDangNhap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCNDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCNDangNhap_ItemClick);
            // 
            // btnCNDangKy
            // 
            this.btnCNDangKy.Caption = "Đăng ký";
            this.btnCNDangKy.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCNDangKy.Glyph")));
            this.btnCNDangKy.Id = 7;
            this.btnCNDangKy.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCNDangKy.LargeGlyph")));
            this.btnCNDangKy.Name = "btnCNDangKy";
            this.btnCNDangKy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCNDangKy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCNDangKy_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thông Tin Tài Khoản";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Danh Sách";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 10;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // ribDanhba
            // 
            this.ribDanhba.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribDanhba.Name = "ribDanhba";
            this.ribDanhba.Text = "Danh Bạ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Danh Bạ";
            // 
            // ribCongViec
            // 
            this.ribCongViec.Name = "ribCongViec";
            this.ribCongViec.Text = "Công Việc";
            // 
            // ribLichTrinh
            // 
            this.ribLichTrinh.Name = "ribLichTrinh";
            this.ribLichTrinh.Text = "Lịch Trình";
            // 
            // ribQuanTri
            // 
            this.ribQuanTri.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribQuanTri.Name = "ribQuanTri";
            this.ribQuanTri.Text = "Quản Trị";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDSNguoiDung);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThemND);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Người Dùng";
            // 
            // ribTaiKhoan
            // 
            this.ribTaiKhoan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribPGThongTin,
            this.ribPGChucNang});
            this.ribTaiKhoan.Name = "ribTaiKhoan";
            this.ribTaiKhoan.Text = "Tài Khoản";
            // 
            // ribPGThongTin
            // 
            this.ribPGThongTin.ItemLinks.Add(this.barButtonItem1);
            this.ribPGThongTin.Name = "ribPGThongTin";
            this.ribPGThongTin.Text = "Thông Tin";
            // 
            // ribPGChucNang
            // 
            this.ribPGChucNang.ItemLinks.Add(this.btnCNDangNhap);
            this.ribPGChucNang.ItemLinks.Add(this.btnCNDangKy);
            this.ribPGChucNang.Name = "ribPGChucNang";
            this.ribPGChucNang.Text = "Chức Năng";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.txtNguoiDung);
            this.ribbonStatusBar.ItemLinks.Add(this.txtPhanQuyen);
            this.ribbonStatusBar.ItemLinks.Add(this.btnDangXuat);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 586);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1304, 36);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.AllowDragDrop = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.FloatOnDrag = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabbedMdiManager1.FloatPageDragMode = DevExpress.XtraTabbedMdi.FloatPageDragMode.Preview;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 622);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmChinh";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Phần mềm quản lý sổ tay cá nhân";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribQuanTri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnDSNguoiDung;
        private DevExpress.XtraBars.BarButtonItem btnThemND;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarHeaderItem txtNguoiDung;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribDanhba;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribCongViec;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribLichTrinh;
        private DevExpress.XtraBars.BarStaticItem txtPhanQuyen;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribPGThongTin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribPGChucNang;
        private DevExpress.XtraBars.BarButtonItem btnCNDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnCNDangKy;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu appMenu;
    }
}