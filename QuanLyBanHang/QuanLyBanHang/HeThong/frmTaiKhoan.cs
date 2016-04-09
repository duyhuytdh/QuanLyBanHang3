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

namespace QuanLyBanHang
{
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }
        private void btnThemTK_Click(object sender, EventArgs e)
        {
             try
            {
                if (validate.CheckTextBoxisEmpty(txtTaiKhoan) && validate.CheckTextBoxisEmpty(txtMatKhau))
                {
                    QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                    TaiKhoan tk = new TaiKhoan();
                    tk.TaiKhoan1 = txtTaiKhoan.Text.Trim();
                    tk.MatKhau = txtMatKhau.Text.Trim();
                    tk.NgayTao = DateTime.Now;
                    if (checkBoxAdmin.Checked)
                    {
                        tk.AdminYN = "Y";
                    }
                    else
                    {
                        tk.AdminYN = "N";
                    }
                    db.TaiKhoans.Add(tk);
                    db.SaveChanges();
                    loadDatatoGrid();
                    MessageBox.Show("Bạn đã thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
             catch (Exception v_e)
            {

                MessageBox.Show("Lỗi :"+v_e) ;
            }
        }
        void loadDatatoGrid()
        {
            this.taiKhoanTableAdapter.Fill(this.quanLyBanHangDataSet.TaiKhoan);
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            loadDatatoGrid();
        }
    }
}
