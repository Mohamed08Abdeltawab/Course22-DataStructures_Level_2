using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable1
{
    public class Person : IComparable<Person>
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public int CompareTo(Person other)
        {
            if (other == null) return 1;// Current instance is greater than null

            return this.Age.CompareTo(other.Age); // Compare based on Age
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "Alice", Age = 30 },
                new Person { Name = "Bob", Age = 25 },
                new Person { Name = "Charlie", Age = 35 }
            };
            // Sort the list of people based on their age
            people.Sort();//understand that the Sort method will use the CompareTo method defined in the Person class to determine the order of the elements in the list. In this case, it will sort the people by their age in ascending order.
            // Print the sorted list
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
