using System;

namespace MyTest
{
    public class Person
    {
        //private string _name;
        
        public string Name { get; set; }
        
        public string SecondName { get; }

        public Person(string secondName, string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("empty name");
            }
            SecondName = secondName;
            Name = name;
        }

        /*public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("empty name");
            }
            _name = name;
        }*/

        /*public string Name
        {
            get
            {
                return _name;
                
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("empty name");
                }
                _name = value + "Polishchuk";
            }
        }*/
    }
}