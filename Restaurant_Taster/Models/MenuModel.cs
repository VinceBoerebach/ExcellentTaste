using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Restaurant_Taster.Models
{
    public class MenuModel
    {
        public int Id { get; set; }
        public int Table { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime TimeDate { get; set; }
        public Food Food { get; set; }
        public Customer Customer { get; set; }
    }

    public class Food
    {
        public int FoodId { get; set; }
        public bool DrinkorFood { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Tax { get; set; }
        public string Category { get; set; }

    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }

    }


}

