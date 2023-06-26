namespace Program
{
    internal class Application
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            // Create categories
            Category przystawki = new Category("Przystawki");
            Category glowne = new Category("Dania główne");
            Category desery = new Category("Desery");
            Category napoje = new Category("Napoje");

            // Add categories to menu
            menu.AddCategory(przystawki);
            menu.AddCategory(glowne);
            menu.AddCategory(desery);
            menu.AddCategory(napoje);

            // Add dishes to categories
            przystawki.AddDish(new Dish(1, "Salatka mango z kozim serem", 15.0));
            przystawki.AddDish(new Dish(2, "Bagietka czosnkowa", 8.0));
            glowne.AddDish(new MainDish(3, "Stek z konfiturą wiśniową", 37.0));
            glowne.AddDish(new MainDish(4, "Kurczak po toskańsku", 34.0));
            glowne.AddDish(new MainDish(5, "Łosoś z sosem koperkowym", 42.0));
            glowne.AddDish(new MainDish(6, "Wegański stroganow z kurkami", 39.0));
            desery.AddDish(new Dessert(7, "Lody pistacjowe", 6.0));
            desery.AddDish(new Dessert(8, "Sernik japoński", 11.0));
            desery.AddDish(new Dessert(9, "Wegańska pianka kakaowa", 12.0));
            napoje.AddDish(new Drinks(10, "Lemoniada arbuzowa", 7.0));
            napoje.AddDish(new Drinks(11, "Spieniona kawa karmelowa", 14.0));
            napoje.AddDish(new Drinks(12, "Herbata jaśminowa", 10.0));

            // Display menu
            Console.WriteLine("Restaurant Menu:");
            foreach (var category in menu.Categories)
            {
                Console.WriteLine("\n" + category.Name + ":");
                foreach (var dish in category.Dishes)
                {
                    Console.WriteLine("\t" + dish.ID + ". " + dish.Name + ": $" + dish.Price);
                }
            }

            // Create order
            Order order = new Order();

            Console.WriteLine("\nWybierz numer z menu lub 'q' aby zakończyć: ");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "q")
                {
                    break;
                }
                int dishNum;
                try
                {
                    dishNum = Convert.ToInt32(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nieprawidłowe dane. Wybierz numer, aby zamówić lub 'q' aby zakończyć: ");
                    continue;
                }
                int dishCount = 0;
                bool found = false;
                foreach (var category in menu.Categories)
                {
                    foreach (var dish in category.Dishes)
                    {
                        dishCount++;
                        if (dishNum == dishCount)
                        {
                            order.AddDish(dish);
                            Console.WriteLine("Dodano " + dish.Name + " do zamówienia");
                            found = true;
                            break;
                        }
                    }
                    if (found)
                    {
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Nie znaleziono takiej pozycji. Wprowadź poprawne dane lub 'q' aby zakończyć: ");
                }
            }


            // Display order
            Console.WriteLine("\nZamowienie:");
            foreach (var dish in order.Dishes)
            {
                Console.WriteLine("- " + dish.Name + ": $" + dish.Price);
            }
            Console.WriteLine("Razem: $" + order.TotalPrice);

            // Create bill
            Console.WriteLine("\nWpłata: ");
            double paidAmount = Convert.ToDouble(Console.ReadLine());
            Bill bill = new Bill(order, paidAmount);

            // Display bill
            Console.WriteLine("\nRachunek:");
            Console.WriteLine("Razem: $" + bill.TotalPrice);
            Console.WriteLine("Wpłacono: $" + bill.PaidAmount);
            Console.WriteLine("Reszta: $" + bill.Change);


            Console.ReadLine();
        }
    }
    
}