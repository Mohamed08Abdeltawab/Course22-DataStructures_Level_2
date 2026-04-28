using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerable1
{
    public class CustomCollection<T> : IEnumerable<T>
    {
        private List<T> _items = new List<T>();

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < _items.Count; i++)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            _items.Add(item);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var myCollection = new CustomCollection<string>();
            myCollection.Add("Hello");
            myCollection.Add("World");

            foreach (var item in myCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
