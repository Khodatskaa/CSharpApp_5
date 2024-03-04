using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_5
{
    public class CustomArray : IOutput, IMath, ISort
    {
        private int[] elements;

        public CustomArray(int[] elements)
        {
            this.elements = elements;
        }

        public void Show()
        {
            Console.WriteLine(string.Join(", ", elements));
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
            Show();
        }

        public int Max()
        {
            return elements.Max();
        }

        public int Min()
        {
            return elements.Min();
        }

        public float Avg()
        {
            return (float)elements.Average();
        }

        public bool Search(int valueToSearch)
        {
            return elements.Contains(valueToSearch);
        }

        public void SortAsc()
        {
            Array.Sort(elements);
        }

        public void SortDesc()
        {
            Array.Sort(elements);
            Array.Reverse(elements);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }
    }
}
