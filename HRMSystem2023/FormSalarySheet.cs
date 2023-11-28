using HRMSystem.BLL;
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
    public partial class FormSalarySheet : Form
    {
        public FormSalarySheet()
        {
            InitializeComponent();
        }

        private void FormSalarySheet_Load(object sender, EventArgs e)
        {
            ComboSource cs = new ComboSource();
            comboBoxDepartment.DataSource = cs.GetDepartmentSource();
            comboBoxDepartment.DisplayMember = "Name";
            comboBoxDepartment.ValueMember = "Id";
            comboBoxDepartment.SelectedIndex = -1;
            DataTable years = new DataTable();
            years.Columns.Add("Year");
            years.Columns.Add("Value");
            for (int i = 2012; i <= DateTime.Now.Year; i++)
            {
                DataRow dr = years.NewRow();
                dr["Year"] = i.ToString();
                dr["Value"] = i;
                years.Rows.Add(dr);
            }
            comboBoxYear.DataSource = years;
            comboBoxYear.DisplayMember = "Year";
            comboBoxYear.ValueMember = "Value";
            comboBoxYear.SelectedValue = DateTime.Now.Year;
            DataTable months = new DataTable();
            months.Columns.Add("Month");
            months.Columns.Add("Value");
            for (int i = 1; i <= 12; i++)
            {
                DataRow dr = months.NewRow();
                dr["Month"] = i.ToString();
                dr["Value"] = i;
                months.Rows.Add(dr);
            }
            comboBoxMonth.DataSource = months;
            comboBoxMonth.DisplayMember = "Month";
            comboBoxMonth.ValueMember = "Value";
            comboBoxMonth.SelectedValue = DateTime.Now.Month;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            SheetProcess sp = new SheetProcess();
            if (comboBoxYear.SelectedIndex == -1 || comboBoxMonth.SelectedIndex == -1 || comboBoxDepartment.SelectedIndex == -1)
            {
                CommonHelper.ShowErrorMessageBox("请选择年、月和部门！");
                return;
            }
            SalarySheet ss = new SalarySheet();
            ss.Year = Convert.ToInt32(comboBoxYear.SelectedValue);
            ss.Month = Convert.ToInt32(comboBoxMonth.SelectedValue);
            ss.DepartmentId = (Guid)comboBoxDepartment.SelectedValue;
            if (!sp.IsEmployeeExist(ss))
            {
                CommonHelper.ShowErrorMessageBox("该部门不存在员工！");
                return;
            }
            if (sp.IsSalarySheetExist(ss))
            {
                ss.Id = sp.GetSalarySheetId(ss);
                if (CommonHelper.ShowYesNoMessageBox("该部门的工资单已经存在，是否提取原工资单？[是]提取原工资单，[否]重新生成新的工资单") == DialogResult.Yes)
                {
                    dgvSalarySheet.DataSource = sp.GetSalarySheetItem(ss.Id);
                }
                else
                {
                    sp.RebuildSalarySheetItem(ss);
                    dgvSalarySheet.DataSource = sp.GetSalarySheetItem(ss.Id);
                }
            }
            else
            {
                ss.Id = Guid.NewGuid();
                sp.GenerateSalarySheet(ss);
                sp.BuildSalarySheetItem(ss);
                dgvSalarySheet.DataSource = sp.GetSalarySheetItem(ss.Id);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SheetProcess sp = new SheetProcess();
            bool f = false;
            foreach (DataGridViewRow row in dgvSalarySheet.Rows)
            {
                SalarySheetItem item = new SalarySheetItem();
                item.Id = (Guid)row.Cells[0].Value;
                item.BaseSalary = (decimal)row.Cells[2].Value;
                item.Bonus = (decimal)row.Cells[3].Value;
                item.Fine = (decimal)row.Cells[4].Value;
                item.Other = (decimal)row.Cells[5].Value;
                sp.SaveItem(item);
                f = true;
            }
            if (f)
            {
                CommonHelper.ShowSuccessMessageBox("保存成功！");
            }
            else
            {
                CommonHelper.ShowErrorMessageBox("没有需要保存的数据！");
            }
        }
    }
}

