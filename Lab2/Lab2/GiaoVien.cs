using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class GiaoVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh;
        public DanhMucMonHoc dsMonHoc;
        public string GioiTinh;
        public string[] NgoaiNgu;
        public string SoDT;
        public string Mail;
        public GiaoVien()
        {
            dsMonHoc = new DanhMucMonHoc();
            NgoaiNgu = new string[10];

        }
        public GiaoVien(string maso, string hoten, DateTime ngaysinh, DanhMucMonHoc ds,
            string gt, string[] nn, string sdt, string mail)
        {
            this.MaSo = maso;
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.dsMonHoc = ds;
            this.GioiTinh = gt;
            this.NgoaiNgu = nn;
            this.SoDT = sdt;
            this.Mail = mail;
        }
        public override string ToString()
        {
            string s = "Mã số " + MaSo + "\n" +
                "Họ tên: " + HoTen + "\n" +
                "Ngày sinh : " + NgaySinh.ToString() + "\n" +
                "Giới tính: " + GioiTinh + '\n' +
                "Số ĐT: " + SoDT + '\n' +
                "Mail: " + Mail + '\n';
            string snn = "Ngoại ngữ: ";
            foreach(var x in NgoaiNgu)
            {
                snn += x + ';';
            }
            string MonDay = "Danh sách môn dạy:";
            foreach (var x in dsMonHoc.ds)
                MonDay += x.ToString() + ';';
            s += '\n' + snn + '\n' + MonDay;
            return s;
        }
    }
}
