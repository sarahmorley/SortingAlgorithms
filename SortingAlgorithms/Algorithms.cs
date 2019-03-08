using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    public class Algorithms
    {
        static void Main(string[] args)
        {
            var sortList = new List<int>();
            int[] numbers = { 2, 2, 5, 3, 1, 7, 6, 1, 8, 9 };
            sortList.AddRange(numbers);

            sortList = BubbleSort(sortList);
            foreach (var number in sortList)
            {
                Console.Write(number + " ");
            }

            Console.ReadLine();
        }

        public static List<int> BubbleSort(List<int> sortList)
        {
            bool swap = true;
            while (swap)
            {
                swap = false;
                for (int z = 0; z < sortList.Count - 1; z++)
                {
                    if (sortList[z] > sortList[z + 1])
                    {
                        var zHolder = sortList[z];
                        sortList[z] = sortList[z + 1];
                        sortList[z + 1] = zHolder;
                        swap = true;
                    }
                }
            }

            return sortList;
        }

        public static List<int> InsertionSort(List<int> sortList)
        {
            //How does this work? 

            return sortList;
        }
    }
}

