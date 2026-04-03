using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
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
            /*
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
            */
            /*
                        #region Filtering Data with LINQ in C# Using List
                        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        Console.WriteLine("Number of Items in the list: " + string.Join(", ", numbers));

                        //using LINQ to filter data
                        //where -> is used to filter data based on a condition and it returns a new collection that contains only the elements that satisfy the condition
                        Console.WriteLine("Event Numbers: " + string.Join(", ",numbers.Where(n => n % 2 == 0)));
                        Console.WriteLine("Odd Numbers: " + string.Join(", ", numbers.Where(n => n % 2 != 0)));
                        //Where (n => n) used int (int,bool) and return int of value based on bool value
                        Console.WriteLine("Numbers Greater than 5: " + string.Join(", ", numbers.Where(n => n > 5)));
                        //Where (n,index) used int (int,int,bool) and return int of n and used index from 0 to end based on bool value
                        Console.WriteLine("Every Second Number: " + string.Join(", ", numbers.Where((n,index) => index % 2 == 1 )));//value in (n) and index in (index) if true then add (n) to the result
                        Console.WriteLine("Numbers Between 3 and 8: " + string.Join(", ", numbers.Where(n => n > 3 && n<8)));
                        #endregion
            */

            /*
                        #region Sorting a List in C# Using Various Methods
                        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        Console.WriteLine("Number of Items in the list: " + string.Join(", ", numbers));

                        //.Sort () method is used to sort the list in ascending order
                        numbers.Sort();
                        Console.WriteLine("Sorted List using Sort(Ascending): " + string.Join(", ", numbers));

                        //.reverse () method is used to sort the list in descending order
                        numbers.Reverse();
                        Console.WriteLine("Sorted List using Reverse(Descending): " + string.Join(", ", numbers));

                        //using LINQ to sort the list in ascending order
                        Console.WriteLine("Sorted List using OrderBy(Ascending)" + string.Join(",", numbers.OrderBy(n => n)));
                        Console.WriteLine("Sorted List using OrderByDescending(Descending)" + string.Join(",", numbers.OrderByDescending(n => n)));

                        #endregion
            */
            /*

                        #region Exploring Contains, Exists, Find, FindAll, and Any with List of Integers
                        List<int> numbers = new List<int> { 44, 22, -55, 666, 9, -6, 345, 11, 3, 3 };
                        Console.WriteLine("Number of Items in the list: " + string.Join(", ", numbers));

                        //Contains method is used to check if a specific element exists in the list and it returns a boolean value (true or false)
                        Console.WriteLine("Does the list contain 22? " + numbers.Contains(22));

                        //Exists method is used to check if any element in the list satisfies a specific condition and it returns a boolean value (true or false)
                        Console.WriteLine("Does the list contain any negative numbers? " + numbers.Exists(n => n < 0));

                        //Find method is used to find the first element in the list that satisfies a specific condition and it returns the element if found,
                        //otherwise it returns the default value for the type (e.g., null for reference types, 0 for numeric types)
                        Console.WriteLine("First negative number in the list: " + numbers.Find(n => n < 0));

                        //FindAll method is used to find all elements in the list that satisfy a specific condition
                        //and it returns a new list that contains all the elements that satisfy the condition
                        Console.WriteLine("All negative numbers in the list: " + string.Join(", ", numbers.FindAll(n => n < 0)));

                        //Any method is used to check if any element in the list satisfies a specific condition and it returns a boolean value (true or false)
                        Console.WriteLine("Are there any numbers greater than 100 in the list? " + numbers.Any(n => n > 100));
                        #endregion
            */

            /*
                        #region Exploring Contains, Exists, Find, FindAll, and Any with List of Strings
                        List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry", "fig", "grape", "honeydew" };
                        Console.WriteLine("Items in the list: " + string.Join(", ", words));

                        //Contains
                        Console.WriteLine("List contains 'apple': " + words.Contains("apple"));

                        //Exist
                        Console.WriteLine("List contains a word of length 5: " + words.Exists(w => w.Length ==5));

                        //Find
                        Console.WriteLine("First word longer than 5 characters: " + words.Find(word => word.Length > 5));

                        //Find All
                        Console.WriteLine("Words longer than 5 characters: " + string.Join(", ", words.FindAll(word => word.Length > 5)));

                        //Any
                        Console.WriteLine("Any words starting with 'a': " + words.Any(word => word.StartsWith("a")));

                        #endregion
            */
            /*
                        #region Working with a List of Custom Objects
                        List<Person> people = new List<Person>()
                        {
                            new Person("Mohamed",14),
                            new Person("Ahmed", 20),
                            new Person("Sara", 25),
                            new Person("Ali", 30),
                            new Person("Mona", 35),
                            new Person("Omar", 40) ,
                            new Person("Laila", 45),
                            new Person("Youssef", 50),
                        };

                        //current list of people
                        Console.WriteLine("Current List of People:");
                        foreach(Person person in people)
                        {
                            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
                        }

                        //using Find
                        Person firstOlderThan30 = people.Find(p => p.Age > 30);
                        Console.WriteLine("\nFinding the first person older than 30:" + firstOlderThan30.Name);

                        //find and update age that name is Alice
                        Person searchResult = people.Find(p => p.Name == "Alice");
                        if (searchResult != null)
                        {
                            searchResult.Age = 28;
                            Console.WriteLine($"\nUpdated Alice's age to: {searchResult.Age}");
                        }
                        else
                            Console.WriteLine("There is no person with Name 'Alice'");

                            //using FindAll
                            List<Person> PersopleOlderThan30 = people.FindAll(p => p.Age > 30);
                        Console.WriteLine("People older than 30: ");
                        foreach (Person person1 in PersopleOlderThan30)
                        {
                            Console.WriteLine($"Name: {person1.Name}, Age: {person1.Age}");
                        }

                        //using Any
                        bool anyPersonYoungerThan20 = people.Any(p => p.Age < 20);
                        Console.WriteLine("\nIs there any person younger than 20? " + anyPersonYoungerThan20);


                        //using Exist
                        bool anyPersonOver40 = people.Any(p => p.Age > 40);
                        Console.WriteLine("\nIs there any person Over than 40? " + anyPersonYoungerThan20);


                        //using Removing 
                        people.RemoveAll(p => p.Age > 40);
                        Console.WriteLine("\nList of People after removing those older than 40:");

                        foreach (Person person in people)
                        {
                            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
                        }
                        #endregion
            */
/*
            #region Converting a List to an Array
            List<int>numbers = new List<int> { 1, 2, 3, 4, 5 };

            int[] numbersArray = numbers.ToArray();
            Console.WriteLine("Array elements: " + string.Join(", " , numbersArray));

            #endregion
*/

            #region Converting an Array to List
            int[] numbersArray = new int[] { 1, 2, 3, 4, 5 };
            List<int> numbersList = new List<int>(numbersArray);
            //or using LINQ
            //List<int> numbersList = numbersArray.ToList();
            Console.WriteLine("List elements: " + string.Join(", ", numbersList));


            #endregion



        }

        /*
                public class Person
                {
                    public string Name { get; set; }
                    public int Age { get; set; }

                    public Person(string name, int age)
                    {
                        this.Name = name;
                        this.Age = age;
                    }
                }
        */
    }
}
