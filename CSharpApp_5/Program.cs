namespace CSharpApp_5
{
    internal class Program
    {
        static void Main()
        {
            CustomArray myCustomArray = new CustomArray(new int[] { 10, 5, 8, 15, 3 });

            Console.WriteLine("Array elements:");
            myCustomArray.Show();

            Console.WriteLine($"\nMax value: {myCustomArray.Max()}");
            Console.WriteLine($"Min value: {myCustomArray.Min()}");
            Console.WriteLine($"Average value: {myCustomArray.Avg()}");

            int valueToSearch = 8;
            bool searchResult = myCustomArray.Search(valueToSearch);
            Console.WriteLine($"Search for {valueToSearch}: {searchResult}");
        }
    }
}
