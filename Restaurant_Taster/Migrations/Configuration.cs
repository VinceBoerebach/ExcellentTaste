namespace Restaurant_Taster.Migrations
{
    using Restaurant_Taster.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Restaurant_Taster.Models.ResDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Restaurant_Taster.Models.ResDBContext context)
        {
            context.MenuDB.Add(new MenuModel
            {
                Customer = new Customer
                {
                    CustomerName = "Test",
                    Email = "Test@test.test",
                    Phone = 0678255339
                },
                Food = new Food
                {
                    Category = "TestCategory",
                    Description = "Testdesc",
                    DrinkorFood = true,
                    Price = 2.50,
                    Tax = "9%"
                },
                Table = 2,
                TimeDate = new DateTime(2019,11,11)
            });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
