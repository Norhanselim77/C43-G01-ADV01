using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_C__Advanced
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }
        public Range(T min, T max)
        {

            if (min.CompareTo(max) > 0)
            {
                throw new ArgumentException("Minimum value must be lessthan or equal to miximum value.");
            }
            this.Min = min;
            this.Max = max;
        }

        public bool ISInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public T Length()
        {
            dynamic min = Min;
            dynamic max = Max;
            return max - min;
        }

        public override string ToString()
        {
            return $"Range: [{Min}, {Max}]";
        }


    }
}