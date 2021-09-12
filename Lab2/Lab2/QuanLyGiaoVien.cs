using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{

    public class QuanLyGiaoVien
    {
        public enum KieuTim {
            TheoMa,
            TheoHoTen,
            TheoSDt
        };

        public delegate int SoSanh(object a, object b);

        List<GiaoVien> dsGiaoVien;
        public QuanLyGiaoVien()
        {
            dsGiaoVien = new List<GiaoVien>();
        }
        public GiaoVien this[int index]
        {
            get { return dsGiaoVien[index]; }
            set { }
        }
        
        public bool Them(GiaoVien gv)
        {
            if (dsGiaoVien.Contains(gv))
                return false;
            else dsGiaoVien.Add(gv);
            return true;
        }
        public GiaoVien Tim(object temp)
        {
            return new GiaoVien();
        }
        public void Xoa(object temp)
        {
            if (!dsGiaoVien.Contains(temp as GiaoVien)) return;
            SoSanh ss = new SoSanh(compareMS);
            dsGiaoVien.RemoveAll(x => compareMS(x, temp) == 0);
        }
        private int compareMS(object a, object b)
        {
            return (a as GiaoVien).MaSo.CompareTo((b as GiaoVien).MaSo);
        }
        private int compareHoTen(object  a, object  b)
        {
            return (a as GiaoVien).HoTen.CompareTo((b as GiaoVien).HoTen);
        }
        private int compareSdt(object a, object b)
        {
            return (a as GiaoVien).SoDT.CompareTo((b as GiaoVien).SoDT);
        }
        public void SapXep(SoSanh ss)
        {
            
        }
    }
}
