using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ArrayGenerator
    {
        internal static int[] AsOrdered(uint arraySize)
        {
            // magic numeric
            // https://docs.microsoft.com/en-us/dotnet/api/system.array?redirectedfrom=MSDN&view=net-5.0
            const int maxSizeArray = 0X7FEFFFFF;

            int[] ArrayResult;

            switch (arraySize)
            {
                case 0:
                    ArrayResult = new int[1];
                    break;
                case < maxSizeArray:
                    ArrayResult = new int[arraySize];
                    break;
                default:
                    ArrayResult = new int[maxSizeArray];
                    arraySize = maxSizeArray;
                    break;
            }

            for (int i = 0; i < arraySize; i++)
            {
                ArrayResult[i] = i;
            }

            return ArrayResult;
        }

    }
}
