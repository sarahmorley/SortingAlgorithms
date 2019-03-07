using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    class Algorithms
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

            public static List<int> BubbleSort(List<int> sortList2)
            {
                bool swap = true;
                while (swap)
                {
                    swap = false;
                    for (int z = 0; z < sortList2.Count - 1; z++)
                    {
                        if (sortList2[z] > sortList2[z + 1])
                        {
                            var zHolder = sortList2[z];
                            sortList2[z] = sortList2[z + 1];
                            sortList2[z + 1] = zHolder;
                            swap = true;
                        }
                    }
                }

                return sortList2;
            }
        }
    }

