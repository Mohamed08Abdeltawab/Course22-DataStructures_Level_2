/*
         * DEFINITION:
         * SortedDictionary<TKey, TValue> represents a collection of key/value pairs 
         * that are sorted on the key.

// 1. TIME COMPLEXITY (Speed)
// Insertion, Deletion, and Search: O(log n)
// It is slower than Dictionary<TKey, TValue> (which is O(1)) 
// but maintains constant sorting.


// 2. ADVANTAGES (Pros)
// - Automatic sorting: Elements are always sorted by Key.
// - Efficient memory usage for large, unsorted data insertions compared to SortedList.
// - Fast search operations using Binary Search logic.
        // 3. DISADVANTAGES (Cons)
        // - Slower than Hash-based Dictionary for Lookups.
        // - Keys cannot be null.
        // - Higher overhead due to tree balancing.

*/




using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a SortedDictionary with string keys and integer values
            SortedDictionary<string, int> sortedDict = new SortedDictionary<string, int>();

            // Adding elements to the SortedDictionary
            sortedDict.Add("apple", 10);
            sortedDict.Add("banana", 20);
            sortedDict.Add("orange", 15);

            // Displaying the contents of the SortedDictionary
            Console.WriteLine("Contents of the SortedDictionary:");
            foreach (var kvp in sortedDict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Accessing values by key
            Console.WriteLine("\nAccessing values by key:");
            Console.WriteLine($"Value of 'apple': {sortedDict["apple"]}");
            Console.WriteLine($"Value of 'orange': {sortedDict["orange"]}");

            // Checking if a key exists
            Console.WriteLine("\nChecking if a key exists:");
            Console.WriteLine($"Contains 'banana': {sortedDict.ContainsKey("banana")}");
            Console.WriteLine($"Contains 'grape': {sortedDict.ContainsKey("grape")}");

            // Removing an element
            sortedDict.Remove("banana");

            // Displaying the contents after removal
            Console.WriteLine("\nContents of the SortedDictionary after removal:");
            foreach (var kvp in sortedDict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

        }

    }
}
