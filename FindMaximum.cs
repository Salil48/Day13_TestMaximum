using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTestMax
{
    public class FindMaximum

    {
        public static float MaximumFloatNumber(float firstValue,  float SecondValue,  float thirdValue)
        {
            if (firstValue.CompareTo(SecondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(SecondValue) >= 0 && firstValue.CompareTo(thirdValue) >= 0 ||
                firstValue.CompareTo(SecondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }

            if (SecondValue.CompareTo(firstValue) > 0 && SecondValue.CompareTo(thirdValue) > 0 ||
                SecondValue.CompareTo(firstValue) >= 0 && SecondValue.CompareTo(thirdValue) >= 0 ||
                SecondValue.CompareTo(firstValue) < 0 && SecondValue.CompareTo(thirdValue) < 0)
            {
                return SecondValue;
            }

            if (thirdValue.CompareTo(SecondValue) > 0 && thirdValue.CompareTo(firstValue) > 0 ||
                thirdValue.CompareTo(SecondValue) >= 0 && thirdValue.CompareTo(firstValue) >= 0 ||
                thirdValue.CompareTo(SecondValue) > 0 && thirdValue.CompareTo(firstValue) >= 0)
            {
                return thirdValue;
            }

            return firstValue;
        }
        
    }
}
