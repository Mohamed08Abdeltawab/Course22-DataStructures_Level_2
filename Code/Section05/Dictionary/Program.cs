using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Working with Hashtable in C#

            Dictionary<string, int> fruitBasket = new Dictionary<string, int>();

            //adding elements to the dictionary
            fruitBasket.Add("Apple", 10);
            fruitBasket.Add("Banana", 20);
            fruitBasket.Add("Orange", 15);
            //fruitBasket.Add("Orange", 15);run time error , must be uniqe id
            fruitBasket.Add("Grapes", 25);

            //accessing elements in the dictionary
            fruitBasket["Banana"] = 30; //update the value for Banana

            Console.WriteLine("\nDictionary contaent: ");
            foreach(KeyValuePair<string,int> item in fruitBasket)
            {
                Console.WriteLine(item.Key + " = " + item.Value);
            }

            fruitBasket.Remove("Banana");

            Console.WriteLine("\nDictionary contaent after removeing Banana: ");
            foreach (KeyValuePair<string, int> item in fruitBasket)
            {
                Console.WriteLine(item.Key + " = " + item.Value);
            }
            #endregion


            #region TryGetValue Method in C# Dictionaries

            if(fruitBasket.TryGetValue("Apple",out int appleQunatity))
            {
                Console.WriteLine($"\n\nApple Quantity: {appleQunatity}");
            }
            else
            {
                Console.WriteLine($"Apple not found in the basket");
            }

            #endregion


            #region Utilizing LINQ with Dictionaries
            Console.WriteLine("\n\nusing linq");

            var filteredFruit = fruitBasket.Where(kpv => kpv.Value > 3);
            Console.WriteLine("\n\nitem value big than 3: \n");
            foreach(var item in filteredFruit)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }

            //sort
            var sortedByQuantity = fruitBasket.OrderBy(kpv => kpv.Value);
            Console.WriteLine("\n\nsorted Fruit by value");
            foreach (var item in sortedByQuantity)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }

            //sort
            var sortedByQuantityDesc = fruitBasket.OrderByDescending(kpv => kpv.Value);
            Console.WriteLine("\n\nsorted Fruit by value Desc");
            foreach (var item in sortedByQuantityDesc)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }

            //total
            var totalQuantity = fruitBasket.Sum(kpv => kpv.Value);
            Console.WriteLine("\n\nTotal Fruit Quantity " + totalQuantity);

            #endregion
        }
    }
}
