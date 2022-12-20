# Restauracja-OOP
Szkielet restauracji w C# OOP w języku angielskim.
wymagania: 

1.	System powinien posiadać obiekty podstawowe: 
•	Danie (charakteryzuje pojedyncze danie w restauracji)
•	Kategoria (przechowuje dania z określonej kategorii, np. przystawki, zupy, dania główne, desery, itp.), 
•	Menu (przechowuje menu restauracji z podziałem na kategorie)
•	Zamówienie (opisuje pojedyncze zamówienie użytkownika)
•	Rachunek (opisuje rachunek za zamówienie: faktura lub paragon)
•	Aplikacja (główny obiekt zapewniający interakcję z użytkownikiem)
2.	Dziedziczenie: zaprojektować obiekty potomne od obiektu typu Danie będące typami dań, np. DanieRybne, DanieVege, DanieMięsne, itp. Można też zaprojektować obiekty potomne Faktura i Paragon od obiektu Rachunek.
3.	Umożliwić podstawowe operacje na Daniach, Kategoriach, Menu, Zamówieniach i Rachunkach. Do podstawowych operacji zaliczamy:
a.	Dodawanie obiektu/kolekcji obiektów
b.	Usuwanie obiektu/kolekcji obiektów
c.	Wyświetlanie obiektu/kolekcji obiektów
d.	Wyszukiwanie/Filtrowanie obiektu/kolekcji obiektów
4.	Funkcje dodatkowe programu (na ocenę powyżej 4.0)
a.	Zaprojektować i zaimplementować interfejsy. Całość systemu oprzeć na interfejsach
b.	Wykonać zapis i odczyt do pliku/plików (utrwalanie danych)
c.	Wykorzystać mechanizmy „Dependency Injection”, np. Singleton, Fabryka, Dekorator (np. dekoratory przy wprowadzeniu operatorów and/or przy wyszukiwaniu)


wymagania w j. angielskim:
1. The system should have basic objects:
• Dish (characterizes a single dish in a restaurant)
• Category (stores dishes from a specific category, e.g. starters, soups, main dishes, desserts, etc.),
• Menu (stores the restaurant menu divided into categories)
• Order (describes a single user order)
• Bill (describes the bill for the order: invoice or receipt)
• Application (the main object providing interaction with the user)
2. Inheritance: design child objects from the Dish type object that are types of dishes, e.g. Vegan Dishes, Meat Based Dishes, 
3. Enable basic operations on Dishes, Categories, Menus, Orders and Bills. The basic operations include:
- Adding an object/collection of objects
- Deleting an object/collection of objects
- Displaying an object/collection of objects
- Searching/Filtering an object/collection of objects
4. Additional functions of the program:
- Design and implement interfaces. The whole system is based on interfaces
- Write and read to file/files (data saving)
- Use "Dependency Injection" mechanisms, e.g. Singleton, Factory, Decorator (e.g. decorators when entering and/or operators when searching)


plan:
Dish: This object could have the following attributes:
name: a string representing the name of the dish
price: a float representing the price of the dish
description: a string describing the dish
image: a string representing the file path of an image of the dish (optional)
It could also have the following methods:
get_name(): returns the name of the dish
get_price(): returns the price of the dish
get_description(): returns the description of the dish
get_image(): returns the file path of the image of the dish (if it exists)
Category: This object could have the following attributes:
name: a string representing the name of the category
dishes: a list of Dish objects representing the dishes in the category
It could also have the following methods:
get_name(): returns the name of the category
get_dishes(): returns the list of dishes in the category
add_dish(dish): adds a Dish object to the list of dishes in the category
remove_dish(dish): removes a Dish object from the list of dishes in the category
Menu: This object could have the following attributes:
categories: a list of Category objects representing the categories in the menu
It could also have the following methods:
get_categories(): returns the list of categories in the menu
add_category(category): adds a Category object to the list of categories in the menu
remove_category(category): removes a Category object from the list of categories in the menu
Order: This object could have the following attributes:
dishes: a list of Dish objects representing the dishes in the order
total_price: a float representing the total price of the order
It could also have the following methods:
get_dishes(): returns the list of dishes in the order
get_total_price(): returns the total price of the order
add_dish(dish): adds a Dish object to the list of dishes in the order and updates the total price
remove_dish(dish): removes a Dish object from the list of dishes in the order and updates the total price
Bill: This object could have the following attributes:
order: an Order object representing the order for which the bill is being generated
date: a string representing the date when the bill was generated
type: a string representing the type of the bill (invoice or receipt)
It could also have the following methods:
get_order(): returns the Order object for which the bill is being generated
get_date(): returns the date when the bill was generated
get_type(): returns the type of the bill (invoice or receipt)
here is the remainder of the description for the Application object:
This object could have the following attributes:
menu: a Menu object representing the menu of the restaurant
orders: a list of Order objects representing the orders placed by customers
bills: a list of Bill objects representing the bills generated for orders
It could also have the following methods:
get_menu(): returns the Menu object representing the menu of the restaurant
get_orders(): returns the list of Order objects representing the orders placed by customers
get_bills(): returns the list of Bill objects representing the bills generated for orders
place_order(order): adds an Order object to the list of orders and generates a Bill object for the order
cancel_order(order): removes an Order object from the list of orders and removes the corresponding Bill object (if it exists)
add_dish_to_menu(dish, category): adds a Dish object to the specified Category object in the menu
remove_dish_from_menu(dish, category): removes a Dish object from the specified Category object in the menu
