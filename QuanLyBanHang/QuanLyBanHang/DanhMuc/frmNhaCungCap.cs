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
    public partial class frmNhaCungCap : Form
    {
        private long mID;
        private bool mIsRowSelected;

        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            loadDatatoGridView();
        }

        private void loadDatatoGridView()
        {
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.quanLyBanHangDataSet.NhaCungCap);
        }
        private bool validate_data()
        {
            if (txtMaNCC.Text.Length < 1)
            {
                MsgUtil.MessageThongBao("Bạn chưa nhập mã nhà cung cấp");
                txtMaNCC.Focus();
                return false;
            }
            if (txtTenNCC.Text.Length < 1)
            {
                MessageBox.Show("Bạn chưa nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK);
                txtTenNCC.Focus();
                return false;
            }
            return true;
        }
        private bool checkMaNCCExist(QuanLyBanHangEntities db, bool isInsert)
        {
            NhaCungCap NCC;
            if (isInsert)
            {
                NCC = db.NhaCungCaps.FirstOrDefault(x => x.MaNCC == txtMaNCC.Text.Trim());
            }
            else
            {
                NCC = db.NhaCungCaps.FirstOrDefault(x => x.MaNCC == txtMaNCC.Text.Trim() && x.ID != mID);
            }
            if (NCC == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate_data())
                {
                    QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                    NhaCungCap vNCC = new NhaCungCap();
                    if (checkMaNCCExist(db,true))
                    {
                        vNCC.MaNCC = txtMaNCC.Text.Trim();
                    }
                    else
                    {
                        MsgUtil.MessageThongBao("Mã nhà cung cấp đã tồn tại");
                        txtMaNCC.Focus();
                        return;
                    }
                    vNCC.TenNCC = txtTenNCC.Text.Trim();
                    if (txtEmail.Text.Length > 0)
                    {
                        vNCC.Email = txtEmail.Text.Trim();
                    }
                    if (txtDienThoai.Text.Length > 0)
                    {
                        vNCC.DienThoai = txtDienThoai.Text.Trim();
                    }
                    if (txtDiaChi.Text.Length > 0)
                    {
                        vNCC.DiaChi = txtDiaChi.Text.Trim();
                    }
                    if (txtFax.Text.Length > 0)
                    {
                        vNCC.Fax = txtFax.Text.Trim();
                    }
                    db.NhaCungCaps.Add(vNCC);
                    db.SaveChanges();
                    loadDatatoGridView();
                    MsgUtil.MessageThemSuccess();
                }
            }
            catch (Exception v_e)
            {

                MessageBox.Show("Lỗi :" + v_e);
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (mIsRowSelected)
                {
                    QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                    NhaCungCap vNCC = db.NhaCungCaps.FirstOrDefault(x => x.ID == mID);
                    if (checkMaNCCExist(db,false))
                    {
                        vNCC.MaNCC = txtMaNCC.Text.Trim();
                    }
                    else
                    {
                        MsgUtil.MessageThongBao("Mã nhà cung cấp đã tồn tại");
                        txtMaNCC.Focus();
                        return;
                    }
                    vNCC.TenNCC = txtTenNCC.Text.Trim();
                    if (txtEmail.Text.Length > 0)
                    {
                        vNCC.Email = txtEmail.Text.Trim();
                    }
                    if (txtDienThoai.Text.Length > 0)
                    {
                        vNCC.DienThoai = txtDienThoai.Text.Trim();
                    }
                    if (txtDiaChi.Text.Length > 0)
                    {
                        vNCC.DiaChi = txtDiaChi.Text.Trim();
                    }
                    if (txtFax.Text.Length > 0)
                    {
                        vNCC.Fax = txtFax.Text.Trim();
                    }
                    db.SaveChanges();
                    loadDatatoGridView();
                    MsgUtil.MessageCapNhatSuccess();
                }
            }
            catch (Exception v_e)
            {

                MessageBox.Show("Lỗi :" + v_e);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (mIsRowSelected)
                {

                    QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                    NhaCungCap v_NCC = db.NhaCungCaps.FirstOrDefault(x => x.ID == mID);
                    db.NhaCungCaps.Remove(v_NCC);
                    db.SaveChanges();
                    loadDatatoGridView();
                    MsgUtil.MessageXoaSuccess();
                }
            }
            catch (Exception v_e)
            {

                MessageBox.Show("Lỗi :" + v_e);
            }
        }

        private void grvNCC_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                mIsRowSelected = true;
                DataRow row = grvNCC.GetDataRow(grvNCC.GetSelectedRows()[0]);
                txtMaNCC.Text = row["MaNCC"].ToString();
                txtTenNCC.Text = row["TenNCC"].ToString();
                txtDienThoai.Text = row["TenNCC"].ToString();
                txtEmail.Text = row["DiaChi"].ToString();
                txtFax.Text = row["Fax"].ToString();
                mID = Convert.ToInt32(row["ID"].ToString());
            }
            catch (Exception v_e)
            {
                
                MessageBox.Show("Lỗi :" + v_e);
            }
        }
    }
}
