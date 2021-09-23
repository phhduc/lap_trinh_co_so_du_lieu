using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class SinhVien
    {
        public string MS { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBird { get; set; }
        public bool IsMale { get; set; }
        public string Class { get; set; }
        public string Phone { get; set; }
        public string Imange { get; set; }
        public SinhVien(string ms)
        {
            this.MS = ms;
        }
        public SinhVien(string ms, string name, string email, string address,
            DateTime dob, bool isMale, string cl, string phone, string image)
        {
            this.MS = ms;
            this.Name = name;
            this.Email = email;
            this.Address = address;
            this.DateOfBird = dob;
            this.IsMale = isMale;
            this.Class = cl;
            this.Phone = phone;
            this.Imange = image;
        }
        public override string ToString()
        {
            return MS + "*" + Name + "*" + Email + "*" + Address + "*" + DateOfBird.ToString() + "*" + (IsMale) +
                "*" + Class + "*" + Phone + "*" + Imange +"*";
        }
    }
}
