/*
 Explaination


The Dictionary in C#: A Student-Friendly Summary
1. The Core Concept (What is it?)
Imagine a real-life dictionary: you use a Word to find its Meaning. You don't read the dictionary from page 1 to 1000; you jump straight to the word you want.
In C#, a Dictionary<TKey, TValue> works exactly the same way. It is a collection that stores data in Key-Value pairs.

The Key: The unique identifier (like the Word, a Student ID, or a Phone Number).

The Value: The data associated with that key (like the Meaning, the Student's Name, or the Contact Details).


2. Golden Rules of a Dictionary

Keys MUST be unique: You cannot have two identical keys. If you try to add a duplicate key, the program will crash.

Values can be duplicated: Multiple different keys can point to the same value.

Keys cannot be null: But values can be null (if the value type allows it, like a string).


3. Common Use Cases (When should you use it?)

Fast Data Retrieval (Lookups): When you have a unique ID and need to find the related object instantly (e.g., finding a user profile using their UserID).

Caching: Storing data temporarily in memory so you don't have to fetch it from the database over and over again.

Counting Frequencies: Keeping track of how many times something happens (e.g., counting how many times each word appears in a paragraph, where the Key is the word and the Value is the count).


4. The Advantages (Pros)

Lightning Fast Performance: Finding an item by its Key is incredibly fast. In Computer Science terms, the time complexity for lookups is O(1). It doesn't matter if you have 10 items or 1,000,000 items; it finds the data in roughly the same amount of time.

Meaningful Connections: It maps related data together logically, making your code cleaner and easier to read.

Dynamic: It automatically grows in size as you add more items to it.


5. The Disadvantages (Cons)

High Memory Consumption: A Dictionary takes up more memory (RAM) compared to a simple List or Array. It has to store the keys, the values, and extra internal data (Hash Tables) to make the fast lookups work.

No Guaranteed Order: A Dictionary does not care about the order of items. If you loop through it, the items might not come out in the exact order you put them in. (If order is strictly important, a List is better).

Risk of Exceptions: If you try to access a Key that doesn't exist (e.g., patients[99]), the application will throw a KeyNotFoundException. This requires careful coding (using TryGetValue as we did in the previous code).


In Short: Use a List when you just have a collection of items and order matters. Use a Dictionary when you have pairs of connected data and you need to look up items super fast using a unique ID.
 
 
 
 */




using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Working with Hashtable in C#

            Dictionary<string, int> fruitBasket = new Dictionary<string, int>();

            //adding elements to the dictionary
            fruitBasket.Add("Apple", 10);
            fruitBasket.Add("Banana", 20);
            fruitBasket.Add("Orange", 15);
            //fruitBasket.Add("Orange", 15);run time error , must be uniqe id
            fruitBasket.Add("Grapes", 25);

            //accessing elements in the dictionary
            fruitBasket["Banana"] = 30; //update the value for Banana

            Console.WriteLine("\nDictionary contaent: ");
            foreach(KeyValuePair<string,int> item in fruitBasket)
            {
                Console.WriteLine(item.Key + " = " + item.Value);
            }

            fruitBasket.Remove("Banana");

            Console.WriteLine("\nDictionary contaent after removeing Banana: ");
            foreach (KeyValuePair<string, int> item in fruitBasket)
            {
                Console.WriteLine(item.Key + " = " + item.Value);
            }
            #endregion


            #region TryGetValue Method in C# Dictionaries

            if(fruitBasket.TryGetValue("Apple",out int appleQunatity))
            {
                Console.WriteLine($"\n\nApple Quantity: {appleQunatity}");
            }
            else
            {
                Console.WriteLine($"Apple not found in the basket");
            }

            #endregion


            #region Utilizing LINQ with Dictionaries
            Console.WriteLine("\n\nusing linq");

            var filteredFruit = fruitBasket.Where(kpv => kpv.Value > 3);
            Console.WriteLine("\n\nitem value big than 3: \n");
            foreach(var item in filteredFruit)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }

            //sort
            var sortedByQuantity = fruitBasket.OrderBy(kpv => kpv.Value);
            Console.WriteLine("\n\nsorted Fruit by value");
            foreach (var item in sortedByQuantity)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }

            //sort
            var sortedByQuantityDesc = fruitBasket.OrderByDescending(kpv => kpv.Value);
            Console.WriteLine("\n\nsorted Fruit by value Desc");
            foreach (var item in sortedByQuantityDesc)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }

            //total
            var totalQuantity = fruitBasket.Sum(kpv => kpv.Value);
            Console.WriteLine("\n\nTotal Fruit Quantity " + totalQuantity);

            #endregion

            #region Advanced LINQ Queries with Dictionaries
            Dictionary<string,string>fruitsCategory = new Dictionary<string, string>()
            {
                { "Apple", "Tree" },
                { "Banana", "Herb" },
                { "Cherry", "Tree" },
                { "Strawberry", "Bush" },
                { "Raspberry", "Bush" }
            };

            //group by category
            var groupedFruits = fruitsCategory.GroupBy(kpv => kpv.Value);
            Console.WriteLine("\n\nGrouped Fruits by Category:");
            foreach(var group in groupedFruits)
            {
                //key is not key of dictionary is key of ordering 
                Console.WriteLine($"\nCategory: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine($"Fruit: {item.Key}");//key is not of dictionary is keh of ordering
                }
            }

            var sortedFilteredFruits = fruitBasket.Where(kpv => kpv.Value > 3).OrderBy(kpv => kpv.Value)
                .Select(kpv => new { kpv.Key, kpv.Value });

            Console.WriteLine("\n\nFiltering, Sorting, and Transforming\n:");
            foreach (var fruit in sortedFilteredFruits)
            {
                Console.WriteLine($"Fruit: {fruit.Key}, Quantity: {fruit.Value}");
            }

            #endregion


            Console.WriteLine("\n\nDisplayFunction:");
            DictionaryInCSharp();
        }



        public static void DictionaryInCSharp()
        {
            // 1. Initialization
            // Creating a Dictionary to store Patient IDs (int) as Keys, and Names (string) as Values.
            Dictionary<int, string> patients = new Dictionary<int, string>()
        {
            { 1, "Ahmed Ali" },
            { 2, "Sara Mohamed" }
        };

            // 2. Adding Elements
            // Method A: Using .Add()
            // Caution: Throws an ArgumentException if the key already exists.
            patients.Add(3, "Omar Khaled");

            // Method B: Using Indexer []
            // Safe: Adds the key if it doesn't exist, or updates the value if the key already exists (Upsert).
            patients[4] = "Laila Hassan";

            // 3. Accessing Elements
            // Caution: Direct access throws a KeyNotFoundException if the key doesn't exist.
            Console.WriteLine("Patient 1: " + patients[1]);

            // 4. Safe Access (Best Practice)
            // Using TryGetValue prevents exceptions, doesn't require double-checking, and is highly optimized.
            if (patients.TryGetValue(5, out string patientName))
            {
                Console.WriteLine("Found Patient 5: " + patientName);
            }
            else
            {
                Console.WriteLine("Patient 5 does not exist in the system.");
            }

            // 5. Checking for Keys or Values
            // ContainsKey is O(1) - Very fast hash lookup.
            if (patients.ContainsKey(3))
            {
                Console.WriteLine("Key 3 exists in the dictionary.");
            }

            // ContainsValue is O(n) - Slower because it iterates through all values linearly.
            bool hasAhmed = patients.ContainsValue("Ahmed Ali");

            // 6. Updating an Element
            // Just use the indexer with the existing key to overwrite the value.
            patients[2] = "Sara Mohamed El-Sayed";

            // 7. Removing an Element
            // Returns true if successfully removed, false if the key wasn't found.
            bool isRemoved = patients.Remove(3);

            // 8. Iterating / Looping through the Dictionary
            Console.WriteLine("\n--- All Patients List ---");

            // Iterating over both Keys and Values using KeyValuePair struct.
            foreach (KeyValuePair<int, string> kvp in patients)
            {
                Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
            }

            // Iterating over Keys only.
            foreach (int id in patients.Keys)
            {
                // Execute logic using the ID
            }

            // Iterating over Values only.
            foreach (string name in patients.Values)
            {
                // Execute logic using the Name
            }

            // 9. Useful LINQ and Properties
            // Count: Gets the total number of key/value pairs contained in the Dictionary.
            int totalPatients = patients.Count;

            // Converting Dictionary Values (or Keys) to a List using LINQ.
            List<string> patientNamesList = patients.Values.ToList();

            // 10. Clearing the Dictionary
            // Removes all keys and values from the Dictionary.
            patients.Clear();
        }

    }
}
