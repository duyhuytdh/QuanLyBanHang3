namespace QuanLyBanHang.DanhMuc
{
    partial class frmSanPham
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.loaiSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanHangDataSet = new QuanLyBanHang.DataSet.QuanLyBanHangDataSet();
            this.loaiSanPhamTableAdapter = new QuanLyBanHang.DataSet.QuanLyBanHangDataSetTableAdapters.LoaiSanPhamTableAdapter();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamTableAdapter = new QuanLyBanHang.DataSet.QuanLyBanHangDataSetTableAdapters.SanPhamTableAdapter();
            this.gridCtrDMSP = new DevExpress.XtraGrid.GridControl();
            this.viewSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvSP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.viewSanPhamTableAdapter = new QuanLyBanHang.DataSet.QuanLyBanHangDataSetTableAdapters.ViewSanPhamTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboNCC = new DevExpress.XtraEditors.LookUpEdit();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaCungCapTableAdapter = new QuanLyBanHang.DataSet.QuanLyBanHangDataSetTableAdapters.NhaCungCapTableAdapter();
            this.cboLoaiSP = new DevExpress.XtraEditors.LookUpEdit();
            this.fKSanPhamLoaiSanPham1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrDMSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSanPhamLoaiSanPham1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đơn vị tính";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(195, 97);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(204, 20);
            this.txtTenSP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Sản Phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Sản Phẩm";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Location = new System.Drawing.Point(195, 65);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(204, 20);
            this.txtMaSP.TabIndex = 3;
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(195, 127);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(131, 20);
            this.txtDVT.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(195, 162);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // loaiSanPhamBindingSource
            // 
            this.loaiSanPhamBindingSource.DataMember = "LoaiSanPham";
            this.loaiSanPhamBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // quanLyBanHangDataSet
            // 
            this.quanLyBanHangDataSet.DataSetName = "QuanLyBanHangDataSet";
            this.quanLyBanHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiSanPhamTableAdapter
            // 
            this.loaiSanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // gridCtrDMSP
            // 
            this.gridCtrDMSP.DataSource = this.viewSanPhamBindingSource;
            gridLevelNode1.RelationName = "Level1";
            this.gridCtrDMSP.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridCtrDMSP.Location = new System.Drawing.Point(49, 208);
            this.gridCtrDMSP.MainView = this.grvSP;
            this.gridCtrDMSP.Name = "gridCtrDMSP";
            this.gridCtrDMSP.Size = new System.Drawing.Size(777, 317);
            this.gridCtrDMSP.TabIndex = 6;
            this.gridCtrDMSP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvSP});
            // 
            // viewSanPhamBindingSource
            // 
            this.viewSanPhamBindingSource.DataMember = "ViewSanPham";
            this.viewSanPhamBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // grvSP
            // 
            this.grvSP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLoai,
            this.colMaNCC,
            this.colTenSP,
            this.colMaSP,
            this.colDonViTinh});
            this.grvSP.GridControl = this.gridCtrDMSP;
            this.grvSP.Name = "grvSP";
            // 
            // colMaLoai
            // 
            this.colMaLoai.Caption = "Mã Loại SP";
            this.colMaLoai.FieldName = "MaLoai";
            this.colMaLoai.Name = "colMaLoai";
            this.colMaLoai.Visible = true;
            this.colMaLoai.VisibleIndex = 0;
            // 
            // colMaNCC
            // 
            this.colMaNCC.Caption = "Mã NCC";
            this.colMaNCC.FieldName = "MaNCC";
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.Visible = true;
            this.colMaNCC.VisibleIndex = 1;
            // 
            // colTenSP
            // 
            this.colTenSP.Caption = "Tên Sản Phẩm";
            this.colTenSP.FieldName = "TenSP";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.Visible = true;
            this.colTenSP.VisibleIndex = 2;
            // 
            // colMaSP
            // 
            this.colMaSP.Caption = "Mã Sản Phẩm";
            this.colMaSP.FieldName = "MaSP";
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.Visible = true;
            this.colMaSP.VisibleIndex = 3;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.Caption = "Đơn vị tính";
            this.colDonViTinh.FieldName = "DonViTinh";
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.Visible = true;
            this.colDonViTinh.VisibleIndex = 4;
            // 
            // viewSanPhamTableAdapter
            // 
            this.viewSanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhà Cung Cấp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Loại SP";
            // 
            // cboNCC
            // 
            this.cboNCC.Location = new System.Drawing.Point(515, 65);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNCC.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaNCC", "Mã NCC"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNCC", "Tên Nhà Cung Cấp")});
            this.cboNCC.Properties.DataSource = this.nhaCungCapBindingSource;
            this.cboNCC.Properties.DisplayMember = "TenNCC";
            this.cboNCC.Properties.NullText = "--Chọn Nhà Cung Cấp--";
            this.cboNCC.Properties.ValueMember = "ID";
            this.cboNCC.Size = new System.Drawing.Size(146, 20);
            this.cboNCC.TabIndex = 8;
            this.cboNCC.EditValueChanged += new System.EventHandler(this.cboNCC_EditValueChanged);
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // nhaCungCapTableAdapter
            // 
            this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.Location = new System.Drawing.Point(515, 104);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLoaiSP.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaLoai", "Mã SP"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenLoaiSP", "Loại Sản Phẩm")});
            this.cboLoaiSP.Properties.DataSource = this.loaiSanPhamBindingSource;
            this.cboLoaiSP.Properties.DisplayMember = "TenLoaiSP";
            this.cboLoaiSP.Properties.NullText = "--Chọn Loại Sản Phẩm--";
            this.cboLoaiSP.Properties.ValueMember = "ID";
            this.cboLoaiSP.Size = new System.Drawing.Size(146, 20);
            this.cboLoaiSP.TabIndex = 9;
            this.cboLoaiSP.EditValueChanged += new System.EventHandler(this.cboLoaiSP_EditValueChanged);
            // 
            // fKSanPhamLoaiSanPham1BindingSource
            // 
            this.fKSanPhamLoaiSanPham1BindingSource.DataMember = "FK_SanPham_LoaiSanPham1";
            this.fKSanPhamLoaiSanPham1BindingSource.DataSource = this.loaiSanPhamBindingSource;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.cboLoaiSP);
            this.Controls.Add(this.cboNCC);
            this.Controls.Add(this.gridCtrDMSP);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrDMSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSanPhamLoaiSanPham1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Button btnThem;
        private DataSet.QuanLyBanHangDataSet quanLyBanHangDataSet;
        private System.Windows.Forms.BindingSource loaiSanPhamBindingSource;
        private DataSet.QuanLyBanHangDataSetTableAdapters.LoaiSanPhamTableAdapter loaiSanPhamTableAdapter;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private DataSet.QuanLyBanHangDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private DevExpress.XtraGrid.GridControl gridCtrDMSP;
        private DevExpress.XtraGrid.Views.Grid.GridView grvSP;
        private System.Windows.Forms.BindingSource viewSanPhamBindingSource;
        private DataSet.QuanLyBanHangDataSetTableAdapters.ViewSanPhamTableAdapter viewSanPhamTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSP;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSP;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.LookUpEdit cboNCC;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private DataSet.QuanLyBanHangDataSetTableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit cboLoaiSP;
        private System.Windows.Forms.BindingSource fKSanPhamLoaiSanPham1BindingSource;
    }
}