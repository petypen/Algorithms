using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    public static class BinarySearch
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sortedList"> отсортированный массив, в котром производится бинарный поиск </param>
        /// <param name="item"> искомое число </param>
        /// <returns>
        ///     * индекс элемента массива с найденным значением или null, есзи значение не найдено
        ///     * количество итераций, за которое был найден результат
        /// </returns>
        public static (int?, int) SearchOne(int[] sortedList, int item)
        {
            int numberOfIteration = 0;
            int low = 0;
            int high = sortedList.Length - 1;
            int mid;


            while (low <= high)
            {
                numberOfIteration++;
                mid = (high + low) / 2;
                if (sortedList[mid] == item)
                {
                    return (mid, numberOfIteration);
                }
                if (sortedList[mid] > item)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return (null, numberOfIteration);
        }
    }
}
