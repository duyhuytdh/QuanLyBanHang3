namespace QuanLyBanHang.NghiepVu
{
    partial class frmDatHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboSanPham = new DevExpress.XtraEditors.LookUpEdit();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanHangDataSet = new QuanLyBanHang.DataSet.QuanLyBanHangDataSet();
            this.dtNgayDat = new System.Windows.Forms.DateTimePicker();
            this.txtMaDatHang = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.gridCtrDatHang = new DevExpress.XtraGrid.GridControl();
            this.viewDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvDatHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDatHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayDat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.sanPhamTableAdapter = new QuanLyBanHang.DataSet.QuanLyBanHangDataSetTableAdapters.SanPhamTableAdapter();
            this.fKDatHangSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QuanLyBanHang.DataSet.QuanLyBanHangDataSetTableAdapters.DatHangTableAdapter();
            this.viewDatHangTableAdapter = new QuanLyBanHang.DataSet.QuanLyBanHangDataSetTableAdapters.ViewDatHangTableAdapter();
            this.quanLyBanHangDataSet1 = new QuanLyBanHang.DataSet.QuanLyBanHangDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.cboSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDatHangSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đặt hàng";
            // 
            // cboSanPham
            // 
            this.cboSanPham.Location = new System.Drawing.Point(231, 95);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSanPham.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaSP", "Mã SP"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenSP", "Tên SP"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.cboSanPham.Properties.DataSource = this.sanPhamBindingSource;
            this.cboSanPham.Properties.DisplayMember = "TenSP";
            this.cboSanPham.Properties.NullText = "----- Chọn Sản Phẩm-----";
            this.cboSanPham.Properties.ValueMember = "ID";
            this.cboSanPham.Size = new System.Drawing.Size(208, 20);
            this.cboSanPham.TabIndex = 1;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // quanLyBanHangDataSet
            // 
            this.quanLyBanHangDataSet.DataSetName = "QuanLyBanHangDataSet";
            this.quanLyBanHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtNgayDat
            // 
            this.dtNgayDat.Location = new System.Drawing.Point(367, 57);
            this.dtNgayDat.Name = "dtNgayDat";
            this.dtNgayDat.Size = new System.Drawing.Size(187, 20);
            this.dtNgayDat.TabIndex = 2;
            // 
            // txtMaDatHang
            // 
            this.txtMaDatHang.Location = new System.Drawing.Point(128, 60);
            this.txtMaDatHang.Name = "txtMaDatHang";
            this.txtMaDatHang.Size = new System.Drawing.Size(164, 20);
            this.txtMaDatHang.TabIndex = 3;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(560, 124);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(116, 20);
            this.txtSoDienThoai.TabIndex = 3;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(560, 91);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(116, 20);
            this.txtSoLuong.TabIndex = 3;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(231, 131);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(208, 20);
            this.txtTenKhachHang.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Đặt Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sản Phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ngày đặt";
            // 
            // dtNgayNhan
            // 
            this.dtNgayNhan.Location = new System.Drawing.Point(656, 57);
            this.dtNgayNhan.Name = "dtNgayNhan";
            this.dtNgayNhan.Size = new System.Drawing.Size(187, 20);
            this.dtNgayNhan.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(591, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ngày nhận";
            // 
            // gridCtrDatHang
            // 
            this.gridCtrDatHang.DataSource = this.viewDatHangBindingSource;
            this.gridCtrDatHang.Location = new System.Drawing.Point(30, 198);
            this.gridCtrDatHang.MainView = this.grvDatHang;
            this.gridCtrDatHang.Name = "gridCtrDatHang";
            this.gridCtrDatHang.Size = new System.Drawing.Size(829, 339);
            this.gridCtrDatHang.TabIndex = 5;
            this.gridCtrDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDatHang});
            // 
            // viewDatHangBindingSource
            // 
            this.viewDatHangBindingSource.DataMember = "ViewDatHang";
            this.viewDatHangBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // grvDatHang
            // 
            this.grvDatHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMaDatHang,
            this.colMaSP,
            this.colTenSP,
            this.colDonViTinh,
            this.colSoLuong,
            this.colNgayDat,
            this.colNgayNhan,
            this.colTenKhachHang,
            this.colDienThoai});
            this.grvDatHang.GridControl = this.gridCtrDatHang;
            this.grvDatHang.Name = "grvDatHang";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colMaDatHang
            // 
            this.colMaDatHang.Caption = "Mã Đặt Hàng";
            this.colMaDatHang.FieldName = "MaDatHang";
            this.colMaDatHang.Name = "colMaDatHang";
            this.colMaDatHang.Visible = true;
            this.colMaDatHang.VisibleIndex = 0;
            this.colMaDatHang.Width = 90;
            // 
            // colMaSP
            // 
            this.colMaSP.FieldName = "MaSP";
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.Visible = true;
            this.colMaSP.VisibleIndex = 1;
            this.colMaSP.Width = 90;
            // 
            // colTenSP
            // 
            this.colTenSP.FieldName = "TenSP";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.Visible = true;
            this.colTenSP.VisibleIndex = 2;
            this.colTenSP.Width = 166;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.FieldName = "DonViTinh";
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.Visible = true;
            this.colDonViTinh.VisibleIndex = 4;
            this.colDonViTinh.Width = 85;
            // 
            // colSoLuong
            // 
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 3;
            this.colSoLuong.Width = 70;
            // 
            // colNgayDat
            // 
            this.colNgayDat.FieldName = "NgayDat";
            this.colNgayDat.Name = "colNgayDat";
            this.colNgayDat.Visible = true;
            this.colNgayDat.VisibleIndex = 5;
            this.colNgayDat.Width = 72;
            // 
            // colNgayNhan
            // 
            this.colNgayNhan.FieldName = "NgayNhan";
            this.colNgayNhan.Name = "colNgayNhan";
            this.colNgayNhan.Visible = true;
            this.colNgayNhan.VisibleIndex = 6;
            this.colNgayNhan.Width = 59;
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.FieldName = "TenKhachHang";
            this.colTenKhachHang.Name = "colTenKhachHang";
            this.colTenKhachHang.Visible = true;
            this.colTenKhachHang.VisibleIndex = 7;
            this.colTenKhachHang.Width = 90;
            // 
            // colDienThoai
            // 
            this.colDienThoai.FieldName = "DienThoai";
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.Visible = true;
            this.colDienThoai.VisibleIndex = 8;
            this.colDienThoai.Width = 89;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(231, 169);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // fKDatHangSanPhamBindingSource
            // 
            this.fKDatHangSanPhamBindingSource.DataMember = "FK_DatHang_SanPham";
            this.fKDatHangSanPhamBindingSource.DataSource = this.sanPhamBindingSource;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // viewDatHangTableAdapter
            // 
            this.viewDatHangTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyBanHangDataSet1
            // 
            this.quanLyBanHangDataSet1.DataSetName = "QuanLyBanHangDataSet";
            this.quanLyBanHangDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gridCtrDatHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtMaDatHang);
            this.Controls.Add(this.dtNgayNhan);
            this.Controls.Add(this.dtNgayDat);
            this.Controls.Add(this.cboSanPham);
            this.Controls.Add(this.label1);
            this.Name = "frmDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDatHang";
            this.Load += new System.EventHandler(this.frmDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDatHangSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit cboSanPham;
        private System.Windows.Forms.DateTimePicker dtNgayDat;
        private System.Windows.Forms.TextBox txtMaDatHang;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtNgayNhan;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraGrid.GridControl gridCtrDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDatHang;
        private System.Windows.Forms.Button btnThem;
        private DataSet.QuanLyBanHangDataSet quanLyBanHangDataSet;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private DataSet.QuanLyBanHangDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private System.Windows.Forms.BindingSource fKDatHangSanPhamBindingSource;
        private DataSet.QuanLyBanHangDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.BindingSource viewDatHangBindingSource;
        private DataSet.QuanLyBanHangDataSetTableAdapters.ViewDatHangTableAdapter viewDatHangTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDatHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSP;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSP;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayDat;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private DataSet.QuanLyBanHangDataSet quanLyBanHangDataSet1;
    }
}