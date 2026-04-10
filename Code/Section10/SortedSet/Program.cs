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

            
        }
    }
}
