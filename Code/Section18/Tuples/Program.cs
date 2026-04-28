using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (int, string, double) person = (1, "Mohamed", 5.5);

            Console.WriteLine("Person item1: " + person.Item1);
            Console.WriteLine("Person item2: " + person.Item2);
            Console.WriteLine("Person item3: " + person.Item3);

            //uisng function to return tuple
            var person2 = GetPerson();
            Console.WriteLine("Person2 item1: " + person2.Item1);
            Console.WriteLine("Person2 item2: " + person2.Item2);
        }

        static (int, string) GetPerson()
        {
            return (1, "Mohamed");
        }
    }
}
