using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpApp_5
{
    public class ArrayCalculator : ICalc
    {
        public int[] array;

        public ArrayCalculator(int[] inputArray)
        {
            array = inputArray;
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (int element in array)
            {
                if (element < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (int element in array)
            {
                if (element > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }
}