using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    public static class BinarySearch
    {
        public static int? SearchOne(int[] sortedList, int item)
        {
            int low = 0;
            int high = sortedList.Length - 1;
            int mid;


            mid = (high - low) / 2;
            if (sortedList[mid] == item)
            {
                return mid;
            }
            if (sortedList[mid] > item)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }

            return null;
        }
    }
}
