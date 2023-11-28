namespace HRMSystem2023
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogMigrate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOperatorManage = new System.Windows.Forms.ToolStripMenuItem();
            this.部门管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDepartmentManage = new System.Windows.Forms.ToolStripMenuItem();
            this.员工管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmployeeList = new System.Windows.Forms.ToolStripMenuItem();
            this.工资单管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalarySheet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiItemPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPasswordModify = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdmin,
            this.部门管理ToolStripMenuItem,
            this.员工管理ToolStripMenuItem,
            this.工资单管理ToolStripMenuItem,
            this.tsmiMy});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1268, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiAdmin
            // 
            this.tsmiAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLogQuery,
            this.tsmiLogMigrate,
            this.tsmiOperatorManage});
            this.tsmiAdmin.Name = "tsmiAdmin";
            this.tsmiAdmin.Size = new System.Drawing.Size(116, 24);
            this.tsmiAdmin.Text = "管理员操作(&a)";
            // 
            // tsmiLogQuery
            // 
            this.tsmiLogQuery.Name = "tsmiLogQuery";
            this.tsmiLogQuery.Size = new System.Drawing.Size(224, 26);
            this.tsmiLogQuery.Text = "日志查询";
            this.tsmiLogQuery.Click += new System.EventHandler(this.tsmiLogQuery_Click);
            // 
            // tsmiLogMigrate
            // 
            this.tsmiLogMigrate.Name = "tsmiLogMigrate";
            this.tsmiLogMigrate.Size = new System.Drawing.Size(224, 26);
            this.tsmiLogMigrate.Text = "日志迁移";
            this.tsmiLogMigrate.Click += new System.EventHandler(this.tsmiLogMigrate_Click);
            // 
            // tsmiOperatorManage
            // 
            this.tsmiOperatorManage.Name = "tsmiOperatorManage";
            this.tsmiOperatorManage.Size = new System.Drawing.Size(224, 26);
            this.tsmiOperatorManage.Text = "操作员管理";
            this.tsmiOperatorManage.Click += new System.EventHandler(this.tsmiOperatorManage_Click);
            // 
            // 部门管理ToolStripMenuItem
            // 
            this.部门管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDepartmentManage});
            this.部门管理ToolStripMenuItem.Name = "部门管理ToolStripMenuItem";
            this.部门管理ToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.部门管理ToolStripMenuItem.Text = "部门(&d)";
            // 
            // tsmiDepartmentManage
            // 
            this.tsmiDepartmentManage.Name = "tsmiDepartmentManage";
            this.tsmiDepartmentManage.Size = new System.Drawing.Size(224, 26);
            this.tsmiDepartmentManage.Text = "部门管理";
            this.tsmiDepartmentManage.Click += new System.EventHandler(this.tsmiDepartmentManage_Click);
            // 
            // 员工管理ToolStripMenuItem
            // 
            this.员工管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmployeeList});
            this.员工管理ToolStripMenuItem.Name = "员工管理ToolStripMenuItem";
            this.员工管理ToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.员工管理ToolStripMenuItem.Text = "员工管理(&e)";
            // 
            // tsmiEmployeeList
            // 
            this.tsmiEmployeeList.Name = "tsmiEmployeeList";
            this.tsmiEmployeeList.Size = new System.Drawing.Size(224, 26);
            this.tsmiEmployeeList.Text = "员工列表";
            this.tsmiEmployeeList.Click += new System.EventHandler(this.tsmiEmployeeList_Click);
            // 
            // 工资单管理ToolStripMenuItem
            // 
            this.工资单管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSalarySheet,
            this.tsmiItemPrint});
            this.工资单管理ToolStripMenuItem.Name = "工资单管理ToolStripMenuItem";
            this.工资单管理ToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.工资单管理ToolStripMenuItem.Text = "工资单管理(&s)";
            // 
            // tsmiSalarySheet
            // 
            this.tsmiSalarySheet.Name = "tsmiSalarySheet";
            this.tsmiSalarySheet.Size = new System.Drawing.Size(224, 26);
            this.tsmiSalarySheet.Text = "生成工资单";
            this.tsmiSalarySheet.Click += new System.EventHandler(this.tsmiSalarySheet_Click);
            // 
            // tsmiItemPrint
            // 
            this.tsmiItemPrint.Name = "tsmiItemPrint";
            this.tsmiItemPrint.Size = new System.Drawing.Size(224, 26);
            this.tsmiItemPrint.Text = "打印工资单";
            this.tsmiItemPrint.Click += new System.EventHandler(this.tsmiItemPrint_Click);
            // 
            // tsmiMy
            // 
            this.tsmiMy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPasswordModify,
            this.tsmiAbout});
            this.tsmiMy.Name = "tsmiMy";
            this.tsmiMy.Size = new System.Drawing.Size(77, 24);
            this.tsmiMy.Text = "我的(&m)";
            // 
            // tsmiPasswordModify
            // 
            this.tsmiPasswordModify.Name = "tsmiPasswordModify";
            this.tsmiPasswordModify.Size = new System.Drawing.Size(224, 26);
            this.tsmiPasswordModify.Text = "修改密码";
            this.tsmiPasswordModify.Click += new System.EventHandler(this.tsmiPasswordModify_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(224, 26);
            this.tsmiAbout.Text = "关于";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 763);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1268, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslInfo
            // 
            this.tsslInfo.Name = "tsslInfo";
            this.tsslInfo.Size = new System.Drawing.Size(0, 16);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 785);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "人力资源管理系统";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiMy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPasswordModify;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmiOperatorManage;
        private System.Windows.Forms.ToolStripMenuItem 部门管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDepartmentManage;
        private System.Windows.Forms.ToolStripMenuItem 员工管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmployeeList;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogMigrate;
        private System.Windows.Forms.ToolStripMenuItem 工资单管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalarySheet;
        private System.Windows.Forms.ToolStripMenuItem tsmiItemPrint;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
    }
}