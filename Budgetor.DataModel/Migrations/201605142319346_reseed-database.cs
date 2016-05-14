namespace Budgetor.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reseeddatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Expensor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Expensors", t => t.Expensor_Id)
                .Index(t => t.Expensor_Id);
            
            CreateTable(
                "dbo.Expensors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ExpenseType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExpenseTypes", t => t.ExpenseType_Id)
                .Index(t => t.ExpenseType_Id);
            
            CreateTable(
                "dbo.ExpenseTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Transactions", "AmountSpent", c => c.Double(nullable: false));
            DropColumn("dbo.Transactions", "Amount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "Amount", c => c.Double(nullable: false));
            DropForeignKey("dbo.Expenses", "Expensor_Id", "dbo.Expensors");
            DropForeignKey("dbo.Expensors", "ExpenseType_Id", "dbo.ExpenseTypes");
            DropIndex("dbo.Expensors", new[] { "ExpenseType_Id" });
            DropIndex("dbo.Expenses", new[] { "Expensor_Id" });
            DropColumn("dbo.Transactions", "AmountSpent");
            DropTable("dbo.ExpenseTypes");
            DropTable("dbo.Expensors");
            DropTable("dbo.Expenses");
        }
    }
}
