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

namespace QuanLyBanHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
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
        #endregion


    }
}
