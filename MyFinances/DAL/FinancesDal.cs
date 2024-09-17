    using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyFinances.Models;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

namespace MyFinances.DAL
{
    public class FinancesDal : IFinancesDAL
    {
        public FinancesDal()
        {
        }
        private readonly AppDbContext db;

        public FinancesDal(AppDbContext context)
        {
            db = context;
        }

        
        public IEnumerable<ExpenseReport> GetAllExpenses()
        {
            try
            {
                return db.ExpenseReport.ToList();
                
            }
            catch { throw; }
        }

        //Filter reports based on search string
        public IEnumerable<ExpenseReport> GetFilterExpenses(string criterion)
        {
            List<ExpenseReport> expense = new List<ExpenseReport>();
            try
            {
                expense = GetAllExpenses().ToList();
                return expense.Where(x => x.ItemName.IndexOf(criterion, StringComparison.OrdinalIgnoreCase) != -1);
            }
            catch { throw; }
        }


        //Add a new expense
        public void AddExpense(ExpenseReport expense)
        {
            try
            {
                db.ExpenseReport.Add(expense);
                db.SaveChanges();
            }
            catch { throw; }
        }

        //Update a expense
        public int UpdateExpense(ExpenseReport expense)
        {
            try
            {
                db.Entry(expense).State = EntityState.Modified;
                db.SaveChanges();
                return 1;
            }
            catch { throw; }
        }

        //Get a expense per id
        public ExpenseReport GetExpense(int id)
        {
            try
            {
                ExpenseReport expense = db.ExpenseReport.Find(id);
                return expense;
            }
            catch { throw; }
        }

        //Delete a expense
        public void DeleteExpense(int id)
        {
            try
            {
                ExpenseReport expense = db.ExpenseReport.Find(id);
                db.ExpenseReport.Remove(expense);
                db.SaveChanges();
            }
            catch { throw; }
        }

        //Calcule semi-annual expense
        public Dictionary<string, decimal> CalculeExpensePeriod(int period)
        {
            Dictionary<string, decimal> SumExpensePeriod = new Dictionary<string, decimal>();
            decimal expenseFood = db.ExpenseReport.Where
                (cat => cat.Category == "Food" && (cat.ExpenseDate >
                DateTime.Now.AddMonths(-period)))
                .Select(cat => cat.Value)
                .Sum();

            decimal expenseShopping = db.ExpenseReport.Where
            (cat => cat.Category == "Shopping" && (cat.ExpenseDate >
            DateTime.Now.AddMonths(-period)))
            .Select(cat => cat.Value)
            .Sum();

            decimal expenseTransport = db.ExpenseReport.Where
            (cat => cat.Category == "Transport" && (cat.ExpenseDate >
            DateTime.Now.AddMonths(-period)))
            .Select(cat => cat.Value)
            .Sum();

            decimal expenseHealth = db.ExpenseReport.Where
            (cat => cat.Category == "Health" && (cat.ExpenseDate >
            DateTime.Now.AddMonths(-period)))
            .Select(cat => cat.Value)
            .Sum();

            decimal expenseHome = db.ExpenseReport.Where
            (cat => cat.Category == "Home" && (cat.ExpenseDate >
            DateTime.Now.AddMonths(-period)))
            .Select(cat => cat.Value)
            .Sum();

            decimal expenseLeisure = db.ExpenseReport.Where
            (cat => cat.Category == "Leisure" && (cat.ExpenseDate >
            DateTime.Now.AddMonths(-period)))
            .Select(cat => cat.Value)
            .Sum();

            SumExpensePeriod.Add("Food", expenseFood);
            SumExpensePeriod.Add("Shopping", expenseShopping);
            SumExpensePeriod.Add("Transport", expenseTransport);
            SumExpensePeriod.Add("Health", expenseHealth);
            SumExpensePeriod.Add("Home", expenseHome);
            SumExpensePeriod.Add("Leisure", expenseLeisure);

            return SumExpensePeriod;

        }

        //Calcule monthly expense
        public Dictionary<string, decimal> CalculeExpensePeriodWeekly(int period)
        {
            Dictionary<string, decimal> SumExpensePeriodWeekly = new Dictionary<string, decimal>();
            decimal expenseFood = db.ExpenseReport.Where
            (cat => cat.Category == "Food" && (cat.ExpenseDate > DateTime.Now.AddDays(-period)))
            .Select(cat => cat.Value)
            .Sum();

            decimal expenseShopping= db.ExpenseReport.Where
            (cat => cat.Category == "Shopping" && (cat.ExpenseDate > DateTime.Now.AddDays(-period)))
            .Select(cat => cat.Value)
            .Sum();

            decimal expenseTransport = db.ExpenseReport.Where
            (cat => cat.Category == "Transport" && (cat.ExpenseDate > DateTime.Now.AddDays(-period)))
            .Select(cat => cat.Value)
            .Sum();

            decimal expenseHealth = db.ExpenseReport.Where
            (cat => cat.Category == "Health" && (cat.ExpenseDate > DateTime.Now.AddDays(-period)))
            .Select(cat => cat.Value)
            .Sum();

            decimal expenseHome = db.ExpenseReport.Where
            (cat => cat.Category == "Home" && (cat.ExpenseDate > DateTime.Now.AddDays(-period)))
            .Select(cat => cat.Value)
            .Sum();

            decimal expenseLeisure = db.ExpenseReport.Where
            (cat => cat.Category == "Leisure" && (cat.ExpenseDate > DateTime.Now.AddDays(-period)))
            .Select(cat => cat.Value)
            .Sum();

            SumExpensePeriodWeekly.Add("Food", expenseFood);
            SumExpensePeriodWeekly.Add("Shopping", expenseShopping);
            SumExpensePeriodWeekly.Add("Transport", expenseTransport);
            SumExpensePeriodWeekly.Add("Health", expenseHealth);
            SumExpensePeriodWeekly.Add("Home", expenseHome);
            SumExpensePeriodWeekly.Add("Leisure", expenseLeisure);

            return SumExpensePeriodWeekly;


        }

        public Dictionary<string, decimal> CalculeExpensePeriodMonthly(int? month, int? year)
        {
            var currentMonth = month ?? DateTime.Now.Month;
            var currentYear = year ?? DateTime.Now.Year;

            Dictionary<string, decimal> SumExpensePeriod = new Dictionary<string, decimal>();
            decimal expenseFood = db.ExpenseReport.Where
            (cat => cat.Category == "Food" && (cat.ExpenseDate.Month == currentMonth && cat.ExpenseDate.Year == currentYear))
            .Select(cat => cat.Value)
            .Sum();

            decimal expenseShopping = db.ExpenseReport.Where
            (cat => cat.Category == "Shopping" && (cat.ExpenseDate.Month == currentMonth && cat.ExpenseDate.Year == currentYear))
            .Select(cat => cat.Value)
            .Sum();

            decimal expenseTransport = db.ExpenseReport.Where
            (cat => cat.Category == "Transport" && (cat.ExpenseDate.Month == currentMonth && cat.ExpenseDate.Year == currentYear))
            .Select(cat => cat.Value)
            .Sum();

            decimal expenseHealth = db.ExpenseReport.Where
            (cat => cat.Category == "Health" && (cat.ExpenseDate.Month == currentMonth && cat.ExpenseDate.Year == currentYear))
            .Select(cat => cat.Value)
            .Sum();

            decimal expenseHome = db.ExpenseReport.Where
            (cat => cat.Category == "Home" && (cat.ExpenseDate.Month == currentMonth && cat.ExpenseDate.Year == currentYear))
            .Select(cat => cat.Value)
            .Sum();

            decimal expenseLeisure = db.ExpenseReport.Where
            (cat => cat.Category == "Leisure" && (cat.ExpenseDate.Month == currentMonth && cat.ExpenseDate.Year == currentYear))
            .Select(cat => cat.Value)
            .Sum();

            SumExpensePeriod.Add("Food", expenseFood);
            SumExpensePeriod.Add("Shopping", expenseShopping);
            SumExpensePeriod.Add("Transport", expenseTransport);
            SumExpensePeriod.Add("Health", expenseHealth);
            SumExpensePeriod.Add("Home", expenseHome);
            SumExpensePeriod.Add("Leisure", expenseLeisure);

            return SumExpensePeriod;

        }

        public decimal SumExpense(IEnumerable<ExpenseReport> expenses)
        {
            decimal totalExpenses = 0;

            foreach (var item in expenses)
            {
                totalExpenses += item.Value;
            }

            return totalExpenses;
        }


    }
}
