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

            /*
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
            */
            /*
                        #region Remove Items from List

                        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        //removing by item
                        numbers.Remove(1);
                        Console.WriteLine("after removing 1: " + string.Join(", ", numbers));


                        //removing by index
                        numbers.RemoveAt(0);//remove item at index 0
                        Console.WriteLine("after removing item at index 0: " + string.Join(", ", numbers));

                        //removing base on condition
                        numbers.RemoveAll(x => x % 2 == 0);//remove all even numbers
                        Console.WriteLine("after removing all even numbers: " + string.Join(", ", numbers));

                        //remove all
                        numbers.Clear();
                        Console.WriteLine("after removing all items: " + string.Join(", ", numbers));
                        #endregion
            */
            /*
                        #region Looping Through a List in C#
                        List<int> numbers = new List<int> { 1,2,3,4,5 };
                        Console.WriteLine("Number of Items in the list: " + string.Join(", ",numbers));

                        //using for loop
                        Console.Write("\nusing for loop: ");
                        for (int i =0; i < numbers.Count; i++)
                        {
                            Console.Write(numbers[i] + " ");
                        }

                        //using foreach loop
                        Console.WriteLine("\nusing foreach loop: ");
                        foreach(int number in numbers)
                        {
                            Console.Write(number + " ");
                        }

                        //using lambda expression with ForEach method
                        Console.WriteLine("\nusing lambda expression with ForEach method: ");
                        numbers.ForEach(number => Console.Write(number + " "));
                        #endregion
            */

            #region Aggregating Data Using LINQ with List
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("Number of Items in the list: " + string.Join(", ", numbers));
            //using LINQ to calculate the sum of all numbers in the list

            Console.WriteLine("Sum: " + numbers.Sum());
            Console.WriteLine("Average: " + numbers.Average());
            Console.WriteLine("Minimum: " + numbers.Min());
            Console.WriteLine("Maximum: " + numbers.Max());
            Console.WriteLine("Count: " + numbers.Count());
            #endregion

        }
    }
}
