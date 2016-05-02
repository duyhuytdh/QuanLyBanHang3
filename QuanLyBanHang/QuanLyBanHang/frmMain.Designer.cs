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
            this.ItemBaoCaoNhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBCXuatHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBCTonKho = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong,
            this.menuDanhMuc,
            this.menuNghiepVu,
            this.menuBaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHeThong
            // 
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_tai_khoan,
            this.menuItemDoiMatKhau,
            this.menuItemLogout});
            this.menuHeThong.Image = global::QuanLyBanHang.Properties.Resources.icon17;
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.ShowShortcutKeys = false;
            this.menuHeThong.Size = new System.Drawing.Size(102, 25);
            this.menuHeThong.Text = "Hệ thống";
            // 
            // menu_tai_khoan
            // 
            this.menu_tai_khoan.Image = global::QuanLyBanHang.Properties.Resources.icon19;
            this.menu_tai_khoan.Name = "menu_tai_khoan";
            this.menu_tai_khoan.Size = new System.Drawing.Size(202, 26);
            this.menu_tai_khoan.Text = "Quản lý tài khoản";
            this.menu_tai_khoan.Click += new System.EventHandler(this.menu_tai_khoan_Click);
            // 
            // menuItemDoiMatKhau
            // 
            this.menuItemDoiMatKhau.Image = global::QuanLyBanHang.Properties.Resources.icon8;
            this.menuItemDoiMatKhau.Name = "menuItemDoiMatKhau";
            this.menuItemDoiMatKhau.Size = new System.Drawing.Size(202, 26);
            this.menuItemDoiMatKhau.Text = "Đổi mật khẩu";
            this.menuItemDoiMatKhau.Click += new System.EventHandler(this.menuItemDoiMatKhau_Click);
            // 
            // menuItemLogout
            // 
            this.menuItemLogout.Image = global::QuanLyBanHang.Properties.Resources.icon6;
            this.menuItemLogout.Name = "menuItemLogout";
            this.menuItemLogout.Size = new System.Drawing.Size(202, 26);
            this.menuItemLogout.Text = "Thoát";
            this.menuItemLogout.Click += new System.EventHandler(this.menuItemLogout_Click);
            // 
            // menuDanhMuc
            // 
            this.menuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSP,
            this.menuItemNhaCungCap,
            this.menuItemLoaiSP});
            this.menuDanhMuc.Image = global::QuanLyBanHang.Properties.Resources.icon321;
            this.menuDanhMuc.Name = "menuDanhMuc";
            this.menuDanhMuc.Size = new System.Drawing.Size(109, 25);
            this.menuDanhMuc.Text = "Danh mục";
            // 
            // menuItemSP
            // 
            this.menuItemSP.Image = global::QuanLyBanHang.Properties.Resources.icon18;
            this.menuItemSP.Name = "menuItemSP";
            this.menuItemSP.Size = new System.Drawing.Size(181, 26);
            this.menuItemSP.Text = "Sản phẩm";
            this.menuItemSP.Click += new System.EventHandler(this.menuItemSP_Click);
            // 
            // menuItemNhaCungCap
            // 
            this.menuItemNhaCungCap.Image = global::QuanLyBanHang.Properties.Resources.icon14;
            this.menuItemNhaCungCap.Name = "menuItemNhaCungCap";
            this.menuItemNhaCungCap.Size = new System.Drawing.Size(181, 26);
            this.menuItemNhaCungCap.Text = "Nhà cung cấp";
            this.menuItemNhaCungCap.Click += new System.EventHandler(this.menuItemNhaCungCap_Click);
            // 
            // menuItemLoaiSP
            // 
            this.menuItemLoaiSP.Image = global::QuanLyBanHang.Properties.Resources.icon15;
            this.menuItemLoaiSP.Name = "menuItemLoaiSP";
            this.menuItemLoaiSP.Size = new System.Drawing.Size(181, 26);
            this.menuItemLoaiSP.Text = "Loại sản phẩm";
            this.menuItemLoaiSP.Click += new System.EventHandler(this.menuItemLoaiSP_Click);
            // 
            // menuNghiepVu
            // 
            this.menuNghiepVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDatHang,
            this.menuItemNhapHang,
            this.menuItemXuatHang});
            this.menuNghiepVu.Image = global::QuanLyBanHang.Properties.Resources.icon10;
            this.menuNghiepVu.Name = "menuNghiepVu";
            this.menuNghiepVu.Size = new System.Drawing.Size(112, 25);
            this.menuNghiepVu.Text = "Nghiệp Vụ";
            // 
            // menuItemDatHang
            // 
            this.menuItemDatHang.Image = global::QuanLyBanHang.Properties.Resources.icon28;
            this.menuItemDatHang.Name = "menuItemDatHang";
            this.menuItemDatHang.Size = new System.Drawing.Size(179, 26);
            this.menuItemDatHang.Text = "Đặt hàng";
            this.menuItemDatHang.Click += new System.EventHandler(this.menuItemDatHang_Click);
            // 
            // menuItemNhapHang
            // 
            this.menuItemNhapHang.Image = global::QuanLyBanHang.Properties.Resources.icon30;
            this.menuItemNhapHang.Name = "menuItemNhapHang";
            this.menuItemNhapHang.Size = new System.Drawing.Size(179, 26);
            this.menuItemNhapHang.Text = "Hóa đơn nhập";
            this.menuItemNhapHang.Click += new System.EventHandler(this.menuItemNhapHang_Click);
            // 
            // menuItemXuatHang
            // 
            this.menuItemXuatHang.Image = global::QuanLyBanHang.Properties.Resources.icon16;
            this.menuItemXuatHang.Name = "menuItemXuatHang";
            this.menuItemXuatHang.Size = new System.Drawing.Size(179, 26);
            this.menuItemXuatHang.Text = "Hóa đơn xuất";
            this.menuItemXuatHang.Click += new System.EventHandler(this.menuItemXuatHang_Click);
            // 
            // menuBaoCao
            // 
            this.menuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemBaoCaoNhapHang,
            this.menuItemBCXuatHang,
            this.menuItemBCTonKho});
            this.menuBaoCao.Image = global::QuanLyBanHang.Properties.Resources.icon27;
            this.menuBaoCao.Name = "menuBaoCao";
            this.menuBaoCao.Size = new System.Drawing.Size(92, 25);
            this.menuBaoCao.Text = "Báo cáo";
            // 
            // ItemBaoCaoNhapHang
            // 
            this.ItemBaoCaoNhapHang.Image = global::QuanLyBanHang.Properties.Resources.icon31;
            this.ItemBaoCaoNhapHang.Name = "ItemBaoCaoNhapHang";
            this.ItemBaoCaoNhapHang.Size = new System.Drawing.Size(212, 26);
            this.ItemBaoCaoNhapHang.Text = "Báo cáo nhập hàng";
            this.ItemBaoCaoNhapHang.Click += new System.EventHandler(this.ItemBaoCaoNhapHang_Click);
            // 
            // menuItemBCXuatHang
            // 
            this.menuItemBCXuatHang.Image = global::QuanLyBanHang.Properties.Resources.icon32;
            this.menuItemBCXuatHang.Name = "menuItemBCXuatHang";
            this.menuItemBCXuatHang.Size = new System.Drawing.Size(212, 26);
            this.menuItemBCXuatHang.Text = "Báo cáo xuất hàng";
            this.menuItemBCXuatHang.Click += new System.EventHandler(this.menuItemBCXuatHang_Click);
            // 
            // menuItemBCTonKho
            // 
            this.menuItemBCTonKho.Image = global::QuanLyBanHang.Properties.Resources.icon7;
            this.menuItemBCTonKho.Name = "menuItemBCTonKho";
            this.menuItemBCTonKho.Size = new System.Drawing.Size(212, 26);
            this.menuItemBCTonKho.Text = "Báo cáo tồn kho";
            this.menuItemBCTonKho.Click += new System.EventHandler(this.menuItemBCTonKho_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanHang.Properties.Resources.logo_công_ty;
            this.pictureBox1.Location = new System.Drawing.Point(745, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 147);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(223, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "CÔNG TY TNHH DINH DƯỠNG QUỐC TẾ VIỆT ĐỨC";
            // 
            // frmMain
            // 
            this.BackgroundImage = global::QuanLyBanHang.Properties.Resources.nền5;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem ItemBaoCaoNhapHang;
        private System.Windows.Forms.ToolStripMenuItem menuItemBCXuatHang;
        private System.Windows.Forms.ToolStripMenuItem menuItemBCTonKho;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

