using System;

namespace TestMaximumProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("Enter 3 integers");
            int firstInteger = Convert.ToInt32(Console.ReadLine());
            int secondInteger = Convert.ToInt32(Console.ReadLine());
            int thirdInteger = Convert.ToInt32(Console.ReadLine());
            MaximumNumber maximumValue = new MaximumNumber();
            int maximumNumber = maximumValue.GetMaximumInteger(firstInteger, secondInteger, thirdInteger);
            Console.WriteLine("The maximum Integer is: " + maximumNumber);

            Console.WriteLine("Enter 3 decimal values");
            double firstDouble = Convert.ToDouble(Console.ReadLine());
            double secondDouble = Convert.ToDouble(Console.ReadLine());
            double thirdDouble = Convert.ToDouble(Console.ReadLine());
            double maximumDouble = maximumValue.GetMaximumFloat(firstDouble, secondDouble, thirdDouble);
            Console.WriteLine("The maximim Float Value is: " + maximumDouble);
        }
    }
}
