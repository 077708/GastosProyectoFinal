using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IColeccion
{
    public interface IColeccionE <T>
    {
        bool Add(T t);

        bool Update(T t);

        List<T> FindAll();

        bool Delete(T t);
    }
}
