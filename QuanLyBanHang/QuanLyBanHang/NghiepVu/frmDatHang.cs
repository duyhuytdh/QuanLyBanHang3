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
    public partial class frmDatHang : Form
    {
        public frmDatHang()
        {
            InitializeComponent();
        }

        #region private method
        private void loadcboSP()
        {
            this.sanPhamTableAdapter.Fill(this.quanLyBanHangDataSet.SanPham);
        }
        private void loadDatatoGridView()
        {
            this.viewDatHangTableAdapter.Fill(this.quanLyBanHangDataSet.ViewDatHang);
        }
        #endregion

        private void frmDatHang_Load(object sender, EventArgs e)
        {            
            loadcboSP();
            loadDatatoGridView();
        }
 
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate.CheckTextBoxisEmpty(txtMaDatHang)
                    && validate.CheckTextBoxisEmpty(txtSoLuong)
                    && validate.checkisNumber(txtSoLuong)
                    && validate.CheckLookupisSelected(cboSanPham, "Bạn chưa chọn sản phẩm")
                    && validate.checkDateTime(dtNgayDat.Value, dtNgayNhan.Value,"Ngày nhận phải sau ngày đặt"))
                {
                    QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                    DatHang dh = new DatHang();
                    dh.MaDatHang = txtMaDatHang.Text.Trim();
                    dh.NgayDat = dtNgayDat.Value;
                    dh.NgayNhan = dtNgayNhan.Value;
                    dh.IDSP = (long)cboSanPham.EditValue;
                    dh.SoLuong = Convert.ToDouble(txtSoLuong.Text.Trim());
                    if (txtTenKhachHang.Text.Length > 0)
                    {
                        dh.TenKhachHang = txtTenKhachHang.Text.Trim();
                    }
                    if (txtSoDienThoai.Text.Length > 0)
                    {
                        dh.DienThoai = txtSoDienThoai.Text.Trim();
                    }
                    db.DatHangs.Add(dh);
                    db.SaveChanges();
                    loadDatatoGridView();
                    MsgUtil.MessageThemSuccess();
                    
                }
            }
            catch (Exception v_e)
            {

                MsgUtil.MessageThongBao("Lỗi: "+v_e);
            }
        }
    }
}
