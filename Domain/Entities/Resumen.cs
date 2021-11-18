using Domain.Enums;
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

        public decimal Ingreso { get; set; }

        public decimal Gasto { get; set; }

        public decimal Total { get; set; }
    }
}
