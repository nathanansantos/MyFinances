using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFinances.Models;
using System.Collections.Generic;

namespace MyFinances.DAL
{
    public interface IFinancesDAL
    {
        IEnumerable<ExpenseReport> GetAllExpenses();
        IEnumerable<ExpenseReport> GetFilterExpenses(string criterion);
        void AddExpense(ExpenseReport expense);
        int UpdateExpense(ExpenseReport expense);
        ExpenseReport GetExpense(int id);
        void DeleteExpense(int id);
        Dictionary<string, decimal> CalculeExpensePeriod(int period);
        Dictionary<string, decimal> CalculeExpensePeriodWeekly(int period);
        Dictionary<string, decimal> CalculeExpensePeriodMonthly(int? month, int? year);
        Dictionary<string, decimal> CalculeExpenseCategory();
    }
}
