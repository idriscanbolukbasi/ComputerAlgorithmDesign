using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerAlgorithmDesign
{
    public class QuickSortClass
    {
        private static int[] arr = new int[] { 9, 16, 4, 15, 2, 5, 17, 1 };
        public static void Start()
        {
            

            Console.Write("Before Quick Sort : ");
            Utils.PrintArray(arr);

            QuickSort(arr, 0, arr.Length - 1);

            Console.Write("After Quick Sort : ");
            Utils.PrintArray(arr);

        }
        private static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                QuickSort(arr, left, pivot - 1);
                QuickSort(arr, pivot + 1, right);
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];

            int i = left - 1;

            for (int j = left; j <= right - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Utils.Swap(arr, i, j);
                }
            }

            Utils.Swap(arr, i + 1, right);
            return i + 1;
        }

        
    }
}
