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
            #endregion


            #region LINQ with sortedList in C#

            SortedList<int, string> sortedListNumber = new SortedList<int, string>()
            {
                {1,"One" },
                {2,"Two" },
                {3,"Three" },
                {4,"Four" },
            };


            //use query linq
            var queryExpressionsSyntax = from kvp in sortedListNumber
                                         where kvp.Key > 1
                                         select kvp;

            Console.WriteLine("Query Expression Syntax Results:");
            foreach(var item in queryExpressionsSyntax)
            {
                Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
            }

            //use query linq
            var MethodSyntax = sortedListNumber.Where(kvp => kvp.Key > 1);

            Console.WriteLine("Method Syntax Results:");
            foreach (var item in MethodSyntax)
            {
                Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
            }

            #endregion
        }

    }
}
