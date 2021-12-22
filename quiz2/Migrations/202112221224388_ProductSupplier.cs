namespace quiz2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductSupplier : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(maxLength: 40),
                        ContactName = c.String(maxLength: 50),
                        ContactTitle = c.String(maxLength: 40),
                        City = c.String(maxLength: 40),
                        Country = c.String(maxLength: 40),
                        Phone = c.String(maxLength: 30),
                        Fax = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.CompanyName)
                .Index(t => t.Country);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(maxLength: 50),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Package = c.String(maxLength: 30),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.SupplierId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "SupplierId", "dbo.Suppliers");
            DropIndex("dbo.Products", new[] { "SupplierId" });
            DropIndex("dbo.Suppliers", new[] { "Country" });
            DropIndex("dbo.Suppliers", new[] { "CompanyName" });
            DropTable("dbo.Products");
            DropTable("dbo.Suppliers");
        }
    }
}
