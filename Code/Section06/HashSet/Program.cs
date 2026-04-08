/*
================================================================================
THE C# HASHSET<T>: A CS STUDENT'S CHEAT SHEET
================================================================================

1. THE CORE CONCEPT:
A HashSet<T> is a strongly typed collection designed to store UNIQUE elements. 
It is based on the mathematical concept of a "Set". It uses a hash table behind 
the scenes, but unlike a Dictionary (which stores Key-Value pairs), a HashSet 
only stores the Keys (the values themselves act as the keys). 

2. THE ADVANTAGES (PROS):
- Guaranteed Uniqueness: It automatically prevents duplicate entries. If you try 
  to add an item that already exists, it simply ignores it without crashing.
- Blazing Fast Lookups: Checking if an item exists using .Contains() is extremely 
  fast (O(1) time complexity), making it much faster than a List<T> for searching.
- Powerful Math Operations: It has built-in methods for advanced set operations 
  like Union (combining), Intersection (finding commonalities), and Difference.

3. THE DISADVANTAGES (CONS):
- No Indexing: You cannot access elements by their position. You cannot do 
  myHashSet[0] because a HashSet does not maintain any specific order.
- Unpredictable Order: When you loop through a HashSet, the items might not 
  appear in the order you added them. 
- Higher Memory Usage: Like a Dictionary, it consumes more memory than a standard 
  List because of the internal hash table structure required for fast lookups.

When to use it? 
Use a HashSet when you need to maintain a collection of unique items (like tracking 
which IDs have been processed), when you need to quickly remove duplicates from a List, 
or when you need to perform mathematical set operations.
================================================================================
*/








using System;
using System.Collections.Generic;
using System.IO;
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


            #region Using LINQ with HashSet Example 2
            // Creating and populating a HashSet of strings
            HashSet<string> names = new HashSet<string> { "Alice", "Bob", "Charlie", "Daisy", "Ethan", "Fiona" };

            var startWtihC = names.Where(name => name.StartsWith("C"));
            Console.WriteLine("\n\names that start with 'C'");
            foreach(var name in startWtihC)
            {
                Console.WriteLine(name);
            }

            var longThan4 = names.Where(name => name.Length > 4);
            Console.WriteLine("\n\nnames that long than 4:");
            foreach (var name in longThan4)
            {
                Console.WriteLine(name);
            }

            #endregion

            Console.WriteLine("\n\nUse Function of HashSet Explaination:");
            HashSetInCSharp();
        }


        public static void HashSetInCSharp()
        {
            // 1. Initialization
            // Creating a HashSet to track unique Patient IDs currently in the clinic.
            HashSet<int> activePatientIds = new HashSet<int>();

            // 2. Adding Elements
            // Add() returns 'true' if the item was added, and 'false' if it was already there.
            bool addedFirst = activePatientIds.Add(101);  // Returns true
            activePatientIds.Add(102);
            activePatientIds.Add(103);

            bool addedDuplicate = activePatientIds.Add(101); // Returns false, safely ignored! dont't crash or throw an error.

            // 3. Checking for Elements (The main superpower of HashSet)
            // Contains() is incredibly fast (O(1)).
            if (activePatientIds.Contains(102))
            {
                Console.WriteLine("Patient 102 is currently in the clinic.");
            }

            // 4. Removing Elements
            // Remove() returns true if the item was found and removed.
            activePatientIds.Remove(103);

            // =====================================================================
            // 5. ADVANCED SET OPERATIONS (MATHEMATICAL)
            // =====================================================================

            HashSet<int> morningShiftPatients = new HashSet<int> { 101, 102, 104, 105 };
            HashSet<int> eveningShiftPatients = new HashSet<int> { 104, 105, 106, 107 };

            Console.WriteLine("\n--- Set Operations ---");

            // A. IntersectWith (Find Common Elements)
            // Modifies the first set to only keep elements that exist in BOTH sets.
            HashSet<int> overlappingPatients = new HashSet<int>(morningShiftPatients);
            overlappingPatients.IntersectWith(eveningShiftPatients);
            Console.WriteLine($"Patients in BOTH shifts: {string.Join(", ", overlappingPatients)}");
            // Output: 104, 105

            // B. UnionWith (Combine Sets without duplicates)
            // Modifies the first set to contain all unique elements from both sets.
            HashSet<int> allDailyPatients = new HashSet<int>(morningShiftPatients);
            allDailyPatients.UnionWith(eveningShiftPatients);
            Console.WriteLine($"ALL unique patients today: {string.Join(", ", allDailyPatients)}");
            // Output: 101, 102, 104, 105, 106, 107

            // C. ExceptWith (Find Differences)
            // Removes all elements from the first set that are present in the second set.
            HashSet<int> morningOnlyPatients = new HashSet<int>(morningShiftPatients);
            morningOnlyPatients.ExceptWith(eveningShiftPatients);
            Console.WriteLine($"Patients ONLY in morning shift: {string.Join(", ", morningOnlyPatients)}");
            // Output: 101, 102

            // D. SymmetricExceptWith (Exclusive OR)
            // Keeps elements that are in ONE of the sets, but NOT in both.
            HashSet<int> singleShiftPatients = new HashSet<int>(morningShiftPatients);
            singleShiftPatients.SymmetricExceptWith(eveningShiftPatients);
            Console.WriteLine($"Patients in exactly ONE shift: {string.Join(", ", singleShiftPatients)}");
            // Output: 101, 102, 106, 107

            // 6. Iterating through a HashSet
            Console.WriteLine("\n--- Active Patients List ---");
            // We use foreach because there is no index (like a for-loop requires).
            foreach (int patientId in activePatientIds)
            {
                Console.WriteLine($"Processing Patient ID: {patientId}");
            }

            // 7. Converting to and from Lists (Very Common Trick)
            // Let's say you have a List with duplicates:
            List<string> rawData = new List<string> { "Apple", "Banana", "Apple", "Cherry" };

            // Pass the List into the HashSet constructor to instantly remove duplicates!
            HashSet<string> uniqueData = new HashSet<string>(rawData);

            // Convert back to a List if you need indexing again:
            List<string> cleanList = uniqueData.ToList();

            // 8. Cleanup
            activePatientIds.Clear(); // Empties the set
        }
    }
}
