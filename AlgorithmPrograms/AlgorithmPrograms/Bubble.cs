using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class Bubble
    {
        public static void bubbleSort(int[] arr)
        {
            int n=arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        //swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        // print array
        public static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 1, 4, 2, 8 };
            bubbleSort(arr);
            Console.WriteLine("Sorted Array");
            PrintArray(arr);
        }
    }
}
