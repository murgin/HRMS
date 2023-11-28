namespace HRMSystem2023
{
    partial class FormPwdModify
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPwdAfter = new System.Windows.Forms.TextBox();
            this.textBoxPwdBefore = new System.Windows.Forms.TextBox();
            this.buttonModify = new System.Windows.Forms.Button();
            this.labelShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "现密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "原密码";
            // 
            // textBoxPwdAfter
            // 
            this.textBoxPwdAfter.Location = new System.Drawing.Point(129, 146);
            this.textBoxPwdAfter.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPwdAfter.Name = "textBoxPwdAfter";
            this.textBoxPwdAfter.PasswordChar = '*';
            this.textBoxPwdAfter.Size = new System.Drawing.Size(260, 25);
            this.textBoxPwdAfter.TabIndex = 5;
            // 
            // textBoxPwdBefore
            // 
            this.textBoxPwdBefore.Location = new System.Drawing.Point(129, 82);
            this.textBoxPwdBefore.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPwdBefore.Name = "textBoxPwdBefore";
            this.textBoxPwdBefore.PasswordChar = '*';
            this.textBoxPwdBefore.Size = new System.Drawing.Size(260, 25);
            this.textBoxPwdBefore.TabIndex = 4;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(120, 222);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(186, 59);
            this.buttonModify.TabIndex = 8;
            this.buttonModify.Text = "修改";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // labelShow
            // 
            this.labelShow.Location = new System.Drawing.Point(54, 35);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(335, 23);
            this.labelShow.TabIndex = 9;
            this.labelShow.Text = "                                                ";
            // 
            // FormPwdModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 370);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPwdAfter);
            this.Controls.Add(this.textBoxPwdBefore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPwdModify";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.FormPasswordModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPwdAfter;
        private System.Windows.Forms.TextBox textBoxPwdBefore;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Label labelShow;
    }
}