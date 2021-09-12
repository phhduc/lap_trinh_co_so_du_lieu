using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bttuan3.IO
{
    public class NewRepository : INewsRepository
    {
        private const string FilePath = "Data\\Data.txt";
        public List<Publisher> GetNews()
        {
            var publishers = new List<Publisher>();
            Publisher office = null;
            string line;
            try
            {
                using (var stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new StreamReader(stream))
                    {
                        while (!reader.EndOfStream)
                        {
                            line = reader.ReadLine();
                            if (line == null) break;
                            if (line.StartsWith("@"))
                            {
                                office = ParsePublisher(line);
                                publishers.Add(office);
                            }
                            else if(line.StartsWith("#") && office != null)
                            {
                                var category = ParseCatogory(line);
                                office.Categories.Add(category);
                            }
                        }
                    }
                }
            }
            catch(Exception)
            {

            }
            return publishers;
        }

        private Category ParseCatogory(string line)
        {
            var parts = line.Substring(1).Split('^');
            return new Category()
            {
                Name = parts[0].Trim(),
                RssLink=parts[1].Trim()
            };
        }

        private Publisher ParsePublisher(string line)
        {
            return new Publisher()
            {
                Name = line.Substring(1).Trim()
            };
        }

        public void Save(List<Publisher> publishers)
        {
            using (var stream = new FileStream(FilePath, FileMode.Create, FileAccess.Write))
            {
                using (var writer = new StreamWriter(stream))
                {
                    foreach(var publisher in publishers)
                    {
                        writer.WriteLine("@{0}", publisher.Name);
                        foreach(var c in publisher.Categories)
                        {
                            writer.WriteLine("#{0}^{1}", c.Name, c.RssLink);
                        }
                    }
                }
            }
        }
    }
}
