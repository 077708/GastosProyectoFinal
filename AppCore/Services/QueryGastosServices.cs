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
    public class QueryGastosServices : IQueryGastosServices
    {
        private IQueryGastos queryGastos;

        public QueryGastosServices(IQueryGastos queryGastos)
        {
            this.queryGastos = queryGastos;
        }

        public List<Gastos> GetByCostPrice(List<Gastos> gastos, decimal num)
        {
            return queryGastos.GetByCostPrice(gastos, num);
        }

        public List<Gastos> GetByDate(List<Gastos> gastos, DateTime dateTime)
        {
            return queryGastos.GetByDate(gastos, dateTime);
        }

        public List<Gastos> GetById(List<Gastos> gastos, int t)
        {
            return queryGastos.GetById(gastos, t);
        }

        public List<Gastos> GetByName(List<Gastos> gastos, string Name)
        {
            return queryGastos.GetByName(gastos, Name);
        }

        public decimal GetByPriceDashboard(DateTime btnDashboard, List<Gastos> gastos, int monthCount)
        {
            return queryGastos.GetByPriceDashboard(btnDashboard, gastos, monthCount);
        }

        public List<Gastos> GetbyUnit(List<Gastos> gastos, CategoriaGastos categoria)
        {
            return queryGastos.GetbyUnit(gastos, categoria);
        }
    }
}
