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

namespace QuanLyBanHang.HeThong
{
    public partial class frmDoiMatKhau : Form
    {
        QuanLyBanHangEntities db;
        TaiKhoan tk;
        public frmDoiMatKhau()
        {
            InitializeComponent();
            db = new QuanLyBanHangEntities();
        }

        private bool checkPassOldisTrue()
        {
            tk = db.TaiKhoans.FirstOrDefault(x=>x.ID == MsgUtil.userID);
            if (tk.MatKhau == txtPassOld.Text.Trim())
            {
                return true;
            }
            MsgUtil.MessageThongBao("Mật khẩu cũ của bạn không chính xác!");
            return false;
        }

        private bool checkPassNewisEqualPassNewRepeat()
        {
            if (txtPassNew.Text.Trim() == txtPassNewRepeat.Text.Trim())
            {
                return true;
            }
            MsgUtil.MessageThongBao("Mật khẩu mới nhập lại không chính xác");
            return false;
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate.CheckTextBoxisEmpty(txtPassOld)
                    && validate.CheckTextBoxisEmpty(txtPassNew)
                    && validate.CheckTextBoxisEmpty(txtPassNewRepeat)
                    && checkPassOldisTrue()
                    && checkPassNewisEqualPassNewRepeat())
                {
                    tk.MatKhau = txtPassNew.Text.Trim();
                    db.SaveChanges();
                    MsgUtil.MessageThongBao("Bạn đã thay đổi mật khẩu thành công");
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                
                MsgUtil.MessageThongBao("Lỗi: " + v_e);
            }
        }
    }
}
