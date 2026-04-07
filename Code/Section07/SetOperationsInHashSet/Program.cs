using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetOperationsInHashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Union Operation with HashSet in C#

            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };


            // Union of set1 and set2
            set1.UnionWith(set2);


            Console.WriteLine("Union of sets:");
            foreach (int item in set1)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
