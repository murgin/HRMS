using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HRMSystem2023
{
    partial class FormAboutBox : Form
    {
        public FormAboutBox()
        {
            InitializeComponent();
            this.Text = String.Format("关于 人力资源管理系统" );
            this.labelProductName.Text = "人力资源管理系统";
            this.labelVersion.Text = String.Format("版本 {0}", AssemblyVersion);
            this.labelCopyright.Text = "Copyright © mjj";
            this.labelContact.Text = "联系我们 3403515251@qq.com";
            this.textBoxDescription.Text = "一切最终解释权归著作人所有";
        }

        #region 程序集特性访问器


        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }
        #endregion

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
