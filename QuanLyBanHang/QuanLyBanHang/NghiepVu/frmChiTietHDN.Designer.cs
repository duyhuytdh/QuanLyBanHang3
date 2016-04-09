namespace QuanLyBanHang.NghiepVu
{
    partial class frmChiTietHDN
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
            this.c = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.cboSanPham = new DevExpress.XtraEditors.LookUpEdit();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanHangDataSet = new QuanLyBanHang.DataSet.QuanLyBanHangDataSet();
            this.gridCtrHDNDetail = new DevExpress.XtraGrid.GridControl();
            this.grvHDNDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.chiTietHDNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietHDNTableAdapter = new QuanLyBanHang.DataSet.QuanLyBanHangDataSetTableAdapters.ChiTietHDNTableAdapter();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sanPhamTableAdapter = new QuanLyBanHang.DataSet.QuanLyBanHangDataSetTableAdapters.SanPhamTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.hoaDonNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonNhapTableAdapter = new QuanLyBanHang.DataSet.QuanLyBanHangDataSetTableAdapters.HoaDonNhapTableAdapter();
            this.fKChiTietHDNHoaDonNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDHDN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDongia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cboSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrHDNDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHDNDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHDNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKChiTietHDNHoaDonNhapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(325, 20);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(238, 25);
            this.c.TabIndex = 2;
            this.c.Text = "Chi tiết hóa đơn nhập";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(197, 142);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã hóa đơn";
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Location = new System.Drawing.Point(197, 67);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.Size = new System.Drawing.Size(164, 20);
            this.txtMaHDN.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sản Phẩm";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(197, 104);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(136, 20);
            this.txtDonGia.TabIndex = 15;
            // 
            // cboSanPham
            // 
            this.cboSanPham.Location = new System.Drawing.Point(513, 63);
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
            this.cboSanPham.TabIndex = 14;
            this.cboSanPham.EditValueChanged += new System.EventHandler(this.cboSanPham_EditValueChanged);
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
            // gridCtrHDNDetail
            // 
            this.gridCtrHDNDetail.DataSource = this.chiTietHDNBindingSource;
            this.gridCtrHDNDetail.Location = new System.Drawing.Point(28, 182);
            this.gridCtrHDNDetail.MainView = this.grvHDNDetail;
            this.gridCtrHDNDetail.Name = "gridCtrHDNDetail";
            this.gridCtrHDNDetail.Size = new System.Drawing.Size(827, 351);
            this.gridCtrHDNDetail.TabIndex = 18;
            this.gridCtrHDNDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvHDNDetail});
            // 
            // grvHDNDetail
            // 
            this.grvHDNDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colIDHDN,
            this.colIDSP,
            this.colSoLuong,
            this.colDongia,
            this.colVAT});
            this.grvHDNDetail.GridControl = this.gridCtrHDNDetail;
            this.grvHDNDetail.Name = "grvHDNDetail";
            // 
            // chiTietHDNBindingSource
            // 
            this.chiTietHDNBindingSource.DataMember = "ChiTietHDN";
            this.chiTietHDNBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // chiTietHDNTableAdapter
            // 
            this.chiTietHDNTableAdapter.ClearBeforeFill = true;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(513, 104);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(87, 20);
            this.txtSoLuong.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "(VNĐ)";
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(647, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "VAT";
            // 
            // txtVAT
            // 
            this.txtVAT.Location = new System.Drawing.Point(681, 104);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(60, 20);
            this.txtVAT.TabIndex = 15;
            this.txtVAT.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(747, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "(%)";
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Location = new System.Drawing.Point(386, 110);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(29, 13);
            this.lblDonViTinh.TabIndex = 16;
            this.lblDonViTinh.Text = "DVT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "/";
            // 
            // hoaDonNhapBindingSource
            // 
            this.hoaDonNhapBindingSource.DataMember = "HoaDonNhap";
            this.hoaDonNhapBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // hoaDonNhapTableAdapter
            // 
            this.hoaDonNhapTableAdapter.ClearBeforeFill = true;
            // 
            // fKChiTietHDNHoaDonNhapBindingSource
            // 
            this.fKChiTietHDNHoaDonNhapBindingSource.DataMember = "FK_ChiTietHDN_HoaDonNhap";
            this.fKChiTietHDNHoaDonNhapBindingSource.DataSource = this.hoaDonNhapBindingSource;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colIDHDN
            // 
            this.colIDHDN.FieldName = "IDHDN";
            this.colIDHDN.Name = "colIDHDN";
            this.colIDHDN.Visible = true;
            this.colIDHDN.VisibleIndex = 1;
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
            // colDongia
            // 
            this.colDongia.FieldName = "Dongia";
            this.colDongia.Name = "colDongia";
            this.colDongia.Visible = true;
            this.colDongia.VisibleIndex = 4;
            // 
            // colVAT
            // 
            this.colVAT.FieldName = "VAT";
            this.colVAT.Name = "colVAT";
            this.colVAT.Visible = true;
            this.colVAT.VisibleIndex = 5;
            // 
            // frmChiTietHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.gridCtrHDNDetail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDonViTinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.cboSanPham);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaHDN);
            this.Controls.Add(this.c);
            this.Name = "frmChiTietHDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChiTietHDN";
            this.Load += new System.EventHandler(this.frmChiTietHDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrHDNDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHDNDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHDNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKChiTietHDNHoaDonNhapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDonGia;
        private DevExpress.XtraEditors.LookUpEdit cboSanPham;
        private DevExpress.XtraGrid.GridControl gridCtrHDNDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView grvHDNDetail;
        private DataSet.QuanLyBanHangDataSet quanLyBanHangDataSet;
        private System.Windows.Forms.BindingSource chiTietHDNBindingSource;
        private DataSet.QuanLyBanHangDataSetTableAdapters.ChiTietHDNTableAdapter chiTietHDNTableAdapter;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private DataSet.QuanLyBanHangDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource hoaDonNhapBindingSource;
        private DataSet.QuanLyBanHangDataSetTableAdapters.HoaDonNhapTableAdapter hoaDonNhapTableAdapter;
        private System.Windows.Forms.BindingSource fKChiTietHDNHoaDonNhapBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIDHDN;
        private DevExpress.XtraGrid.Columns.GridColumn colIDSP;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colDongia;
        private DevExpress.XtraGrid.Columns.GridColumn colVAT;
    }
}