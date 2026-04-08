/*
================================================================================
THE C# HASHTABLE: A CS STUDENT'S CHEAT SHEET
================================================================================

1. THE CORE CONCEPT:
A Hashtable is a non-generic collection that stores data in Key-Value pairs. 
It uses a mathematical concept called a "Hash Function" to compute an index 
based on the Key, allowing for incredibly fast data retrieval. Because it 
belongs to the older `System.Collections` namespace, both Keys and Values 
are stored as plain `object` types.

2. THE ADVANTAGES (PROS):
- Fast Lookups: The average time complexity for searching, adding, and removing is O(1).
- Mixed Data Types: Because it stores everything as an `object`, you can mix 
  completely different types of keys and values in the exact same Hashtable 
  (e.g., Key: int, Value: string alongside Key: string, Value: double).
- Dynamic Resizing: It automatically grows in capacity as you add more elements.

3. THE DISADVANTAGES (CONS):
- Lack of Type Safety: Since everything is an `object`, the compiler won't catch 
  type mismatches. This can lead to unexpected `InvalidCastException` runtime errors.
- Performance Overhead (Boxing/Unboxing): If you use value types (like `int` or `bool`), 
  the system must convert them to `object` (Boxing) and back (Unboxing). This consumes 
  extra CPU and memory compared to generic collections.
- Legacy Status: In modern C#, `Hashtable` is mostly considered obsolete. It is highly 
  recommended to use the generic `Dictionary<TKey, TValue>` instead for better 
  performance, safety, and cleaner code.

When to use it? 
Very rarely in modern applications. You might encounter it in older legacy codebases 
(.NET Framework 1.0/1.1) or in highly specific edge cases where you absolutely 
need a collection that holds completely disparate, unpredictable data types.
================================================================================
*/








using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Initialization
        Hashtable myHashtable = new Hashtable();
        myHashtable.Add("key1", "value1");
        myHashtable.Add("key2", "value2");
        myHashtable.Add("key3", "value3");


        // Accessing an element
        Console.WriteLine($"Accessing key1: {myHashtable["key1"]}");

        // Modifying an element
        myHashtable["key1"] = "newValue1";

        // Removing an element
        myHashtable.Remove("key2");

        // Iterating over elements
        Console.WriteLine("\nCurrent Hashtable contents:");
        foreach (DictionaryEntry entry in myHashtable)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
        Console.ReadKey();

        Console.WriteLine("\n\nFunction of Explanation of Hashtable in C#");
        HashTableInCSharp();

    }

    public static void HashTableInCSharp()
    {
        // 1. Initialization
        // Creating a new Hashtable (no need to specify data types)
        Hashtable studentInfo = new Hashtable();

        // 2. Adding Elements
        // Using the .Add(key, value) method
        // Notice how we can mix strings, integers, and booleans!
        studentInfo.Add("StudentID", 10052);    // Key: string, Value: int
        studentInfo.Add("Name", "Mohamed");     // Key: string, Value: string
        studentInfo.Add("IsActive", true);      // Key: string, Value: bool
        studentInfo.Add(1, "First Place");      // Key: int,    Value: string 

        // 3. Accessing Elements
        // We use the indexer [] with the key. 
        // CAUTION: Because it returns an `object`, you usually have to cast it back to its original type.
        string name = (string)studentInfo["Name"];
        Console.WriteLine("Student Name: " + name);

        // Safe Access Difference: If a key doesn't exist in a Hashtable, it returns `null` 
        // (Unlike a Dictionary, which would crash with a KeyNotFoundException).
        object missingValue = studentInfo["GPA"];
        if (missingValue == null)
        {
            Console.WriteLine("Key 'GPA' does not exist in the Hashtable.");
        }

        // 4. Checking for Keys or Values
        // ContainsKey() or Contains() - Both do the exact same thing for checking keys (Fast O(1)).
        if (studentInfo.ContainsKey("StudentID"))
        {
            Console.WriteLine("The Student ID key was found.");
        }

        // ContainsValue() - Slower (O(n)) because it must search all values linearly.
        if (studentInfo.ContainsValue("Mohamed"))
        {
            Console.WriteLine("The value 'Mohamed' was found.");
        }

        // 5. Updating an Element
        // Just use the indexer with an existing key to overwrite its value.
        studentInfo["IsActive"] = false;

        // 6. Removing an Element
        // Remove(key) deletes the key/value pair.
        studentInfo.Remove(1); // Removes the key '1' and its associated value

        // 7. Iterating / Looping through the Hashtable
        Console.WriteLine("\n--- Hashtable Contents ---");

        // IMPORTANT: You MUST use the `DictionaryEntry` struct to iterate over a Hashtable.
        // You cannot use KeyValuePair like you do in a Dictionary.
        foreach (DictionaryEntry entry in studentInfo)
        {
            Console.WriteLine($"Key: {entry.Key} -> Value: {entry.Value}");
        }

        // Iterating over Keys only (Returned as a collection of objects)
        foreach (object key in studentInfo.Keys)
        {
            // Execute logic using the key
        }

        // Iterating over Values only (Returned as a collection of objects)
        foreach (object val in studentInfo.Values)
        {
            // Execute logic using the value
        }

        // 8. Properties and Cleanup
        // Count: Gets the total number of key/value pairs currently inside.
        int totalItems = studentInfo.Count;

        // Clear(): Wipes out all elements, leaving an empty Hashtable.
        studentInfo.Clear();
    }
}
