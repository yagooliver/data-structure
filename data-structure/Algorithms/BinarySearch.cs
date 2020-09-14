using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class BinarySearch
    {
        public static int SearchUsingBinary(int[] array, int value)
        {
            int low = 0;
            int high = array.Length;
            while (low < high)
            {
                int mid = (low + high) / 2;

                if (array[mid] == value)
                    return mid;
                if (array[mid] < value)
                    low = mid + 1;
                else
                    high = mid;
            }

            return -1;
        }
    }
}

