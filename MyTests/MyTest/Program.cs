using System;
using System.Collections.Generic;

namespace MyTest
{
    class Program
    {
        static void Main(string[] args)
        { 
            var name = Console.ReadLine();
            Person person = new Person("Polishchuk", "Oksana");
            //person.SetName("Oksana");
            person.Name = "Oksana";

            Console.WriteLine(person.Name);
            Console.ReadLine();
        }
    }
} 