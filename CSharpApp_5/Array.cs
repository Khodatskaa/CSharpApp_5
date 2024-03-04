using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_5
{
    public class Array : IOutput
    {
        private int[] elements;

        public Array(int[] elements)
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
    }
}
