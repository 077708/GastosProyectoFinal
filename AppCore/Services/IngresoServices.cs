using AppCore.IServices;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class IngresoServices : IIngresosServices
    {
        private IIngresos ingresos;

        public IngresoServices(IIngresos ingresos)
        {
            this.ingresos = ingresos;
        }

        public bool Add(Ingresos t)
        {
            return ingresos.Add(t);
        }

        public bool Delete(int t)
        {
            return ingresos.Delete(t);
        }

        public List<Ingresos> FindAll()
        {
            return ingresos.FindAll();
        }

        public bool Update(Ingresos t)
        {
            return ingresos.Update(t);
        }
    }
}
