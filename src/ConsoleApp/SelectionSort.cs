using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.SelectionSort
{
    public static class SelectionSort
    {
        public static void Execute(IList<int> unsorted)
        {
            for (int i = 0; i < unsorted.Count - 1; i++)
            {
                int indexOfMinValue = i;

                // j=i+1 -> can omit first item because it would compare it with itself
                for (int j = i + 1; j < unsorted.Count; j++)
                {
                    // new minimum
                    if (unsorted[j] < unsorted[indexOfMinValue])
                    {
                        indexOfMinValue = j;
                    }
                }

                Swap(unsorted, i, indexOfMinValue);
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
