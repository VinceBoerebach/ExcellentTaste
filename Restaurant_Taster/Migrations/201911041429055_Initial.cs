namespace Restaurant_Taster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        FoodId = c.Int(nullable: false, identity: true),
                        DrinkorFood = c.Boolean(nullable: false),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        Tax = c.Int(nullable: false),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.FoodId);
            
            CreateTable(
                "dbo.MenuModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Table = c.Int(nullable: false),
                        TimeDate = c.DateTime(nullable: false),
                        Customer_CustomerId = c.Int(),
                        Food_FoodId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId)
                .ForeignKey("dbo.Foods", t => t.Food_FoodId)
                .Index(t => t.Customer_CustomerId)
                .Index(t => t.Food_FoodId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MenuModels", "Food_FoodId", "dbo.Foods");
            DropForeignKey("dbo.MenuModels", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.MenuModels", new[] { "Food_FoodId" });
            DropIndex("dbo.MenuModels", new[] { "Customer_CustomerId" });
            DropTable("dbo.MenuModels");
            DropTable("dbo.Foods");
            DropTable("dbo.Customers");
        }
    }
}
