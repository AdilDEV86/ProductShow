using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.MicroService.Models
{
    public class Product
    {
        //commentaire 10
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPreferredDrink { get; set; }
        public bool InStock2 { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
