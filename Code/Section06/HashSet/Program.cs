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
        }
    }
}
