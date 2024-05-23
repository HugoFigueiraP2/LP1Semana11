using System;
using System.Collections.Generic;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static object GetTheOnesBefore<T>(IEnumerable<object> items, T value) where T : IComparable
        {
            int count = 0;

            foreach (var item in items)
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