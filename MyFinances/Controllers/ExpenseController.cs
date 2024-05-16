using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFinances.Models;
using MyFinances.DAL;

namespace MyFinances.Controllers
{
    /*
    [Route("api/[controller]")]
    [ApiController]
    */
    public class ExpenseController : Controller
    {
        private readonly IFinancesDAL _dal;
        public ExpenseController(IFinancesDAL dal)
        {
            _dal = dal;
        }

        //GET: Expense
        public IActionResult Index(string criterion)
        {
            var listExpenses = _dal.GetAllExpenses().ToList();
            if(!String.IsNullOrEmpty(criterion))
            {
                listExpenses = _dal.GetFilterExpenses(criterion).ToList();
            }
            return View(listExpenses);
        }

        public IActionResult AddEditExpense(int itemId)
        {
            ExpenseReport model = new ExpenseReport();
            if (itemId > 0)
            {
                model = _dal.GetExpense(itemId);
            }
            return PartialView("_expenseForm", model);
        }

        [HttpPost]
        public IActionResult Create(ExpenseReport newExpense)
        {
            if(ModelState.IsValid)
            {
                if(newExpense.ItemId > 0)
                {
                    _dal.UpdateExpense(newExpense);
                }
                else
                {
                    _dal.AddExpense(newExpense);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _dal.DeleteExpense(id);
            return RedirectToAction("Index");
        }

        public IActionResult ExpenseSummary()
        {
            return PartialView("_expenseReport");
        }

        public JsonResult GetExpensePierPeriod()
        {
            Dictionary<string, decimal> expensePeriod = _dal.CalculeExpensePeriod(7);
            return new JsonResult(expensePeriod);
        }

        public JsonResult GetExpensePierPeriodWeekly()
        {
            Dictionary<string, decimal> expensePeriodWeekly = _dal.CalculeExpensePeriodWeekly(7);
            return new JsonResult(expensePeriodWeekly);
        }
    }
}
