using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Saldo
    { 
        public int Id { get; set; }

        public Ingresos Ingresos { get; set; }

        public Gastos Gastos { get; set; }

        public decimal SaldoTotal => Ingresos.Ingreso - Gastos.Gasto + Ingresos.IngresoAux;

        public decimal ingresos { get; set; }

        public decimal gastos { get; set; }

        public decimal total { get; set; }
    }
}
