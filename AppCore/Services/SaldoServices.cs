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
    public class SaldoServices : ISaldoServices
    {
        private ISaldo saldo;

        public SaldoServices(ISaldo saldo)
        {
            this.saldo = saldo;
        }

        public bool Add(Saldo t)
        {
            return saldo.Add(t);
        }

        public List<Saldo> FindAll()
        {
            return saldo.FindAll();
        }
    }
}
