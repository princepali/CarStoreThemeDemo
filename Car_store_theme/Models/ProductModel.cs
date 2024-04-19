using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car_store_theme.Models
{
    public class ProductModel
    {
        public Guid ProductId { get; set; }

        public string ProductName { get; set; }

        public string Image { get; set; }

        public decimal Price { get; set; }

        public int Rating { get; set; }

        public string HoverImage { get; set; }

        public string IndicatorImage{ get; set; }

        public string Short_Description { get; set; } 
        
        public string Description { get; set; }
    }
}