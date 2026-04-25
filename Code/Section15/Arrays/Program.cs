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

            #region Advanced Array Operations
            // Initializing an array
            int[] numbers2 = { 5, 3, 1, 4, 2 };


            // Sorting the array
            Array.Sort(numbers2);

            // Display the sorted array
            Console.WriteLine("Sorted array:");
            foreach (int number in numbers2)
            {
                Console.WriteLine(number);
            }

              
            // Searching for an element, this will return the index for the element you searched for.
            int index = Array.IndexOf(numbers2, 4);
            Console.WriteLine("\nIndex of 4: " + index);

            #endregion

            #region Coping Arrays
            int[] Original = { 1, 2, 3, 4, 5 };

            int[] Copy = new int[Original.Length + 1];//if not the same length will be 0 or not tack the last element of the original array
            Array.Copy(Original, Copy, Original.Length - 1);//take to length -1 to not take the last element of the original array

            Console.WriteLine("Original array:");
            foreach (int number in Original)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nCopied array:");
            foreach (int number in Copy)
            {
                Console.WriteLine(number);
            }

            #endregion

            #region uisng linq with arrays ex
            int [] numbers3 = { 1, 2, 3, 4, 5 };
            //using linq to filter even numbers from the array
            var SquarEvenNumbers = numbers3.Where(n => n % 2 == 0).Select(n => n * n);
            Console.WriteLine("Squares of Even numbers with linq Operation:");
            foreach (int number in SquarEvenNumbers)
            {
                Console.WriteLine(number);
            }

            #endregion

            #region Advanced LINQ Operations on Arrays
            var people = new[]
             {
                 new { Name = "Alice", Age = 30 },
                 new { Name = "Bob", Age = 25},
                 new { Name = "Charlie", Age = 35 },
                 new { Name = "Diana", Age = 30 },
                 new { Name = "Ethan", Age = 25 }
             };

            var groupedByAge = people.GroupBy(p => p.Age)
                .Select(group => new
            {
                Age = group.Key,
                People = group.OrderBy(p => p.Name).Select(p => p.Name).ToList()
                });

            foreach (var group in groupedByAge)
            {
                Console.WriteLine($"Age Group: {group.Age}");
                foreach (var person in group.People)//people is list of names for each age group
                {
                    Console.WriteLine($" - {person}");
                }
            }

            #endregion

            #region  Advanced LINQ Operations on Arrays - Filtering and Aggregation Introduction to Filtering and Aggregation
            int[] numbers4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = numbers4.Where(n => n % 2 == 0);

            var sumOfEvenNumbers = evenNumbers.Sum();
            var averageOfEvenNumbers = evenNumbers.Average();
            var countOfEvenNumbers = evenNumbers.Count();
            //var sumOfEvenNumbers = numbers4.Where(n => n % 2 == 0).Sum(); //you can do it in one line without creating a variable for the even numbers

            Console.WriteLine("Even Numbers:");
            foreach (var number in evenNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\nSum of even numbers: " + sumOfEvenNumbers);
            Console.WriteLine("Average of even numbers: " + averageOfEvenNumbers);
            Console.WriteLine("Count of even numbers: " + countOfEvenNumbers);

            #endregion

            #region Advanced LINQ Operations on Arrays - Joining and Projection Introduction to Joining and Projection
            // Array of employees
            var employees = new[]
            {
                new { Id = 1, Name = "Alice", DepartmentId = 2 },
                new { Id = 2, Name = "Bob", DepartmentId = 1 }
            };


            // Array of departments
            var departments = new[]
            {
                new { Id = 1, Name = "Human Resources" },
                new { Id = 2, Name = "Development" }
            };

            // Joining employees with their respective departments
            //like inner join in sql, it will create a new when the deptID == emp.DetartmentId then it will create a new object with the employee name and the department name
            //if not it will not create a new object and it will not be included in the result
            //if you change id in Department to 3,4 it will not be included in the result because there is no employee with department id 3 or 4 return nothing
            var employeeDepartments = employees.Join(departments,
                emp => emp.DepartmentId,// Employee's department ID
                dept => dept.Id, // Department's ID
                (emp, dept) => new
                {
                    EmployeeName = emp.Name,
                    DepartmentName = dept.Name
                });

            Console.WriteLine("\nEmployee Departments:");
            foreach(var ed in employeeDepartments)
            {
                Console.WriteLine($"Employee: {ed.EmployeeName}, Department: {ed.DepartmentName}");
            }

            #endregion
        }
    }
}
