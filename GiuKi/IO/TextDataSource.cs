using GiuKi.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuKi.IO
{
    class TextDataSource: IDataSource
    {
        public string _filePath;
        public TextDataSource(string filePath)
        {
            _filePath = filePath;
        }
        public List<Sv> GetSv()
        {
            List<Sv> students = new List<Sv>();
            if (File.Exists(_filePath))
            {
                using (var stream = new FileStream(_filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new StreamReader(stream))
                    {
                        string line;
                        while((line = reader.ReadLine()) != null)
                        {
                            Sv sv = ParseSv(line);
                            students.Add(sv);
                        }
                    }
                }
            }
            return students;
        }
        public void Save(List<Sv> Students)
        {

        }

        public Sv ParseSv(string line)
        {
            Sv r = new Sv();
            string[] l = line.Split('\t');
            r.StudentId = l[0];
            r.FirstName = l[1];
            r.LastName = l[2];
            r.ClassName = l[3];
            r.FacultyName = l[4];
            return r;
        }


    }
}
