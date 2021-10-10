using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiuKi.Model;

namespace GiuKi.View
{
    public partial class StudentInfo : Form
    {
        public List<Faculty> faculties;
        public Sv sv;
        public bool _update;
        public StudentInfo()
        {
            InitializeComponent();
        }
        public StudentInfo(List<Faculty> ls) : this()
        {
            this.faculties = ls;
            this._update = false;
        }
        public StudentInfo(Sv sv, List<Faculty> ls) : this()
        {
            this._update = true;
            this.mktbMSSV.ReadOnly = true;
            this.faculties = ls;
            this.sv = sv;
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            foreach(var x in faculties)
            {
                this.cbKhoa.Items.Add(x.Name);
                foreach(var y in x.Classes)
                {
                    this.cbLop.Items.Add(y);
                }
            }
            this.cbKhoa.SelectedIndexChanged += CbKhoa_SelectedIndexChanged;
            if (this._update)
            {
                this.mktbMSSV.Text = this.sv.StudentId;
                this.txtHo.Text = this.sv.FirstName;
                this.txtTen.Text = this.sv.LastName;
                this.dtpNgaySinh.Value = this.sv.DateOfBirth;
                this.mktbPhone.Text = this.sv.PhoneNumber;
                this.txtDiachi.Text = this.sv.Address;
                this.rdNam.Checked = true;
                if (!this.sv.Gender) this.rdNu.Checked = true;
                Faculty x = this.faculties.Find(item => item.Name == this.sv.FacultyName);
                int i = this.faculties.IndexOf(x);
                this.cbKhoa.SelectedIndex = i;
                this.cbLop.Text = this.sv.ClassName;
            }

        }

        private void CbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbLop.Items.Clear();
            int i =this.cbKhoa.SelectedIndex;
            foreach (var y in this.faculties[i].Classes)
            {
                this.cbLop.Items.Add(y);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string s = "";
            if (String.IsNullOrEmpty(this.mktbMSSV.Text))
                s += "MSSV, ";
            if (String.IsNullOrEmpty(this.txtHo.Text))
                s += "Họ và tên lót, ";
            if (String.IsNullOrEmpty(this.txtTen.Text))
                s += "Tên, ";
            if (String.IsNullOrEmpty(this.cbKhoa.Text))
                s += "Khoa, ";
            if (String.IsNullOrEmpty(this.cbLop.Text))
                s += "Lớp, ";
            if (this.dtpNgaySinh.Value == DateTime.Today)
                s += "ngày sinh, ";
            if (s == "")
            {
                if(this._update)
                {
                    this.sv.StudentId = this.mktbMSSV.Text;
                    this.sv.FirstName = this.txtHo.Text;
                    this.sv.LastName = this.txtTen.Text;
                    this.sv.DateOfBirth = this.dtpNgaySinh.Value;
                    this.sv.ClassName = this.cbLop.Text;
                    this.sv.PhoneNumber = this.mktbPhone.Text;
                    this.sv.Address = this.txtDiachi.Text;
                    this.sv.Gender = this.rdNam.Checked;
                    this.sv.FacultyName = this.cbKhoa.SelectedText;
                } else
                {
                    this.sv = new Sv();
                    this.sv.StudentId = this.mktbMSSV.Text;
                    this.sv.FirstName = this.txtHo.Text;
                    this.sv.LastName = this.txtTen.Text;
                    this.sv.DateOfBirth = this.dtpNgaySinh.Value;
                    this.sv.ClassName = this.cbLop.Text;
                    this.sv.PhoneNumber = this.mktbPhone.Text;
                    this.sv.Address = this.txtDiachi.Text;
                    this.sv.Gender = this.rdNam.Checked;
                    this.sv.FacultyName = this.cbKhoa.SelectedText;
                }
            }
            else
            {
                s = s.Remove(s.Length - 1);
                DialogResult d = MessageBox.Show("Bạn chưa nhập " + s, "Cảnh bảo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Close();
        }
    }
}
