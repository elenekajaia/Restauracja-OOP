using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program;

namespace Program
{
    public class Dish
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Dish(int id, string name, double price)
        {   
            ID = id;
            Name = name;
            Price = price;
        }
    }

    public class MainDish : Dish
    {
        public MainDish(int id, string name, double price) : base(id, name, price) { }
    }

    class Dessert : Dish
    {
        public Dessert(int id, string name, double price) : base(id, name, price) { }
    }
    class Drinks : Dish
    {
        public Drinks(int id, string name, double price) : base(id, name, price) { }
    }
}
