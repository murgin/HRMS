namespace HRMSystem2023
{
    partial class FormEmployeeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployeeList));
            this.toolStripExport = new System.Windows.Forms.ToolStrip();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpInDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpInDateFrom = new System.Windows.Forms.DateTimePicker();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkBoxTime = new System.Windows.Forms.CheckBox();
            this.checkBoxDepartment = new System.Windows.Forms.CheckBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripExport
            // 
            this.toolStripExport.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripExport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDelete,
            this.tsbExport});
            this.toolStripExport.Location = new System.Drawing.Point(0, 0);
            this.toolStripExport.Name = "toolStripExport";
            this.toolStripExport.Size = new System.Drawing.Size(686, 27);
            this.toolStripExport.TabIndex = 6;
            this.toolStripExport.Text = "导出";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(9, 133);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 23;
            this.dgvEmployee.Size = new System.Drawing.Size(662, 275);
            this.dgvEmployee.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpInDateTo);
            this.groupBox1.Controls.Add(this.dtpInDateFrom);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxDepartment);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.checkBoxTime);
            this.groupBox1.Controls.Add(this.checkBoxDepartment);
            this.groupBox1.Controls.Add(this.checkBoxName);
            this.groupBox1.Location = new System.Drawing.Point(9, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 91);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索条件";
            // 
            // dtpInDateTo
            // 
            this.dtpInDateTo.Location = new System.Drawing.Point(476, 25);
            this.dtpInDateTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpInDateTo.Name = "dtpInDateTo";
            this.dtpInDateTo.Size = new System.Drawing.Size(162, 21);
            this.dtpInDateTo.TabIndex = 10;
            // 
            // dtpInDateFrom
            // 
            this.dtpInDateFrom.Location = new System.Drawing.Point(288, 24);
            this.dtpInDateFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpInDateFrom.Name = "dtpInDateFrom";
            this.dtpInDateFrom.Size = new System.Drawing.Size(162, 21);
            this.dtpInDateFrom.TabIndex = 9;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(422, 50);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(72, 32);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "搜索";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "到";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(74, 64);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(106, 20);
            this.comboBoxDepartment.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(75, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(106, 21);
            this.textBoxName.TabIndex = 3;
            // 
            // checkBoxTime
            // 
            this.checkBoxTime.AutoSize = true;
            this.checkBoxTime.Location = new System.Drawing.Point(216, 29);
            this.checkBoxTime.Name = "checkBoxTime";
            this.checkBoxTime.Size = new System.Drawing.Size(72, 16);
            this.checkBoxTime.TabIndex = 2;
            this.checkBoxTime.Text = "入职时间";
            this.checkBoxTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxDepartment
            // 
            this.checkBoxDepartment.AutoSize = true;
            this.checkBoxDepartment.Location = new System.Drawing.Point(21, 66);
            this.checkBoxDepartment.Name = "checkBoxDepartment";
            this.checkBoxDepartment.Size = new System.Drawing.Size(48, 16);
            this.checkBoxDepartment.TabIndex = 1;
            this.checkBoxDepartment.Text = "部门";
            this.checkBoxDepartment.UseVisualStyleBackColor = true;
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Location = new System.Drawing.Point(21, 29);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(48, 16);
            this.checkBoxName.TabIndex = 0;
            this.checkBoxName.Text = "姓名";
            this.checkBoxName.UseVisualStyleBackColor = true;
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(24, 24);
            this.tsbAdd.Text = "添加";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(24, 24);
            this.tsbEdit.Text = "编辑";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(24, 24);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport.Image")));
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(24, 24);
            this.tsbExport.Text = "导出";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // FormEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 418);
            this.Controls.Add(this.toolStripExport);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormEmployeeList";
            this.Text = "员工列表";
            this.Load += new System.EventHandler(this.FormEmployeeList_Load);
            this.toolStripExport.ResumeLayout(false);
            this.toolStripExport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripExport;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxTime;
        private System.Windows.Forms.CheckBox checkBoxDepartment;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.DateTimePicker dtpInDateTo;
        private System.Windows.Forms.DateTimePicker dtpInDateFrom;
    }
}