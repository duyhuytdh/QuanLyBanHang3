using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Model;
using QuanLyBanHang.Help;

namespace QuanLyBanHang.DanhMuc
{
    public partial class frmLoaiSanPham : Form
    {
        private long IDLoaiSP;
        private bool isRowSelected;

        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            loadDatatoGridView();

        }

        void loadDatatoGridView()
        {
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet.LoaiSanPham' table. You can move, or remove it, as needed.
            this.loaiSanPhamTableAdapter.Fill(this.quanLyBanHangDataSet.LoaiSanPham);
        }

        private bool checkMaLoaiExist(QuanLyBanHangEntities db, Boolean isInsert)
        {
            LoaiSanPham loaiSP;
            if (isInsert)
            {
                 loaiSP = db.LoaiSanPhams.FirstOrDefault(x => x.MaLoai == txtMaLoai.Text.Trim());
            }
            else
            {
                 loaiSP = db.LoaiSanPhams.FirstOrDefault(x => x.MaLoai == txtMaLoai.Text.Trim() && x.ID != IDLoaiSP);
            }
            if (loaiSP == null)
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
                if (validate.CheckTextBoxisEmpty(txtMaLoai) && validate.CheckTextBoxisEmpty(txtTenLoai))
                {
                    QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                    LoaiSanPham v_loaiSP = new LoaiSanPham();
                    if (checkMaLoaiExist(db,true))
                    {
                        v_loaiSP.MaLoai = txtMaLoai.Text.Trim();
                    }
                    else
                    {
                        MsgUtil.MessageThongBao("Mã loại sản phẩm đã tồn tại");
                        txtMaLoai.Focus();
                        return;
                    }
                    v_loaiSP.TenLoaiSP = txtTenLoai.Text.Trim();
                    if (txtMoTa.Text.Length > 0)
                    {
                        v_loaiSP.MoTa = txtMoTa.Text.Trim();
                    }
                    if (txtGhiChu.Text.Length > 0)
                    {
                        v_loaiSP.GhiChu = txtGhiChu.Text.Trim();
                    }
                    db.LoaiSanPhams.Add(v_loaiSP);
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
                if (isRowSelected)
                {
                    QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                    LoaiSanPham v_loaiSP = db.LoaiSanPhams.FirstOrDefault(x => x.ID == IDLoaiSP);
                    if (checkMaLoaiExist(db, false))
                    {
                        v_loaiSP.MaLoai = txtMaLoai.Text.Trim();
                    }
                    else
                    {
                        MsgUtil.MessageThongBao("Mã loại sản phẩm đã tồn tại");
                        txtMaLoai.Focus();
                        return;
                    }
                    v_loaiSP.TenLoaiSP = txtTenLoai.Text.Trim();
                    if (txtMoTa.Text.Length > 0)
                    {
                        v_loaiSP.MoTa = txtMoTa.Text.Trim();
                    }
                    if (txtGhiChu.Text.Length > 0)
                    {
                        v_loaiSP.GhiChu = txtGhiChu.Text.Trim();
                    }
                    //db.LoaiSanPhams.Add(v_loaiSP);
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
                if (isRowSelected)
                {

                    QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                    LoaiSanPham v_loaiSP = db.LoaiSanPhams.FirstOrDefault(x => x.ID == IDLoaiSP);
                    db.LoaiSanPhams.Remove(v_loaiSP);
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

        private void grvLoaiSP_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                DataRow row = grvLoaiSP.GetDataRow(grvLoaiSP.GetSelectedRows()[0]);
                txtMaLoai.Text = row["MaLoai"].ToString();
                txtTenLoai.Text = row["TenLoaiSP"].ToString();
                txtMoTa.Text = row["MoTa"].ToString();
                txtGhiChu.Text = row["GhiChu"].ToString();
                IDLoaiSP = Convert.ToInt32(row["ID"].ToString());
                isRowSelected = true;
            }
            catch (Exception v_e)
            {

                MessageBox.Show("Lỗi :" + v_e);
            }
        }
    }
}
