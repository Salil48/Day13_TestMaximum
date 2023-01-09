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
            public T[] value;

            public testCases(T[] value)
            {
                this.value = value;
            }
            public T[] Sort(T[] values)
            {
                Array.Sort(values);
                return values;
            }
            public T Maxvalue(params T[] values)
            {
                var sort_val = Sort(values);
                return sort_val[^1];
            }
            public T Maxmethod()
            {
                var max = Maxvalue(this.value);
                return max;
            }
            public void toPrint()
            {
                var max = Maxvalue(this.value);
                Console.WriteLine("The Maximum value is :" + max);
            }
        }

    }
}
