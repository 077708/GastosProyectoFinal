using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IQueryGastos 
    {
        List<Gastos> GetById(List<Gastos> gastos, int t);

        List<Gastos> GetByName(List<Gastos> gastos, string Name);

        List<Gastos> GetByCostPrice(List<Gastos> gastos, decimal num);

        List<Gastos> GetbyUnit(List<Gastos> gastos, CategoriaGastos categoria);

        List<Gastos> GetByDate(List<Gastos> gastos, DateTime dateTime);

        decimal GetByPriceDashboard(DateTime btnDashboard, List<Gastos> gastos, int monthCount);
    }
}
