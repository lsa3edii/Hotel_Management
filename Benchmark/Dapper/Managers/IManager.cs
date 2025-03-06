using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark.Dapper.Managers
{
    interface IManager<T>
    {
        List<T> GetAll();
        T GetByID(long ID);
    }
}
