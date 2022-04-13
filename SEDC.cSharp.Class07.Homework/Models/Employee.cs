using Models.Enums;
using System;

namespace Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public double Salary { get; set; }


        public void PrintInfo()
        {
            Console.WriteLine($"First name: {Name}, Last Name: {LastName}, Salary: {Salary}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }


    }

}
