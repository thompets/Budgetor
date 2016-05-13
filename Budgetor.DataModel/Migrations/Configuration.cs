namespace Budgetor.DataModel.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Linq;
    using Classes.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<Budgetor.DataModel.Data.BudgetorContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Budgetor.DataModel.Data.BudgetorContext context)
        {            
            context.BillerTypes.AddOrUpdate(bt => bt.Id,
                new BillerType() { Id = 1, Name = "Rent" },
                new BillerType() { Id = 2, Name = "Utilities" },
                new BillerType() { Id = 3, Name = "Credit Cards" },
                new BillerType() { Id = 4, Name = "Student Loans" },
                new BillerType() { Id = 5, Name = "Car Loans" },
                new BillerType() { Id = 6, Name = "Groceries" },
                new BillerType() { Id = 7, Name = "Insurance" },
                new BillerType() { Id = 8, Name = "Entertainment" },
                new BillerType() { Id = 9, Name = "Tobacco" },
                new BillerType() { Id = 10, Name = "Gas" },
                new BillerType() { Id = 11, Name = "Restaurants" },
                new BillerType() { Id = 12, Name = "Pet Supplies" },
                new BillerType() { Id = 13, Name = "Misc" }
            );

            context.DepositTypes.AddOrUpdate(dt => dt.Id,
                new DepositType() { Id = 1, Name = "P Paycheck"},
                new DepositType() { Id = 2, Name = "C Paycheck"},
                new DepositType() { Id = 3, Name = "Other"}
            );

            context.TransactionTypes.AddOrUpdate(tt => tt.Id,
                new TransactionType() { Id = 1, Name = "Bill" },
                new TransactionType() { Id = 2, Name = "Deposit" }
            );

        }
    }
}
