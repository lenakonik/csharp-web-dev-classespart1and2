using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace RestaurantMenu
{
    internal class Menu
    {
        public List<MenuItem> Items { get; set; }
        // A way to tell when the menu was last updated
        public DateTime DateModified { get; set; }

        public Menu(DateTime time)
        {
            Items = new List<MenuItem>();
            DateModified = time;
        }

        public Menu(): this(DateTime.Today){}


        // A way to add and remove menu items from the menu
        public void Add(MenuItem i)
        {
            Items.Add(i);
        }

        public void Remove(MenuItem i)
        {
            string itemName = i.Name;
            Items.RemoveAll(i => i.Name == itemName);
        }

        // A way to print out both a single menu item as well as the entire menu
        public void Write()
        {
            foreach (MenuItem i in Items)
            {
                Console.WriteLine(i);
            }

        }


    }
}
