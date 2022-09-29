using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu

{
    public enum Category { Appetizer, MainCourse, Desert }

    internal class MenuItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        // Declare a property of *type* Category, and with a *name* of Category
        public Category Category { get; set; }
        public bool IsNew { get; set; }

        public MenuItem(string name, decimal price, string desc, Category cat, bool isNew)
        {
            Name = name;
            Price = price;
            Description = desc;
            Category = cat;
            IsNew = isNew;
        }

        public override string ToString()
        {
            return Name + ". " + Description + ". Price: $" + Price + ".";
        }

        // A way to tell if a menu item is new

        // A way to determine whether or not two menu items are equal

    }
}
