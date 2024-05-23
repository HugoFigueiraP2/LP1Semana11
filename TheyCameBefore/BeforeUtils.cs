using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static IEnumerable GetTheOnesBefore<T>(IEnumerable<T> items, T number) where T : IComparable<T>
        {

            foreach (T item in items)
            {
                if (item.CompareTo(number) < 0)
                {
                    yield return item;
                }
            }

            
        }
    }
}