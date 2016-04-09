namespace QuanLyBanHang.NghiepVu
{
    partial class frmChiTietHDX
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
            this.fKChiTietHDNHoaDonNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanHangDataSet = new QuanLyBanHang.DataSet.QuanLyBanHangDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.sanPhamTableAdapter = new QuanLyBanHang.DataSet.QuanLyBanHangDataSetTableAdapters.SanPhamTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.chiTietHDNTableAdapter = new QuanLyBanHang.DataSet.QuanLyBanHangDataSetTableAdapters.ChiTietHDNTableAdapter();
            this.grvHDXDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridCtrHDXDetail = new DevExpress.XtraGrid.GridControl();
            this.chiTietHDNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.cboSanPham = new DevExpress.XtraEditors.LookUpEdit();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHDX = new System.Windows.Forms.TextBox();
            this.hoaDonNhapTableAdapter = new QuanLyBanHang.DataSet.QuanLyBanHangDataSetTableAdapters.HoaDonNhapTableAdapter();
            this.lblheader = new System.Windows.Forms.Label();
            this.chiTietHDXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietHDXTableAdapter = new QuanLyBanHang.DataSet.QuanLyBanHangDataSetTableAdapters.ChiTietHDXTableAdapter();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDHDX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fKChiTietHDNHoaDonNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHDXDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrHDXDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHDNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHDXBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fKChiTietHDNHoaDonNhapBindingSource
            // 
            this.fKChiTietHDNHoaDonNhapBindingSource.DataMember = "FK_ChiTietHDN_HoaDonNhap";
            this.fKChiTietHDNHoaDonNhapBindingSource.DataSource = this.hoaDonNhapBindingSource;
            // 
            // hoaDonNhapBindingSource
            // 
            this.hoaDonNhapBindingSource.DataMember = "HoaDonNhap";
            this.hoaDonNhapBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // quanLyBanHangDataSet
            // 
            this.quanLyBanHangDataSet.DataSetName = "QuanLyBanHangDataSet";
            this.quanLyBanHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(748, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(648, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "VAT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "/";
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Location = new System.Drawing.Point(387, 114);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(29, 13);
            this.lblDonViTinh.TabIndex = 31;
            this.lblDonViTinh.Text = "DVT";
            // 
            // txtVAT
            // 
            this.txtVAT.Location = new System.Drawing.Point(682, 108);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(60, 20);
            this.txtVAT.TabIndex = 24;
            this.txtVAT.Text = "10";
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "(VNĐ)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(514, 108);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(87, 20);
            this.txtSoLuong.TabIndex = 25;
            // 
            // chiTietHDNTableAdapter
            // 
            this.chiTietHDNTableAdapter.ClearBeforeFill = true;
            // 
            // grvHDXDetail
            // 
            this.grvHDXDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colIDHDX,
            this.colIDSP,
            this.colSoLuong,
            this.colDonGia,
            this.colVAT});
            this.grvHDXDetail.GridControl = this.gridCtrHDXDetail;
            this.grvHDXDetail.Name = "grvHDXDetail";
            // 
            // gridCtrHDXDetail
            // 
            this.gridCtrHDXDetail.DataSource = this.chiTietHDXBindingSource;
            this.gridCtrHDXDetail.Location = new System.Drawing.Point(29, 186);
            this.gridCtrHDXDetail.MainView = this.grvHDXDetail;
            this.gridCtrHDXDetail.Name = "gridCtrHDXDetail";
            this.gridCtrHDXDetail.Size = new System.Drawing.Size(827, 351);
            this.gridCtrHDXDetail.TabIndex = 35;
            this.gridCtrHDXDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvHDXDetail});
            // 
            // chiTietHDNBindingSource
            // 
            this.chiTietHDNBindingSource.DataMember = "ChiTietHDN";
            this.chiTietHDNBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Sản Phẩm";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(198, 108);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(136, 20);
            this.txtDonGia.TabIndex = 26;
            // 
            // cboSanPham
            // 
            this.cboSanPham.Location = new System.Drawing.Point(514, 67);
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
            this.cboSanPham.Size = new System.Drawing.Size(228, 20);
            this.cboSanPham.TabIndex = 23;
            this.cboSanPham.EditValueChanged += new System.EventHandler(this.cboSanPham_EditValueChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(198, 146);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã hóa đơn";
            // 
            // txtMaHDX
            // 
            this.txtMaHDX.Location = new System.Drawing.Point(198, 71);
            this.txtMaHDX.Name = "txtMaHDX";
            this.txtMaHDX.Size = new System.Drawing.Size(164, 20);
            this.txtMaHDX.TabIndex = 20;
            // 
            // hoaDonNhapTableAdapter
            // 
            this.hoaDonNhapTableAdapter.ClearBeforeFill = true;
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.Location = new System.Drawing.Point(326, 24);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(231, 25);
            this.lblheader.TabIndex = 19;
            this.lblheader.Text = "Chi tiết hóa đơn xuất";
            // 
            // chiTietHDXBindingSource
            // 
            this.chiTietHDXBindingSource.DataMember = "ChiTietHDX";
            this.chiTietHDXBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // chiTietHDXTableAdapter
            // 
            this.chiTietHDXTableAdapter.ClearBeforeFill = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colIDHDX
            // 
            this.colIDHDX.FieldName = "IDHDX";
            this.colIDHDX.Name = "colIDHDX";
            this.colIDHDX.Visible = true;
            this.colIDHDX.VisibleIndex = 1;
            // 
            // colIDSP
            // 
            this.colIDSP.FieldName = "IDSP";
            this.colIDSP.Name = "colIDSP";
            this.colIDSP.Visible = true;
            this.colIDSP.VisibleIndex = 2;
            // 
            // colSoLuong
            // 
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 3;
            // 
            // colDonGia
            // 
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 4;
            // 
            // colVAT
            // 
            this.colVAT.FieldName = "VAT";
            this.colVAT.Name = "colVAT";
            this.colVAT.Visible = true;
            this.colVAT.VisibleIndex = 5;
            // 
            // frmChiTietHDX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDonViTinh);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.gridCtrHDXDetail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.cboSanPham);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaHDX);
            this.Controls.Add(this.lblheader);
            this.Name = "frmChiTietHDX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChiTietHDX";
            this.Load += new System.EventHandler(this.frmChiTietHDX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fKChiTietHDNHoaDonNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHDXDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrHDXDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHDNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHDXBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource fKChiTietHDNHoaDonNhapBindingSource;
        private System.Windows.Forms.BindingSource hoaDonNhapBindingSource;
        private DataSet.QuanLyBanHangDataSet quanLyBanHangDataSet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.TextBox txtVAT;
        private DataSet.QuanLyBanHangDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private DataSet.QuanLyBanHangDataSetTableAdapters.ChiTietHDNTableAdapter chiTietHDNTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView grvHDXDetail;
        private DevExpress.XtraGrid.GridControl gridCtrHDXDetail;
        private System.Windows.Forms.BindingSource chiTietHDNBindingSource;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDonGia;
        private DevExpress.XtraEditors.LookUpEdit cboSanPham;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHDX;
        private DataSet.QuanLyBanHangDataSetTableAdapters.HoaDonNhapTableAdapter hoaDonNhapTableAdapter;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.BindingSource chiTietHDXBindingSource;
        private DataSet.QuanLyBanHangDataSetTableAdapters.ChiTietHDXTableAdapter chiTietHDXTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIDHDX;
        private DevExpress.XtraGrid.Columns.GridColumn colIDSP;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colVAT;
    }
}