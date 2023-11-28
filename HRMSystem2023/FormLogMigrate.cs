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
    public partial class FormLogMigrate : Form
    {
        public FormLogMigrate()
        {
            InitializeComponent();
        }

        private void buttonMigrate_Click(object sender, EventArgs e)
        {
            OperationLogService logServ = new OperationLogService();
            if (logServ.LogMigrate(dtpSelect.Value))
            {
                CommonHelper.ShowSuccessMessageBox("迁移成功！");
            }
            else
            {
                CommonHelper.ShowErrorMessageBox("迁移失败！");
            }
        }
    }
}
