using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Restaurant_Taster.Models
{
    public class ResDBContext : DbContext
    {
        public ResDBContext() : base("ResDBContext")
        {

        }
        public DbSet<MenuModel> MenuDB { get; set; }
        public DbSet<Food> FoodDB { get; set; }
        public DbSet<Customer> CustomersDB { get; set; }

    }
}