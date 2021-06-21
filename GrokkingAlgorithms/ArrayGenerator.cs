using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    public static class ArrayGenerator
    {
         public static int[] AsOrdered(int arraySize)
        {
            // magic numeric
            // https://docs.microsoft.com/en-us/dotnet/api/system.array?redirectedfrom=MSDN&view=net-5.0
            const int maxSizeArray = 0X7FEFFFFF;

            switch (arraySize)
            {
                case 0:
                    arraySize = 1;
                    break;
                case > maxSizeArray:
                    arraySize = maxSizeArray;
                    break;
                default:
                    break;
            }

            return Enumerable.Range(0, arraySize).ToArray();
        }

    }
}
