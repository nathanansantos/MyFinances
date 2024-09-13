using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyFinances.Models
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<ExpenseReport> ExpenseReport { get; set; }
        public virtual DbSet<Investment> Investment { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
