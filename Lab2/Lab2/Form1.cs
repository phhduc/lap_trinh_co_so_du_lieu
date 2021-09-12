using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class GiaoVienForm : Form
    {
        public GiaoVienForm()
        {
            InitializeComponent();
        }

        private void GiaoVienForm_Load(object sender, EventArgs e)
        {
            string lienhe = "http://cntt.dlu.edu.vn/";
            this.linklbLienHe.Links.Add(0, lienhe.Length, lienhe);
            this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = this.lbDanhSachMH.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbMonHocDay.Items.Add(lbDanhSachMH.SelectedItems[i]);
                this.lbDanhSachMH.Items.Remove(lbDanhSachMH.SelectedItems[i]);
                i--;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = this.lbMonHocDay.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbDanhSachMH.Items.Add(lbMonHocDay.SelectedItems[i]);
                this.lbMonHocDay.Items.Remove(lbMonHocDay.SelectedItems[i]);
                i--;
            }
        }
        public void Reset()
        {
            this.cboMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.txtMail.Text = "";
            this.mtxtSoDT.Text = "";
            this.rdNam.Checked = true;
            for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
                chklbNgoaiNgu.SetItemChecked(i, false);
            foreach (object x in this.lbMonHocDay.Items)
                this.lbDanhSachMH.Items.Add(x);
            this.lbMonHocDay.Items.Clear();
        }

        private void linklbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = e.Link.LinkData.ToString();
            System.Diagnostics.Process.Start(s);
        }

        public GiaoVien GetGiaoVien()
        {
            string gt = "Nam";
            if (rdNu.Checked) gt = "Nữ";
            GiaoVien gv = new GiaoVien();
            gv.MaSo = this.cboMaSo.Text;
            gv.GioiTinh = gt;
            gv.HoTen = this.txtHoTen.Text;
            gv.NgaySinh = this.dtpNgaySinh.Value;
            gv.Mail = this.txtMail.Text;
            gv.SoDT = this.mtxtSoDT.Text;
            string ngoaingu = "";
            for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
                if (chklbNgoaiNgu.GetItemChecked(i))
                    ngoaingu += chklbNgoaiNgu.Items[i] + ";";
            gv.NgoaiNgu = ngoaingu.Split(';');
            DanhMucMonHoc mh = new DanhMucMonHoc();
            foreach (var x in lbMonHocDay.Items)
                mh.Them(new MonHoc(x.ToString()));
            gv.dsMonHoc = mh;
            return gv;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TBGiaoVienForm f = new TBGiaoVienForm();
            f.SetText(GetGiaoVien().ToString());
            f.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
