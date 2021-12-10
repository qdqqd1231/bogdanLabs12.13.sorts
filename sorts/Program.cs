using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorts
{
    class Program
    {
        public static void ShellSort(int[] Array)
        {
            int step = Array.Length / 2;
            while (step > 0)
            {
                int i, j;
                for (i = step; i < Array.Length; i++)
                {
                    int value = Array[i];
                    for (j = i - step; (j >= 0) && (Array[j] > value); j -= step)
                        Array[j + step] = Array[j];
                    Array[j + step] = value;
                }
                step /= 2;
            }
        }
        public static void BubbleSort(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
        public static int Partition(int[] Array, int start, int end)
        {
            int temp;
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                if (Array[i] < Array[end]) 
                {
                    temp = Array[marker];
                    Array[marker] = Array[i];
                    Array[i] = temp;
                    marker += 1;
                }
            }
            temp = Array[marker];
            Array[marker] = Array[end];
            Array[end] = temp;
            return marker;
        }

        public static void QuickSort(int[] Array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = Partition(Array, start, end);
            QuickSort(Array, start, pivot - 1);
            QuickSort(Array, pivot + 1, end);
        }
        public static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int cur = array[i];
                int j = i;
                while (j > 0 && cur < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = cur;
            }
        }
        public static void SelectionSort(int[] Array)
        {
            for (int i = 0; i < Array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[j] < Array[min])
                    {
                        min = j;
                    }
                }
                int dummy = Array[i];
                Array[i] = Array[min];
                Array[min] = dummy;
                min = i;
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };
            Console.WriteLine("BubbleSort:");
            BubbleSort(arr);
            Console.WriteLine("Shell sort :");
            ShellSort(arr);
            Console.WriteLine("quick sort: ");
            QuickSort(arr, 0, 7);
            Console.WriteLine("selection sort :");
            SelectionSort(arr);
            Console.WriteLine("insertion sort");
            InsertionSort(arr);
        }
    }
}
