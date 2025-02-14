namespace OrderingSystemApp
{
    public class Cook
    {
        public string Name { get; set; }
        public List<Dish> DishesInProgress { get; set; }

        public Cook(string name)
        {
            Name = name;
            DishesInProgress = new List<Dish>();
        }

        public bool CanTakeOrder()
        {
           return DishesInProgress.Count < 5;
        }

        public void AddDish(Dish dish)
        {
            DishesInProgress.Add(dish);
        }
        public void RemoveDish(Dish dish)
        {
            DishesInProgress.Remove(dish);
        }

        public int GetTotalCookingTime()
        {
            return DishesInProgress.Sum(d => d.EstimatedCookingTime);
        }
    }
}
