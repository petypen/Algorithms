﻿using System;

namespace GrokkingAlgorithms
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            int[] TestSet = ArrayGenerator.AsOrdered(int.MaxValue);
            Console.WriteLine(TestSet.Length);
        }
    }
}
