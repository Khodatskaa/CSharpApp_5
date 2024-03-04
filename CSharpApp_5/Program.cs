namespace CSharpApp_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array myArray = new Array(new int[] { 1, 2, 3, 4, 5 });

            Console.WriteLine("Displaying array elements:");
            myArray.Show();

            Console.WriteLine("\nDisplaying array elements with an information message:");
            myArray.Show("Here are the elements of the array:");
        }
    }
}
