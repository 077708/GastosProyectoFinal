using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.IServices
{
    public interface IServices <T>
    {
        bool Add(T t);

        bool Update(T t);

        List<T> FindAll();

        bool Delete(int t);
    }
}
