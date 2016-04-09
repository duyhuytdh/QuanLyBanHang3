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
        private bool checkMaNCCExist(QuanLyBanHangEntities db)
        {
            NhaCungCap NCC = db.NhaCungCaps.FirstOrDefault(x => x.MaNCC == txtMaNCC.Text.Trim());
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
                    if (checkMaNCCExist(db))
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
    }
}
