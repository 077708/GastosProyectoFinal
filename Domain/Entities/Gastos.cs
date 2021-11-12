using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Gastos
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Expenditure { get; set; }

        public CategoriaGastos CategoryExpense { get; set; }

        public DateTime Date { get; set; }

        public byte[] Image { get; set; }

    }
}
