using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace restruent2.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; } // e.g., Starter, Main, Dessert
        public string ImageUrl { get; set; } // new field for image
    }


}
