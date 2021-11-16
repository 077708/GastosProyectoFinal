using AppCore.IServices;
using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class QueryServicesIngresos : IQueryIngresosServices
    {
        private IQueryIngresos queryIngresos;

        public QueryServicesIngresos(IQueryIngresos queryIngresos)
        {
            this.queryIngresos = queryIngresos;
        }

        public List<Ingresos> GetByCostPrice(List<Ingresos> ingresos, decimal num)
        {
            return queryIngresos.GetByCostPrice(ingresos, num);
        }

        public List<Ingresos> GetByDate(List<Ingresos> ingresos, DateTime dateTime)
        {
            return queryIngresos.GetByDate(ingresos, dateTime);
        }

        public List<Ingresos> GetById(List<Ingresos> ingresos, int t)
        {
            return queryIngresos.GetById(ingresos, t);
        }

        public List<Ingresos> GetByName(List<Ingresos> ingresos, string Name)
        {
            return queryIngresos.GetByName(ingresos, Name);
        }

        public List<Ingresos> GetbyUnit(List<Ingresos> ingresos, CategoriaIngresos categoria)
        {
            return queryIngresos.GetbyUnit(ingresos, categoria);
        }
    }
}
