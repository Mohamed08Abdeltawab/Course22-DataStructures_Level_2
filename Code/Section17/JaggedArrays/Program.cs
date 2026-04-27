using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Jagged array declaration
            int[][] jaggedArr1 =
            {
                new int[] {1,2,3,4,5,6,7,},
                new int[] {8,9,10,11,12},
                new int[] {13,14,15,16,17,18,19,20}
            };

            int[][] jaggedArr2 = new int[3][];
            jaggedArr2[0] = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            jaggedArr2[1] = new int[] { 8, 9, 10, 11, 12 };
            jaggedArr2[2] = new int[] { 13, 14, 15, 16, 17, 18, 19, 20 };

            foreach (int[] arr in jaggedArr1)
            {
                foreach(int num in arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

            //or
            Console.WriteLine();

            for(int i = 0; i<jaggedArr2.Length; i++)
            {
                for(int j = 0; j< jaggedArr2[i].Length; j++)
                {
                    Console.Write(jaggedArr2[i][j] + " ");
                }
                Console.WriteLine();
            }

            #region using linq with jagged arrays
            int[][] jaggedArray = {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9, 10 }
        };

            // Using LINQ to flatten the jagged array and calculate the sum of all elements
            var totalSum = jaggedArray.SelectMany(arr => arr).Sum();
            Console.WriteLine("Total Sum using Sum method: " + totalSum);

            var MaxValue = jaggedArray.SelectMany(arr => arr).Max();
            Console.WriteLine("Max Value: " + MaxValue);
            var MinValue = jaggedArray.SelectMany(arr => arr).Min();
            Console.WriteLine("Min Value: " + MinValue);

            var FilterElements = jaggedArray.Where(subarr => subarr.Length > 3).Select(arr => arr.First());

            foreach(var element in FilterElements)
            {
                Console.WriteLine("First element of sub-arrays with length greater than 3: " +  element);
            }
            #endregion
        }
    }
}
