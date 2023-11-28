using HRMSystem.BLL;
using HRMSystem.DAL;
using HRMSystem2023;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem.Model
{
    public partial class FormEmployeeAdd : Form
    {
        Guid empid = Guid.Empty;
        public FormEmployeeAdd()
        {
            InitializeComponent();
        }
        public FormEmployeeAdd(Guid id)
        {
            InitializeComponent();
            empid = id;
        }
        Employee emp = new Employee();
        private byte[] photo;
        private void FormEmployeeAdd_Load(object sender, EventArgs e)
        {
            ComboSource cs = new ComboSource();
            comboBoxGender.DataSource = cs.GetComboList("性别");
            comboBoxGender.DisplayMember = "Name";
            comboBoxGender.ValueMember = "Id";
            comboBoxGender.SelectedIndex = -1;
            comboBoxMarriage.DataSource = cs.GetComboList("婚姻状况");
            comboBoxMarriage.DisplayMember = "Name";
            comboBoxMarriage.ValueMember = "Id";
            comboBoxMarriage.SelectedIndex = -1;
            comboBoxParty.DataSource = cs.GetComboList("政治面貌");
            comboBoxParty.DisplayMember = "Name";
            comboBoxParty.ValueMember = "Id";
            comboBoxParty.SelectedIndex = -1;
            comboBoxEducation.DataSource = cs.GetComboList("学历");
            comboBoxEducation.DisplayMember = "Name";
            comboBoxEducation.ValueMember = "Id";
            comboBoxEducation.SelectedIndex = -1;
            comboBoxDepartment.DataSource = cs.GetDepartmentSource();
            comboBoxDepartment.DisplayMember = "Name";
            comboBoxDepartment.ValueMember = "Id";
            comboBoxDepartment.SelectedIndex = -1;
            if (empid != Guid.Empty)
            {
                EmployeeService empServ = new EmployeeService();
                Employee emp = empServ.GetEmployeeById(empid);
                textBoxName.Text = emp.Name;
                comboBoxGender.SelectedValue = emp.GenderId;
                dtpBirthDay.Value = emp.BirthDay;
                dtpInDay.Value = emp.InDay;
                comboBoxMarriage.SelectedValue = emp.MarriageId;
                comboBoxParty.SelectedValue = emp.PartyId;
                textBoxNativePlace.Text = emp.NativePlace;
                textBoxNation.Text = emp.Nation;
                comboBoxEducation.SelectedValue = emp.EducationId;
                textBoxAddress.Text = emp.Address;
                textBoxEmail.Text = emp.Email;
                textBoxTelephone.Text = emp.Telephone;
                textBoxNumber.Text = emp.Number;
                comboBoxDepartment.SelectedValue = emp.DepartmentId;
                textBoxRemarks.Text = emp.Remarks;
                textBoxResume.Text = emp.Resume;
                if (emp.Photo != null)
                {
                    MemoryStream ms = new MemoryStream(emp.Photo);
                    pictureBoxPhoto.Image = new Bitmap(ms);
                    photo = emp.Photo;
                }
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Trim() == "")
            {
                CommonHelper.ShowErrorMessageBox("姓名不能为空！");
                return;
            }
            else
            {
                emp.Name = textBoxName.Text;
            }
            if (comboBoxGender.SelectedIndex == -1)
            {
                CommonHelper.ShowErrorMessageBox("性别不能为空！");
                return;
            }
            else
            {
                emp.GenderId = (Guid)comboBoxGender.SelectedValue;
            }
            if (comboBoxMarriage.SelectedIndex == -1)
            {
                CommonHelper.ShowErrorMessageBox("婚姻状况不能为空！");
                return;
            }
            else
            {
                emp.MarriageId = (Guid)comboBoxMarriage.SelectedValue;
            }
            if (comboBoxParty.SelectedIndex == -1)
            {
                CommonHelper.ShowErrorMessageBox("政治面貌不能为空！");
                return;
            }
            else
            {
                emp.PartyId = (Guid)comboBoxParty.SelectedValue;

            }
            if (textBoxNativePlace.Text.Trim() == "")
            {
                CommonHelper.ShowErrorMessageBox("籍贯不能为空！");
                return;
            }
            else
            {
                emp.NativePlace = textBoxNativePlace.Text;
            }
            if (textBoxNation.Text.Trim() == "")
            {
                CommonHelper.ShowErrorMessageBox("民族不能为空！");
                return;
            }
            else
            {
                emp.Nation = textBoxNation.Text;
            }
            if (comboBoxEducation.SelectedIndex == -1)
            {
                CommonHelper.ShowErrorMessageBox("学历不能为空！");
                return;
            }
            else
            {
                emp.EducationId = (Guid)comboBoxEducation.SelectedValue;
            }
            if (textBoxAddress.Text.Trim() == "")
            {
                CommonHelper.ShowErrorMessageBox("联系地址不能为空！");
                return;
            }
            else
            {
                emp.Address = textBoxAddress.Text;
            }
            if (textBoxTelephone.Text.Trim() == "")
            {
                CommonHelper.ShowErrorMessageBox("联系电话不能为空！");
                return;
            }
            else
            {
                emp.Telephone = textBoxTelephone.Text;
            }
            if (textBoxEmail.Text.Trim() == "")
            {
                CommonHelper.ShowErrorMessageBox("电子邮箱不能为空！");
                return;
            }
            else
            {
                emp.Email = textBoxEmail.Text;
            }
            if (comboBoxDepartment.SelectedIndex == -1)
            {
                CommonHelper.ShowErrorMessageBox("所属部门不能为空！");
                return;
            }
            else
            {
                emp.DepartmentId = (Guid)comboBoxDepartment.SelectedValue;
            }
            if (textBoxNumber.Text == "")
            {
                CommonHelper.ShowErrorMessageBox("工号不能为空！");
                return;
            }
            else
            {
                emp.Number = textBoxNumber.Text;
            }
            emp.Photo = photo;
            if (emp.Photo == null)
            {
                CommonHelper.ShowErrorMessageBox("请选择照片！");
                return;
            }
            emp.Remarks = textBoxRemarks.Text;
            emp.Resume = textBoxResume.Text;
            emp.BirthDay = dtpBirthDay.Value;
            emp.InDay = dtpInDay.Value;
            EmployeeService empServ = new EmployeeService();
            if (empid == Guid.Empty)
            {
                emp.Id = Guid.NewGuid();
                if (empServ.AddEmployee(emp))
                {
                    this.DialogResult = DialogResult.OK;
                    CommonHelper.ShowSuccessMessageBox("添加员工成功！");
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                    CommonHelper.ShowErrorMessageBox("保存失败！");
                }
            }
            else
            {
                emp.Id = empid;
                if (empServ.EditEmployee(emp))
                {
                    this.DialogResult = DialogResult.OK;
                    CommonHelper.ShowSuccessMessageBox("修改成功！");
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                    CommonHelper.ShowErrorMessageBox("修改失败！");
                }
            }
        }
        private void buttonChosePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG图片|*.jpg|位图|*.bmp|Gif图片|*.gif|PNG图片|*.png|全部文件|*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                photo = File.ReadAllBytes(ofd.FileName);
                pictureBoxPhoto.Image = new Bitmap(ofd.FileName);
            }
        }
    }
}
