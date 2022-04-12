using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerAlgorithmDesign
{
    public class HeapSortClass
    {

        private static int[] arr = new int[] { 2,4,3,7,5,8,9,11,6,10 };
        public static void Start()
        {
            Console.Write("Before Heap Sort : ");
            Utils.PrintArray(arr);

            Heap heap = new Heap(arr);
            HeapSort(heap);

            Console.Write("After Heap Sort : ");
            Utils.PrintArray(arr);
        }

        private static void HeapSort(Heap heap)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = heap.DeleteMin();
            }
        }

    }
}
