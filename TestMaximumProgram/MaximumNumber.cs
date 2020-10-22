using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximumProgram
{
    public class MaximumNumber<T> where T : IComparable
    {
        T[] values;
        public MaximumNumber(T[] values)
        {
            this.values = values;
        }
        public T GetMaximumValue()
        {
            Array.Sort(values);
            return values[values.Length - 1];
        }
    }
}
