using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTestMax
{
    public class FindMaximum
    {
        public class testCases<T> where T : IComparable
        {

            public T maxi(T a, T b, T c)
            {
                if (a.CompareTo(b) == 1 && a.CompareTo(c) == 1)
                    return a;
                if (b.CompareTo(a) == 1 && b.CompareTo(c) == 1)
                    return b;
                if (c.CompareTo(a) == 1 && c.CompareTo(b) == 1)
                    return c;
                return a;

            }

        }
    }
}

