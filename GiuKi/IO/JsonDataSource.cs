using GiuKi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace GiuKi.IO
{
    public class JsonDataSource: IDataSource
    {
        public string _filePath;
        public JsonDataSource(string filepath)
        {
            _filePath = filepath;
        }
        public List<Sv> GetSv()
        {
            List<Sv> students = new List<Sv>();
            if (File.Exists(_filePath))
            {
                using (var reader = new StreamReader(_filePath))
                {
                    var json = reader.ReadToEnd();
                    students = JsonConvert.DeserializeObject<List<Sv>>(json);
                }
            }
            return students;
        }
        public void Save(List<Sv> Students)
        {
            var data = JsonConvert.SerializeObject(Students);
            File.WriteAllText(_filePath, data);
        }

    }
}
