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

        public Ingredient(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }
}
