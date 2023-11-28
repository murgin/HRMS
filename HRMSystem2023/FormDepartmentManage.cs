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
    public partial class FormDepartmentManage : Form
    {
        DepartmentService depServ = new DepartmentService();
        public FormDepartmentManage()
        {
            InitializeComponent();
        }
        private void FormDepartmentManage_Load(object sender, EventArgs e)
        {
            dataGridViewDepartments.DataSource = depServ.GetDepartmentList();
        }
        private void buttonQuery_Click(object sender, EventArgs e)
        {
            if (textBoxSearchByName.Text == "")
            {
                CommonHelper.ShowErrorMessageBox("请输入需要查找的部门名称!");
            }
            else
            {
                dataGridViewDepartments.DataSource = depServ.GetDepartmentList(textBoxSearchByName.Text);
                textBoxSearchByName.Text = "";
            }
        }
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            dataGridViewDepartments.DataSource = depServ.GetDepartmentList();
        }
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            FormDepartmentAdd fda = new FormDepartmentAdd();
            if (fda.ShowDialog() == DialogResult.OK)
            {
                dataGridViewDepartments.DataSource = depServ.GetDepartmentList();
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewDepartments.SelectedRows.Count == 1)
            {
                Guid id = (Guid)dataGridViewDepartments.SelectedRows[0].Cells[0].Value;
                if (CommonHelper.ShowYesNoMessageBox("确定删除该部门？") == DialogResult.Yes)
                {
                    depServ.DeleteDepartment(id);
                    dataGridViewDepartments.DataSource = depServ.GetDepartmentList();
                }
            }
            else
            {
                CommonHelper.ShowErrorMessageBox("请先选中一个部门！");
            }
        }
    }
}
