using Lab4.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Manager
    {
        public List<SinhVien> DS { get; set; }
        public Manager()
        {
            DS = new List<SinhVien>();
        }

        public override string ToString()
        {
            string s = "";
            foreach(var item in DS)
            {
                s += item.ToString() + "\n";
            }
            return s;
        }
        public void ReadFile()
        {
            using (StreamReader f = new StreamReader(".\\Data\\data.txt"))
            {
                string ln;
                while((ln=f.ReadLine()) != null)
                {
                    var arr = ln.Split('*');
                    try
                    {
                        this.DS.Add(
                            new SinhVien(arr[0], arr[1], arr[2], arr[3], DateTime.Parse(arr[4]),
                            bool.Parse(arr[5]), arr[6], arr[7], arr[8])
                            );

                    }
                    catch { };
                }
            }
        }
        
        public void SaveFile()
        {
            using (StreamWriter sw = new StreamWriter(".\\Data\\data.txt"))
            {
                foreach (var i in DS)
                    sw.WriteLine(i.ToString()); 
            }
        }
    }
}
