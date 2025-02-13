using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    
    public class OrderManagement
    {
        private List<Cook> cooks;
        private List<Dish> menu;

        public OrderManagement() 
        {
            cooks = new List<Cook>
            {
                new Cook("Alessandro"),
                new Cook("Matteo"),
                new Cook("Lorenzo"),
                new Cook("Giuseppe"),
                new Cook("Fabio")
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
                }, 60)
            };
        }

    }
}
