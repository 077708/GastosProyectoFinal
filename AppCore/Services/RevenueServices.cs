using AppCore.IServices;
using Domain.Entities;
using Domain.IColeccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class RevenueServices : IRevenueS
    {
        private IRevenue revenue;

        public RevenueServices(IRevenue revenue)
        {
            this.revenue = revenue;
        }

        public bool Add(Revenue t)
        {
            return revenue.Add(t);
        }

        public bool Delete(Revenue t)
        {
            return revenue.Delete(t);
        }

        public List<Revenue> FindAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Revenue t)
        {
            throw new NotImplementedException();
        }
    }
}
