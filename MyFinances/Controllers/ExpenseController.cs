﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using MyFinances.Models;
using MyFinances.DAL;

namespace MyFinances.Controllers
{

    public class ExpenseController : Controller
    {
        private readonly IFinancesDAL _dal;
        public ExpenseController(IFinancesDAL dal)
        {
            _dal = dal;
        }

        //GET: Expense
        public IActionResult Index(string criterion, int? month, int? year)
        {
            var currentMonth = month ?? DateTime.Now.Month;
            var currentYear = year ?? DateTime.Now.Year;

            var listExpenses = _dal.GetAllExpenses().Where(x => x.ExpenseDate.Month == currentMonth && 
            x.ExpenseDate.Year == currentYear).ToList();

            if (!String.IsNullOrEmpty(criterion))
            {
                listExpenses = _dal.GetFilterExpenses(criterion).ToList();
            }
            ViewBag.Titulo = "Despesas";
            ViewBag.CurrentMonth = currentMonth;
            ViewBag.CurrentYear = currentYear;

            return View(listExpenses);
        }

        public IActionResult EfIndex(string criterion, int? month, int? year)
        {
            var currentMonth = month ?? DateTime.Now.Month;
            var currentYear = year ?? DateTime.Now.Year;

            var listExpenses = _dal.GetAllExpenses().Where(x => x.FixedExpense == true).ToList();
            if (!String.IsNullOrEmpty(criterion))
            {
                listExpenses = _dal.GetFilterExpenses(criterion).ToList();
            }
            ViewBag.Titulo = "Despesas fixas";
            ViewBag.CurrentMonth = currentMonth;
            ViewBag.CurrentYear = currentYear;

            return View("Index", listExpenses);
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

                if (newExpense.ItemId > 0)
                {
                    _dal.UpdateExpense(newExpense);
                }
                else
                {
                    _dal.AddExpense(newExpense);
                }

            return RedirectToAction("EfIndex");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _dal.DeleteExpense(id);

            return RedirectToAction("EfIndex");
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

        public JsonResult GetExpensePierPeriodMonthly()
        {
            var currentMonth = DateTime.Now.Month;
            var currentYear = DateTime.Now.Year;
            Dictionary<string, decimal> expensePeriodMonthly = _dal.CalculeExpensePeriodMonthly(currentMonth, currentYear);
            return new JsonResult(expensePeriodMonthly);

        }

        public JsonResult GetExpensePierCategory()
        {
            Dictionary<string, decimal> expenseCategory = _dal.CalculeExpenseCategory();
            return new JsonResult(expenseCategory);
        }
    }
}
