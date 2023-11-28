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
    public partial class FormEmployeeList : Form
    {
        EmployeeService empServ = new EmployeeService();
        DepartmentService deptServ = new DepartmentService();
        public FormEmployeeList()
        {
            InitializeComponent();
        }
        private void FormEmployeeList_Load(object sender, EventArgs e)
        {
            dgvEmployee.DataSource = empServ.GetEmployeeList();
            comboBoxDepartment.DataSource = deptServ.GetAllDepartments();
            comboBoxDepartment.DisplayMember = "Name";
            comboBoxDepartment.ValueMember = "Id";
            comboBoxDepartment.SelectedIndex = -1;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            EmployeeSearchWhere esw = new EmployeeSearchWhere();
            esw.ExistDate = false;
            if (checkBoxName.Checked)
            {
                if (textBoxName.Text == "")
                {
                    CommonHelper.ShowErrorMessageBox("请输入姓名！");
                }
                else
                {
                    esw.Name = textBoxName.Text;
                }
            }
            if (checkBoxTime.Checked)
            {
                esw.ExistDate = true;
                esw.InDayFrom = dtpInDateFrom.Value;
                esw.InDayTo = dtpInDateTo.Value;
            }
            if (checkBoxDepartment.Checked)
            {
                if (comboBoxDepartment.SelectedIndex == -1) 
                {
                    CommonHelper.ShowErrorMessageBox("请选择部门！");
                }
                else
                {
                    esw.DeptId = (Guid)comboBoxDepartment.SelectedValue;
                }
            }
            dgvEmployee.DataSource = empServ.GetEmployeeList(esw);
        }
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            FormEmployeeAdd fea = new FormEmployeeAdd();
            if (fea.ShowDialog() == DialogResult.OK)
            {
                dgvEmployee.DataSource = empServ.GetEmployeeList();
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                Guid id = (Guid)dgvEmployee.SelectedRows[0].Cells[0].Value;
                if (id != Guid.Empty)
                {
                    FormEmployeeAdd fea = new FormEmployeeAdd(id);
                    if (fea.ShowDialog() == DialogResult.OK) 
                    {
                        dgvEmployee.DataSource = empServ.GetEmployeeList();
                    }
                }
                else
                {
                    CommonHelper.ShowErrorMessageBox("无此用户！");
                }
            }
            else
            {
                CommonHelper.ShowErrorMessageBox("请选中一个需要修改的员工信息！");
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count == 1) 
            {
                Guid id = (Guid)dgvEmployee.SelectedRows[0].Cells[0].Value;
                if (CommonHelper.ShowYesNoMessageBox("确定删除该员工吗？") == DialogResult.Yes)
                {
                    empServ.DeleteEmployee(id);
                    dgvEmployee.DataSource = empServ.GetEmployeeList();
                }
            }
            else
            {
                CommonHelper.ShowErrorMessageBox("请选中一个需要删除的员工信息！");
            }
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            string path = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "保存文件";
            sfd.Filter = "Excel 97-2003工作簿(*.xls)|*.xls|Excel 工作簿(*.xlsx)|*.xlsx";
            sfd.RestoreDirectory = true;
            sfd.FileName = "员工信息";
            sfd.FilterIndex = 1;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                path = sfd.FileName.ToString();
            }
            else
            {
                return;
            }
            if (empServ.ExportToExcel(path))
            {
                CommonHelper.ShowSuccessMessageBox("保存成功！");
            }
            else
            {
                CommonHelper.ShowErrorMessageBox("保存失败！");
            }
        }
    }
}
