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

            foreach (var item in TestSet)
            {
                Console.Write("{0, 5}", item);
            }
            Console.WriteLine();
            Console.WriteLine($"Number of elements {TestSet.Length}");
        }
    }
}
