using Models;
using Models.Enums;
using System;

namespace Services
{
    public class EmployeeService
    {
        public void CreateObjectAndWriteInConsole()
        {
            Employee employee = new Employee() { Id = 1, Name = "Bob", Role = Role.Guest };
            Employee employee2 = new Employee() { Id = 2, Name = "Aleksandar", Role = Role.Guest };
            Employee employee3 = new Employee() { Id = 3, Name = "Martin", Role = Role.Guest };
           
            Console.WriteLine($"Employee {employee.Name} is Created");
        }
    }
}
