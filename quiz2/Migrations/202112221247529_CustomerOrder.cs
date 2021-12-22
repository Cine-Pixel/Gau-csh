namespace quiz2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerOrder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 40),
                        LastName = c.String(maxLength: 40),
                        City = c.String(maxLength: 40),
                        Country = c.String(maxLength: 40),
                        Phone = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        OrderNumber = c.String(maxLength: 10),
                        TotalAmount = c.Decimal(nullable: false, precision: 12, scale: 2),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.OrderDate)
                .Index(t => t.TotalAmount)
                .Index(t => t.CustomerId);
            
            AlterColumn("dbo.Products", "UnitPrice", c => c.Decimal(nullable: false, precision: 12, scale: 2));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.Orders", new[] { "TotalAmount" });
            DropIndex("dbo.Orders", new[] { "OrderDate" });
            AlterColumn("dbo.Products", "UnitPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
        }
    }
}
