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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.chiTietHDXBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.chiTietHDXTableAdapter = new QuanLyBanHang.DataSet.QuanLyBanHangDataSetTableAdapters.ChiTietHDXTableAdapter();
            this.viewChiTietHDXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewChiTietHDXTableAdapter = new QuanLyBanHang.DataSet.QuanLyBanHangDataSetTableAdapters.ViewChiTietHDXTableAdapter();
            this.grvHDXDetail = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDHDXDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSPDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinhDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fKChiTietHDNHoaDonNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHDXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHDNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewChiTietHDXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHDXDetail)).BeginInit();
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
            this.label7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(748, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(636, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "VAT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(346, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "/";
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonViTinh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDonViTinh.Location = new System.Drawing.Point(358, 111);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(36, 16);
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
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(311, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "(VNĐ)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(438, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
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
            // chiTietHDXBindingSource
            // 
            this.chiTietHDXBindingSource.DataMember = "ChiTietHDX";
            this.chiTietHDXBindingSource.DataSource = this.quanLyBanHangDataSet;
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
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(65, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(438, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Sản Phẩm";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(150, 104);
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
            this.btnThem.Location = new System.Drawing.Point(150, 146);
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
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(65, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã hóa đơn";
            // 
            // txtMaHDX
            // 
            this.txtMaHDX.Enabled = false;
            this.txtMaHDX.Location = new System.Drawing.Point(150, 67);
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
            this.lblheader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblheader.Location = new System.Drawing.Point(308, 22);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(282, 31);
            this.lblheader.TabIndex = 19;
            this.lblheader.Text = "Chi tiết hóa đơn xuất";
            // 
            // chiTietHDXTableAdapter
            // 
            this.chiTietHDXTableAdapter.ClearBeforeFill = true;
            // 
            // viewChiTietHDXBindingSource
            // 
            this.viewChiTietHDXBindingSource.DataMember = "ViewChiTietHDX";
            this.viewChiTietHDXBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // viewChiTietHDXTableAdapter
            // 
            this.viewChiTietHDXTableAdapter.ClearBeforeFill = true;
            // 
            // grvHDXDetail
            // 
            this.grvHDXDetail.AllowUserToAddRows = false;
            this.grvHDXDetail.AutoGenerateColumns = false;
            this.grvHDXDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvHDXDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.iDHDXDataGridViewTextBoxColumn1,
            this.iDSPDataGridViewTextBoxColumn1,
            this.tenSPDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn1,
            this.donGiaDataGridViewTextBoxColumn1,
            this.vATDataGridViewTextBoxColumn1,
            this.donViTinhDataGridViewTextBoxColumn1,
            this.thanhTienDataGridViewTextBoxColumn1});
            this.grvHDXDetail.DataSource = this.viewChiTietHDXBindingSource;
            this.grvHDXDetail.Location = new System.Drawing.Point(32, 198);
            this.grvHDXDetail.Name = "grvHDXDetail";
            this.grvHDXDetail.Size = new System.Drawing.Size(822, 335);
            this.grvHDXDetail.TabIndex = 36;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // iDHDXDataGridViewTextBoxColumn1
            // 
            this.iDHDXDataGridViewTextBoxColumn1.DataPropertyName = "IDHDX";
            this.iDHDXDataGridViewTextBoxColumn1.HeaderText = "IDHDX";
            this.iDHDXDataGridViewTextBoxColumn1.Name = "iDHDXDataGridViewTextBoxColumn1";
            this.iDHDXDataGridViewTextBoxColumn1.Visible = false;
            // 
            // iDSPDataGridViewTextBoxColumn1
            // 
            this.iDSPDataGridViewTextBoxColumn1.DataPropertyName = "IDSP";
            this.iDSPDataGridViewTextBoxColumn1.HeaderText = "IDSP";
            this.iDSPDataGridViewTextBoxColumn1.Name = "iDSPDataGridViewTextBoxColumn1";
            this.iDSPDataGridViewTextBoxColumn1.Visible = false;
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "Tên Sản Phẩm";
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            this.tenSPDataGridViewTextBoxColumn.Width = 230;
            // 
            // soLuongDataGridViewTextBoxColumn1
            // 
            this.soLuongDataGridViewTextBoxColumn1.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn1.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn1.Name = "soLuongDataGridViewTextBoxColumn1";
            // 
            // donGiaDataGridViewTextBoxColumn1
            // 
            this.donGiaDataGridViewTextBoxColumn1.DataPropertyName = "DonGia";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "###,###";
            this.donGiaDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.donGiaDataGridViewTextBoxColumn1.HeaderText = "Đơn giá";
            this.donGiaDataGridViewTextBoxColumn1.Name = "donGiaDataGridViewTextBoxColumn1";
            // 
            // vATDataGridViewTextBoxColumn1
            // 
            this.vATDataGridViewTextBoxColumn1.DataPropertyName = "VAT";
            this.vATDataGridViewTextBoxColumn1.HeaderText = "VAT";
            this.vATDataGridViewTextBoxColumn1.Name = "vATDataGridViewTextBoxColumn1";
            // 
            // donViTinhDataGridViewTextBoxColumn1
            // 
            this.donViTinhDataGridViewTextBoxColumn1.DataPropertyName = "DonViTinh";
            this.donViTinhDataGridViewTextBoxColumn1.HeaderText = "Đơn vị tính";
            this.donViTinhDataGridViewTextBoxColumn1.Name = "donViTinhDataGridViewTextBoxColumn1";
            // 
            // thanhTienDataGridViewTextBoxColumn1
            // 
            this.thanhTienDataGridViewTextBoxColumn1.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle2.Format = "###,###";
            this.thanhTienDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.thanhTienDataGridViewTextBoxColumn1.HeaderText = "Thành Tiền";
            this.thanhTienDataGridViewTextBoxColumn1.Name = "thanhTienDataGridViewTextBoxColumn1";
            this.thanhTienDataGridViewTextBoxColumn1.Width = 150;
            // 
            // frmChiTietHDX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanHang.Properties.Resources.màu_xám;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.grvHDXDetail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDonViTinh);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoLuong);
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
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHDXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHDNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewChiTietHDXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHDXDetail)).EndInit();
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
        private System.Windows.Forms.BindingSource viewChiTietHDXBindingSource;
        private DataSet.QuanLyBanHangDataSetTableAdapters.ViewChiTietHDXTableAdapter viewChiTietHDXTableAdapter;
        private System.Windows.Forms.DataGridView grvHDXDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHDXDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSPDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinhDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn1;
    }
}