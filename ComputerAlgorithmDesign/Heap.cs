using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerAlgorithmDesign
{
    public class Heap
    {
        private int[] arr { get; set; }
        private int capacity { get; set; }
        private int heapSize { get; set; }

        public static void Test()
        {
            Heap heap = new Heap(11);
            heap.Insert(2);
            heap.Insert(4);
            heap.Insert(3);
            heap.Insert(7);
            heap.Insert(5);
            heap.Insert(8);
            heap.Insert(9);
            heap.Insert(11);
            heap.Insert(9);
            heap.Insert(6);
            heap.Insert(10);

            Console.Write("Before Heap Operations : ");
            Utils.PrintArray(heap.GetArray(), heap.GetHeapSize());

            heap.DeleteMin();
            heap.IncreaseKey(1, 6);

            Console.Write("After Heap Operations : ");
            Utils.PrintArray(heap.GetArray(), heap.GetHeapSize());
        }

        public Heap(int capacity)
        {
            this.capacity = capacity;
            arr = new int[capacity];
            heapSize = 0;
        }

        public Heap(int[] array)
        {
            arr = new int[array.Length];
            for(int i = 0; i < array.Length; i++)
            {
                arr[i] = array[i];
            }
            capacity = array.Length;
            heapSize = array.Length;
            BuildHeap(heapSize);
        }

        public int[] GetArray()
        {
            return arr;
        }

        public void Insert(int key)
        {
            if (heapSize == capacity) return;

            int i = heapSize;
            arr[heapSize++] = key;

            while (i != 0 && arr[i] < arr[Parent(i)])
            {
                Utils.Swap(arr, i, Parent(i));
                i = Parent(i);
            }
        }

        public int DeleteMin()
        {
            if (heapSize == 1)
            {
                heapSize--;
                return arr[0];
            }

            int root = arr[0];
            arr[0] = arr[heapSize - 1];
            heapSize--;

            Heapify(0);

            return root;
        }

        private void Heapify(int index)
        {
            int left = Left(index);
            int right = Right(index);

            int smallest = index;

            if (left < heapSize && arr[left] < arr[smallest]) smallest = left;
            if (right < heapSize && arr[right] < arr[smallest]) smallest = right;
        
            if(smallest != index)
            {
                Utils.Swap(arr, index, smallest);
                Heapify(smallest);
            }
        }

        public void DecreaseKey(int index, int value)
        {
            arr[index] -= value;

            while(index != 0 && arr[index] < arr[Parent(index)])
            {
                Utils.Swap(arr, index, Parent(index));
                index = Parent(index);
            }
        }

        public void IncreaseKey(int index, int value)
        {
            arr[index] += value;

            Heapify(index);
        }

        private void BuildHeap(int index)
        {
            for(int i = Parent(index); i >= 0; i--)
            {
                Heapify(i);
            }
        }

        private int Parent(int index)
        {
            return (index - 1) / 2;
        }

        private int Left(int index)
        {
            return 2 * index + 1;
        }

        private int Right(int index)
        {
            return 2 * index + 2;
        }

        public int GetMin()
        {
            return arr[0];
        }

        public int GetHeapSize()
        {
            return heapSize;
        }
    }
}
