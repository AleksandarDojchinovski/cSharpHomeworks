using Database;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;

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

            try
            {
                if (!isNumber)
                {
                    throw new Exception("You must enter a number!");
                }
                if (userInput > 3)
                {
                    throw new Exception("Number must be 1-3");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("You chose Admin");
                    var username = EnterUserName();
                    var password = EnterPassword();
                    Console.WriteLine();
                    try
                    {
                        var admin = LoginAsAdmin(database.admins, username, password);
                        if (admin == null)
                        {
                            throw new Exception("There is no such admin");
                        }
                        Console.WriteLine($"Welcome {admin.Name}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                    Console.WriteLine("1. Add Admin,Trainer or Student");
                    Console.WriteLine("2. Remove Admin,Trainer or Student");

                    isNumber = int.TryParse(Console.ReadLine(), out int parsedNumber);

                    try
                    {
                        if (!isNumber)
                        {
                            throw new Exception("Invalid input");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }

                    AddOrRemove(parsedNumber, database, username);
                    break;
                case 2:
                    Console.WriteLine("You chose Trainer");
                    Console.WriteLine();
                    username = EnterUserName();
                    password = EnterPassword();
                    var trainer = LoginAsTrainer(database.trainers, username, password);
                    try
                    {
                        if (trainer == null)
                        {
                            throw new Exception("There is no such trainer");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    
                    Console.WriteLine($"Welcome {trainer.Name}");
                    Console.WriteLine("1. See students");
                    Console.WriteLine("2. See subjects");

                    isNumber = int.TryParse(Console.ReadLine(), out int switchNumber);
                    try {
                        if (!isNumber)
                        {
                            throw new Exception("You must enter a number");
                        }
                        else if (switchNumber > 2)
                        {
                            throw new Exception("Select 1 or 2");
                        }
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    TrainerSwitch(switchNumber, database.students);
                    break;
                case 3:
                    Console.WriteLine("You chose Student");
                    Console.WriteLine();
                    username = EnterUserName();
                    password = EnterPassword();
                    var student = LoginAsStudent(database.students, username, password);

                    try
                    {
                        if (student == null)
                        {
                            throw new Exception("There is no such student");
                        }
                    }
                    catch(Exception e) 
                    {
                        Console.WriteLine(e.Message);
                    }

                    student.PrintStudent();
                    break;
                default:
                    break;
            }
        }

        private static string EnterPassword()
        {
            Console.WriteLine("Enter Password");
            return Console.ReadLine();
        }

        private static string EnterUserName()
        {
            Console.WriteLine("Enter Username");
            return Console.ReadLine();
        }

        private static int EnterAge()
        {
            Console.WriteLine("Enter age");
            int.TryParse(Console.ReadLine(), out int age);
            return age;
        }

        private static Admin LoginAsAdmin(List<Admin> admins, string username, string password)
        {
            return admins.FirstOrDefault(admin => admin.Name.Equals(username) && admin.Password.Equals(password));
        }

        private static Student LoginAsStudent(List<Student> students, string username, string password)
        {
            return students.FirstOrDefault(student => student.Name.Equals(username) && student.Password.Equals(password));
        }

        private static Trainer LoginAsTrainer(List<Trainer> trainers, string username, string password)
        {
            return trainers.FirstOrDefault(trainer => trainer.Name.Equals(username) && trainer.Password.Equals(password));
        }

        public static void TrainerSwitch(int trainerInput, List<Student> students)
        {
            UserDatabase database = new UserDatabase();
            switch (trainerInput)
            {
                case 1:
                    students.ForEach(name => Console.WriteLine($"{students.IndexOf(name) + 1}. {name.Name}"));
                    Console.WriteLine($"Select the student you want to see");
                    bool isNumber = int.TryParse(Console.ReadLine(), out int parsedNumber);
                    try {
                        if (!isNumber)
                        {
                            throw new Exception("Enter a number!");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    
                    foreach (var keyValuePair in students[parsedNumber - 1].Grades)
                    {
                        Console.WriteLine(keyValuePair.Key.SubjectName);
                    }
                    break;
                case 2:
                    Dictionary<string, int> subjects = new Dictionary<string, int>();

                    students.ForEach(s =>
                    {
                        if (subjects.ContainsKey(s.Subject.SubjectName))
                        {
                            subjects[s.Subject.SubjectName]++;
                        }
                        else
                        {
                            subjects.Add(s.Subject.SubjectName, 1);
                        }
                    });
                    foreach (var item in subjects)
                    {
                        Console.WriteLine($"The subject{item.Key} is attended by {item.Value} students");
                    }
                    break;
            }
        }

        public static void AddOrRemove(int num, UserDatabase database, string adminUsername)
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("What do you want to add?");
                    Console.WriteLine("1. Admin");
                    Console.WriteLine("2. Trainer");
                    Console.WriteLine("3. Student");
                    int.TryParse(Console.ReadLine(), out int number);
                    AddInput(number, database);
                    break;
                case 2:
                    Console.WriteLine("What do you want to remove?");
                    Console.WriteLine("1. Admin");
                    Console.WriteLine("2. Trainer");
                    Console.WriteLine("3. Student");
                    int.TryParse(Console.ReadLine(), out int numberr);
                    DeleteInput(numberr, database, adminUsername);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }

        public static void AddInput(int num, UserDatabase database)
        {
            var username = EnterUserName();
            var password = EnterPassword();
            int age = EnterAge();

            switch (num)
            {
                case 1:
                    database.admins.Add(new Admin() { Name = username, Password = password, Age = age });
                    database.admins.ForEach(a => a.PrintPerson());
                    break;
                case 2:
                    database.trainers.Add(new Trainer() { Name = username, Password = password, Age = age });
                    database.trainers.ForEach(t => t.PrintPerson());
                    break;
                case 3:
                    database.students.Add(new Student() { Name = username, Password = password, Age = age });
                    database.students.ForEach(s => s.PrintPerson());
                    break;
                default:
                    Console.WriteLine("Invald input");
                    break;
            }
        }

        public static void DeleteInput(int num, UserDatabase database, string adminUsername)
        {
            switch (num)
            {
                case 1:
                    database.admins.ForEach(a => a.PrintPerson());
                    var username = EnterUserName();
                    try
                    {
                        var deletedItem = database.admins.Find(a => a.Name == username);
                        if(deletedItem.Name.Equals(adminUsername))
                        {
                            throw new Exception("You cannot remove yourself");
                        }
                        database.admins.Remove(deletedItem);
                        Console.WriteLine($"Admin {deletedItem.Name} was removed");
                        Console.WriteLine("New list of admins");
                        database.admins.ForEach(a => a.PrintPerson());
                    }
                    catch (NullReferenceException e)
                    {
                        Console.WriteLine("There is no such admin to remove");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 2:
                    database.trainers.ForEach(a => a.PrintPerson());
                    username = EnterUserName();
                    try
                    {
                        var deletedItem = database.trainers.Find(a => a.Name == username);
                        database.trainers.Remove(deletedItem);
                        Console.WriteLine($"Trainer {deletedItem.Name} was removed");
                        Console.WriteLine("New list of Trainers");
                        database.trainers.ForEach(a => a.PrintPerson());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("There is no such trainer to remove");
                    }
                    break;
                case 3:
                    database.students.ForEach(a => a.PrintPerson());
                    username = EnterUserName();
                    try
                    {
                        var deletedItem = database.students.Find(a => a.Name == username);
                        database.students.Remove(deletedItem);
                        Console.WriteLine($"Student {deletedItem.Name} was removed");
                        Console.WriteLine("New list of Students");
                        database.students.ForEach(a => a.PrintPerson());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("There is no such student to remove");
                    }
                    break;
                default:
                    Console.WriteLine("Invald input");
                    break;
            }
        }
    }
}