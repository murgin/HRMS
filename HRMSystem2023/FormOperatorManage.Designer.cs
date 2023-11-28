namespace HRMSystem2023
{
    partial class FormOperatorManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperatorManage));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.dataGridViewOperators = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbLock = new System.Windows.Forms.ToolStripButton();
            this.checkBoxUserName = new System.Windows.Forms.CheckBox();
            this.checkBoxRealName = new System.Windows.Forms.CheckBox();
            this.textBoxRealName = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperators)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxRealName);
            this.groupBox2.Controls.Add(this.checkBoxRealName);
            this.groupBox2.Controls.Add(this.checkBoxUserName);
            this.groupBox2.Controls.Add(this.textBoxUserName);
            this.groupBox2.Controls.Add(this.buttonQuery);
            this.groupBox2.Location = new System.Drawing.Point(12, 50);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(878, 84);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(104, 28);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(153, 25);
            this.textBoxUserName.TabIndex = 11;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(672, 22);
            this.buttonQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(101, 31);
            this.buttonQuery.TabIndex = 2;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // dataGridViewOperators
            // 
            this.dataGridViewOperators.AllowUserToAddRows = false;
            this.dataGridViewOperators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOperators.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewOperators.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewOperators.Name = "dataGridViewOperators";
            this.dataGridViewOperators.RowHeadersWidth = 51;
            this.dataGridViewOperators.RowTemplate.Height = 27;
            this.dataGridViewOperators.Size = new System.Drawing.Size(878, 349);
            this.dataGridViewOperators.TabIndex = 13;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbDelete,
            this.tsbLock});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(904, 27);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = global::HRMSystem2023.Properties.Resources.add;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(29, 24);
            this.tsbAdd.Text = "添加";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::HRMSystem2023.Properties.Resources.delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(29, 24);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbLock
            // 
            this.tsbLock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLock.Image = ((System.Drawing.Image)(resources.GetObject("tsbLock.Image")));
            this.tsbLock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLock.Name = "tsbLock";
            this.tsbLock.Size = new System.Drawing.Size(29, 24);
            this.tsbLock.Text = "锁定";
            this.tsbLock.Click += new System.EventHandler(this.tsbLock_Click);
            // 
            // checkBoxUserName
            // 
            this.checkBoxUserName.AutoSize = true;
            this.checkBoxUserName.Location = new System.Drawing.Point(24, 34);
            this.checkBoxUserName.Name = "checkBoxUserName";
            this.checkBoxUserName.Size = new System.Drawing.Size(74, 19);
            this.checkBoxUserName.TabIndex = 15;
            this.checkBoxUserName.Text = "用户名";
            this.checkBoxUserName.UseVisualStyleBackColor = true;
            // 
            // checkBoxRealName
            // 
            this.checkBoxRealName.AutoSize = true;
            this.checkBoxRealName.Location = new System.Drawing.Point(348, 34);
            this.checkBoxRealName.Name = "checkBoxRealName";
            this.checkBoxRealName.Size = new System.Drawing.Size(89, 19);
            this.checkBoxRealName.TabIndex = 16;
            this.checkBoxRealName.Text = "真实姓名";
            this.checkBoxRealName.UseVisualStyleBackColor = true;
            // 
            // textBoxRealName
            // 
            this.textBoxRealName.Location = new System.Drawing.Point(443, 28);
            this.textBoxRealName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRealName.Name = "textBoxRealName";
            this.textBoxRealName.Size = new System.Drawing.Size(153, 25);
            this.textBoxRealName.TabIndex = 17;
            // 
            // FormOperatorManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 497);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewOperators);
            this.Name = "FormOperatorManage";
            this.Text = "操作员管理";
            this.Load += new System.EventHandler(this.OperatorManage_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperators)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.DataGridView dataGridViewOperators;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbLock;
        private System.Windows.Forms.CheckBox checkBoxUserName;
        private System.Windows.Forms.CheckBox checkBoxRealName;
        private System.Windows.Forms.TextBox textBoxRealName;
    }
}