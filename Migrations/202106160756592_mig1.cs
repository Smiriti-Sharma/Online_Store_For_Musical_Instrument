namespace Online_Store_For_Musical_Instrument.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Price = c.Double(),
                        Brand = c.String(),
                        ProductDescription = c.String(),
                        QuantityOnHand = c.Int(),
                        ProductImage = c.String(),
                        CategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.DeliveryAddresses",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        PinCode = c.Int(nullable: false),
                        CustomerID = c.Int(),
                    })
                .PrimaryKey(t => t.AddressID)
                .ForeignKey("dbo.Users", t => t.CustomerID)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        ProductID = c.Int(),
                        OrderMasterID = c.Int(nullable: false),
                        DeliveryAddress_AddressID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.OrderMasters", t => t.OrderID)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .ForeignKey("dbo.DeliveryAddresses", t => t.DeliveryAddress_AddressID)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID)
                .Index(t => t.DeliveryAddress_AddressID);
            
            CreateTable(
                "dbo.OrderMasters",
                c => new
                    {
                        OrderMasterID = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        OrderStatus = c.String(),
                        PaymentMode = c.String(),
                        TotalAmount = c.Int(nullable: false),
                        PaymentStatus = c.String(),
                        DeliveryStatus = c.String(),
                        OrderType = c.String(),
                        ProductID = c.Int(),
                        CustomerID = c.Int(),
                        AddressID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderMasterID)
                .ForeignKey("dbo.DeliveryAddresses", t => t.AddressID)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .ForeignKey("dbo.Users", t => t.CustomerID)
                .Index(t => t.ProductID)
                .Index(t => t.CustomerID)
                .Index(t => t.AddressID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        MobileNumber = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DeliveryAddresses", "CustomerID", "dbo.Users");
            DropForeignKey("dbo.Orders", "DeliveryAddress_AddressID", "dbo.DeliveryAddresses");
            DropForeignKey("dbo.Orders", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Orders", "OrderID", "dbo.OrderMasters");
            DropForeignKey("dbo.OrderMasters", "CustomerID", "dbo.Users");
            DropForeignKey("dbo.OrderMasters", "ProductID", "dbo.Products");
            DropForeignKey("dbo.OrderMasters", "AddressID", "dbo.DeliveryAddresses");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.OrderMasters", new[] { "AddressID" });
            DropIndex("dbo.OrderMasters", new[] { "CustomerID" });
            DropIndex("dbo.OrderMasters", new[] { "ProductID" });
            DropIndex("dbo.Orders", new[] { "DeliveryAddress_AddressID" });
            DropIndex("dbo.Orders", new[] { "ProductID" });
            DropIndex("dbo.Orders", new[] { "OrderID" });
            DropIndex("dbo.DeliveryAddresses", new[] { "CustomerID" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.Users");
            DropTable("dbo.OrderMasters");
            DropTable("dbo.Orders");
            DropTable("dbo.DeliveryAddresses");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
            DropTable("dbo.Admins");
        }
    }
}
