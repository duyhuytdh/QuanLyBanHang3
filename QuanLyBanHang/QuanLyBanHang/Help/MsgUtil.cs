using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Help
{
    public static class MsgUtil
    {
        public static long userID;
        public static void MessageThongBao(string messageText)
        {
            MessageBox.Show(messageText, "Thông Báo", MessageBoxButtons.OK);
        }
        public static void MessageThemSuccess()
        {
            MessageBox.Show("Bạn đã thêm mới thành công!", "Thông Báo", MessageBoxButtons.OK);
        }
    }
}
