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
    public partial class FormDepartmentAdd : Form
    {
        public FormDepartmentAdd()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                CommonHelper.ShowErrorMessageBox("添加的信息不能为空！");
            }
            else
            {
                DepartmentService depServ = new DepartmentService();
                Department dp = new Department();
                dp.Id = Guid.NewGuid();
                dp.Name = textBoxName.Text;
                if (depServ.AddDepartment(dp))
                {
                    this.DialogResult = DialogResult.OK;
                    CommonHelper.ShowSuccessMessageBox("添加成功！");
                }
                else
                {
                    this.DialogResult= DialogResult.Cancel;
                    CommonHelper.ShowErrorMessageBox("添加失败！");
                }
                textBoxName.Text = "";
            }
        }
    }
}
