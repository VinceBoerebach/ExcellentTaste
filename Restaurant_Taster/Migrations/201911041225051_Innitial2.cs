namespace Restaurant_Taster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Innitial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MenuModels", "DrinkorFood", c => c.Boolean());
            AddColumn("dbo.MenuModels", "Customers_Id", c => c.Int());
            AddColumn("dbo.MenuModels", "Food_Id", c => c.Int());
            CreateIndex("dbo.MenuModels", "Customers_Id");
            CreateIndex("dbo.MenuModels", "Food_Id");
            AddForeignKey("dbo.MenuModels", "Customers_Id", "dbo.MenuModels", "Id");
            AddForeignKey("dbo.MenuModels", "Food_Id", "dbo.MenuModels", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MenuModels", "Food_Id", "dbo.MenuModels");
            DropForeignKey("dbo.MenuModels", "Customers_Id", "dbo.MenuModels");
            DropIndex("dbo.MenuModels", new[] { "Food_Id" });
            DropIndex("dbo.MenuModels", new[] { "Customers_Id" });
            DropColumn("dbo.MenuModels", "Food_Id");
            DropColumn("dbo.MenuModels", "Customers_Id");
            DropColumn("dbo.MenuModels", "DrinkorFood");
        }
    }
}
