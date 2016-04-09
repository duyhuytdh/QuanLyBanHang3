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

namespace QuanLyBanHang.DanhMuc
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        #region private method
        private void loadCboNCC()
        {
            this.nhaCungCapTableAdapter.Fill(this.quanLyBanHangDataSet.NhaCungCap);    
        }
        private void loadCboLoaiSP()
        {
            this.loaiSanPhamTableAdapter.Fill(this.quanLyBanHangDataSet.LoaiSanPham);
        }
        private void loadDatatoGrid()
        {
            this.viewSanPhamTableAdapter.Fill(this.quanLyBanHangDataSet.ViewSanPham);
        }
        private void generateMaSP()
        {
            txtMaSP.Text = cboLoaiSP.GetColumnValue("MaLoai").ToString() + Convert.ToDateTime(DateTime.Now).ToString("yyyyMMddhmmss");
        }

        #endregion
        #region Event

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate.CheckTextBoxisEmpty(txtMaSP,"Hãy chọn loại sản phẩm để hệ thống tự động sinh mã sản phẩm")
               && validate.CheckTextBoxisEmpty(txtTenSP)
               && validate.CheckTextBoxisEmpty(txtDVT)
               && validate.CheckLookupisSelected(cboNCC,"Bạn chưa chọn nhà cung cấp")
               && validate.CheckLookupisSelected(cboLoaiSP,"Bạn chưa chọn loại sản phẩm"))
                {
                    QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                    SanPham sp = new SanPham();
                    sp.IDLoaiSP = (long)cboLoaiSP.EditValue;
                    sp.IDNCC = (long)cboNCC.EditValue;
                    sp.MaSP = txtMaSP.Text.Trim();
                    sp.TenSP = txtTenSP.Text.Trim();
                    sp.DonViTinh = txtDVT.Text.Trim();
                    sp.SoLuong = 0;
                    sp.GiaBan = 0;
                    sp.GiaNhap = 0;
                    db.SanPhams.Add(sp);
                    db.SaveChanges();
                    MsgUtil.MessageThemSuccess();
                    loadDatatoGrid();
                }
            }
            catch (Exception v_e)
            {         
                MsgUtil.MessageThongBao("Lỗi "+v_e);
            }
           
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            loadCboNCC();
            loadCboLoaiSP();
            loadDatatoGrid();
        }

        private void cboNCC_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cboLoaiSP_EditValueChanged(object sender, EventArgs e)
        {
            generateMaSP();
        }
#endregion

     
    }
}
