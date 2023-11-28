using HRMSystem.BLL;
using HRMSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem2023
{
    public partial class FormPwdModify : Form
    {
        public FormPwdModify()
        {
            InitializeComponent();
        }
        private void buttonModify_Click(object sender, EventArgs e)
        {
            LoginUser lu = LoginUser.GetInstance();
            if(!lu.Password.Equals(CommonHelper.GetMD5(textBoxPwdBefore.Text)))
            {
                CommonHelper.ShowErrorMessageBox("原密码输入错误!");
            }
            else if (textBoxPwdAfter.Text.Trim() == "")
            {
                CommonHelper.ShowErrorMessageBox("修改后的密码不能为空！");
            }
            else
            {
                OperatorService opServ = new OperatorService();
                opServ.PwdModify(lu.UserName, CommonHelper.GetMD5(textBoxPwdAfter.Text));
                lu.Password = CommonHelper.GetMD5(textBoxPwdAfter.Text);
                CommonHelper.ShowSuccessMessageBox("密码修改成功!");
                this.Close();
            }
        }
        private void FormPasswordModify_Load(object sender, EventArgs e)
        {
            LoginUser lu = LoginUser.GetInstance();
            labelShow.Text = "当前用户名：" + lu.UserName;
        }
    }
}
