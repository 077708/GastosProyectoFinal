using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Ingresos
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Ingreso { get; set; }

        public CategoriaIngresos CategoryExpense { get; set; }

        public DateTime Date { get; set; }

        public byte[] Image { get; set; }
    }
}
