using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollection1
{
    public class myCustomCollection<T> : ICollection<T>
    {
        private List<T> items = new List<T>();


        public int Count => items.Count;


        public bool IsReadOnly => false;


        public void Add(T item)
        {
            items.Add(item);
        }


        public void Clear()
        {
            items.Clear();
        }


        public bool Contains(T item)
        {
            return items.Contains(item);
        }


        public void CopyTo(T[] array, int arrayIndex)
        {
            items.CopyTo(array, arrayIndex);
        }


        public bool Remove(T item)
        {
            return items.Remove(item);
        }


        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            myCustomCollection<string> myCollection = new myCustomCollection<string>();
            myCollection.Add("Hello");
            myCollection.Add("World");

            Console.WriteLine("Items in myCollection:");
            foreach (var item in myCollection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Count: {myCollection.Count}");

            myCollection.Remove("Hello");

            Console.WriteLine("Items in myCollection after removal:");
            foreach (var item in myCollection)
            {
                Console.WriteLine(item);
            }

            if(myCollection.Contains("World"))
            {
                Console.WriteLine("myCollection contains 'World'");
            }

            
        }
    }
}
