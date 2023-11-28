namespace HRMSystem2023
{
    partial class FormLogQuery
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
            this.dgvLogList = new System.Windows.Forms.DataGridView();
            this.linkLabelFirst = new System.Windows.Forms.LinkLabel();
            this.linkLabelLast = new System.Windows.Forms.LinkLabel();
            this.linkLabelNext = new System.Windows.Forms.LinkLabel();
            this.linkLabelPrev = new System.Windows.Forms.LinkLabel();
            this.labelPageCurrent = new System.Windows.Forms.Label();
            this.labelPageTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxRealName = new System.Windows.Forms.ComboBox();
            this.dtpActionDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpActionDateFrom = new System.Windows.Forms.DateTimePicker();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxActionDesc = new System.Windows.Forms.ComboBox();
            this.checkBoxTime = new System.Windows.Forms.CheckBox();
            this.checkBoxActionDesc = new System.Windows.Forms.CheckBox();
            this.checkBoxRealName = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLogList
            // 
            this.dgvLogList.AllowUserToAddRows = false;
            this.dgvLogList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogList.Location = new System.Drawing.Point(25, 132);
            this.dgvLogList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLogList.Name = "dgvLogList";
            this.dgvLogList.RowHeadersWidth = 51;
            this.dgvLogList.RowTemplate.Height = 23;
            this.dgvLogList.Size = new System.Drawing.Size(890, 401);
            this.dgvLogList.TabIndex = 0;
            // 
            // linkLabelFirst
            // 
            this.linkLabelFirst.AutoSize = true;
            this.linkLabelFirst.Location = new System.Drawing.Point(408, 567);
            this.linkLabelFirst.Name = "linkLabelFirst";
            this.linkLabelFirst.Size = new System.Drawing.Size(37, 15);
            this.linkLabelFirst.TabIndex = 1;
            this.linkLabelFirst.TabStop = true;
            this.linkLabelFirst.Text = "首页";
            this.linkLabelFirst.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFirst_LinkClicked);
            // 
            // linkLabelLast
            // 
            this.linkLabelLast.AutoSize = true;
            this.linkLabelLast.Location = new System.Drawing.Point(474, 567);
            this.linkLabelLast.Name = "linkLabelLast";
            this.linkLabelLast.Size = new System.Drawing.Size(37, 15);
            this.linkLabelLast.TabIndex = 2;
            this.linkLabelLast.TabStop = true;
            this.linkLabelLast.Text = "尾页";
            this.linkLabelLast.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLast_LinkClicked);
            // 
            // linkLabelNext
            // 
            this.linkLabelNext.AutoSize = true;
            this.linkLabelNext.Location = new System.Drawing.Point(643, 567);
            this.linkLabelNext.Name = "linkLabelNext";
            this.linkLabelNext.Size = new System.Drawing.Size(52, 15);
            this.linkLabelNext.TabIndex = 3;
            this.linkLabelNext.TabStop = true;
            this.linkLabelNext.Text = "下一页";
            this.linkLabelNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelNext_LinkClicked);
            // 
            // linkLabelPrev
            // 
            this.linkLabelPrev.AutoSize = true;
            this.linkLabelPrev.Location = new System.Drawing.Point(566, 567);
            this.linkLabelPrev.Name = "linkLabelPrev";
            this.linkLabelPrev.Size = new System.Drawing.Size(52, 15);
            this.linkLabelPrev.TabIndex = 4;
            this.linkLabelPrev.TabStop = true;
            this.linkLabelPrev.Text = "上一页";
            this.linkLabelPrev.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPrev_LinkClicked);
            // 
            // labelPageCurrent
            // 
            this.labelPageCurrent.AutoSize = true;
            this.labelPageCurrent.Location = new System.Drawing.Point(83, 573);
            this.labelPageCurrent.Name = "labelPageCurrent";
            this.labelPageCurrent.Size = new System.Drawing.Size(61, 15);
            this.labelPageCurrent.TabIndex = 5;
            this.labelPageCurrent.Text = "共{0}页";
            // 
            // labelPageTotal
            // 
            this.labelPageTotal.AutoSize = true;
            this.labelPageTotal.Location = new System.Drawing.Point(193, 572);
            this.labelPageTotal.Name = "labelPageTotal";
            this.labelPageTotal.Size = new System.Drawing.Size(61, 15);
            this.labelPageTotal.TabIndex = 6;
            this.labelPageTotal.Text = "第{0}页";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxRealName);
            this.groupBox1.Controls.Add(this.dtpActionDateTo);
            this.groupBox1.Controls.Add(this.dtpActionDateFrom);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxActionDesc);
            this.groupBox1.Controls.Add(this.checkBoxTime);
            this.groupBox1.Controls.Add(this.checkBoxActionDesc);
            this.groupBox1.Controls.Add(this.checkBoxRealName);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(889, 109);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索条件";
            // 
            // comboBoxRealName
            // 
            this.comboBoxRealName.FormattingEnabled = true;
            this.comboBoxRealName.Location = new System.Drawing.Point(180, 19);
            this.comboBoxRealName.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRealName.Name = "comboBoxRealName";
            this.comboBoxRealName.Size = new System.Drawing.Size(140, 23);
            this.comboBoxRealName.TabIndex = 20;
            // 
            // dtpActionDateTo
            // 
            this.dtpActionDateTo.Location = new System.Drawing.Point(706, 15);
            this.dtpActionDateTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpActionDateTo.Name = "dtpActionDateTo";
            this.dtpActionDateTo.Size = new System.Drawing.Size(159, 25);
            this.dtpActionDateTo.TabIndex = 19;
            // 
            // dtpActionDateFrom
            // 
            this.dtpActionDateFrom.Location = new System.Drawing.Point(511, 15);
            this.dtpActionDateFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpActionDateFrom.Name = "dtpActionDateFrom";
            this.dtpActionDateFrom.Size = new System.Drawing.Size(159, 25);
            this.dtpActionDateFrom.TabIndex = 18;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(415, 57);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(96, 40);
            this.buttonSearch.TabIndex = 17;
            this.buttonSearch.Text = "搜索";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(677, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "到";
            // 
            // comboBoxActionDesc
            // 
            this.comboBoxActionDesc.FormattingEnabled = true;
            this.comboBoxActionDesc.Location = new System.Drawing.Point(180, 67);
            this.comboBoxActionDesc.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxActionDesc.Name = "comboBoxActionDesc";
            this.comboBoxActionDesc.Size = new System.Drawing.Size(140, 23);
            this.comboBoxActionDesc.TabIndex = 15;
            // 
            // checkBoxTime
            // 
            this.checkBoxTime.AutoSize = true;
            this.checkBoxTime.Location = new System.Drawing.Point(415, 21);
            this.checkBoxTime.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxTime.Name = "checkBoxTime";
            this.checkBoxTime.Size = new System.Drawing.Size(89, 19);
            this.checkBoxTime.TabIndex = 13;
            this.checkBoxTime.Text = "操作时间";
            this.checkBoxTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxActionDesc
            // 
            this.checkBoxActionDesc.AutoSize = true;
            this.checkBoxActionDesc.Location = new System.Drawing.Point(17, 71);
            this.checkBoxActionDesc.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxActionDesc.Name = "checkBoxActionDesc";
            this.checkBoxActionDesc.Size = new System.Drawing.Size(89, 19);
            this.checkBoxActionDesc.TabIndex = 12;
            this.checkBoxActionDesc.Text = "操作描述";
            this.checkBoxActionDesc.UseVisualStyleBackColor = true;
            // 
            // checkBoxRealName
            // 
            this.checkBoxRealName.AutoSize = true;
            this.checkBoxRealName.Location = new System.Drawing.Point(17, 25);
            this.checkBoxRealName.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxRealName.Name = "checkBoxRealName";
            this.checkBoxRealName.Size = new System.Drawing.Size(134, 19);
            this.checkBoxRealName.TabIndex = 11;
            this.checkBoxRealName.Text = "操作员真实姓名";
            this.checkBoxRealName.UseVisualStyleBackColor = true;
            // 
            // FormLogQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 615);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelPageTotal);
            this.Controls.Add(this.labelPageCurrent);
            this.Controls.Add(this.linkLabelPrev);
            this.Controls.Add(this.linkLabelNext);
            this.Controls.Add(this.linkLabelLast);
            this.Controls.Add(this.linkLabelFirst);
            this.Controls.Add(this.dgvLogList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogQuery";
            this.Text = "查询日志";
            this.Load += new System.EventHandler(this.FormLogQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogList;
        private System.Windows.Forms.LinkLabel linkLabelFirst;
        private System.Windows.Forms.LinkLabel linkLabelLast;
        private System.Windows.Forms.LinkLabel linkLabelNext;
        private System.Windows.Forms.LinkLabel linkLabelPrev;
        private System.Windows.Forms.Label labelPageCurrent;
        private System.Windows.Forms.Label labelPageTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpActionDateTo;
        private System.Windows.Forms.DateTimePicker dtpActionDateFrom;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxActionDesc;
        private System.Windows.Forms.CheckBox checkBoxTime;
        private System.Windows.Forms.CheckBox checkBoxActionDesc;
        private System.Windows.Forms.CheckBox checkBoxRealName;
        private System.Windows.Forms.ComboBox comboBoxRealName;
    }
}