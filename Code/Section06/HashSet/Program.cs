using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Working with Hashset

            HashSet<string>fruits = new HashSet<string>();

            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Orange");

            //trying to add duplicate item
            bool added = fruits.Add("Apple");
            Console.WriteLine("Added duplicate item: " + added); // Output: Added duplicate item: False

            Console.WriteLine("All Fruits");
            foreach(var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            #endregion

            #region Checking for Existence in HashSet
            HashSet<string> fruits2 = new HashSet<string>() {"Apple", "Banana", "Cherry" };
            if (fruits2.Contains("Apple"))
            {
                Console.WriteLine("Apple is in HashSet");
            }
            else
            {
                Console.WriteLine("Apple is not in HashSet");
            }
            if (fruits2.Contains("Watermelon"))
            {
                Console.WriteLine("Watermelon is in HashSet");
            }
            else
            {
                Console.WriteLine("Watermelon is not in HashSet");
            }
            #endregion
        }
    }
}
