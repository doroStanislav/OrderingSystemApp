using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    public class Ingredient
    {   
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Quantity { get; set; }

        public Ingredient(string name, string quantity, decimal price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

    }
}
