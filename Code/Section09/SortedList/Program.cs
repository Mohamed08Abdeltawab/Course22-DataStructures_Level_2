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


            #region Advanced LINQ Usage with SortedList Grouping Elements
            SortedList<int, string> sortedListFruites2 = new SortedList<int, string>()
            {
                {1, "Apple" },
                {2, "Banana" },
                {3, "Cherry" },
                {4, "Date" },
                {5, "Grape" },
                {6, "Fig" },
                {7, "Elderber" }
            };

            //group.key -> length 
            var groups = sortedListFruites2.GroupBy(kvp => kvp.Value.Length);
            Console.WriteLine("\nGrouping By the length of the value");
            foreach (var group in groups)
            {
                Console.WriteLine($"Length: {group.Key}, Values: '{string.Join(", ", group.Select(kvp => kvp.Value))}'");
            }

            //another way
            //foreach(var group in groups)
            //{
            //    Console.Write($"Length: {group.Key}, Values: ");
            //    foreach(var item in group)
            //    {
            //        Console.Write(item.Value + ", ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Advance Complex Object Operations using Linq and Sotred List
            SortedList<int, Employee> employees = new SortedList<int, Employee>
            {
                {1, new Employee("Alice","HR",50000) },
                {2, new Employee("Bob","IT",70000) },
                {3, new Employee("Charlie","HR",52000) },
                {4, new Employee("Daisy","IT",80000) },
                {5, new Employee("Ethan","Marketing",45000) }
            };

            var EmployeesWithITDepartment = employees
                .Where(e => e.Value.Department == "IT")
                .OrderByDescending(e => e.Value.Salary)
                //select if not used is defualt reutrn parameter of emplyees that is sortedList have a Key and Value
                //but you can used to return a spasific parameter so we used var as return type
                //myby you dicided to select Name only then reutrn type is string not a sortedList like default
                .Select(e => e.Value.Name);
            
            Console.WriteLine("\nIT Department Employees Name sorted by salary (Descending)");
            foreach (var employeeName in EmployeesWithITDepartment)
            {
                Console.WriteLine(employeeName);
            }


            var EmployeesWithGreaterThan60000Salary = employees
                .Where(e => e.Value.Salary > 60000)
                .OrderBy(e => e.Value.Salary)
                .Select(e => e.Value); //return value only 

            Console.WriteLine("\nEmployees That have more than 60000 sorted by salary (Ascending)");
            foreach (var employee in EmployeesWithGreaterThan60000Salary)
            {
                Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}");
            }


            #endregion

        }

        //Advance Complex Object Operations using Linq and Sotred List
        public class Employee
        {
            public string Name { get; set; }
            public string Department { get; set; }
            public decimal Salary { get; set; }

            public Employee(string name, string department, decimal salary)
            {
                Name = name;
                Department = department;
                Salary = salary;
            }
        }

    }
}
