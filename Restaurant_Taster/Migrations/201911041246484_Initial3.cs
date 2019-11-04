namespace Restaurant_Taster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MenuModels", "Customer");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MenuModels", "Customer", c => c.String());
        }
    }
}
