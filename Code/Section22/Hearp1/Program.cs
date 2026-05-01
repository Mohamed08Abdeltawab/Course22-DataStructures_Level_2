using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearp1
{
    class MinHeap
    {
        private List<int> heap = new List<int>();

        public void Insert(int value)
        {
            heap.Add(value);

            HeapifyUp(heap.Count - 1);
        }

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int ParentIndex = (index - 1) / 2;

                if (heap[ParentIndex] <= heap[index]) break;

                //swap
                (heap[index], heap[ParentIndex]) = (heap[ParentIndex], heap[index]);
                index = ParentIndex;
            }
        }

        public void DisplayHeap()
        {
            Console.WriteLine("\nHeap Elements: ");
            foreach (int value in heap)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MinHeap minHeap = new MinHeap();

            Console.WriteLine("Inserting elements into the Min-Heap...\n");
            minHeap.Insert(10);
            minHeap.Insert(4);
            minHeap.Insert(15);
            minHeap.Insert(2);
            minHeap.Insert(8);

            // Display the heap after insertion
            minHeap.DisplayHeap();
        }
    }
}
