namespace Budgetor.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Billers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BillerType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BillerTypes", t => t.BillerType_Id)
                .Index(t => t.BillerType_Id);
            
            CreateTable(
                "dbo.BillerTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DueDate = c.DateTime(nullable: false),
                        AmountDue = c.Double(nullable: false),
                        Biller_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Billers", t => t.Biller_Id)
                .Index(t => t.Biller_Id);
            
            CreateTable(
                "dbo.Deposits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                        DepositType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DepositTypes", t => t.DepositType_Id)
                .Index(t => t.DepositType_Id);
            
            CreateTable(
                "dbo.DepositTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                        TransactionType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TransactionTypes", t => t.TransactionType_Id)
                .Index(t => t.TransactionType_Id);
            
            CreateTable(
                "dbo.TransactionTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "TransactionType_Id", "dbo.TransactionTypes");
            DropForeignKey("dbo.Deposits", "DepositType_Id", "dbo.DepositTypes");
            DropForeignKey("dbo.Bills", "Biller_Id", "dbo.Billers");
            DropForeignKey("dbo.Billers", "BillerType_Id", "dbo.BillerTypes");
            DropIndex("dbo.Transactions", new[] { "TransactionType_Id" });
            DropIndex("dbo.Deposits", new[] { "DepositType_Id" });
            DropIndex("dbo.Bills", new[] { "Biller_Id" });
            DropIndex("dbo.Billers", new[] { "BillerType_Id" });
            DropTable("dbo.TransactionTypes");
            DropTable("dbo.Transactions");
            DropTable("dbo.DepositTypes");
            DropTable("dbo.Deposits");
            DropTable("dbo.Bills");
            DropTable("dbo.BillerTypes");
            DropTable("dbo.Billers");
        }
    }
}
