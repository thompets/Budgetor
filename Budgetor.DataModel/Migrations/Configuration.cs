namespace Budgetor.DataModel.Migrations
{
    using System.Data.Entity.Migrations;
    using Classes;

    internal sealed class Configuration : DbMigrationsConfiguration<Budgetor.DataModel.BudgetorContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Budgetor.DataModel.BudgetorContext context)
        {
            context.BillerTypes.AddOrUpdate(bt => bt.Id,
                new BillerType() { Id = 1, Name = "Rent" },
                new BillerType() { Id = 2, Name = "Utilities" },
                new BillerType() { Id = 3, Name = "Credit Cards" },
                new BillerType() { Id = 4, Name = "Student Loans" },
                new BillerType() { Id = 5, Name = "Car Loans" },
                new BillerType() { Id = 6, Name = "Insurance" }
            );

            context.DepositTypes.AddOrUpdate(dt => dt.Id,
                new DepositType() { Id = 1, Name = "P Paycheck" },
                new DepositType() { Id = 2, Name = "C Paycheck" },
                new DepositType() { Id = 3, Name = "Other" }
            );

            context.ExpenseTypes.AddOrUpdate(e => e.Id,
                new ExpenseType() { Id = 1, Name = "Groceries" },
                new ExpenseType() { Id = 2, Name = "Tobacco" },
                new ExpenseType() { Id = 3, Name = "Gas" },
                new ExpenseType() { Id = 4, Name = "Restaurants" },
                new ExpenseType() { Id = 5, Name = "Pet Supplies" },
                new ExpenseType() { Id = 6, Name = "Misc" },
                new ExpenseType() { Id = 7, Name = "Entertainment" }
            );

            context.TransactionTypes.AddOrUpdate(tt => tt.Id,
                new TransactionType() { Id = 1, Name = "Bill" },
                new TransactionType() { Id = 2, Name = "Deposit" },
                new TransactionType() { Id = 3, Name = "Expense" }
            );

        }
    }
}
