using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_5
{
    public interface IOutput
    {
        void Show();
        void Show(string info);
    }
}