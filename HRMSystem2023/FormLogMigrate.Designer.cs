namespace HRMSystem2023
{
    partial class FormLogMigrate
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSelect = new System.Windows.Forms.DateTimePicker();
            this.buttonMigrate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "将该日期之前的数据迁移至新表";
            // 
            // dtpSelect
            // 
            this.dtpSelect.Location = new System.Drawing.Point(265, 41);
            this.dtpSelect.Name = "dtpSelect";
            this.dtpSelect.Size = new System.Drawing.Size(230, 25);
            this.dtpSelect.TabIndex = 1;
            // 
            // buttonMigrate
            // 
            this.buttonMigrate.Location = new System.Drawing.Point(146, 120);
            this.buttonMigrate.Name = "buttonMigrate";
            this.buttonMigrate.Size = new System.Drawing.Size(197, 53);
            this.buttonMigrate.TabIndex = 2;
            this.buttonMigrate.Text = "迁移";
            this.buttonMigrate.UseVisualStyleBackColor = true;
            this.buttonMigrate.Click += new System.EventHandler(this.buttonMigrate_Click);
            // 
            // FormLogMigrate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 217);
            this.Controls.Add(this.buttonMigrate);
            this.Controls.Add(this.dtpSelect);
            this.Controls.Add(this.label1);
            this.Name = "FormLogMigrate";
            this.Text = "日志迁移";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpSelect;
        private System.Windows.Forms.Button buttonMigrate;
    }
}