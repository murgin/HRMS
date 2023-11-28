using HRMSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem2023
{
    public partial class FormLogin : Form
    {
        public bool isAdmin;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string un = textBoxUserName.Text.Trim();
            string pwd = textBoxPassWord.Text.Trim();
            SystemGuard sg = new SystemGuard();
            UserType ut = sg.Check(un, CommonHelper.GetMD5(pwd));
            if (ut == UserType.NoUser)
            {
                CommonHelper.ShowErrorMessageBox("用户名不存在！");
                this.DialogResult = DialogResult.Cancel;
            }
            else if (ut == UserType.PassWordError) 
            {
                CommonHelper.ShowErrorMessageBox("密码不正确！");
                this.DialogResult = DialogResult.Cancel;
            }
            else if (ut == UserType.Deleted)
            {
                CommonHelper.ShowErrorMessageBox("无此用户！");
                this.DialogResult = DialogResult.Cancel;
            }
            else if (ut == UserType.Locked)
            {
                CommonHelper.ShowErrorMessageBox("该用户已被锁定。");
                this.DialogResult = DialogResult.Cancel;
            }
            else if(ut == UserType.Admin)
            {
                CommonHelper.ShowSuccessMessageBox("欢迎管理员使用本系统！！！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                CommonHelper.ShowSuccessMessageBox("登陆成功，欢迎使用本系统！");
                this.DialogResult = DialogResult.OK;
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
