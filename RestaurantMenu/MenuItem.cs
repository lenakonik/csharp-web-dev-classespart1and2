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

    }
}
