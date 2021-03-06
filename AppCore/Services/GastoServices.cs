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
    public class GastoServices : IGastosServices
    {
        private IGastos gastos;

        public GastoServices(IGastos gastos)
        {
            this.gastos = gastos;
        }

        public bool Add(Gastos t)
        {
            return gastos.Add(t);
        }

        public bool Delete(int t)
        {
            return gastos.Delete(t);
        }

        public List<Gastos> FindAll()
        {
            return gastos.FindAll();
        }

        public bool Update(Gastos t)
        {
            return gastos.Update(t);
        }
    }
}
