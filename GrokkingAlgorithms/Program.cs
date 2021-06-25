using System;

namespace GrokkingAlgorithms
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            int[] TestSet = ArrayGenerator.AsOrdered(0);
            ArrayGenerator.AsMixed(ref TestSet);

            (int?, int) resullt;
            resullt = BinarySearch.SearchOne(ArrayGenerator.AsOrdered(1_000_000), 873_999);
            Console.WriteLine($"Element {resullt.Item1??0} number of iteration {resullt.Item2}");

            Console.WriteLine();
        }
    }
}
