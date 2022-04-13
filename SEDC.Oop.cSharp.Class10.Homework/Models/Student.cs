using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Student : Person
    {
        public Subject Subject { get; set; }
        public Dictionary<Subject, int> Grades {get; set;}

        public void PrintStudent()
        {
            Console.WriteLine( $"Student {Name} is currently studying {Subject.SubjectName}");
            Console.WriteLine();
            PrintGrades();
        }

        public void PrintGrades()
        {
            foreach (KeyValuePair<Subject, int> grade in Grades)
            {
                Console.WriteLine($"{grade.Key.SubjectName} : {grade.Value} \n");
            }
        }
    }


}
