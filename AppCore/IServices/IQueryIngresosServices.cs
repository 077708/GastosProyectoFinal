using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.IServices
{
    public interface IQueryIngresosServices 
    {
        List<Ingresos> GetById(List<Ingresos> ingresos, int t);

        List<Ingresos> GetByName(List<Ingresos> ingresos, string Name);

        List<Ingresos> GetByCostPrice(List<Ingresos> ingresos, decimal num);

        List<Ingresos> GetbyUnit(List<Ingresos> ingresos, CategoriaIngresos categoria);

        List<Ingresos> GetByDate(List<Ingresos> ingresos, DateTime dateTime);
    }
}
