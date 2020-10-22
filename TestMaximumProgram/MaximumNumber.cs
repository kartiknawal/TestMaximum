﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximumProgram
{
    public class MaximumNumber
    {
        public int GetMaximumInteger(int firstInteger, int secondInteger, int thirdInteger)
        {
            if (firstInteger.CompareTo(secondInteger) > 0 && firstInteger.CompareTo(thirdInteger) > 0)
                return firstInteger;
            if (secondInteger.CompareTo(firstInteger) > 0 && secondInteger.CompareTo(thirdInteger) > 0)
                return secondInteger;
            if (thirdInteger.CompareTo(firstInteger) > 0 && thirdInteger.CompareTo(secondInteger) > 0)
                return thirdInteger;
            throw new Exception("Numbers are same. Please enter different numbers");
        }

        public double GetMaximumFloat(double firstDouble, double secondDouble, double thirdDouble)
        {
            if (firstDouble.CompareTo(secondDouble) > 0 && firstDouble.CompareTo(thirdDouble) > 0)
                return firstDouble;
            if (secondDouble.CompareTo(firstDouble) > 0 && secondDouble.CompareTo(thirdDouble) > 0)
                return secondDouble;
            if (thirdDouble.CompareTo(firstDouble) > 0 && thirdDouble.CompareTo(secondDouble) > 0)
                return thirdDouble;
            throw new Exception("Numbers are same. Please enter different numbers");
        }

        public string GetMaximumString(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 || firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0 || firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0)
                return firstString;
            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0 || secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) > 0 || secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0)
                return secondString;
            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0 || thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(secondString) > 0 || thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) >= 0)
                return thirdString;
            throw new Exception("All three strings are equal");
        }
    }
}
