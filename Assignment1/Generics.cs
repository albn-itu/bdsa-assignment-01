using System;
using System.Collections.Generic;

namespace Assignment1 {
    public class Generics {
        public static int GreaterCount<T, U>(IEnumerable<T> items, T x)
            where T : U
            where U : IComparable<U>
        {
            int count = 0;

            foreach (var item in items)
            {
                if (item.CompareTo(x) == 1) {
                    count++;
                }
            }

            return count;
        }
    }
}