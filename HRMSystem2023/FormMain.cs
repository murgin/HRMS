using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using HRMSystem.Model;
using HRMSystem.DAL;
using HRMSystem.BLL;

namespace HRMSystem2023
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void tsmiPasswordModify_Click(object sender, EventArgs e)
        {
            FormPwdModify fpm = new FormPwdModify();
            fpm.MdiParent = this;
            fpm.Show();
        }
        private void tsmiLogQuery_Click(object sender, EventArgs e)
        {
            FormLogQuery flq = new FormLogQuery();
            flq.MdiParent = this;
            flq.Show();
        }
        private void tsmiOperatorManage_Click(object sender, EventArgs e)
        {
            FormOperatorManage fpm = new FormOperatorManage();
            fpm.MdiParent = this;
            fpm.Show();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            if (fl.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
            LoginUser lu = LoginUser.GetInstance();
            tsmiAdmin.Visible = lu.IsAdmin;
            tsslInfo.Text = string.Format("欢迎{0}使用本系统，登录时间{1}", lu.RealName, DateTime.Now);
        }

        private void tsmiDepartmentManage_Click(object sender, EventArgs e)
        {
            FormDepartmentManage fpm = new FormDepartmentManage();
            fpm.MdiParent= this;
            fpm.Show();
        }

        private void tsmiEmployeeList_Click(object sender, EventArgs e)
        {
            FormEmployeeList fel = new FormEmployeeList();
            fel.MdiParent = this;
            fel.Show();
        }

        private void tsmiLogMigrate_Click(object sender, EventArgs e)
        {
            FormLogMigrate flm = new FormLogMigrate();
            flm.MdiParent = this;
            flm.Show();
        }

        private void tsmiSalarySheet_Click(object sender, EventArgs e)
        {
            FormSalarySheet fss = new FormSalarySheet();
            fss.MdiParent = this;
            fss.Show();
        }

        private void tsmiItemPrint_Click(object sender, EventArgs e)
        {
            FormItemPrint fip = new FormItemPrint();
            fip.MdiParent = this;
            fip.Show();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            FormAboutBox fab = new FormAboutBox();
            fab.MdiParent = this;
            fab.Show();
        }
    }
}
