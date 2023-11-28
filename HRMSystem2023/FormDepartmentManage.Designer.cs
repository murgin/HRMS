namespace HRMSystem2023
{
    partial class FormDepartmentManage
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.textBoxSearchByName = new System.Windows.Forms.TextBox();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.dataGridViewDepartments = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxSearchByName);
            this.groupBox2.Controls.Add(this.buttonReturn);
            this.groupBox2.Controls.Add(this.buttonQuery);
            this.groupBox2.Location = new System.Drawing.Point(437, 45);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(303, 254);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "部门名称";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(160, 140);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(101, 68);
            this.buttonReturn.TabIndex = 14;
            this.buttonReturn.Text = "还原";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // textBoxSearchByName
            // 
            this.textBoxSearchByName.Location = new System.Drawing.Point(104, 44);
            this.textBoxSearchByName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearchByName.Name = "textBoxSearchByName";
            this.textBoxSearchByName.Size = new System.Drawing.Size(157, 25);
            this.textBoxSearchByName.TabIndex = 11;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(31, 140);
            this.buttonQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(101, 68);
            this.buttonQuery.TabIndex = 2;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // dataGridViewDepartments
            // 
            this.dataGridViewDepartments.AllowUserToAddRows = false;
            this.dataGridViewDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartments.Location = new System.Drawing.Point(12, 45);
            this.dataGridViewDepartments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDepartments.Name = "dataGridViewDepartments";
            this.dataGridViewDepartments.RowHeadersWidth = 51;
            this.dataGridViewDepartments.RowTemplate.Height = 27;
            this.dataGridViewDepartments.Size = new System.Drawing.Size(406, 365);
            this.dataGridViewDepartments.TabIndex = 17;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(766, 27);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = global::HRMSystem2023.Properties.Resources.add;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(29, 24);
            this.tsbAdd.Text = "添加部门";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::HRMSystem2023.Properties.Resources.delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(29, 24);
            this.tsbDelete.Text = "删除部门";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // FormDepartmentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 421);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewDepartments);
            this.Name = "FormDepartmentManage";
            this.Text = "部门管理";
            this.Load += new System.EventHandler(this.FormDepartmentManage_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.TextBox textBoxSearchByName;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.DataGridView dataGridViewDepartments;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbDelete;
    }
}