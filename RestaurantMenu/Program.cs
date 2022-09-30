using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;

namespace RestaurantMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            MenuItem pizza = new MenuItem("Canadian Pizza", 19.99m, "Pepperoni, bacon crumble, sliced mushrooms and pizza mozzarella", Category.MainCourse);
            MenuItem margarita = new MenuItem("Mango Burst", 5.99m, "Our frozen Sauza Gold margarita shaken with all-natural guava & mango flavours", Category.Desert);

            menu.Add(pizza);
            menu.Add(margarita);

            bool another = true;
            while (another)
            {
                Console.WriteLine("Menu item name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Menu item description: ");
                string description = Console.ReadLine();

                Console.WriteLine("Menu item price: ");
                string input = Console.ReadLine();
                decimal price = decimal.Parse(input);

                Console.WriteLine("Menu item category: Appetizer, MainCourse, Desert");
                input = Console.ReadLine();
                Category cat = (Category)Enum.Parse(typeof(Category), input, true);

                MenuItem i = new MenuItem(name, price, description, Category.MainCourse);
                // if we were able to add item, print it
                if (menu.Add(i))
                {
                    Console.WriteLine("Item is added to the menu.");
                }
                Console.WriteLine("Do you want to add another item? y n");
                input = Console.ReadLine();
                another = (input.Equals("y")) ? true : false;

            }

            menu.Write();
            Console.WriteLine(pizza.DateModified.ToString());
            Console.WriteLine(pizza.IsNew());

        }
    }
}
