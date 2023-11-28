using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem2023
{
    class CommonHelper
    {
        public static string GetMD5(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            byte[] md5Bytes = md5.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in md5Bytes)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
        public static void ShowSuccessMessageBox(string msg)
        {
            MessageBox.Show(msg, "操作成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowErrorMessageBox(string msg)
        {
            MessageBox.Show(msg, "操作失败提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult ShowYesNoMessageBox(string msg)
        {
            return MessageBox.Show(msg, "确认提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
