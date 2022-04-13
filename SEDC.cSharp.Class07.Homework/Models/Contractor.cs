using Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }
        public string CurrentPosition()
        {
            return Responsible.Department;
        }
    }
    
}

