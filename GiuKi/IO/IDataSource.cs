using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiuKi.Model;

namespace GiuKi.IO
{
    public  interface IDataSource
    {
        List<Sv> GetSv();
        void Save(List<Sv> Students);
    }
}
