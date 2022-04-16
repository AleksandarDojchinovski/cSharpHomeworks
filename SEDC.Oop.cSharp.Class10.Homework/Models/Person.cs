using System;

namespace Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }

        public  void PrintPerson()
        {
            Console.WriteLine($"Name : {Name}, Age: {Age} ");
        }
    }
}
