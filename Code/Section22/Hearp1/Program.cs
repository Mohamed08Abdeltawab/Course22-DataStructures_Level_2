using System;
using System.Collections.Generic;
using System.IO;
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

        // Peek the minimum element without removing it
        public int Peek()
        {
            if (heap.Count == 0)
            {
                throw new InvalidOperationException("Heap is empty.");
            }

            return heap[0]; // The smallest element is at the root
        }

        public int ExtractMin()
        {
            if(heap.Count == 0)
            {
                throw new InvalidOperationException("Heap is empty.");
            }

            //we need to remove the min element and return it
            int min = heap[0];//return it

            heap[0] = heap[heap.Count - 1];//move the last element to the root

            heap.RemoveAt(heap.Count - 1);//remove the last element to resize the heap

            HeapyifyDown(0);//heapify down from the root to restore the heap property
            return min;
        }

        public void HeapyifyDown(int index)
        {
            while (index < heap.Count)
            {
                int smallest = index;

                int leftChild = 2 * index + 1;
                int rightChild = 2 * index + 2;

                if (leftChild < heap.Count && heap[leftChild] < heap[smallest])
                {
                    smallest = leftChild;
                }

                if (rightChild < heap.Count && heap[rightChild] < heap[smallest])
                {
                    smallest = rightChild;
                }

                //if not access to two if statements, we can break the loop if the smallest is still the current index, which means we are done
                if (smallest == index) break;//if the smallest is still the current index, we are done 

                (heap[index], heap[smallest]) = (heap[smallest], heap[index]);

                index = smallest;
            }
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

            Console.WriteLine(minHeap.Peek());

            // Extract elements based on priority
            Console.WriteLine("\nExtracting elements from the Min-Heap:");
            Console.WriteLine("Extracted Minimum: " + minHeap.ExtractMin());
            minHeap.DisplayHeap();

            Console.WriteLine("\nExtracted Minimum: " + minHeap.ExtractMin());
            minHeap.DisplayHeap();
        }
    }
}
