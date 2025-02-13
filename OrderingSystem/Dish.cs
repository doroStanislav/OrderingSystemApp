using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    public class Dish
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public int EstimatedCookingTime { get; set; }

        public Dish(string name, string description, string price, int estimatedCookingTime)
        {
            Name = name;
            Description = description;
            Price = price;
            EstimatedCookingTime = estimatedCookingTime;
        }
    }
}
