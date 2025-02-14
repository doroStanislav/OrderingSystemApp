using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemApp
{
    
    public class OrderManagement
    {
        private List<Cook> cooks;
        private List<Dish> menu;

        public OrderManagement() 
        {
            cooks = new List<Cook>
            { 
                new("Alessandro"),
                new("Matteo"),
                new("Lorenzo"),
                new("Giuseppe"),
                new("Fabio")
            };

            menu = new List<Dish>
            {
                new Dish("Lasagna alla Bolognese", "Classic layered meat lasagna.", new List<Ingredient>
                {
                    new Ingredient("Ground beef", "300g", 4.5m),
                    new Ingredient("Ricotta cheese", "150g", 3.0m),
                    new Ingredient("Mozzarella cheese", "200g", 4.0m),
                    new Ingredient("Parmesan cheese", "50g", 2.5m),
                    new Ingredient("Lasagna noodles", "250g", 2.0m),
                    new Ingredient("Olive oil", "2 tbsp", 0.4m),
                    new Ingredient("Garlic", "2 cloves", 0.3m),
                    new Ingredient("Onion ", "1 medium", 0.6m),
                    new Ingredient("Fresh basil", "a few leaves", 0.5m)
                }, 60),

                new Dish("Margherita Pizza", "Simple mozzarella and basil pizza.", new List<Ingredient>
                {
                    new Ingredient("Pizza dough", "250g", 2.0m),
                    new Ingredient("Tomato sauce", "100g", 1.0m),
                    new Ingredient("Fresh mozzarella cheese", "150g", 3.5m),
                    new Ingredient("Fresh basil leaves", "a handful", 0.6m),
                    new Ingredient("Olive oil", "1 tbsp", 0.2m),
                    new Ingredient("Salt", "to taste", 0.05m),
                    new Ingredient("Black pepper", "to taste", 0.05m)
                }, 15),

                new Dish("Risotto ai Funghi", "Creamy mushroom risotto.", new List<Ingredient>
                {
                    new Ingredient("Arborio rice", "200g", 2.5m),
                    new Ingredient("Mixed wild mushrooms", "200g", 5.0m),
                    new Ingredient("Parmesan cheese", "50g", 2.5m),
                    new Ingredient("White wine", "100g", 1.0m),
                    new Ingredient("Vegetable broth", "500ml", 1.0m),
                    new Ingredient("Butter ", "2 tbsp", 0.3m),
                    new Ingredient("Olive oil", "1 tbsp", 0.2m),
                    new Ingredient("Onion ", "1 medium", 0.6m),
                    new Ingredient("Fresh parsley", "for garnish", 0.3m)
                }, 30),

                new Dish("Pasta Carbonara", "Egg, cheese, and guanciale pasta.", new List<Ingredient>
                {
                    new Ingredient("Spaghetti", "200g", 1.8m),
                    new Ingredient("Guanciale", "150g", 5.0m),
                    new Ingredient("Eggs ", "2 large", 0.8m),
                    new Ingredient("Parmesan cheese", "50g", 2.5m),
                    new Ingredient("Pecorino Romano cheese", "50g", 2.5m),
                    new Ingredient("Black pepper", "to taste", 0.05m),
                    new Ingredient("Olive oil", "1 tbsp", 0.2m)
                }, 20), 

                new Dish("Tiramisu", "Coffee-flavoured creamy dessert.", new List<Ingredient>
                {
                    new Ingredient("Ladyfingers", "200g", 3.0m),
                    new Ingredient("Mascarpone cheese", "150g", 5.0m),
                    new Ingredient("Eggs ", "2 large", 0.8m),
                    new Ingredient("Sugar ", "100g", 0.5m),
                    new Ingredient("Strong coffee", "150ml", 0.8m),
                    new Ingredient("Cocoa powder", "for dusting", 0.3m),
                    new Ingredient("Dark chocolate", "for garnish", 1.0m)
                }, 20)
            };
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            foreach (var dish in menu)
            {
                Console.WriteLine($"{dish.Name}: {dish.Description}");
                Console.WriteLine($"Ingredients: {dish.GetIngredients()}");
                Console.WriteLine($"Price: {dish.Price:C}");
                Console.WriteLine($"Estimated Cooking Time: {dish.EstimatedCookingTime} minutes");
                Console.WriteLine();
            }
        }

        public void OrderDish()
        {
            var getDishName = Console.ReadLine();

            if (string.IsNullOrEmpty(getDishName))
            {
                Console.WriteLine("Please enter a valid dish name.");
                return;
            }

            var availableDish = menu.FirstOrDefault(d => d.Name.Contains(getDishName,
                StringComparison.OrdinalIgnoreCase));

            if (availableDish == null)
            {
                Console.WriteLine("Dish is not found.");
                return;
            }

            var availableCook = cooks.FirstOrDefault(c => c.CanTakeOrder());
            if (availableCook == null)
            {
                Console.WriteLine("No cooks available.");
                return;
            }

            availableCook.AddDish(availableDish);
            int estimatedFinishTime = availableCook.GetTotalCookingTime();
            Console.WriteLine($"Order assigned to: {availableCook.Name}, and will be ready in: {estimatedFinishTime} minutes.");
        }
    }
}
