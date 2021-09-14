using Lab3_Demo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Demo
{
    public partial class SinhVienForm : Form
    {
        QuanLySinhVien qlsv;

        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> cn = new List<string>();
            sv.MaSo = this.mtxtMaSo.Text;
            sv.HoTen = this.txtHoTen.Text;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.DiaChi = this.txtDiaChi.Text;
            sv.Lop = this.cboLop.Text;
            sv.Hinh = this.txtHinh.Text;
            if (rdNu.Checked) gt = false;
            sv.GioiTinh = gt;
            for (int i = 0; i < this.chklbChuyenNganh.Items.Count; i++)
                if (chklbChuyenNganh.GetItemChecked(i))
                    cn.Add(chklbChuyenNganh.Items[i].ToString());
            sv.ChuyenNganh = cn;
            return sv;
        }
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[2].Text);
            sv.DiaChi = lvitem.SubItems[3].Text;
            sv.Lop = lvitem.SubItems[4].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[5].Text == "Nam") sv.GioiTinh = true;
            List<string> cn = new List<string>();
            string[] s = lvitem.SubItems[6].Text.Split(',');
            foreach (string t in s) cn.Add(t);
            sv.ChuyenNganh = cn;
            sv.Hinh = lvitem.SubItems[7].Text;
            return sv;
        }
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMaSo.Text = sv.MaSo;
            this.txtHoTen.Text = sv.HoTen;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.txtDiaChi.Text = sv.DiaChi;
            this.cboLop.Text = sv.Lop;
            this.txtHinh.Text = sv.Hinh;
            this.pbHinh.ImageLocation = sv.Hinh;
            if (sv.GioiTinh) this.rdNam.Checked = true;
            else this.rdNu.Checked = true;
            for (int i = 0; i < this.chklbChuyenNganh.Items.Count; i++)
                this.chklbChuyenNganh.SetItemChecked(i, false);
            foreach (string s in sv.ChuyenNganh)
                for (int i = 0; i < this.chklbChuyenNganh.Items.Count; i++)
                    if (s.CompareTo(this.chklbChuyenNganh.Items[i]) == 0)
                        this.chklbChuyenNganh.SetItemChecked(i, true);
        }
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MaSo);
            lvitem.SubItems.Add(sv.HoTen);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Lop);
            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            string cn = "";
            foreach (string s in sv.ChuyenNganh)
                cn += s + ",";
            cn = cn.Substring(0, cn.Length - 1);
            lvitem.SubItems.Add(cn);
            lvitem.SubItems.Add(sv.Hinh);
            this.lvSinhVien.Items.Add(lvitem);
        }
        private void LoadList(List<SinhVien> list)
        {
            this.lvSinhVien.Items.Clear();
            foreach (SinhVien x in list)
                ThemSV(x);
        }
        private void LoadListView()
        {
            this.lvSinhVien.Items.Clear();
            foreach (SinhVien sv in qlsv.DanhSach)
                ThemSV(sv);
        }



        public SinhVienForm()
        {
            InitializeComponent();
        }

        private void SinhVienForm_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
            LoadListView();
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvSinhVien.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = this.lvSinhVien.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(chklbChuyenNganh.SelectedItems.Count<1)
            {
                MessageBox.Show("Bạn chưa chọn chuyên ngành ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.Tim(sv.MaSo, SoSanhTheoMa);
            if (kq != null)
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.qlsv.Them(sv);
                this.LoadListView();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = this.lvSinhVien.Items.Count - 1;
            for (i = count; i >= 0; i--)
            {
                lvitem = this.lvSinhVien.Items[i];
                if (lvitem.Checked)
                    qlsv.Xoa((lvitem.SubItems[0].Text), SoSanhTheoMa);
            }
            this.LoadListView();
            this.btnMacDinh.PerformClick();
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mtxtMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgaySinh.Value = DateTime.Now;
            this.txtDiaChi.Text = "";
            this.cboLop.Text = this.cboLop.Items[0].ToString();
            this.txtHinh.Text = "";
            this.pbHinh.ImageLocation = "";
            this.rdNam.Checked = true;
            for (int i = 0; i < this.chklbChuyenNganh.Items.Count - 1; i++)
                this.chklbChuyenNganh.SetItemChecked(i, false);
            this.LoadListView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            sv.MaSo = sv.MaSo.Split('.')[1];
            bool kqsua;
            kqsua = qlsv.Sua(sv, sv.MaSo, SoSanhTheoMa);
            
            if (kqsua) this.LoadListView();


           
        }
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MaSo.CompareTo(obj1 as string);
        }

        private void bntBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.ico; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbHinh.Image = new Bitmap(open.FileName);
                // image file path  
                this.txtHinh.Text = open.FileName;
            }
        }

        private void mởFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            qlsv = new QuanLySinhVien();
            f.Title = "Mở file";
            f.Filter = "txtFile (*.txt)|*.txt|All files (*.*)|*.*";
            f.FilterIndex = 2;
            f.RestoreDirectory = true;
            if (f.ShowDialog() == DialogResult.OK)
                qlsv.FileName = f.FileName;
            qlsv.DocTuFile();
            lvSinhVien.Items.Clear();
            this.LoadListView();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnThoat.PerformClick();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnThem.PerformClick();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnXoa.PerformClick();
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnSua.PerformClick();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            f.ShowDialog();
            if(f.ShowDialog() == DialogResult.OK)
            {
                
                lvSinhVien.Font = f.Font;
            }
            
        }

        private void màuChữToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog f = new ColorDialog();
            f.ShowDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                lvSinhVien.ForeColor = f.Color;
            }
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TuyChonForm f = new TuyChonForm();
            f.ShowDialog();
            string s = f.Tk;
            List<SinhVien> ds = new List<SinhVien>();
            switch (f.SS)
            {
                case 1:
                    ds = (qlsv.Tim2(s, TimTheoMS));
                    break;
                case 2:
                    ds= (qlsv.Tim2(s, TimTheoTen));
                    break;
                case 3:
                    ds=(qlsv.Tim2(s, TimTheoNS));
                    break;
            }
            lvSinhVien.Items.Clear();
            LoadList(ds);

        }

        private void sắpXếpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TuyChonForm f = new TuyChonForm(true);
            f.ShowDialog();
            switch (f.SS)
            {
                case 1:
                    qlsv.DanhSach.Sort(SoSanhTheoMa);
                    break;
                case 2:
                    qlsv.DanhSach.Sort(SoSanhTheoHoTen);
                    break;
                case 3:
                    qlsv.DanhSach.Sort(SoSanhTheoNS);
                    break;
            }
            lvSinhVien.Items.Clear();
            this.LoadListView();
        }
        public int SoSanhTheoHoTen(object obj1, object obj2)
        {
            return (obj2 as SinhVien).MaSo.CompareTo((obj1 as SinhVien).MaSo);
        }
        public int SoSanhTheoNS(object obj1, object obj2)
        {
            return DateTime.Compare((obj1 as SinhVien).NgaySinh, (obj2 as SinhVien).NgaySinh);
        }
        public int TimTheoTen(object o1, object o2)
        {
            return (o2 as SinhVien).HoTen.Contains(o1 as string) ? 0 : 1 ;
        }
        public int TimTheoMS(object o1, object o2)
        {
            return (o2 as SinhVien).MaSo.Contains(o1 as string)?0:1;
        }
        public int TimTheoNS(object o1, object o2)
        {
            return (o2 as SinhVien).NgaySinh.ToString().Contains(o1 as string)?0:1;
        }
        
    }
}
