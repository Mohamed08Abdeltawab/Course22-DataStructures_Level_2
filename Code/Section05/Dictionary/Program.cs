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

        }
    }
}
