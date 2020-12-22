using System;
using System.Collections.Generic;
using System.Text;

namespace Features.MyLinq
{
    public static class MyLinq
    {
        // Count is a generic method denoted by type <T>. The 'this' keyword in parameter allows for use of the count method wherever there is an IEnumerable<T>
        public static int Count<T>(this IEnumerable<T> sequence)
        {
            int count = 0;
            foreach (var item in sequence)
            {
                count += 1;
            }
            return count;
        }
    }
}
