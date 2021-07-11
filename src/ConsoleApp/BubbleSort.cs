using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.BubbleSort
{
    public static class BubbleSort
    {
        public static void Execute(IList<int> unsorted)
        {
            bool iterationWithoutSwap = false;
            // index of the first item in the last checked pair
            int endIndex = unsorted.Count - 2;

            while ((endIndex >= 0) && (!iterationWithoutSwap))
            {
                iterationWithoutSwap = true;
                for (int i = 0; i <= endIndex; i++)
                {
                    Console.WriteLine($"Comparing {unsorted[i]} and {unsorted[i + 1]}");
                    if (unsorted[i] > unsorted[i +1])
                    {
                        Swap(unsorted, i, i + 1);
                        iterationWithoutSwap = false;
                    }
                }
                endIndex--;
            }
        }

        private static void Swap(IList<int> collection, int firstInd, int secondInd)
        {
            int tmp = collection[firstInd];
            collection[firstInd] = collection[secondInd];
            collection[secondInd] = tmp;
        }
    }
}
