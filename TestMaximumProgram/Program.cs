using System;

namespace TestMaximumProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values;
            int[] integerValues = new int[100];
            Console.WriteLine("Enter integers seperated by comma");
            values = Console.ReadLine().Split(",");
            for (int i = 0; i < values.Length; i++)
            {
                integerValues[i] = Convert.ToInt32(values[i]);
            }
            MaximumNumber<int> maximumInt = new MaximumNumber<int>(integerValues);
            maximumInt.DisplayMaximumNumber();


            double[] doubleValues = new double[100];
            Console.WriteLine("Enter decimal numbers seperated by comma");
            values = Console.ReadLine().Split(",");
            for (int i = 0; i < values.Length; i++)
            {
                doubleValues[i] = Convert.ToDouble(values[i]);
            }
            MaximumNumber<double> maximumDouble = new MaximumNumber<double>(doubleValues);
            maximumDouble.DisplayMaximumNumber();


            Console.WriteLine("Enter Strings seperated by comma");
            values = Console.ReadLine().Split(",");
            MaximumNumber<string> maximumString = new MaximumNumber<string>(values);
            string maxString = maximumString.GetMaximumValue();
            maximumString.DisplayMaximumNumber();
        }
    }

}
