using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("some text");
            var user = new Printer(new MyConsole(),);
            user.Print("target");
            Console.WriteLine("some text");
            Console.ReadKey();
        }
    }
}
