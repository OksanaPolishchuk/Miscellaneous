using System;

namespace DelegateApp
{
    public delegate void MyDelegate();
    public delegate int ValueDelegate(int i);
    
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = TestMethod;
            myDelegate += SecondMethod;
            myDelegate();

            MyDelegate seconDelegate = new MyDelegate(SecondMethod);
            seconDelegate.Invoke();

            seconDelegate -= seconDelegate; // delete method from delegate

            MyDelegate testdelegate = myDelegate + seconDelegate; // two delegate in one
            testdelegate.Invoke();

            var valueDelegate = new ValueDelegate(ValueMethod);
            valueDelegate += ValueMethod; // return last resold
            valueDelegate(new Random().Next(10, 50));

            Action<int> action = VoidValueMethod; // 0 - 16 arguments 

            Predicate<int> predicate; // return bool

            Func<string, double, int> func; //1-16 argument. the last arg is return type(int or any other)
            
            Console.ReadLine();
        }
        public static void TestMethod()
        {
            Console.WriteLine("TestMethod");
        }
        public static void SecondMethod()
        {
            Console.WriteLine("TestMethod");
        }

        public static int ValueMethod(int i)
        {
            Console.WriteLine(i);
            return i;
        }
        public static void VoidValueMethod(int i)
        {
            Console.WriteLine(i);
        }
    } 
}