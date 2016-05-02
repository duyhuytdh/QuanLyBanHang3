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
    public partial class frmHoaDonXuat : Form
    {
        public frmHoaDonXuat()
        {
            InitializeComponent();
        }

        private void loadDatatoGrid()
        {
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet.HoaDonXuat' table. You can move, or remove it, as needed.
            this.hoaDonXuatTableAdapter.Fill(this.quanLyBanHangDataSet.HoaDonXuat);
        }

        private void frmHoaDonXuat_Load(object sender, EventArgs e)
        {

            loadDatatoGrid();
        }

        private bool checkExistMaHDX(QuanLyBanHangEntities db)
        {
            HoaDonXuat dhx = db.HoaDonXuats.FirstOrDefault(x=>x.MaHDX==txtMaHDX.Text.Trim());
            if (dhx == null)
            {
                return true;
            }
            MsgUtil.MessageThongBao("Mã đơn hóa đơn đã tồn tại!");
            return false;
        }

        private void btnChiTietHDX_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                frmChiTietHDX frm = new frmChiTietHDX();
                int index = grvHDX.GetFocusedDataSourceRowIndex();
                long IDHDX = (long)this.quanLyBanHangDataSet.HoaDonXuat.Rows[index]["ID"];
                string MaHDX = this.quanLyBanHangDataSet.HoaDonXuat.Rows[index]["MaHDX"].ToString();
                frm.getDataFromParent(IDHDX, MaHDX);
                frm.ShowDialog();           
            }
            catch (Exception v_e)
            {

                MsgUtil.MessageThongBao("Lỗi: " + v_e);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                if (validate.CheckTextBoxisEmpty(txtMaHDX)
                    && checkExistMaHDX(db))
                {
                    HoaDonXuat hdx = new HoaDonXuat();
                    hdx.IDTK = MsgUtil.userID;
                    hdx.MaHDX = txtMaHDX.Text.Trim();
                    hdx.NgayXuat = dtNgayXuat.Value;
                    if (txtKhachHang.Text.Length > 0)
                    {
                        hdx.TenKhachHang = txtKhachHang.Text.Trim();
                    }
                    if (txtDienThoai.Text.Length > 0)
                    {
                        hdx.DienThoai = txtDienThoai.Text.Trim();
                    }
                    db.HoaDonXuats.Add(hdx);
                    db.SaveChanges();
                    loadDatatoGrid();
                    MsgUtil.MessageThemSuccess();
                }
            }
            catch (Exception v_e)
            {

                MsgUtil.MessageThongBao("Lỗi " + v_e);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadDatatoGrid();
        }
    }
}
