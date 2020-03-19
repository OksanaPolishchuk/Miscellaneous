using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
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

           // Console.WriteLine(concatenation);
            return concatenation;
        }

        public string Multiplication(int a, int b)
        {
            int result = a * b;
            string concat = ($"{a} * {b} = {result}");

            return concat;
        }

        public void CreateRecord(string value)
        {
            var folder = @"C:\Work1";
            DirectoryInfo d = Directory.CreateDirectory(folder);
            Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(folder));

            string path = @"C:\Work1\Concat.txt";

            string text = Number() + Environment.NewLine;

            if (!File.Exists(path))
            {
                File.WriteAllText(path, text, Encoding.UTF8);
            }
            else
            {
                string appendText = Number() + Environment.NewLine;
                File.AppendAllText(path, appendText, Encoding.UTF8);
            }

            string readText = File.ReadAllText(path);

            Console.WriteLine(readText);
        }
    }
}