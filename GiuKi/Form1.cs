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
using GiuKi.View;
using GiuKi.IO;

namespace GiuKi
{
    public partial class Form1 : Form
    {
        public Manager manager;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            manager = new Manager("Data\\data.txt");
            LoadLv(manager.Students);
            LoadTree();
            this.txtSearch.TextChanged += TxtSearch_TextChanged;
            this.txtSearch.LostFocus += TxtSearch_LostFocus;
            this.txtSearch.GotFocus += TxtSearch_GotFocus;
        }

        private void TxtSearch_GotFocus(object sender, EventArgs e)
        {
            this.txtSearch.Text = "";
        }

        private void TxtSearch_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtSearch.Text))
                this.txtSearch.Text = "Nhập thông tin cần tìm !!!";
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (this.txtSearch.Text == "Nhập thông tin cần tìm !!!") return;
            if (this.rdMs.Checked) LoadLv(manager.GetSvID(this.txtSearch.Text));
            if (this.rdSdt.Checked) LoadLv(manager.GetSvPhone(this.txtSearch.Text));
            if (this.rdTen.Checked) LoadLv(manager.GetSvName(this.txtSearch.Text));
        }

        public void LoadLv(List<Sv> ds)
        {
            this.lvSv.Items.Clear();
            foreach(var x in ds)
            {
                ListViewItem item = ItemSv(x);
                this.lvSv.Items.Add(item);
            }
        }
        public ListViewItem ItemSv(Sv x)
        {
            ListViewItem item = new ListViewItem();
            item.Text = x.StudentId;
            item.SubItems.Add(x.FirstName);
            item.SubItems.Add(x.LastName);
            if (x.Gender)
                item.SubItems.Add("Nam");
            else item.SubItems.Add("Nữ");
            item.SubItems.Add(x.DateOfBirth.ToString());
            item.SubItems.Add(x.PhoneNumber);
            item.SubItems.Add(x.ClassName);
            return item;
        } 
        private void tsmiThem_Click(object sender, EventArgs e)
        {
            StudentInfo f = new StudentInfo(manager.Faculties);
            f.ShowDialog();
            Sv sv = f.sv;
            if(manager.Students.Find(x => x.StudentId == sv.StudentId)!=null)
            {
                DialogResult d = MessageBox.Show("Trùng MSSV", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            manager.Students.Add(sv);
            LoadLv(manager.GetSvClass(sv.ClassName));
            
        }
        public void LoadTree()
        {
            for (int i = 0; i < manager.Faculties.Count; i++) {
                this.tvLop.Nodes.Add(manager.Faculties[i].Name);
                foreach (var x in manager.Faculties[i].Classes)
                    this.tvLop.Nodes[i].Nodes.Add(x);
            }
        }

        private void tvLop_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadLv(GetDsTvSelect());
        }
        private List<Sv> GetDsTvSelect()
        {
            int i = this.tvLop.SelectedNode.Level;
            string name = this.tvLop.SelectedNode.Text;
            if (i == 0)
                return (manager.GetSvFaculty(name));
            else return (manager.GetSvClass(name));
        }
        private void tsmiRemoveSv_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có chắc xóa sinh viên đã chọn?", "Cảnh bảo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.No) return;
            while (this.lvSv.SelectedItems.Count > 0)
            {
                manager.Students.RemoveAll(x => x.StudentId == this.lvSv.SelectedItems[0].Text);
                this.lvSv.Items.Remove(this.lvSv.SelectedItems[0]);
            }
            
        }

        private void lvSv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvSv_DoubleClick(object sender, EventArgs e)
        {
            Sv sv = manager.Students.Find(x => this.lvSv.SelectedItems[0].Text == x.StudentId);
            StudentInfo f = new StudentInfo(sv, manager.Faculties);
            f.ShowDialog();
            sv = f.sv;
            int index = this.lvSv.Items.IndexOf(this.lvSv.SelectedItems[0]);
            this.lvSv.Items[index] = ItemSv(sv);
        }

        private void tsmiJsonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.InitialDirectory = @"D:\";
            sf.FileName = this.tvLop.SelectedNode.Text;
            sf.Filter = "Excel 2007 file(xlsx>(*.xlsx)|*.xlsx|Json file(json)(*.json)|*.json";
            sf.FilterIndex = 2;
            if(sf.ShowDialog() == DialogResult.OK)
            {
                if(SaveFile(GetDsTvSelect(), sf.FileName))
                    MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public bool SaveFile(List<Sv> ds, string fn)
        {
            IDataSource f = null;
            if (fn.EndsWith(".json")) f = new JsonDataSource(fn);
            if (fn.EndsWith(".xlsx")) f = new ExcelDataSource(fn); 

            f.Save(ds);
            return true;
        }

        private void tsmiExcelSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.InitialDirectory = @"D:\";
            sf.FileName = this.tvLop.SelectedNode.Text;
            sf.Filter = "Excel 2007 file(xlsx>(*.xlsx)|*.xlsx|Json file(json)(*.json)|*.json";
            sf.FilterIndex = 1;
            if (sf.ShowDialog() == DialogResult.OK)
            {
                if (SaveFile(GetDsTvSelect(), sf.FileName))
                    MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
