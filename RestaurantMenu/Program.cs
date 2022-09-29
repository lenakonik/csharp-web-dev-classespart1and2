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

            MenuItem pizza = new MenuItem("Canadian Pizza", 19.99m, "Pepperoni, bacon crumble, sliced mushrooms and pizza mozzarella", Category.MainCourse, true);
            MenuItem margarita = new MenuItem("Mango Burst", 5.99m, "Our frozen Sauza Gold margarita shaken with all-natural guava & mango flavours", Category.Desert, true);

            menu.Add(pizza);
            menu.Add(margarita);
            menu.Remove(pizza);

            menu.Write();

        }
    }
}
