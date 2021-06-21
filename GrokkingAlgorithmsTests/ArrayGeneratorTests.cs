using System;
using Xunit;
using GrokkingAlgorithms;
using System.Linq;

namespace GrokkingAlgorithmsTests
{
    public class ArrayGeneratorTests
    {
        [Fact]
        public void AsOrder_100()
        {
            // arrange
            int arraySize = 100;
            int[] testArray;

            // act
            testArray = ArrayGenerator.AsOrdered(arraySize);

            // assert
            Assert.Equal<int>((int)arraySize, testArray.Length);
            Assert.True(testArray.SequenceEqual(Enumerable.Range(0, arraySize).ToArray()));
        }

        [Fact]
        public void AsOrder_0()
        {
            // arrange
            int arraySize = 0;
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
            int arraySize = int.MaxValue;
            int[] testArray;
            const int maxSizeArray = 0X7FEFFFFF;

            // act
            testArray = ArrayGenerator.AsOrdered(arraySize);

            // assert
            Assert.Equal(maxSizeArray, testArray.Length);
            Assert.True(testArray.SequenceEqual(Enumerable.Range(0, maxSizeArray).ToArray()));
        }

    }
}
