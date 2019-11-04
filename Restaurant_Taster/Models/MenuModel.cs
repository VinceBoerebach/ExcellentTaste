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
        public string Customer { get; set; }
        public int Table { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime TimeDate { get; set; }
    }

    public class Food : MenuModel
    {
        public int FoodId { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Tax { get; set; }
        public string Category { get; set; }

    }

    public class Customers : MenuModel
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }

    }


}

