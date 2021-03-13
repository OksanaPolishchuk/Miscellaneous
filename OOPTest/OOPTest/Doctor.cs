using System;

namespace OOPTest
{
    public class Doctor : Person
    {
        public string Specialization;
        public void Income()
        {
            var doctor = new Doctor();
            var many = doctor._premium;
            Console.WriteLine(many);
        }
    }
}
