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

            

            #region using linq in tuple

            List<(int, string, int)> LPerson = new List<(int, string, int)>
            {
            (1,"mohamed",22),
            (2,"ali",33),
            (3,"karem",44)
            };

            //filter age less than 30 and print name
            var PersonLess30 = LPerson.Where(p => p.Item3 < 30).Select(n => n.Item2).ToList();
            Console.WriteLine("person less than 30:");
            foreach(var p in PersonLess30)
            {
                Console.WriteLine(p);//p hold name
            }

            var AverageAge = LPerson.Average(p => p.Item3);
            Console.WriteLine("Average age: " + AverageAge);
            #endregion
        }
        static (int, string) GetPerson()
        {
            return (1, "Mohamed");
        }

    }
}
