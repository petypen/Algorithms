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
            Assert.Equal<int>(arraySize, testArray.Length);
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
            Assert.Equal<int>(maxSizeArray, testArray.Length);
            Assert.True(testArray.SequenceEqual(Enumerable.Range(0, maxSizeArray).ToArray()));
        }

        [Fact]
        public void AsMixed_100()
        {
            // arrange
            int arraySize = 100;
            int[] testArray;

            // act
            testArray = ArrayGenerator.AsOrdered(arraySize);
            ArrayGenerator.AsMixed(ref testArray);

            // assert
            Assert.Equal<int>(arraySize, testArray.Length);
            Assert.False(testArray.SequenceEqual(Enumerable.Range(0, arraySize).ToArray()));
        }

        [Fact]
        public void AsMixed_0()
        {
            // arrange
            int arraySize = 0;
            int[] testArray;

            // act
            testArray = ArrayGenerator.AsOrdered(arraySize);
            ArrayGenerator.AsMixed(ref testArray);

            // assert
            Assert.Single(testArray);
            Assert.Equal<int>(0, testArray[0]);
        }

        [Fact]
        public void AsMixed_Max()
        {
            // arrange
            int arraySize = int.MaxValue;
            int[] testArray;
            const int maxSizeArray = 0X7FEFFFFF;

            // act
            testArray = ArrayGenerator.AsOrdered(arraySize);
            ArrayGenerator.AsMixed(ref testArray);

            // assert
            Assert.Equal<int>(maxSizeArray, testArray.Length);
            Assert.False(testArray.SequenceEqual(Enumerable.Range(0, maxSizeArray).ToArray()));
        }

        [Fact]
        public void SearchOne_100_66()
        {
            // arange
            int[] sortedList = ArrayGenerator.AsOrdered(100);
            int item = 66;

            // act
            int? result = BinarySearch.SearchOne(sortedList, item);

            // assert
            Assert.Equal<int>(item, result ?? 0 );
        }

        [Fact]
        public void SearchOne_100_117()
        {
            // arange
            int[] sortedList = ArrayGenerator.AsOrdered(100);
            int item = 117;

            // act
            int? result = BinarySearch.SearchOne(sortedList, item);

            // assert
            Assert.Null(result);
        }

    }
}
