using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuKi.Model
{
    public class Faculty
    {
        public List<string> Classes { get; set; }
        public string Name { get; set; }
        public Faculty()
        {
            Classes = new List<string>();
        }
    }
}
