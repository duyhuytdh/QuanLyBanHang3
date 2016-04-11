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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
           
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate.CheckTextBoxisEmpty(txtTaiKhoan, "Bạn phải nhập tên tài khoản")
                    && validate.CheckTextBoxisEmpty(txtMatKhau, "Bạn phải nhập mật khẩu"))
                {
                    QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                    TaiKhoan user = db.TaiKhoans.FirstOrDefault(x => x.TaiKhoan1 == txtTaiKhoan.Text
                                        && x.MatKhau == txtMatKhau.Text);
                    if (user != null)
                    {
                        MsgUtil.userID = user.ID;
                        if (user.AdminYN.Trim() == "Y")
                        {
                            MsgUtil.isAdmin = true;
                        }
                        else MsgUtil.isAdmin = false;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                
            }
            catch (Exception v_e)
            {

                MessageBox.Show("Lỗi :"+v_e) ;
            }
        }

    }
}
