using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Help
{
    public static class validate
    {
        public static bool CheckTextBoxisEmpty(TextBox textBox, String message){
            if (textBox.Text.Length < 1)
            {
                MsgUtil.MessageThongBao(message);
                textBox.Focus();
                return false;
            }
            else return true;
        }
        public static bool CheckTextBoxisEmpty(TextBox textBox)
        {
            if (textBox.Text.Length < 1)
            {
                MsgUtil.MessageThongBao("Bạn không được để trống trường này!");
                textBox.Focus();
                return false;
            }
            else return true;
        }
        public static bool CheckLookupisSelected(DevExpress.XtraEditors.LookUpEdit cbo, string message)
        {
            if ((int)cbo.ItemIndex < 0)
            {
                MsgUtil.MessageThongBao(message);
                return false;
            }
            else return true;
        }
        public static bool checkDateTime(DateTime ngayDau, DateTime ngayCuoi, String message)
        {
            if (ngayDau > ngayCuoi)
            {
                MsgUtil.MessageThongBao(message);
                return false;
            }
            else return true;
        }
        public static bool checkisNumber(TextBox txt)
        {
            double num;
            string candidate = txt.Text;
            if (double.TryParse(candidate, out num))
            {
                if (num <= 0)
                {
                    MsgUtil.MessageThongBao("Bạn phải nhập số dương");
                    return false;
                }
                return true;
            }
            else  
            {
                MsgUtil.MessageThongBao("Bạn phải nhập kiểu số");
                return false;
            }
        }
        
    }
}
