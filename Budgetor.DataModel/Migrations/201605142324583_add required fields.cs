namespace Budgetor.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addrequiredfields : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Billers", "BillerType_Id", "dbo.BillerTypes");
            DropForeignKey("dbo.Bills", "Biller_Id", "dbo.Billers");
            DropForeignKey("dbo.Deposits", "DepositType_Id", "dbo.DepositTypes");
            DropForeignKey("dbo.Expenses", "Expensor_Id", "dbo.Expensors");
            DropForeignKey("dbo.Expensors", "ExpenseType_Id", "dbo.ExpenseTypes");
            DropForeignKey("dbo.Transactions", "TransactionType_Id", "dbo.TransactionTypes");
            DropIndex("dbo.Billers", new[] { "BillerType_Id" });
            DropIndex("dbo.Bills", new[] { "Biller_Id" });
            DropIndex("dbo.Deposits", new[] { "DepositType_Id" });
            DropIndex("dbo.Expenses", new[] { "Expensor_Id" });
            DropIndex("dbo.Expensors", new[] { "ExpenseType_Id" });
            DropIndex("dbo.Transactions", new[] { "TransactionType_Id" });
            AlterColumn("dbo.Billers", "BillerType_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Bills", "Biller_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Deposits", "DepositType_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Expenses", "Expensor_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Expensors", "ExpenseType_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Transactions", "TransactionType_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Billers", "BillerType_Id");
            CreateIndex("dbo.Bills", "Biller_Id");
            CreateIndex("dbo.Deposits", "DepositType_Id");
            CreateIndex("dbo.Expenses", "Expensor_Id");
            CreateIndex("dbo.Expensors", "ExpenseType_Id");
            CreateIndex("dbo.Transactions", "TransactionType_Id");
            AddForeignKey("dbo.Billers", "BillerType_Id", "dbo.BillerTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Bills", "Biller_Id", "dbo.Billers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Deposits", "DepositType_Id", "dbo.DepositTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Expenses", "Expensor_Id", "dbo.Expensors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Expensors", "ExpenseType_Id", "dbo.ExpenseTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Transactions", "TransactionType_Id", "dbo.TransactionTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "TransactionType_Id", "dbo.TransactionTypes");
            DropForeignKey("dbo.Expensors", "ExpenseType_Id", "dbo.ExpenseTypes");
            DropForeignKey("dbo.Expenses", "Expensor_Id", "dbo.Expensors");
            DropForeignKey("dbo.Deposits", "DepositType_Id", "dbo.DepositTypes");
            DropForeignKey("dbo.Bills", "Biller_Id", "dbo.Billers");
            DropForeignKey("dbo.Billers", "BillerType_Id", "dbo.BillerTypes");
            DropIndex("dbo.Transactions", new[] { "TransactionType_Id" });
            DropIndex("dbo.Expensors", new[] { "ExpenseType_Id" });
            DropIndex("dbo.Expenses", new[] { "Expensor_Id" });
            DropIndex("dbo.Deposits", new[] { "DepositType_Id" });
            DropIndex("dbo.Bills", new[] { "Biller_Id" });
            DropIndex("dbo.Billers", new[] { "BillerType_Id" });
            AlterColumn("dbo.Transactions", "TransactionType_Id", c => c.Int());
            AlterColumn("dbo.Expensors", "ExpenseType_Id", c => c.Int());
            AlterColumn("dbo.Expenses", "Expensor_Id", c => c.Int());
            AlterColumn("dbo.Deposits", "DepositType_Id", c => c.Int());
            AlterColumn("dbo.Bills", "Biller_Id", c => c.Int());
            AlterColumn("dbo.Billers", "BillerType_Id", c => c.Int());
            CreateIndex("dbo.Transactions", "TransactionType_Id");
            CreateIndex("dbo.Expensors", "ExpenseType_Id");
            CreateIndex("dbo.Expenses", "Expensor_Id");
            CreateIndex("dbo.Deposits", "DepositType_Id");
            CreateIndex("dbo.Bills", "Biller_Id");
            CreateIndex("dbo.Billers", "BillerType_Id");
            AddForeignKey("dbo.Transactions", "TransactionType_Id", "dbo.TransactionTypes", "Id");
            AddForeignKey("dbo.Expensors", "ExpenseType_Id", "dbo.ExpenseTypes", "Id");
            AddForeignKey("dbo.Expenses", "Expensor_Id", "dbo.Expensors", "Id");
            AddForeignKey("dbo.Deposits", "DepositType_Id", "dbo.DepositTypes", "Id");
            AddForeignKey("dbo.Bills", "Biller_Id", "dbo.Billers", "Id");
            AddForeignKey("dbo.Billers", "BillerType_Id", "dbo.BillerTypes", "Id");
        }
    }
}
