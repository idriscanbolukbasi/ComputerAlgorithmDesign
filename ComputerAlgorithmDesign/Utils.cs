using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerAlgorithmDesign
{
    public class Utils
    {

        public static void PrintArray(int[] arr)
        {
            Console.Write("{ ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + (i == arr.Length - 1 ? " " : ", "));
            }
            Console.Write("}\n");
        }
        
        public static void PrintArray(int[] arr, int length)
        {
            Console.Write("{ ");
            for(int i = 0; i < length; i++)
            {
                Console.Write(arr[i] + (i == length - 1 ? " " : ", "));
            }
            Console.Write("}\n");
        }

        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}
