using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class CEO:Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }

        public double AddSharesPrice(double num)
        {
            SharesPrice = num;
            return SharesPrice;
        }

        public void PrintEmployees()
        {
            Console.WriteLine("Employees: ");
            foreach(Employee employee in Employees)
            {
                Console.WriteLine(employee.Name);
            }
        }

        public override double GetSalary()
        {
            return Salary + Shares * SharesPrice;
        }

    }
}
