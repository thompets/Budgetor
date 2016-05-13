using Budgetor.Classes.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Budgetor.DataModel.Data
{
    public class BudgetorContext : DbContext
    {
        public BudgetorContext() 
            : base("DefaultConnection")
        {

        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Biller> Billers { get; set; }
        public DbSet<BillerType> BillerTypes { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<DepositType> DepositTypes { get; set; }
    }
}