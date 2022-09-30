using System;
using System.Collections;
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
        public DateTime DateModified { get; set; }

        public MenuItem(string name, decimal price, string desc, Category cat)
        {
            Name = name;
            Price = price;
            Description = desc;
            Category = cat;
            DateModified = DateTime.Today;
        }

        public override string ToString()
        {
            return Name + ". " + Description + ". Price: $" + Price + ".";
        }

        // A way to tell if a menu item is new - if added more than a week ago it is not new anymore
        public bool IsNew()
        {
            DateTime end = DateModified.AddDays(7);
            return end >= DateTime.Today;  
        }

        // A way to determine whether or not two menu items are equal
        public override bool Equals(object obj)
        {
            return obj is MenuItem item &&
                   Name == item.Name &&
                   Price == item.Price &&
                   Description == item.Description &&
                   Category == item.Category;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price, Description, Category);
        }
    }
}
