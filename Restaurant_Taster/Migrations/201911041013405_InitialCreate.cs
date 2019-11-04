namespace Restaurant_Taster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MenuModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Customer = c.String(),
                        Table = c.Int(nullable: false),
                        TimeDate = c.DateTime(nullable: false),
                        CustomerId = c.Int(),
                        CustomerName = c.String(),
                        Phone = c.Int(),
                        Email = c.String(),
                        FoodId = c.Int(),
                        Description = c.String(),
                        Price = c.Double(),
                        Tax = c.String(),
                        Category = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MenuModels");
        }
    }
}
