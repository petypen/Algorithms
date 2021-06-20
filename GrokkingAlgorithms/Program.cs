using System;

namespace GrokkingAlgorithms
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            int[] TestSet = ArrayGenerator.AsOrdered(0);
            Console.WriteLine(TestSet.Length);
        }
    }
}
