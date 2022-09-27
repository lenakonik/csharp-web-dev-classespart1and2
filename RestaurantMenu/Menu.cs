using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    internal class Menu
    {
        public List<MenuItem> Items { get; set; }
        public DateTime DateModified { get; set; }

        public Menu(List<MenuItem> items, DateTime time)
        {
            Items = items;
            DateModified = time;
        }

        public Menu(List<MenuItem> items): this(items, DateTime.Now){}
        public Menu()
        {
            Items = new List<MenuItem>();
            DateModified = DateTime.Now;
        }
    }
}
