using HRMSystem.BLL;
using HRMSystem.DAL;
using HRMSystem.Model;
using Microsoft.Reporting.WinForms;
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
    public partial class FormItemPrint : Form
    {
        public FormItemPrint()
        {
            InitializeComponent();
        }

        private void FormItemPrint_Load(object sender, EventArgs e)
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

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            if (comboBoxDepartment.SelectedIndex == -1)
            {
                CommonHelper.ShowErrorMessageBox("请选择正确的年份,月份和部门");
                return;
            }
            SalarySheetService salServ = new SalarySheetService();
            SalarySheet ss = new SalarySheet();
            ss.Month = Convert.ToInt32(comboBoxMonth.SelectedValue);
            ss.Year = Convert.ToInt32(comboBoxYear.SelectedValue);
            ss.DepartmentId = (Guid)comboBoxDepartment.SelectedValue;
            SheetProcess sp = new SheetProcess();
            SalarySheetItemService itemServ = new SalarySheetItemService();
            if (sp.IsSalarySheetExist(ss))
            {
                ss.Id = salServ.GetSalarySheetId(ss);
                DataTable dt1 = new DataTable();
                dt1 = itemServ.GetReportSheet(ss.Id);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt1));
                reportViewer1.RefreshReport();
            }
            else
            {
                CommonHelper.ShowErrorMessageBox("该工资单尚未生成!");
            }
        }
    }
}
