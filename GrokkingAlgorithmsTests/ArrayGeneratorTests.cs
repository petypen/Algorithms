using System;
using Xunit;
using GrokkingAlgorithms;

namespace GrokkingAlgorithmsTests
{
    public class ArrayGeneratorTests
    {
        [Fact]
        public void AsOrder_100()
        {
            // arrange
            uint arraySize = 100;
            int[] testArray;

            // act
            testArray = ArrayGenerator.AsOrdered(arraySize);

            // assert
            Assert.Equal<int>(testArray.Length, (int)arraySize);
            for (int i = 0; i < arraySize; i++)
            {
                Assert.Equal<int>(testArray[i], i);
            }
        }
    }
}
