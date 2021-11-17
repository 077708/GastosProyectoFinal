using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Resumen
    {
        public int Id { get; set; }

        public decimal Ingresos { get; set; }

        public decimal Gastos { get; set; }

        public decimal Total { get; set; }
    }
}
