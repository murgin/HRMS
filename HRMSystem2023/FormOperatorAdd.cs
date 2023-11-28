using HRMSystem.DAL;
using HRMSystem.Model;
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
    public partial class FormOperatorAdd : Form
    {
        public FormOperatorAdd()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OperatorService opServ = new OperatorService(); 
            if (textBoxUserName.Text == "" || textBoxPassword.Text == "" || textBoxPassword.Text == "")
            {
                CommonHelper.ShowErrorMessageBox("添加的信息不能为空！");
            }
            else
            {
                Operator op = new Operator();
                op.Id = Guid.NewGuid();
                op.RealName = textBoxRealName.Text;
                op.UserName = textBoxUserName.Text;
                op.Password = CommonHelper.GetMD5(textBoxPassword.Text);
                if (opServ.AddOperator(op))
                {
                    this.DialogResult = DialogResult.OK;
                    CommonHelper.ShowSuccessMessageBox("添加成功！");
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                    CommonHelper.ShowErrorMessageBox("添加失败！");
                }
                textBoxRealName.Text = "";
                textBoxUserName.Text = "";
                textBoxPassword.Text = "";
            }
        }
    }
}
