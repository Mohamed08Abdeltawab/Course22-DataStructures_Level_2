using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region intro in Arrays
            int[] numbers = new int[5];

            string[] names = { "Alice", "Bob", "Ali" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            foreach(int n in numbers)
            {
                Console.WriteLine(n);//print five zeros
            }
            #endregion

            #region Advanced Array Operations
            // Initializing an array
            int[] numbers2 = { 5, 3, 1, 4, 2 };


            // Sorting the array
            Array.Sort(numbers2);

            // Display the sorted array
            Console.WriteLine("Sorted array:");
            foreach (int number in numbers2)
            {
                Console.WriteLine(number);
            }

              
            // Searching for an element, this will return the index for the element you searched for.
            int index = Array.IndexOf(numbers2, 4);
            Console.WriteLine("\nIndex of 4: " + index);

            #endregion

            #region Coping Arrays
            int[] Original = { 1, 2, 3, 4, 5 };

            int[] Copy = new int[Original.Length + 1];//if not the same length will be 0 or not tack the last element of the original array
            Array.Copy(Original, Copy, Original.Length - 1);//take to length -1 to not take the last element of the original array

            Console.WriteLine("Original array:");
            foreach (int number in Original)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nCopied array:");
            foreach (int number in Copy)
            {
                Console.WriteLine(number);
            }

            #endregion

            #region uisng linq with arrays ex
            int [] numbers3 = { 1, 2, 3, 4, 5 };
            //using linq to filter even numbers from the array
            var SquarEvenNumbers = numbers3.Where(n => n % 2 == 0).Select(n => n * n);
            Console.WriteLine("Squares of Even numbers with linq Operation:");
            foreach (int number in SquarEvenNumbers)
            {
                Console.WriteLine(number);
            }

            #endregion

            #region Advanced LINQ Operations on Arrays
            var people = new[]
             {
                 new { Name = "Alice", Age = 30 },
                 new { Name = "Bob", Age = 25},
                 new { Name = "Charlie", Age = 35 },
                 new { Name = "Diana", Age = 30 },
                 new { Name = "Ethan", Age = 25 }
             };

            var groupedByAge = people.GroupBy(p => p.Age)
                .Select(group => new
            {
                Age = group.Key,
                People = group.OrderBy(p => p.Name).Select(p => p.Name).ToList()
                });

            foreach (var group in groupedByAge)
            {
                Console.WriteLine($"Age Group: {group.Age}");
                foreach (var person in group.People)//people is list of names for each age group
                {
                    Console.WriteLine($" - {person}");
                }
            }

            #endregion
        }
    }
}
