using Lab4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        Manager m = new Manager();
        bool isChanged = false;
        public Form1()
        {
            InitializeComponent();
            m.ReadFile();
            LoadLV();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (this.isChanged)
            {
                DialogResult rs = MessageBox.Show("Danh sách có thay đổi. Lưu lại danh sách mới?", "Confirmation ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (rs == DialogResult.OK)
                    m.SaveFile();
            }
            Application.Exit();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
           
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp|All file (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                this.pbSv.Image = new Bitmap(open.FileName);
                // image file path  
                txtImage.Text = open.FileName;
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            this.txtName.Text = "";
            this.txtEmail.Text = "";
            this.txtAddress.Text = "";
            this.txtImage.Text = "";
            this.mtbMS.Text = "";
            this.mtbPhone.Text = "";
            this.rdNam.Checked = true;
            this.dtpDob.Value = DateTime.Now;
            this.cboClass.Text = "";
            this.pbSv.Image = null;
        }
        private bool checkInfo()
        {
            if (this.mtbMS.Text.Length != 7) return false;
            if (String.IsNullOrEmpty(this.cboClass.Text)) return false;
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!checkInfo()) return;
            string ms = this.mtbMS.Text;
            SinhVien sv;
            if(m.DS.Find(x => x.MS==ms) == null)
            {
                sv = new SinhVien(ms);
                m.DS.Add(sv);
                
            }
            else
            {
                sv = m.DS.Find(x => x.MS == ms);
            }
            sv.Name = this.txtName.Text;
            sv.Email = this.txtEmail.Text;
            sv.Address = this.txtAddress.Text;
            sv.Imange = this.txtImage.Text;
            sv.DateOfBird = this.dtpDob.Value;
            sv.IsMale = this.rdNam.Checked ? true : false;
            sv.Class = this.cboClass.Text;
            sv.Phone = this.mtbPhone.Text;
            this.isChanged = true;
            LoadLV();
        }

        private void LoadLV()
        {
            lvSv.Items.Clear();
            
            foreach (var item in m.DS)
            {
                ListViewItem x = new ListViewItem();
                x.Text = item.MS;
                x.SubItems.Add(item.Name);
                x.SubItems.Add((item.IsMale) ? "Nam" : "Nữ");
                x.SubItems.Add(item.DateOfBird.ToString());
                x.SubItems.Add(item.Class);
                x.SubItems.Add(item.Phone);
                x.SubItems.Add(item.Email);
                x.SubItems.Add(item.Address);
                x.SubItems.Add(item.Imange);
                lvSv.Items.Add(x);
            }
        }

        private void showInfo(SinhVien sv)
        {
            this.mtbMS.Text = sv.MS;
            this.txtName.Text = sv.Name;
            this.txtEmail.Text = sv.Email;
            this.txtAddress.Text = sv.Address;
            this.txtImage.Text = sv.Address;
            this.dtpDob.Value = sv.DateOfBird;
            this.cboClass.Text = sv.Class;
            this.mtbPhone.Text = sv.Phone;
            if (sv.IsMale) rdNam.Checked = true;
            else rdNu.Checked = true;
            if (!string.IsNullOrEmpty(sv.Imange))
                try
                {
                    this.pbSv.Image = new Bitmap(sv.Imange);
                }
                catch { };

        }

        private void lvSv_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ls = lvSv.SelectedItems;
            if (ls.Count == 0) return;
            string ms = ls[0].Text;
            SinhVien sv = m.DS.Find(x => x.MS == ms);
            showInfo(sv);
        }
        
        private void Remove(SinhVien sv)
        {
            m.DS.Remove(sv);
        }


        private void ctmiRemove_Click_1(object sender, EventArgs e)
        {
            while (lvSv.SelectedItems.Count > 0)
            {
                ListViewItem i = lvSv.SelectedItems[0];
                Remove(m.DS.Find(x => x.MS == i.Text));
                lvSv.Items.Remove(i);
            }
            LoadLV();
        }

        private void tảiLạiDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m = new Manager();
            m.ReadFile();
            LoadLV();
            btnDefault.PerformClick();
        }
    }
}
