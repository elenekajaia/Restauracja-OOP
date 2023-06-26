using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Category
    {
        public string Name { get; set; }
        public List<Dish> Dishes { get; set; }

        public Category(string name)
        {
            Name = name;
            Dishes = new List<Dish>();
        }

        // Add a dish to the category
        public void AddDish(Dish dish)
        {
            Dishes.Add(dish);
        }

        // Remove a dish from the category
        public void RemoveDish(Dish dish)
        {
            Dishes.Remove(dish);
        }
    }
}
