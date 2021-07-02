using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LinearSearch
{
    public static class LinearSearch
    {
        public static int Execute(IList<int> items, int searchedValue)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] == searchedValue)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
