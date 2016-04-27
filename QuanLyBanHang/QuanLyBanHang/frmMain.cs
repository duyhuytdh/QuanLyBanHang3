using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.DanhMuc;
using QuanLyBanHang.HeThong;
using QuanLyBanHang.NghiepVu;
using QuanLyBanHang.BaoCao;
using QuanLyBanHang.Help;
using DevExpress.XtraReports.UI;

namespace QuanLyBanHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void PhanQuyen()
        {
            //Phân quyền truy cập
            if (!MsgUtil.isAdmin)
            {
                menu_tai_khoan.Enabled = false;
                menuBaoCao.Enabled = false;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {   
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
            PhanQuyen();
        }

        #region Event

        #region He thong
        private void menu_tai_khoan_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frmTaiKhoan = new frmTaiKhoan();
            frmTaiKhoan.ShowDialog();
        }
        private void menuItemLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void menuItemDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }
        #endregion

        #region Danh muc
        private void menuItemLoaiSP_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham frmLoaiSP = new frmLoaiSanPham();
            frmLoaiSP.ShowDialog();
        }

        private void menuItemNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frmNCC = new frmNhaCungCap();
            frmNCC.ShowDialog();
        }
        private void menuItemSP_Click(object sender, EventArgs e)
        {
            frmSanPham frmSP = new frmSanPham();
            frmSP.ShowDialog();
        }
        #endregion

        #region Nghiep Vu
        private void menuItemDatHang_Click(object sender, EventArgs e)
        {
            frmDatHang frm = new frmDatHang();
            frm.ShowDialog();
        }

        private void menuItemNhapHang_Click(object sender, EventArgs e)
        {
            frmHoaDonNhap frm = new frmHoaDonNhap();
            frm.ShowDialog();
        }

        private void menuItemXuatHang_Click(object sender, EventArgs e)
        {
            frmHoaDonXuat frm = new frmHoaDonXuat();
            frm.ShowDialog();
        }
        #endregion

        #region Bao Cao

        private void menuItem_BCDoanhThu_Click(object sender, EventArgs e)
        {
            BCDoanhThu bc = new BCDoanhThu();
            ReportPrintTool tool = new ReportPrintTool(bc);
            tool.ShowPreviewDialog();
        }

        private void ItemBaoCaoNhapHang_Click(object sender, EventArgs e)
        {
            BCNhapHang bc = new BCNhapHang();
            ReportPrintTool tool = new ReportPrintTool(bc);
            tool.ShowPreviewDialog();
        }

        private void menuItemBCXuatHang_Click(object sender, EventArgs e)
        {
            BCXuatHang bc = new BCXuatHang();
            ReportPrintTool tool = new ReportPrintTool(bc);
            tool.ShowPreviewDialog();
        }

        private void menuItemBCTonKho_Click(object sender, EventArgs e)
        {
            BCTonKho bc = new BCTonKho();
            ReportPrintTool tool = new ReportPrintTool(bc);
            tool.ShowPreviewDialog();
        }

        #endregion

        #endregion

   


    }
}
