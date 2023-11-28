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
    public partial class FormLogQuery : Form
    {
        public static int NUM_PER_PAGE = 10;
        public int currentPage = 1;
        public OperationLogService logServ = null;
        public OperatorService opServ = new OperatorService();
        public int totalPages = 0;
        LogSearchWhere lsw = new LogSearchWhere();
        public FormLogQuery()
        {
            logServ = new OperationLogService();
            InitializeComponent();
        }
        private void FormLogQuery_Load(object sender, EventArgs e)
        {
            labelPageCurrent.Text = string.Format("第{0}页", currentPage);
            int n = logServ.GetLogCount();
            totalPages = n % NUM_PER_PAGE == 0 ? n / NUM_PER_PAGE : n / NUM_PER_PAGE + 1;
            labelPageTotal.Text = string.Format("共{0}页", totalPages);
            linkLabelPrev.Enabled = false;
            linkLabelFirst.Enabled = false;
            if (totalPages <= 1) 
            {
                linkLabelNext.Enabled = false;
                linkLabelLast.Enabled = false;
            }
            string[] ad = new string[] { "无此用户", "密码错误", "登录了被锁定的账户", "登录了被删除的用户", "管理员登录", "登录成功" };
            dgvLogList.DataSource = logServ.GetOperationLogList(currentPage, NUM_PER_PAGE);
            comboBoxRealName.DataSource = opServ.GetOperatorList();
            comboBoxRealName.DisplayMember = "真实姓名";
            comboBoxRealName.ValueMember = "真实姓名";
            comboBoxRealName.SelectedIndex = -1;
            comboBoxActionDesc.Items.AddRange(ad);
            comboBoxActionDesc.SelectedIndex = -1;
        }
        private void show(int pageNo)
        {
            dgvLogList.DataSource = logServ.GetOperationLogList(lsw,pageNo, NUM_PER_PAGE);
            labelPageCurrent.Text = string.Format("第{0}页", pageNo);
        }

        private void linkLabelFirst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (currentPage != 1)
            {
                linkLabelNext.Enabled = true;
                linkLabelLast.Enabled = true;
            }
            currentPage = 1;
            show(currentPage);
            linkLabelPrev.Enabled = false;
            linkLabelFirst.Enabled = false;
        }

        private void linkLabelLast_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (currentPage != 1)
            {
                linkLabelPrev.Enabled = true;
                linkLabelFirst.Enabled = true;
            }
            linkLabelPrev.Enabled = true;
            linkLabelFirst.Enabled = true;
            currentPage = totalPages;
            show(currentPage);
            linkLabelNext.Enabled = false;
            linkLabelLast.Enabled = false;
        }

        private void linkLabelNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelPrev.Enabled = true;
            linkLabelFirst.Enabled = true;
            currentPage++;
            show(currentPage);
            if (currentPage == totalPages)
            {
                linkLabelNext.Enabled = false;
                linkLabelLast.Enabled = false;
            }
        }

        private void linkLabelPrev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelNext.Enabled = true;
            linkLabelLast.Enabled = true;
            currentPage--;
            show(currentPage);
            if (currentPage == 1)
            {
                linkLabelPrev.Enabled = false;
                linkLabelFirst.Enabled = false;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            linkLabelPrev.Enabled = true;
            linkLabelFirst.Enabled = true;
            linkLabelNext.Enabled = true;
            linkLabelLast.Enabled = true;
            lsw = new LogSearchWhere();
            currentPage = 1;
            lsw.ExistDate = false;
            if (checkBoxRealName.Checked)
            {
                if (comboBoxRealName.SelectedIndex == -1)
                {
                    CommonHelper.ShowErrorMessageBox("请选择操作员真实姓名!");
                    return ;
                }
                else
                {
                    lsw.RealName = comboBoxRealName.Text;
                }
            }
            if(checkBoxTime.Checked)
            {
                lsw.ExistDate = true;
                lsw.ActionDateFrom = dtpActionDateFrom.Value;
                lsw.ActionDateTo = dtpActionDateTo.Value;
            }
            if (checkBoxActionDesc.Checked)
            {
                if(comboBoxActionDesc.SelectedIndex == -1)
                {
                    CommonHelper.ShowErrorMessageBox("请选择操作描述！");
                    return ;
                }
                else
                {
                    lsw.ActionDesc = comboBoxActionDesc.Text.Trim();
                }
            }
            dgvLogList.DataSource = logServ.GetOperationLogList(lsw, currentPage, NUM_PER_PAGE);
            labelPageCurrent.Text = string.Format("第{0}页", currentPage);
            int n = logServ.GetLogCount(lsw);
            totalPages = n % NUM_PER_PAGE == 0 ? n / NUM_PER_PAGE : n / NUM_PER_PAGE + 1;
            labelPageTotal.Text = string.Format("共{0}页", totalPages);
            linkLabelPrev.Enabled = false;
            linkLabelFirst.Enabled = false;
            if (totalPages <= 1)
            {
                linkLabelNext.Enabled = false;
                linkLabelLast.Enabled = false;
            }
        }
    }
}
