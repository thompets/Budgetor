namespace Budgetor.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedfields : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Bills", "DueDate");
            DropColumn("dbo.Bills", "AmountDue");
            DropColumn("dbo.Deposits", "Amount");
            DropColumn("dbo.Deposits", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Deposits", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Deposits", "Amount", c => c.Double(nullable: false));
            AddColumn("dbo.Bills", "AmountDue", c => c.Double(nullable: false));
            AddColumn("dbo.Bills", "DueDate", c => c.DateTime(nullable: false));
        }
    }
}
