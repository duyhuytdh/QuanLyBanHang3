namespace QuanLyBanHang.NghiepVu
{
    partial class frmHoaDonNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDonNhap));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.c = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.gridCtrHDN = new DevExpress.XtraGrid.GridControl();
            this.hoaDonNhapBindingSource = new System.Windows.Forms.BindingSource();
            this.quanLyBanHangDataSet = new QuanLyBanHang.DataSet.QuanLyBanHangDataSet();
            this.grvHDN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaHDN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnChiTietHDN = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnThem = new System.Windows.Forms.Button();
            this.hoaDonNhapTableAdapter = new QuanLyBanHang.DataSet.QuanLyBanHangDataSetTableAdapters.HoaDonNhapTableAdapter();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrHDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChiTietHDN)).BeginInit();
            this.SuspendLayout();
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.BackColor = System.Drawing.SystemColors.ControlDark;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.c.Location = new System.Drawing.Point(373, 19);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(195, 31);
            this.c.TabIndex = 1;
            this.c.Text = "Hóa đơn nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(141, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã hóa đơn";
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHDN.Location = new System.Drawing.Point(232, 68);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.Size = new System.Drawing.Size(164, 22);
            this.txtMaHDN.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(435, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ngày nhập";
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayNhap.Location = new System.Drawing.Point(528, 69);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(187, 22);
            this.dtNgayNhap.TabIndex = 7;
            // 
            // gridCtrHDN
            // 
            this.gridCtrHDN.DataSource = this.hoaDonNhapBindingSource;
            this.gridCtrHDN.Location = new System.Drawing.Point(93, 173);
            this.gridCtrHDN.MainView = this.grvHDN;
            this.gridCtrHDN.Name = "gridCtrHDN";
            this.gridCtrHDN.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnChiTietHDN});
            this.gridCtrHDN.Size = new System.Drawing.Size(699, 348);
            this.gridCtrHDN.TabIndex = 9;
            this.gridCtrHDN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvHDN});
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
            // grvHDN
            // 
            this.grvHDN.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.grvHDN.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grvHDN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMaHDN,
            this.colNgayNhap,
            this.colTongTien,
            this.gridColumn1});
            this.grvHDN.GridControl = this.gridCtrHDN;
            this.grvHDN.Name = "grvHDN";
            this.grvHDN.OptionsFind.AlwaysVisible = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colMaHDN
            // 
            this.colMaHDN.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaHDN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaHDN.FieldName = "MaHDN";
            this.colMaHDN.Name = "colMaHDN";
            this.colMaHDN.Visible = true;
            this.colMaHDN.VisibleIndex = 0;
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.Caption = "Ngày nhập";
            this.colNgayNhap.FieldName = "NgayNhap";
            this.colNgayNhap.Name = "colNgayNhap";
            this.colNgayNhap.Visible = true;
            this.colNgayNhap.VisibleIndex = 1;
            // 
            // colTongTien
            // 
            this.colTongTien.Caption = "Tổng tiền";
            this.colTongTien.FieldName = "TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Chi tiết HDN";
            this.gridColumn1.ColumnEdit = this.btnChiTietHDN;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // btnChiTietHDN
            // 
            this.btnChiTietHDN.AutoHeight = false;
            this.btnChiTietHDN.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnChiTietHDN.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnChiTietHDN.Name = "btnChiTietHDN";
            this.btnChiTietHDN.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnChiTietHDN.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnChiTietHDN_ButtonClick);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(232, 121);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // hoaDonNhapTableAdapter
            // 
            this.hoaDonNhapTableAdapter.ClearBeforeFill = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(93, 144);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanHang.Properties.Resources.màu_xám;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gridCtrHDN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtNgayNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaHDN);
            this.Controls.Add(this.c);
            this.Name = "frmHoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmHoaDonNhap";
            this.Load += new System.EventHandler(this.frmHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrHDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChiTietHDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHDN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private DevExpress.XtraGrid.GridControl gridCtrHDN;
        private DevExpress.XtraGrid.Views.Grid.GridView grvHDN;
        private System.Windows.Forms.Button btnThem;
        private DataSet.QuanLyBanHangDataSet quanLyBanHangDataSet;
        private System.Windows.Forms.BindingSource hoaDonNhapBindingSource;
        private DataSet.QuanLyBanHangDataSetTableAdapters.HoaDonNhapTableAdapter hoaDonNhapTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHDN;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnChiTietHDN;
        private System.Windows.Forms.Button btnRefresh;
    }
}