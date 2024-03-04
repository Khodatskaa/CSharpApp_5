using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpApp_5
{
    public class ExtendedArrayCalculator2 : ArrayCalculator, ICalc2
    {
        public ExtendedArrayCalculator2(int[] inputArray) : base(inputArray)
        {
        }

        public int CountDistinct()
        {
            HashSet<int> distinctValues = new HashSet<int>(array);
            return distinctValues.Count;
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            foreach (int element in array)
            {
                if (element == valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }

}
