using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Working with SortedList
            SortedList<string,int> sortedListFruites = new SortedList<string,int>();

            sortedListFruites.Add("Apple", 3);
            sortedListFruites.Add("Banana", 2);
            sortedListFruites.Add("Orange", 2);

            Console.WriteLine("\nQuantity of apple: " + sortedListFruites["Apple"]);

            Console.WriteLine("\nIterating sortedList Elements:");
            foreach(var item in  sortedListFruites)
            {
                Console.WriteLine($"Key: {item.Key}, Value:{item.Value}");
            }

            sortedListFruites.Remove("Apple");

            Console.WriteLine("\nIterating sortedList Elements after remove Apple KEY:");
            foreach (var item in sortedListFruites)
            {
                Console.WriteLine($"Key: {item.Key}, Value:{item.Value}");
            }

        }

    }
}
