using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTestMax
{
    public class FindMaximum

    {
        public static string MaximumString(string first,  string Second,  string third)
        {
            if (first.CompareTo(Second) > 0 && first.CompareTo(third) > 0 ||
                first.CompareTo(Second) >= 0 && first.CompareTo(third) >= 0 ||
                first.CompareTo(Second) > 0 && first.CompareTo(third) >= 0)
            {
                return first;
            }

            if (Second.CompareTo(first) > 0 && Second.CompareTo(third) > 0 ||
                Second.CompareTo(first) >= 0 && Second.CompareTo(third) >= 0 ||
                Second.CompareTo(first) < 0 && Second.CompareTo(third) < 0)
            {
                return Second;
            }

            if (third.CompareTo(Second) > 0 && third.CompareTo(first) > 0 ||
                third.CompareTo(Second) >= 0 && third.CompareTo(first) >= 0 ||
                third.CompareTo(Second) > 0 && third.CompareTo(first) >= 0)
            {
                return third;
            }

            return first;
        }
        
    }
}
