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
            Assert.Equal<int>((int)arraySize, testArray.Length);
            for (int i = 0; i < arraySize; i++)
            {
                Assert.Equal<int>(testArray[i], i);
            }
        }

        [Fact]
        public void AsOrder_0()
        {
            // arrange
            uint arraySize = 0;
            int[] testArray;

            // act
            testArray = ArrayGenerator.AsOrdered(arraySize);

            // assert
            Assert.Single(testArray);
            Assert.Equal<int>(0, testArray[0]);
        }

        [Fact]
        public void AsOrder_Max()
        {
            // arrange
            uint arraySize = uint.MaxValue;
            int[] testArray;
            const int maxSizeArray = 0X7FEFFFFF;

            // act
            testArray = ArrayGenerator.AsOrdered(arraySize);

            // assert
            Assert.Equal(maxSizeArray, testArray.Length);
            for (int i = 0; i < maxSizeArray; i++)
            {
                Assert.Equal<int>(testArray[i], i);
            }
        }

    }
}
