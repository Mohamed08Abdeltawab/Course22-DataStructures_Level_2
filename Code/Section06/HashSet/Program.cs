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

            #region Removing Elements from HashSet

            Console.WriteLine("Hashset Item Count = " + fruits2.Count.ToString());

            // Removing "Banana" from the HashSet
            fruits2.Remove("Banana");

            Console.WriteLine("\nHashset Item Count after removing Banana = " + fruits2.Count.ToString());
            // Displaying the remaining elements
            foreach (string fruit in fruits2)
            {
                Console.WriteLine(fruit);
            }

            //this will remove all elements
            fruits.Clear();
            Console.WriteLine("\nHashset Item Count after clear = " + fruits2.Count.ToString());

            #endregion

            #region  Using HashSet to Remove Duplicates
            // Array with duplicate values
            int[] array = new int[] { 1, 2, 2, 3, 4, 4, 5 };


            // Initializing a HashSet with the array
            //remove dublicates automaticly
            HashSet<int> uniqueNumbers = new HashSet<int>(array);


            // Displaying the unique elements
            foreach (int number in uniqueNumbers)
            {
                Console.WriteLine(number);
            }
            #endregion



            #region Using HashSet with LINQ Example 1
            HashSet<int> numbers= new HashSet<int>(array) { 1,2,3,4,5,6,7,8,9,10 };
            var evenNumber = numbers.Where(x => x % 2 == 0);

            Console.WriteLine("Event numbers in hashSet:\n");
            foreach(var number in evenNumber)
            {
                Console.WriteLine(number);
            }

            //greater than 5
            var GreaterThan5 = numbers.Where(x => x > 5);

            Console.WriteLine("numbers Greater than 5 in hashSet:\n");
            foreach (var number in GreaterThan5)
            {
                Console.WriteLine(number);
            }

            #endregion
        }
    }
}
