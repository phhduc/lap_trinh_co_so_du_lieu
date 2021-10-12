using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiuKi.IO;

namespace GiuKi.Model
{
    public class Manager
    {
        public List<Sv> Students { get; set; }
        public List<Faculty> Faculties { get; set; }
        public Manager()
        {
            Faculties = new List<Faculty>();
        }

        public Manager(string filename) : this()
        {
            IDataSource f = new TextDataSource(filename);
            if (filename.EndsWith(".txt")) 
                f = new TextDataSource(filename);
            this.Students =f.GetSv();
            GetFaculty();
            InsertAll();
        }

        public void Refresh()
        {
            GetFaculty();
            InsertAll();
        }
        public void GetFaculty()
        {
             foreach(var x in Students)
                if(Faculties.FindIndex(item => item.Name==x.FacultyName)>=0)
                {
                    int i = Faculties.FindIndex(item => item.Name == x.FacultyName);
                    if (!Faculties[i].Classes.Contains(x.ClassName.Trim()))
                    {
                        Faculties[i].Classes.Add(x.ClassName);
                    }
                }
                else
                {
                    Faculty f = new Faculty();
                    f.Name = x.FacultyName;
                    f.Classes = new List<string>();
                    f.Classes.Add(x.ClassName);
                    Faculties.Add(f);
                }
        }
        public void InsertAll()
        {
            Faculty f = new Faculty();
            f.Name = "Tất cả";
            foreach (var x in Faculties)
                foreach (var y in x.Classes)
                    f.Classes.Add(y);
            Faculties.Insert(0, f);
        }
        public List<Sv> GetSvClass(string className)
        {
            List<Sv> ds = new List<Sv>();
            foreach (var x in Students)
                if (x.ClassName == className)
                    ds.Add(x);
            return ds;
        }
        public List<Sv> GetSvFaculty(string facultyName)
        {
            if (facultyName == "Tất cả") return Students;
            List<Sv> ds = new List<Sv>();
            foreach (var x in Students)
                if (x.FacultyName == facultyName)
                    ds.Add(x);
            return ds;
        }
        public List<Sv> GetSvID(string id)
        {
            List<Sv> ds = new List<Sv>();
            foreach (var x in Students)
                if (x.StudentId.Contains(id))
                    ds.Add(x);
            return ds;
        }
        public List<Sv> GetSvPhone(string id)
        {
            List<Sv> ds = new List<Sv>();
            foreach (var x in Students)
                if (x.PhoneNumber.Contains(id))
                    ds.Add(x);
            return ds;
        }
        public List<Sv> GetSvName(string id)
        {
            List<Sv> ds = new List<Sv>();
            foreach (var x in Students)
                if ((x.FirstName+" " +x.LastName).ToLower().Contains(id.ToLower()))
                    ds.Add(x);
            return ds;
        }
    }
}
