using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Demo
{
    public class SinhVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Lop { get; set; }
        public string Hinh { get; set; }
        public bool GioiTinh { get; set; }
        public List<string> ChuyenNganh { get; set; }
        public SinhVien()
        {
            ChuyenNganh = new List<string>();
        }
        public SinhVien(string ms, string ht, DateTime ns, string dc, string lop, string hinh, bool gi, List<string> cn)
        {
            this.MaSo = ms;
            this.HoTen = ht;
            this.DiaChi = dc;
            this.Lop = lop;
            this.Hinh = hinh;
            this.ChuyenNganh = cn;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = ns;
        }
    }
}
