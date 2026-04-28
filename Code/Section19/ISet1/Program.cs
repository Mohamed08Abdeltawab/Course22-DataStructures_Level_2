using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ISet1
{
    public class myCustomSet<T> : ISet<T>
    {
        private List<T> _list = new List<T>();

        // Property to get the number of elements
        public int Count => _list.Count;

        public bool IsReadOnly => false;

        // Adds an element and returns true if added, false if already exists
        public bool Add(string item) => Add((T)(object)item); // Just for interface mapping

        public bool Add(T item)
        {
            if (!_list.Contains(item))// Check for duplicates
            {
                _list.Add(item);
                return true;
            }
            return false;
        }

        // Must implement this for ICollection compatibility
        void ICollection<T>.Add(T item) => Add(item);

        public void Clear() => _list.Clear();

        public bool Contains(T item) => _list.Contains(item);

        public void CopyTo(T[] array, int arrayIndex) => _list.CopyTo(array, arrayIndex);

        public bool Remove(T item) => _list.Remove(item);

        // Enumerator to allow foreach loops
        public IEnumerator<T> GetEnumerator() => _list.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        // --- ISet Specific Methods (The Set Math) ---

        public void ExceptWith(IEnumerable<T> other)
        {
            foreach (var item in other) _list.Remove(item);
        }

        public void IntersectWith(IEnumerable<T> other)
        {
            _list = _list.Where(x => other.Contains(x)).ToList();
        }

        public void UnionWith(IEnumerable<T> other)
        {
            foreach (var item in other) Add(item);
        }

        public bool IsProperSubsetOf(IEnumerable<T> other) => _list.All(other.Contains) && other.Count() > _list.Count;

        public bool IsProperSupersetOf(IEnumerable<T> other) => other.All(_list.Contains) && _list.Count > other.Count();

        public bool IsSubsetOf(IEnumerable<T> other) => _list.All(other.Contains);

        public bool IsSupersetOf(IEnumerable<T> other) => other.All(_list.Contains);

        public bool Overlaps(IEnumerable<T> other) => other.Any(_list.Contains);

        public bool SetEquals(IEnumerable<T> other) => _list.Count == other.Count() && _list.All(other.Contains);

        public void SymmetricExceptWith(IEnumerable<T> other)
        {
            foreach (var item in other)
            {
                if (_list.Contains(item)) _list.Remove(item);
                else _list.Add(item);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize our custom set
            myCustomSet<int> myNumbers = new myCustomSet<int>();

            // 1. Testing Add (No duplicates allowed)
            myNumbers.Add(10);
            myNumbers.Add(20);
            myNumbers.Add(10); // This won't be added

            Console.WriteLine($"Total count (should be 2): {myNumbers.Count}");

            // 2. Testing UnionWith
            List<int> otherNumbers = new List<int> { 20, 30, 40 };
            myNumbers.UnionWith(otherNumbers);

            Console.WriteLine("After Union with {20, 30, 40}:");
            foreach (var num in myNumbers)
            {
                Console.WriteLine($"- {num}"); // Expected: 10, 20, 30, 40
            }

            // 3. Testing Contains and Remove
            Console.WriteLine($"Contains 30? {myNumbers.Contains(30)}");
            myNumbers.Remove(10);
            Console.WriteLine($"Count after removing 10: {myNumbers.Count}");

            Console.ReadKey();
        }
    }
}