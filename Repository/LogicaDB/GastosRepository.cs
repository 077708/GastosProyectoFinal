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
    public class GastosRepository : IQueryGastos
    {
        public List<Gastos> GetByCostPrice(List<Gastos> gastos, decimal num)
        {
            return (from e in gastos where e.Gasto >= num select e).ToList();
        }

        public List<Gastos> GetByDate(List<Gastos> gastos, DateTime dateTime)
        {
            return (from e in gastos where e.Date >= dateTime select e).ToList();
        }

        public List<Gastos> GetById(List<Gastos> gastos, int t)
        {
            return (from e in gastos where e.Id == t select e).ToList();
        }

        public List<Gastos> GetByName(List<Gastos> gastos, string Name)
        {
            return (from e in gastos where e.Name == Name select e).ToList();
        }

        public List<Gastos> GetbyUnit(List<Gastos> gastos, CategoriaGastos categoria)
        {
            return (from e in gastos where e.CategoryExpense == categoria select e).ToList();
        }
    }
}
