using Microsoft.EntityFrameworkCore;
using MyFinances.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFinances.DAL
{
    public class InvestmentDAL : IInvestmentDAL
    {
        public InvestmentDAL()
        {

        }
        private readonly AppDbContext db;

        public InvestmentDAL(AppDbContext context)
        {
            db = context;
        }

        public IEnumerable<Investment> GetAllInvestments()
        {
            try
            {
                return db.Investment.ToList();

            }
            catch { throw; }
        }

        //Filter reports based on search string
        public IEnumerable<Investment> GetFilterInvestments(string criterion)
        {
            List<Investment> investments = new List<Investment>();
            try
            {
                investments = GetAllInvestments().ToList();
                return investments.Where(x => x.ItemName.IndexOf(criterion, StringComparison.OrdinalIgnoreCase) != -1);
            }
            catch { throw; }
        }


        //Add a new expense
        public void AddInvestment(Investment investment)
        {
            try
            {
                db.Investment.Add(investment);
                db.SaveChanges();
            }
            catch { throw; }
        }

        //Update a expense
        public int UpdateInvestment(Investment investment)
        {
            try
            {
                db.Entry(investment).State = EntityState.Modified;
                db.SaveChanges();
                return 1;
            }
            catch { throw; }
        }

        //Get a expense per id
        public Investment GetInvestment(int id)
        {
            try
            {
                Investment investment = db.Investment.Find(id);
                return investment;
            }
            catch { throw; }
        }

        //Delete a expense
        public void DeleteInvestment(int id)
        {
            try
            {
                Investment investment = db.Investment.Find(id);
                db.Investment.Remove(investment);
                db.SaveChanges();
            }
            catch { throw; }
        }

        public decimal SumInvestment(IEnumerable<Investment> investments)
        {
            decimal totalInvestments = 0;

            foreach (var item in investments)
            {
                totalInvestments += item.Value;
            }

            return totalInvestments;
        }

    }
}
