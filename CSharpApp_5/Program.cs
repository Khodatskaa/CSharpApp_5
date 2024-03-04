namespace CSharpApp_5
{
    internal class Program
    {
        static void Main()
        {
            int[] testArray = { 2, 5, 8, 12, 15, 18, 22, 25 };
            ArrayCalculator arrayCalculator = new ArrayCalculator(testArray);

            int lessCount = arrayCalculator.Less(20);
            int greaterCount = arrayCalculator.Greater(10);

            Console.WriteLine("Number of elements less than 20: " + lessCount);
            Console.WriteLine("Number of elements greater than 10: " + greaterCount);
        }
    }
}
