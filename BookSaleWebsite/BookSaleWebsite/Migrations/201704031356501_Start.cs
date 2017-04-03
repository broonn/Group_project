namespace BookSaleWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Start : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 100),
                        ConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrdersID = c.Int(nullable: false, identity: true),
                        PaymentID = c.Int(nullable: false),
                        Product_ProductID = c.Int(),
                    })
                .PrimaryKey(t => t.OrdersID)
                .ForeignKey("dbo.Products", t => t.Product_ProductID)
                .Index(t => t.Product_ProductID);
            
            CreateTable(
                "dbo.ShoppingCarts",
                c => new
                    {
                        ShoppingCartID = c.Int(nullable: false, identity: true),
                        Price = c.Double(nullable: false),
                        Quantity = c.Double(nullable: false),
                        SubTotal = c.Double(nullable: false),
                        Product_ProductID = c.Int(),
                        ProductID_ProductID = c.Int(),
                        Title_ProductID = c.Int(),
                        Orders_OrdersID = c.Int(),
                    })
                .PrimaryKey(t => t.ShoppingCartID)
                .ForeignKey("dbo.Products", t => t.Product_ProductID)
                .ForeignKey("dbo.Products", t => t.ProductID_ProductID)
                .ForeignKey("dbo.Products", t => t.Title_ProductID)
                .ForeignKey("dbo.Orders", t => t.Orders_OrdersID)
                .Index(t => t.Product_ProductID)
                .Index(t => t.ProductID_ProductID)
                .Index(t => t.Title_ProductID)
                .Index(t => t.Orders_OrdersID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Author = c.String(),
                        ISBN = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShoppingCarts", "Orders_OrdersID", "dbo.Orders");
            DropForeignKey("dbo.ShoppingCarts", "Title_ProductID", "dbo.Products");
            DropForeignKey("dbo.ShoppingCarts", "ProductID_ProductID", "dbo.Products");
            DropForeignKey("dbo.Orders", "Product_ProductID", "dbo.Products");
            DropForeignKey("dbo.ShoppingCarts", "Product_ProductID", "dbo.Products");
            DropIndex("dbo.ShoppingCarts", new[] { "Orders_OrdersID" });
            DropIndex("dbo.ShoppingCarts", new[] { "Title_ProductID" });
            DropIndex("dbo.ShoppingCarts", new[] { "ProductID_ProductID" });
            DropIndex("dbo.ShoppingCarts", new[] { "Product_ProductID" });
            DropIndex("dbo.Orders", new[] { "Product_ProductID" });
            DropTable("dbo.Products");
            DropTable("dbo.ShoppingCarts");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
        }
    }
}
