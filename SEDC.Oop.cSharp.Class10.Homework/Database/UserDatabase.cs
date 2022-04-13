using System;
using System.Collections.Generic;
using Models;

namespace Database
{
    public class UserDatabase
    {
        // List for admins

       public List<Admin> admins = new List<Admin>()
        {
            new Admin{Age = 46, Name ="AdminOne",Password = "AdminPassword1"},
            new Admin{Age = 56, Name ="AdminTwo",Password = "AdminPassword2"}
        };

        // List for trainers

      public List<Trainer> trainers = new List<Trainer>()
        {
            new Trainer{Age = 36, Name ="TrainerOne",Password = "TrainerPassword1"},
            new Trainer{Age = 36, Name ="TrainerTwo",Password = "TrainerPassword2"},
            new Trainer{Age = 36, Name ="TrainerThree", Password = "TrainerPassword3"}
        };

        // List for students

       public List<Student> students = new List<Student>()
        {
            new Student{Age = 21,Name = "StudentOne",Subject = new Subject("C Sharp Advanced"), Grades = new Dictionary<Subject, int>{
                {new Subject("Math"),4},
                {new Subject("English"),10},
                {new Subject("Html"), 10 },
                {new Subject("Css"), 9 },
                {new Subject("JavaScript"),9 }},Password = "StudentPassword1"},
            new Student{Age = 22,Name = "StudentTwo",Subject = new Subject("C Sharp Basic"), Grades = new Dictionary <Subject,int>{
                {new Subject("Math"),2},
                {new Subject("English"),5},
                {new Subject("Html"), 7 },
                {new Subject("Css"), 4},
                {new Subject("JavaScript"),2 }},Password = "StudentPassword2"},
            new Student{Age = 23,Name = "StudentThree",Subject =new Subject("JavaScript Basic"), Grades = new Dictionary<Subject,int>{
                {new Subject("Math"),4},
                {new Subject("English"),4},
                {new Subject("Html"), 10 },
                {new Subject("Css"), 9 },
                {new Subject("JavaScript"),9 }},Password = "StudentPassword3"},
            new Student{Age = 24,Name = "StudentFour",Subject = new Subject("C ++"), Grades = new Dictionary<Subject,int>{
                {new Subject("Math"),4},
                {new Subject("English"),10},
                {new Subject("Html"), 10 },
                {new Subject("Css"), 9 },
                {new Subject("JavaScript"),6 }},Password = "StudentPassword4"},
            new Student{Age = 22,Name = "StudentFive",Subject =new Subject ("C"), Grades = new Dictionary<Subject,int>{
                {new Subject("Math"),4},
                {new Subject("English"),10},
                {new Subject("Html"), 2 },
                {new Subject("Css"), 6},
                {new Subject("JavaScript"),7 }},Password = "StudentPassword5"}
        };
        
    }
}
