using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.BinarySearch
{
    public static class BinarySearch
    {
        public static int Execute(IList<int> items, int searchedValue)
        {
            int l = 0;
            int r = items.Count - 1;
            int mid;

            while (l != r)
            {
                mid = (l + r) / 2;

                if (items[mid] == searchedValue)
                {
                    return mid;
                }
                else if (items[mid] > searchedValue)
                {
                    // left
                    r = mid - 1;
                }
                else
                {
                    // right
                    l = mid + 1;
                }
            }

            if (items[l] == searchedValue)
            {
                return l;
            }
            return -1;
        }

        public static int ExecuteRecursive(IList<int> items, int searchedValue, int l = 0, int? rp = null)
        {
            int r = rp ?? items.Count;

            if (l != r)
            {
                int mid = (l + r) / 2;

                if (items[mid] == searchedValue)
                {
                    return mid;
                }
                else if (items[mid] > searchedValue)
                {
                    // left
                    return ExecuteRecursive(items, searchedValue, l, mid - 1);
                }
                else
                {
                    // right
                    return ExecuteRecursive(items, searchedValue, mid + 1, r);
                }
            }
            else
            {
                if (items[l] == searchedValue) return l;
                return -1;
            }
        }
    }
}
