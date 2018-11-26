using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of your circle: ");

            int r = Convert.ToInt32(Console.ReadLine());

            double area = r * r * 3.14159;

            Console.WriteLine("Area of circle with radius " + r + " is: " + area);
            Console.Read();
        }
    }
}
