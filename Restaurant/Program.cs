using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem.Category newCategory = MenuItem.Category.Appetizer;
            Console.WriteLine("{0}, {0:D}", newCategory);
            Console.ReadLine();
        }
    }
}
