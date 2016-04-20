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

namespace QuanLyBanHang.NghiepVu
{
    public partial class frmChiTietHDX : Form
    {
        string mMaHDX;
        long mIDHDX;
        QuanLyBanHangEntities db;
        public frmChiTietHDX()
        {
            InitializeComponent();
        }
        public void getDataFromParent(long IDHDX, string MaHDX)
        {
            mMaHDX = MaHDX;
            mIDHDX = IDHDX;
            txtMaHDX.Text = MaHDX;
        }
        private void loadcboSP()
        {
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.quanLyBanHangDataSet.SanPham);
        }
        private void loadDatatoGrid()
        {
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet.ChiTietHDX' table. You can move, or remove it, as needed.
            grvHDXDetail.DataSource = db.ChiTietHDXes.Where(x => x.IDHDX == mIDHDX).ToList();
            grvHDXDetail.Refresh();
        }

        private void frmChiTietHDX_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet.ViewChiTietHDX' table. You can move, or remove it, as needed.
            this.viewChiTietHDXTableAdapter.Fill(this.quanLyBanHangDataSet.ViewChiTietHDX);
            db = new QuanLyBanHangEntities();
            loadcboSP();
            loadDatatoGrid();
        }
        private void saveData()
        {
            //save data to chitietHDN
            ChiTietHDX ctHDX = new ChiTietHDX();
            ctHDX.IDHDX = mIDHDX;
            ctHDX.IDSP = (long)cboSanPham.EditValue;
            ctHDX.SoLuong = Convert.ToDouble(txtSoLuong.Text.Trim());
            ctHDX.DonGia = Convert.ToDouble(txtDonGia.Text.Trim());
            ctHDX.VAT = Convert.ToDouble(txtVAT.Text.Trim());

            //save data to SanPham: so luong nhap va gia nhap.
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.ID == ctHDX.IDSP);
            sp.SoLuong = sp.SoLuong - ctHDX.SoLuong;
            if (sp.SoLuong < 0)
            {
                MsgUtil.MessageThongBao("Số lượng sản phẩm này trong kho không đủ để xuất! Vui lòng kiểm tra lại.");
                return;
            }
            sp.GiaBan = ctHDX.DonGia * (1 + (Double)ctHDX.VAT/100);

            //save data to HDN
            HoaDonXuat hd = db.HoaDonXuats.FirstOrDefault(x => x.ID == ctHDX.IDHDX);
            hd.TongTien = hd.TongTien + sp.GiaNhap;

            db.ChiTietHDXes.Add(ctHDX);
            db.SaveChanges();
            loadDatatoGrid();
            MsgUtil.MessageThemSuccess();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate.CheckTextBoxisEmpty(txtDonGia)
                    && validate.CheckLookupisSelected(cboSanPham, "Bạn chưa chọn sản phẩm")
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
