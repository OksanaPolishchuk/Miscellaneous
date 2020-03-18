using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    public class Table
    {
        public string Number()
        {
            string concatenation = "";

            for (int counter = 0; counter <= 10; counter++)
            {
                string result1 = Multiplication(2, counter);
                concatenation = string.Concat(concatenation, $"{result1}\n");
            }

            Console.WriteLine(concatenation);
            return concatenation;
        }

        public string Multiplication(int a, int b)
        {
            int result = a * b;
            string concat = ($"{a} * {b} = {result}");

            return concat;
        }
    }
}