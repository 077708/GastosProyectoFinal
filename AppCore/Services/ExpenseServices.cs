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
    public class ExpenseServices : IExpenseS
    {
        private IExpense expense;

        public ExpenseServices(IExpense expense)
        {
            this.expense = expense;
        }

        public bool Add(Expense t)
        {
            return expense.Add(t);
        }

        public bool Delete(Expense t)
        {
            return expense.Delete(t);
        }

        public List<Expense> FindAll()
        {
            return expense.FindAll();
        }

        public bool Update(Expense t)
        {
            return expense.Update(t);
        }
    }
}
