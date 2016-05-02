using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Help;
using QuanLyBanHang.Model;
using DevExpress.XtraGrid.Columns;

namespace QuanLyBanHang.NghiepVu
{
    public partial class frmChiTietHDN : Form
    {
        String mMaHDN;
        long mIDHDN;
        QuanLyBanHangEntities db;

        public frmChiTietHDN()
        {
            InitializeComponent();
            txtMaHDN.Enabled = false;
        }
        public void getDataFromParent(long IDHDN, string MaHDN)
        {
            mMaHDN = MaHDN;
            mIDHDN = IDHDN;
            txtMaHDN.Text = MaHDN;
        }
        private void loadcboSP()
        {
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.quanLyBanHangDataSet.SanPham);
        }
        private void loadDatatoGridView()
        {
            grvHDNDetail.DataSource = db.ViewChiTietHDNs.Where(x => x.IDHDN == mIDHDN)
                                                        .ToList();
            grvHDNDetail.Refresh();
        }

        private void frmChiTietHDN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet.ViewChiTietHDN' table. You can move, or remove it, as needed.
            this.viewChiTietHDNTableAdapter.Fill(this.quanLyBanHangDataSet.ViewChiTietHDN);
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet.HoaDonNhap' table. You can move, or remove it, as needed.
            this.hoaDonNhapTableAdapter.Fill(this.quanLyBanHangDataSet.HoaDonNhap);
            loadcboSP();
            db = new QuanLyBanHangEntities();
            loadDatatoGridView();
        }

        private void saveData()
        {
            //save data to chitietHDN
            ChiTietHDN ctHDN = new ChiTietHDN();
            ctHDN.IDHDN = mIDHDN;
            ctHDN.IDSP = (long)cboSanPham.EditValue;
            ctHDN.SoLuong = Convert.ToDouble(txtSoLuong.Text.Trim());
            ctHDN.Dongia = Convert.ToDouble(txtDonGia.Text.Trim());
            ctHDN.VAT = Convert.ToDouble(txtVAT.Text.Trim());

            //save data to SanPham: so luong nhap va gia nhap.
            SanPham sp = db.SanPhams.FirstOrDefault(x=>x.ID==ctHDN.IDSP);
            sp.SoLuong = sp.SoLuong + ctHDN.SoLuong;
            sp.GiaNhap = ctHDN.Dongia * (1 + ctHDN.VAT / 100);

            //save data to HDN
            HoaDonNhap hd = db.HoaDonNhaps.FirstOrDefault(x=>x.ID == ctHDN.IDHDN);
            hd.TongTien = hd.TongTien + sp.GiaNhap * ctHDN.SoLuong;

            db.ChiTietHDNs.Add(ctHDN);
            db.SaveChanges();
            loadDatatoGridView();
            MsgUtil.MessageThemSuccess();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate.CheckTextBoxisEmpty(txtDonGia)
                    && validate.CheckLookupisSelected(cboSanPham,"Bạn chưa chọn sản phẩm")
                    && validate.CheckTextBoxisEmpty(txtSoLuong)
                    && validate.CheckTextBoxisEmpty(txtVAT)
                    && validate.checkisNumber(txtDonGia)
                    && validate.checkisNumber(txtSoLuong)
                    && validate.checkisNumber(txtVAT))
                {
                    saveData();
                }
            }
            catch (Exception v_e)
            {

                MsgUtil.MessageThongBao("Lỗi: " + v_e);
            }
        }

        private void cboSanPham_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboSanPham.ItemIndex >= 0)
                {
                    lblDonViTinh.Text = this.quanLyBanHangDataSet.SanPham.FindByID((long)cboSanPham.EditValue).DonViTinh;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
