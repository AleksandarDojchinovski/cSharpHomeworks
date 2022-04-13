using Models;
using Models.Enums;
using Services;
using System;

namespace ClassLibraries
{
    public class Program
    {
        static void Main(string[] args)
        {
            //EmployeeService employeeService = new EmployeeService();
            //employeeService.CreateObjectAndWriteInConsole();

            Manager aleksandar1 = new Manager() { Name = "Aleksandar", Id = 3, Department = "Development" };
            Employee employee = new Employee() { Id = 1, Name = "Bob", Role = Role.Guest, Salary = 1000 };
            Contractor aleksandar = new Contractor() { Id = 2, PayPerHour = 100, Name = "Aleksandar", WorkHours = 8, Role = Models.Enums.Role.Guest,Salary = 1000,Responsible = aleksandar1 };


            Manager sara = new Manager() { Id = 3, Name = "Sara", Department = "HR" };
            Manager hristina = new Manager() { Id = 4, Name = "Hristina", Department = "PR" };
            Contractor trajan = new Contractor() { Id = 1, Name = "Trajan", PayPerHour = 20, Role = Role.Admin, WorkHours = 8,Responsible = sara };
            Contractor vlatko = new Contractor() { Id = 2, Name = "Vlatko", PayPerHour = 15, Role = Role.Guest, WorkHours = 9, Responsible = hristina };
            SalesPerson pero = new SalesPerson() { Id = 30, Name = "Pero", LastName = "Perovski", Role = Role.Guest };

            Employee[] company = new Employee[]
            {
                trajan,vlatko,sara,hristina,pero
            };

            CEO acko = new CEO() {Name = "Aleksandar", Shares = 5, Salary = 1500, Employees = company, Id = 1, Role = Role.Admin};
            acko.AddSharesPrice(40);
            acko.PrintInfo();
            Console.WriteLine($"Salary of CEO is: {acko.GetSalary()}");
            acko.PrintEmployees();

            
            Console.ReadLine();
        }
    }
}
