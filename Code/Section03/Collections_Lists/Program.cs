using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*
            #region Lists
            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);

            Console.WriteLine("\nChange index 2 with value 200");
            numbers[2] = 200;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);
            #endregion
*/

            #region insert element into List

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //insert at end
            numbers.Add(1);
            Console.WriteLine("after insert '1' at end: " + string.Join(", ", numbers));

            //insert at spacific index
            numbers.Insert(0, 0);//insert 2 at index 0
            Console.WriteLine("after insert 0 at index 0: " + string.Join(", ", numbers));

            //insert multiple elements 
            numbers.InsertRange(3, new List<int> { 3, 4, 5 });//insert 3,4,5 at index 3
            Console.WriteLine("after insert 3,4,5 at index 3: " + string.Join(", ", numbers));
            #endregion
        }
    }
}
