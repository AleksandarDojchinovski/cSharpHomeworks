using Database;
using Models;
using System;
using System.Collections.Generic;

namespace Services
{
    public class AcademyAppService
    {
        public static void StartApp()
        {
            UserDatabase database = new UserDatabase();
            Console.WriteLine("Please select role :");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Trainer");
            Console.WriteLine("3. Student");
            bool isNumber = int.TryParse(Console.ReadLine(), out int userInput);
            if (!isNumber)
            {
                Console.WriteLine("Invalid input");
            }
            if (userInput > 3)
            {
                Console.WriteLine("Choose input from 1-3");
            }
            Console.WriteLine("Enter Username");
            var username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            var password = Console.ReadLine();

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("You chose Admin");
                    Console.WriteLine();
                    var admin = LoginAsAdmin(database.admins,username,password);
                    if (admin == null)
                    {
                        Console.WriteLine("There is not such student");
                        break;
                    }
                    Console.WriteLine($"Welcome {admin.Name}");
                    break;
                case 2:
                    Console.WriteLine("You chose Trainer");
                    Console.WriteLine();
                    var trainer = LoginAsTrainer(database.trainers,username,password);
                    if (trainer == null)
                    {
                        Console.WriteLine("There is not such student");
                        break;
                    }
                    Console.WriteLine($"Welcome {trainer.Name}");
                    Console.WriteLine("1. See students");
                    Console.WriteLine("2. See subjects");
                    isNumber = int.TryParse(Console.ReadLine(), out int switchNumber);
                    if (!isNumber || switchNumber > 2)
                    {
                        Console.WriteLine("Select 1 or 2");
                        break;
                    }
                    TrainerSwitch(switchNumber, database.students);
                    break;
                case 3:
                    Console.WriteLine("You chose Student");
                    Console.WriteLine();
                    var student = LoginAsStudent(database.students,username,password);
                    if (student == null)
                    {
                        Console.WriteLine("There is not such student");
                        break;
                    }
                    student.PrintStudent();
                    break;
                default:
                    break;
            }
        }

        private static Admin LoginAsAdmin(List<Admin> admins,string username,string password)
        {
            return admins.Find(admin => admin.Name.Equals(username) && admin.Password.Equals(password));
        }

        private static Student LoginAsStudent(List<Student> students,string username,string password)
        {
            return  students.Find(student => student.Name.Equals(username) && student.Password.Equals(password));
        }

        private static Trainer LoginAsTrainer(List<Trainer> trainers,string username,string password)
        {
            return trainers.Find(trainer => trainer.Name.Equals(username) && trainer.Password.Equals(password));
        }

        public static void TrainerSwitch(int trainerInput,List<Student>students)
        {
            UserDatabase database = new UserDatabase();
            switch (trainerInput)
            {
                case 1:
                    foreach(Student name in students)
                    {
                        Console.WriteLine($"{students.IndexOf(name) +1}. {name.Name}");
                    }
                    Console.WriteLine($"Select the student you want to see");
                    bool isNumber = int.TryParse(Console.ReadLine(), out int parsedNumber);
                    if (!isNumber)
                    {
                        Console.WriteLine("Enter a number!");
                    }
                    switch (parsedNumber)
                    {
                        case 1:
                            break;

                    }

                    break;
            }

        }
    }
}