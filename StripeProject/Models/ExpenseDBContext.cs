using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StripeProject.Models
{
    public class ExpenseDBContext : DbContext
    {
        public virtual DbSet<ExpenseReport> ExpenseReport { get; set; }

      //  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      //  {
        //    if (!optionsBuilder.IsConfigured)
        //    {
         //       //warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
         //       optionsBuilder.UseSqlServer("");
         //   }
       // }
    }
}
