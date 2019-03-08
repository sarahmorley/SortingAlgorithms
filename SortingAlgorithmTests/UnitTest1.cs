using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithms;

namespace SortingAlgorithmTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BubbleSortTest()
        {
            var listToSort = new List<int>();
            int[] numbers = { 15, 13, 9, 6, 8, 10, 11, 12};
            listToSort.AddRange(numbers);

            var sortedList = new List<int>();
            int[] numbersInOrder = { 6, 8, 9, 10, 11, 12, 13, 15 };
            sortedList.AddRange(numbersInOrder);

            listToSort = Algorithms.BubbleSort(listToSort);
            CollectionAssert.AreEqual(sortedList, listToSort, StructuralComparisons.StructuralComparer);

        }
    }
}
