using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01C_Advanced.Q02
{
    internal class Range<T> where T: IComparable<T>
    {

        public T MinValue { get; set; }
        public T MaxValue { get; set; }

        //public T RangeValue { get; set; }
        public Range(T minValue, T maxValue)
        {            
            if(minValue.CompareTo(maxValue) <0)
            {
                MinValue = minValue;
                MaxValue = maxValue;
            }
            else
                Console.WriteLine("MinValue Must be less MaxValue ");    
        }

        public bool ISInRange( T value)
        {
            
            // 1. If( value > minValue) = +ve  &&  >=0
            // 2. If(value < maxValue ) = -ve &&  <= 0

            return value.CompareTo(MinValue) >= 0 && value.CompareTo(MaxValue) <= 0;
        }


        public int Length()
        {
            int min = Convert.ToInt32(MinValue);
            int max = Convert.ToInt32(MaxValue);
            return max - min;
        }
    }


}
