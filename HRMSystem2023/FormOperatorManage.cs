using HRMSystem.BLL;
using HRMSystem.DAL;
using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem2023
{
    public partial class FormOperatorManage : Form
    {
        readonly OperatorService opServ = new OperatorService();
        public FormOperatorManage()
        {
            InitializeComponent();
        }
        private void OperatorManage_Load(object sender, EventArgs e)
        {
            dataGridViewOperators.DataSource = opServ.GetOperatorList();
        }
        private void buttonQuery_Click(object sender, EventArgs e)
        {
            OperatorSearchWhere osw = new OperatorSearchWhere();
            if (checkBoxUserName.Checked)
            {
                if (textBoxUserName.Text.Trim() == "")
                {
                    CommonHelper.ShowErrorMessageBox("请输入用户名！");
                }
                else
                {
                    osw.UserName = textBoxUserName.Text;
                }
            }
            if (checkBoxRealName.Checked)
            {
                if (textBoxRealName.Text.Trim() == "")
                {
                    CommonHelper.ShowErrorMessageBox("请输入真实姓名！");
                }
                else
                {
                    osw.RealName = textBoxRealName.Text;
                }
            }
            dataGridViewOperators.DataSource = opServ.GetOperatorList(osw);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewOperators.SelectedRows.Count == 1)
            {
                Guid id = (Guid)dataGridViewOperators.SelectedRows[0].Cells[0].Value;
                if (CommonHelper.ShowYesNoMessageBox("确定删除该操作员吗？") == DialogResult.Yes)
                {
                    opServ.DeleteOperator(id);
                    dataGridViewOperators.DataSource = opServ.GetOperatorList();
                }
            }
            else
            {
                CommonHelper.ShowErrorMessageBox("请先选中一个操作员！");
            }
        }

        private void tsbLock_Click(object sender, EventArgs e)
        {
            if (dataGridViewOperators.SelectedRows.Count == 1)
            {
                Guid id = (Guid)dataGridViewOperators.SelectedRows[0].Cells[0].Value;
                if (CommonHelper.ShowYesNoMessageBox("确定锁定该操作员吗？") == DialogResult.Yes)
                {
                    opServ.LockOperator(id);
                    dataGridViewOperators.DataSource = opServ.GetOperatorList();
                }
            }
            else
            {
                CommonHelper.ShowErrorMessageBox("请先选中一个操作员！");
            }
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            FormOperatorAdd foa = new FormOperatorAdd();
            if (foa.ShowDialog() == DialogResult.OK) 
            {
                dataGridViewOperators.DataSource = opServ.GetOperatorList();
            }   
        }
    }
}