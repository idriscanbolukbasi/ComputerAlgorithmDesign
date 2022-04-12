using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerAlgorithmDesign
{
    public class MergeSortClass
    {

        private static int[] arr = new int[] { 8, 2, 9, 4, 5, 3, 1, 6 };
        
        public static void Start()
        {
            Console.Write("Before Merge Sort : ");
            Utils.PrintArray(arr);

            MergeSort(arr, 0, arr.Length - 1);

            Console.Write("After Merge Sort : ");
            Utils.PrintArray(arr);
        }


        private static void MergeSort(int[] arr, int left, int right)
         {
            if(left < right)
            {

                int middle = (left + right) / 2;

                MergeSort(arr, left, middle);
                MergeSort(arr, middle + 1, right);

                Merge(arr, left, right, middle);
            }

        }

        private static void Merge(int[] arr, int left, int right, int middle)
        {

            int[] leftArr = new int[middle - left + 1];
            int[] rightArr = new int[right - middle];

            for(int i = left; i <= middle; i++)
            {
                leftArr[i - left] = arr[i];
            }

            for(int i = middle + 1; i <= right; i++)
            {
                rightArr[i - middle - 1] = arr[i];
            }

            int leftIndex = 0;
            int rightIndex = 0;
            int index = left;

            while(leftIndex < leftArr.Length && rightIndex < rightArr.Length)
            {
                if(leftArr[leftIndex] < rightArr[rightIndex]) arr[index++] = leftArr[leftIndex++];
                else arr[index++] = rightArr[rightIndex++];
            }

            while(leftIndex < leftArr.Length)
            {
                arr[index++] = leftArr[leftIndex++];
            }

            while(rightIndex < rightArr.Length)
            {
                arr[index++] = rightArr[rightIndex++];
            }
        }
    }
}
