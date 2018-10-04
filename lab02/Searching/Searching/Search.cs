using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    public static class Search
    {

        public static int Binary(int[] sortedArray, int searching)
        {
            int start = 0;
            int end = sortedArray.Length;
            int mid = 0;

            while (!(start >= end))
            {
                mid = start + (end - start) / 2;

                if (sortedArray[mid] == searching)
                    return mid;
                else if (sortedArray[mid] > searching)
                    end = mid;
                else
                    start = mid + 1;
            }

            return -1;
        }

        public static int Interpolation(int[] sortedArray, int searching)
        {
            int start = 0;
            int end = sortedArray.Length - 1;
            
            while (sortedArray[start] < searching && sortedArray[end] > searching)
            {
                int middle = start + ((searching - sortedArray[start]) * (end - start)) / (sortedArray[end] - sortedArray[start]);

                if (sortedArray[middle] < searching)
                    start = middle + 1;
                else if (sortedArray[middle] > searching)
                    end = middle - 1;
                else
                    return middle;
            }

            if (sortedArray[start] == searching)
                return start;
            else if (sortedArray[end] == searching)
                return end;
            else
                return -1;
        }

    }
}
