using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingSetswithHashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Using SetEquals with HashSet in C#

            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3};
            HashSet<int> set2 = new HashSet<int>() { 1, 2, 3};
            HashSet<int> set3 = new HashSet<int>() { 3, 4, 5};

            Console.WriteLine("set1 equals set2: " + set1.SetEquals(set2)); // True
            Console.WriteLine("set1 equals set3: " + set1.SetEquals(set3)); // False
            #endregion

            #region Using IsSubsetOf with HashSet in C#
            set1 = new HashSet<int>() { 1, 2, 3 };
            set2 = new HashSet<int>() { 1, 2, 3, 4, 5, 6};


            Console.WriteLine("\nset1 is subset of set2: " + set1.IsSubsetOf(set2)); // True
            Console.WriteLine("set1 is subset of set3: " + set1.IsSubsetOf(set3));// False
            #endregion

            #region Using IsSupersetOf with HashSet in C#
            set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
            set2 = new HashSet<int> { 2, 3 };

            // Check if set1 is a superset of set2 meaning all elements of set2 are in set1
            //set1 is mother of set2
            Console.WriteLine("\nset1 is a superset of set2: " + set1.IsSupersetOf(set2));
            #endregion

            #region Using Overlaps with HashSet in C#
            set1 = new HashSet<int> { 1, 2, 3 };
            set2 = new HashSet<int> { 3, 4, 5 };
            set3 = new HashSet<int> { 6, 7, 8 };


            Console.WriteLine("\nset1 overlaps set2: " + set1.Overlaps(set2));
            Console.WriteLine("set1 overlaps set3: " + set1.Overlaps(set3));
            Console.ReadKey();
            #endregion
        }
    }
}
