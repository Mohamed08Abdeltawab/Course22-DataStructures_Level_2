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


        }
    }
}
