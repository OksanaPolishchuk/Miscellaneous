using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintX
{
    public class Print : IPrint
    {
        public void WriteLine(string a)
        {
            Console.WriteLine();
        }
    }
}
