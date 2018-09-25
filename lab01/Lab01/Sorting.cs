using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public static class Sorting
    {

        public static void QuickSort(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }

        private static void QuickSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(arr, start, end);
                QuickSort(arr, start, pivot - 1);
                QuickSort(arr, pivot + 1, end);
            }
        }

        private static int Partition(int[] arr, int start, int end)
        {
            int marker = start;
            int pivot = end;
            for (int i = start; i < end; i++)
            {
                if (arr[i] < arr[pivot])
                {
                    Swap(ref arr[i], ref arr[marker]);
                    marker++;
                }
            }
            Swap(ref arr[marker], ref arr[pivot]);
            return marker;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void HybridSort(int[] arr, int k)
        {
            HybridSort(arr, 0, arr.Length - 1, k);
        }

        public static void HybridSort(int[] arr, int start, int end, int k)
        {
            if (start < end)
            {
                if (end - start > k)
                {
                    int pivot = Partition(arr, start, end);
                    HybridSort(arr, start, pivot - 1, k);
                    HybridSort(arr, pivot + 1, end, k);
                }
                else
                {
                    InsertionSort(arr, start, end);
                }
            }
        }

        private static void InsertionSort(int[] arr, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                int j = i - 1;
                while (j >= 0 && arr[j] > arr[j + 1])
                {
                    Swap(ref arr[j], ref arr[j + 1]);
                    j--;
                }
            }
        }

        public static void MergeSort(int[] arr, int start, int end)
        {

        }

    }
}
