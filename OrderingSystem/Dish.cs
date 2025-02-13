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
        public List<Ingredient> Ingredients { get; set; }
        public decimal Price { get; set; }
        public int EstimatedCookingTime { get; set; }

        public Dish(string name, string description, List<Ingredient> ingredients, int estimatedCookingTime)
        {
            Name = name;
            Description = description;
            Ingredients = ingredients;
            Price = Ingredients.Sum(i => i.Price) * 1.2m;
            EstimatedCookingTime = estimatedCookingTime;
        }

        public string GetIngredients()
        {
            return string.Join(", ", Ingredients.Select(i => i.Name));
        }
    }
}
