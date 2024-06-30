using MyFinances.Models;
using System.Collections.Generic;

namespace MyFinances.DAL
{
    public interface IInvestmentDAL
    {
        IEnumerable<Investment> GetAllInvestments();
        IEnumerable<Investment> GetFilterInvestments(string criterion);
        void AddInvestment(Investment Investment);
        int UpdateInvestment(Investment Investment);
        Investment GetInvestment(int id);
        void DeleteInvestment(int id);

    }
}
