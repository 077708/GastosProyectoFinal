using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.LogicaDB
{
    public class IngresosRepository : IQueryIngresos
    {
        public List<Ingresos> GetByCostPrice(List<Ingresos> ingresos, decimal num)
        {
            return (from e in ingresos where e.Ingreso == num select e).ToList();
        }

        public List<Ingresos> GetByDate(List<Ingresos> ingresos, DateTime dateTime)
        {
            return (from e in ingresos where e.Date >= dateTime select e).ToList();
        }

        public List<Ingresos> GetById(List<Ingresos> ingresos, int t)
        {
            return (from e in ingresos where e.Id == t select e).ToList();
        }

        public List<Ingresos> GetByName(List<Ingresos> ingresos, string Name)
        {
            return (from e in ingresos where e.Name == Name select e).ToList();
        }

        public List<Ingresos> GetbyUnit(List<Ingresos> ingresos, CategoriaIngresos categoria)
        {
            return (from e in ingresos where e.CategoryExpense == categoria select e).ToList();
        }
    }
}
