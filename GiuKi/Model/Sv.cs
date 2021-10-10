using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuKi.Model
{
    public class Sv
    {
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ClassName { get; set; }
        public string FacultyName { get; set; }
        public Sv() {
            this.Gender = true;
            this.DateOfBirth = DateTime.Today ;
            this.PhoneNumber = "";
            this.Address = "";
        }

        public Sv(string id, string fn, string ln, bool gender,
            DateTime dob, string pn, string ad, string cn, string facn)
        {
            this.StudentId = id;
            this.FirstName = fn;
            this.LastName = ln;
            this.Gender = gender;
            this.DateOfBirth = dob;
            this.PhoneNumber = pn;
            this.Address = ad;
            this.ClassName = cn;
            this.FacultyName = facn;
        }
    }
}
