using Budgetor.Classes;
using System.Data.Entity;

namespace Budgetor.DataModel
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
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Expensor> Expensors { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
    }
}