using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class MenuItem
    {
        public double Price { get; set; }
        public string Description { get; set; }
        readonly DateTime dateAdded;
        private bool isNew;
        public enum Category { Other, Appetizer, MainCourse, Dessert };
    }
}
