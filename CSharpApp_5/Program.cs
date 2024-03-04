using System;

namespace CSharpApp_5
{
    class Program
    {
        static void Main()
        {
            int[] testArray = { 2, 5, 8, 12, 15, 18, 22, 25 };
            ExtendedArrayCalculator extendedArrayCalculator = new ExtendedArrayCalculator(testArray);

            int lessCount = extendedArrayCalculator.Less(20);
            int greaterCount = extendedArrayCalculator.Greater(10);

            Console.WriteLine("Number of elements less than 20: " + lessCount);
            Console.WriteLine("Number of elements greater than 10: " + greaterCount);

            extendedArrayCalculator.ShowEven();
            extendedArrayCalculator.ShowOdd();
        }
    }

}
