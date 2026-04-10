using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Working with SortedSet 
            SortedSet<int> sortedSet1 = new SortedSet<int>();

            //adding 
            sortedSet1.Add(1);
            sortedSet1.Add(3);
            sortedSet1.Add(2);
            sortedSet1.Add(5);
            sortedSet1.Add(4);

            //display
            Console.WriteLine("SortedSet elements:");
            foreach(int element in sortedSet1)
            {
                Console.WriteLine(element);
            }

            //check if an element exist in the sortedSet
            int target = 3;
            if(sortedSet1.Contains(target))
            {
                Console.WriteLine($"\n Number {target} in the sortedSet.");
            }

            //remove item in sortedSet
            sortedSet1.Remove(target);
            Console.WriteLine("\nsortedSet after remove number 3: ");
            foreach (int element in sortedSet1)
            {
                Console.WriteLine(element);
            }
            #endregion

            #region Linq With Sorted Set Ex1
            SortedSet<int> sortedSet2 = new SortedSet<int>() { 1, 2, 3, 4, 5 };


            // Filtering elements greater than 2
            var filteredSet = sortedSet2.Where(x => x > 2);
            Console.WriteLine("Filtered Set:");
            Console.WriteLine(string.Join(", ", filteredSet));


            // Sum of all elements
            var sum = sortedSet2.Sum();
            Console.WriteLine("Sum of all elements: " + sum);


            // Maximum and minimum elements
            var maxElement = sortedSet2.Max();
            var minElement = sortedSet2.Min();
            Console.WriteLine("Maximum element: " + maxElement);
            Console.WriteLine("Minimum element: " + minElement);


            // Sorting the set in descending order
            var descendingSet = sortedSet2.OrderByDescending(x => x);
            Console.WriteLine("Descending Sorted Set:");
            Console.WriteLine(string.Join(", ", descendingSet));
            #endregion
        }
    }
}
