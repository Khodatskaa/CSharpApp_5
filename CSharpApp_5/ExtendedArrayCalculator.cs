using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpApp_5
{
    public class ExtendedArrayCalculator : ArrayCalculator, IOutput2
    {
        public ExtendedArrayCalculator(int[] inputArray) : base(inputArray)
        {
        }

        public void ShowEven()
        {
            Console.WriteLine("Even Values:");
            foreach (int element in array)
            {
                if (element % 2 == 0)
                {
                    Console.Write(element + " ");
                }
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            Console.WriteLine("Odd Values:");
            foreach (int element in array)
            {
                if (element % 2 != 0)
                {
                    Console.Write(element + " ");
                }
            }
            Console.WriteLine();
        }
    }

}
