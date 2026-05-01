using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxHeap1
{
    class MaxHeap
    {
        private List<int> heap = new List<int>();

        public void Insert(int value)
        {
            heap.Add(value);
            HeapifyUp(heap.Count - 1);
        }

        private void HeapifyUp(int index)
        {
            while(index > 0)
            {
                int parentIndex = (index - 1) / 2;

                if (heap[index] <= heap[parentIndex]) break;//if parent index is greater than or equal to the current index, stop heapifying up

                (heap[index], heap[parentIndex]) = (heap[parentIndex], heap[index]);

                index = parentIndex;
            }
        }

        public int Peek()
        {
            // Check if the heap is empty
            if (heap.Count == 0)
            {
                throw new InvalidOperationException("Heap is empty.");
            }

            // Return the element at the root of the heap, which is the maximum element in a Max-Heap
            return heap[0];
        }

        public int ExtractMax()
        {
            if (heap.Count == 0)
            {
                throw new InvalidOperationException("Heap is empty.");
            }
            int max = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            HeapifyDown(0);
            return max;
        }

        private void HeapifyDown(int index)
        {
            while (index < heap.Count)
            {
                int largest = index;
                int leftChild = 2 * index + 1;
                int rightChild = 2 * index + 2;

                if (leftChild < heap.Count && heap[leftChild] > heap[largest])//get the max
                {
                    largest = leftChild;
                }

                if (rightChild < heap.Count && heap[rightChild] > heap[largest])
                {
                    largest = rightChild;
                }

                if (largest == index) break;//if the largest is the current index, stop heapifying down

                (heap[index], heap[largest]) = (heap[largest], heap[index]);
                index = largest;
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
            MaxHeap maxHeap = new MaxHeap();

            Console.WriteLine("Inserting elements into the Max-Heap...\n");
            maxHeap.Insert(10);
            maxHeap.Insert(4);
            maxHeap.Insert(15);
            maxHeap.Insert(2);
            maxHeap.Insert(8);

            // Display the heap after insertion
            maxHeap.DisplayHeap();

            Console.WriteLine("\nPeek Maximum Element: Maximum Element is: " + maxHeap.Peek());

            // Display the heap after insertion, note that the maximum value is not deleted.
            maxHeap.DisplayHeap();

            // Extract elements based on priority
            Console.WriteLine("\nExtracting elements from the Max-Heap:");
            Console.WriteLine("Extracted Maximum: " + maxHeap.ExtractMax());
            maxHeap.DisplayHeap();

            Console.WriteLine("\nExtracted Maximum: " + maxHeap.ExtractMax());
            maxHeap.DisplayHeap();
        }
    }
}
