using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Dapper.Managers
{
    interface IManager<T>
    {
        bool Insert(T Item);
        bool Update(T Item);
        bool Delete(long ID);
        List<T> GetAll();
        T GetByID(long ID);
    }
}
