using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static IEnumerable GetTheOnesBefore<T>(IEnumerable<T> items, double number) where T : IComparable
        {

            foreach (object item in items)
            {
                if (item is T itemT && itemT.CompareTo(value) < 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}