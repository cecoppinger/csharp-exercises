using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            string str = Console.ReadLine();

            foreach (char c in str)
            {
                if (charCount.ContainsKey(c) && char.IsLetter(c))
                    charCount[c]++;
                else if (char.IsLetter(c))
                    charCount.Add(c, 1);
            }

            foreach (KeyValuePair<char, int> c in charCount)
                Console.WriteLine(c.Key + ": " + c.Value);

            Console.Read();
        }
    }
}
