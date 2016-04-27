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
    public partial class frmHoaDonNhap : Form
    {
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }
        private void loadDatatoGrid()
        {
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet.HoaDonNhap' table. You can move, or remove it, as needed.
            this.hoaDonNhapTableAdapter.Fill(this.quanLyBanHangDataSet.HoaDonNhap);
        }

        private bool checkExistMaHDN(QuanLyBanHangEntities db)
        {
            HoaDonNhap dhn = db.HoaDonNhaps.FirstOrDefault(x=>x.MaHDN == txtMaHDN.Text.Trim());
            if (dhn == null)
            {
                return true;
            }
            MsgUtil.MessageThongBao("Mã đơn hóa đơn đã tồn tại!");
            return false;
        }

        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            loadDatatoGrid();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                if(validate.CheckTextBoxisEmpty(txtMaHDN)
                    && checkExistMaHDN(db))
                {
                    HoaDonNhap hdn = new HoaDonNhap();
                    hdn.MaHDN = txtMaHDN.Text.Trim();
                    hdn.NgayNhap = dtNgayNhap.Value;
                    hdn.IDTaiKhoan = MsgUtil.userID;
                    hdn.TongTien = 0;
                    db.HoaDonNhaps.Add(hdn);
                    db.SaveChanges();
                    loadDatatoGrid();
                    MsgUtil.MessageThemSuccess();
                }
            }
            catch (Exception v_e)
            {

                MsgUtil.MessageThongBao("Lỗi "+v_e);
            }
        }

        private void btnChiTietHDN_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                frmChiTietHDN frmHDNDetail = new frmChiTietHDN();
                int index = grvHDN.GetFocusedDataSourceRowIndex();
                long IDHDN = (long)this.quanLyBanHangDataSet.HoaDonNhap.Rows[index]["ID"];
                string MaHDN = this.quanLyBanHangDataSet.HoaDonNhap.Rows[index]["MaHDN"].ToString();
                frmHDNDetail.getDataFromParent(IDHDN,MaHDN);
                frmHDNDetail.ShowDialog();
            }
            catch (Exception v_e)
            {
                
                MsgUtil.MessageThongBao("Lỗi: "+v_e);
            }
        }

    }
}
