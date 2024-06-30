﻿using Microsoft.AspNetCore.Mvc;
using MyFinances.DAL;
using MyFinances.Models;
using System;
using System.Linq;


namespace MyFinances.Controllers
{
    public class InvestmentController : Controller
    {
        private readonly IInvestmentDAL _dal;

        public InvestmentController(IInvestmentDAL dal)
        {
                _dal = dal;
        }
        
        public IActionResult Index(string criterion)
        {
            var listInvestment = _dal.GetAllInvestments().ToList();
            if (!String.IsNullOrEmpty(criterion))
            {
                listInvestment = _dal.GetFilterInvestments(criterion).ToList();
            }
            return View(listInvestment);
        }


        public IActionResult AddEditInvestment(int itemId)
        {
            Investment model = new Investment();
            if (itemId > 0)
            {
                model = _dal.GetInvestment(itemId);
            }
            return PartialView("_InvestmentForm", model);
        }

        [HttpPost]
        public IActionResult Create(Investment newInvestment)
        {
            if (ModelState.IsValid)
            {
                if (newInvestment.ItemId > 0)
                {
                    _dal.UpdateInvestment(newInvestment);
                }
                else
                {
                    _dal.AddInvestment(newInvestment);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _dal.DeleteInvestment(id);
            return RedirectToAction("Index");
        }

    }
}
