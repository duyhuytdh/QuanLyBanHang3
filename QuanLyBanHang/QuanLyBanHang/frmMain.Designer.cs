namespace QuanLyBanHang
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tai_khoan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSP = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLoaiSP = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNghiepVu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDatHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemXuatHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_BCDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoNhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoXuấtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoTồnKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong,
            this.menuDanhMuc,
            this.menuNghiepVu,
            this.menuBaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHeThong
            // 
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_tai_khoan,
            this.menuItemDoiMatKhau,
            this.menuItemLogout});
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(69, 20);
            this.menuHeThong.Text = "Hệ thống";
            // 
            // menu_tai_khoan
            // 
            this.menu_tai_khoan.Name = "menu_tai_khoan";
            this.menu_tai_khoan.Size = new System.Drawing.Size(167, 22);
            this.menu_tai_khoan.Text = "Quản lý tài khoản";
            this.menu_tai_khoan.Click += new System.EventHandler(this.menu_tai_khoan_Click);
            // 
            // menuItemDoiMatKhau
            // 
            this.menuItemDoiMatKhau.Name = "menuItemDoiMatKhau";
            this.menuItemDoiMatKhau.Size = new System.Drawing.Size(167, 22);
            this.menuItemDoiMatKhau.Text = "Đổi mật khẩu";
            this.menuItemDoiMatKhau.Click += new System.EventHandler(this.menuItemDoiMatKhau_Click);
            // 
            // menuItemLogout
            // 
            this.menuItemLogout.Name = "menuItemLogout";
            this.menuItemLogout.Size = new System.Drawing.Size(167, 22);
            this.menuItemLogout.Text = "Thoát";
            this.menuItemLogout.Click += new System.EventHandler(this.menuItemLogout_Click);
            // 
            // menuDanhMuc
            // 
            this.menuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSP,
            this.menuItemNhaCungCap,
            this.menuItemLoaiSP});
            this.menuDanhMuc.Name = "menuDanhMuc";
            this.menuDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.menuDanhMuc.Text = "Danh mục";
            // 
            // menuItemSP
            // 
            this.menuItemSP.Name = "menuItemSP";
            this.menuItemSP.Size = new System.Drawing.Size(151, 22);
            this.menuItemSP.Text = "Sản phẩm";
            this.menuItemSP.Click += new System.EventHandler(this.menuItemSP_Click);
            // 
            // menuItemNhaCungCap
            // 
            this.menuItemNhaCungCap.Name = "menuItemNhaCungCap";
            this.menuItemNhaCungCap.Size = new System.Drawing.Size(151, 22);
            this.menuItemNhaCungCap.Text = "Nhà cung cấp";
            this.menuItemNhaCungCap.Click += new System.EventHandler(this.menuItemNhaCungCap_Click);
            // 
            // menuItemLoaiSP
            // 
            this.menuItemLoaiSP.Name = "menuItemLoaiSP";
            this.menuItemLoaiSP.Size = new System.Drawing.Size(151, 22);
            this.menuItemLoaiSP.Text = "Loại sản phẩm";
            this.menuItemLoaiSP.Click += new System.EventHandler(this.menuItemLoaiSP_Click);
            // 
            // menuNghiepVu
            // 
            this.menuNghiepVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDatHang,
            this.menuItemNhapHang,
            this.menuItemXuatHang});
            this.menuNghiepVu.Name = "menuNghiepVu";
            this.menuNghiepVu.Size = new System.Drawing.Size(75, 20);
            this.menuNghiepVu.Text = "Nghiệp Vụ";
            // 
            // menuItemDatHang
            // 
            this.menuItemDatHang.Name = "menuItemDatHang";
            this.menuItemDatHang.Size = new System.Drawing.Size(150, 22);
            this.menuItemDatHang.Text = "Đặt hàng";
            this.menuItemDatHang.Click += new System.EventHandler(this.menuItemDatHang_Click);
            // 
            // menuItemNhapHang
            // 
            this.menuItemNhapHang.Name = "menuItemNhapHang";
            this.menuItemNhapHang.Size = new System.Drawing.Size(150, 22);
            this.menuItemNhapHang.Text = "Hóa đơn nhập";
            this.menuItemNhapHang.Click += new System.EventHandler(this.menuItemNhapHang_Click);
            // 
            // menuItemXuatHang
            // 
            this.menuItemXuatHang.Name = "menuItemXuatHang";
            this.menuItemXuatHang.Size = new System.Drawing.Size(150, 22);
            this.menuItemXuatHang.Text = "Hóa đơn xuất";
            this.menuItemXuatHang.Click += new System.EventHandler(this.menuItemXuatHang_Click);
            // 
            // menuBaoCao
            // 
            this.menuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_BCDoanhThu,
            this.báoCáoNhậpHàngToolStripMenuItem,
            this.báoCáoXuấtHàngToolStripMenuItem,
            this.báoCáoTồnKhoToolStripMenuItem});
            this.menuBaoCao.Name = "menuBaoCao";
            this.menuBaoCao.Size = new System.Drawing.Size(61, 20);
            this.menuBaoCao.Text = "Báo cáo";
            // 
            // menuItem_BCDoanhThu
            // 
            this.menuItem_BCDoanhThu.Name = "menuItem_BCDoanhThu";
            this.menuItem_BCDoanhThu.Size = new System.Drawing.Size(176, 22);
            this.menuItem_BCDoanhThu.Text = "Báo cáo doanh thu";
            this.menuItem_BCDoanhThu.Click += new System.EventHandler(this.menuItem_BCDoanhThu_Click);
            // 
            // báoCáoNhậpHàngToolStripMenuItem
            // 
            this.báoCáoNhậpHàngToolStripMenuItem.Name = "báoCáoNhậpHàngToolStripMenuItem";
            this.báoCáoNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.báoCáoNhậpHàngToolStripMenuItem.Text = "Báo cáo nhập hàng";
            // 
            // báoCáoXuấtHàngToolStripMenuItem
            // 
            this.báoCáoXuấtHàngToolStripMenuItem.Name = "báoCáoXuấtHàngToolStripMenuItem";
            this.báoCáoXuấtHàngToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.báoCáoXuấtHàngToolStripMenuItem.Text = "Báo cáo xuất hàng";
            // 
            // báoCáoTồnKhoToolStripMenuItem
            // 
            this.báoCáoTồnKhoToolStripMenuItem.Name = "báoCáoTồnKhoToolStripMenuItem";
            this.báoCáoTồnKhoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.báoCáoTồnKhoToolStripMenuItem.Text = "Báo cáo tồn kho";
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem menu_tai_khoan;
        private System.Windows.Forms.ToolStripMenuItem menuItemDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem menuItemLogout;
        private System.Windows.Forms.ToolStripMenuItem menuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem menuItemSP;
        private System.Windows.Forms.ToolStripMenuItem menuItemNhaCungCap;
        private System.Windows.Forms.ToolStripMenuItem menuNghiepVu;
        private System.Windows.Forms.ToolStripMenuItem menuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem menuItemLoaiSP;
        private System.Windows.Forms.ToolStripMenuItem menuItemDatHang;
        private System.Windows.Forms.ToolStripMenuItem menuItemNhapHang;
        private System.Windows.Forms.ToolStripMenuItem menuItemXuatHang;
        private System.Windows.Forms.ToolStripMenuItem menuItem_BCDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem báoCáoNhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoXuấtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoTồnKhoToolStripMenuItem;
    }
}

