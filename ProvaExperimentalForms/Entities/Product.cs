using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaExperimentalForms.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsAvailableForSale { get; set; }

        public Product(string name, string description, double price, bool isAvailableForSale)
        {
            Name = name;
            Description = description;
            Price = price;
            IsAvailableForSale = isAvailableForSale;
        }

        public Product() { }


    }
}
