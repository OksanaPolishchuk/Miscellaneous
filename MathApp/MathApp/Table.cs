using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    public class Table
    {
        public void Number(string concat)
        {
            string result1 = Multiplication(2, 1);
            string result2 = Multiplication(2, 2);
            string result3 = Multiplication(2, 3);
            string result4 = Multiplication(2, 4);
            string result5 = Multiplication(2, 5);
            string result6 = Multiplication(2, 6);
            string result7 = Multiplication(2, 7);
            string result8 = Multiplication(2, 8);
            string result9 = Multiplication(2, 9);
            string result10 = Multiplication(2, 10);

            String concatenation = String.Concat($"{result1}\n{result2}\n{result3}\n{result4}\n{result5}\n{result6}\n{result7}\n{result8}\n{result9}\n{result10}");
            Console.WriteLine(concatenation);
        }

        public string Multiplication(int number1, int number2)
        {
            int result = number1 * number2;
            String concat = String.Concat($"{number1} * {number2} = {result}");
            return concat;
        }
    }
}