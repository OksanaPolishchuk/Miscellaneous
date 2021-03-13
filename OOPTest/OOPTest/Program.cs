using System;
using System.ComponentModel;

namespace OOPTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;  //Int32 j = new Int32Converter();

            Person person = new Person();
            person._firstName = "Oksana";
            person._lastName = "Polishhcuk";

            Person person2 = new Person();
            person2._firstName = "Anton";
            person2._lastName = "Ahmat";

            Doctor doctor = new Doctor();
            doctor._firstName = "Dima";
            doctor._lastName = "Go";
            doctor.Income();
            doctor.Specialization = "medium";

            //polymorphism.
            person = doctor; // Any doctor's specialization.
            Console.WriteLine(person._firstName); // Doctor's Name
            Console.WriteLine(person._lastName);
            Doctor ddoctor = (Doctor)person; // Returned the doctor's specialization

            Console.WriteLine(ddoctor._firstName);
            Console.WriteLine(ddoctor.Specialization);

            Console.WriteLine();
        }
    }
}