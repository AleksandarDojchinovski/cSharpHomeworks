using SEDC.cSharp.Class06.Task02.Models;
using System;

namespace SEDC.cSharp.Class06.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Homework02-----");
            #region Users
            User aleksandar = new User(1, "Aleksandar", "password123", new string[] {"Student","Bot"});
            User trajan = new User()
            {
                Id = 2,
                Username = "Trajan",
                Password = "password456",
                Messages = new string[] { "Teacher", "Developer"}
            };
            User vlatko = new User(3, "Vlatko", "password789", new string[] { "Assistant", "Junior developer" });

            User[] userArr = new User[] { aleksandar, trajan, vlatko };
            #endregion
            Console.WriteLine();

            Console.WriteLine("1. Log in");
            Console.WriteLine("2. Register");

            bool userInput = int.TryParse(Console.ReadLine(), out int parsedUserInput);
            if (!userInput)
            {
                Console.WriteLine("Invalid input");
            }
            if (parsedUserInput == 1)
            {
                LogIn(userArr);
            }
            else if (parsedUserInput == 2)
            {
                RegisterUser(userArr);
            }
            else
            {
                Console.WriteLine("error");
            }

            Console.ReadLine();

        }
        public static void LogIn(User[] userArr)
        {
            Console.WriteLine("Please enter username and password");
            Console.WriteLine("Username :");
            string username = Console.ReadLine();
            Console.WriteLine("Password :");
            string password = Console.ReadLine();
            bool isUserFound = false;
            foreach (User user in userArr)
            {
                if (user.Username == username && user.Password == password)
                {
                    foreach (string message in user.Messages)
                    {
                        Console.WriteLine(message);
                    }
                    isUserFound = true;
                }
            };
            if (!isUserFound)
            {
                Console.WriteLine("User not found");
            }
        }

        public static void RegisterUser(User[] userArr)
        {
            Console.WriteLine("Enter Id");

            bool isNumber = int.TryParse(Console.ReadLine(), out int parsedNumber);
            if (!isNumber)
            {
                Console.WriteLine("Wrong input");
                return;
            }
            Console.WriteLine("Enter Unsername");
            string userNameInput = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string userPasswordInput = Console.ReadLine();

            bool existingUser = false;
            foreach (User user in userArr)
            {
                if (user.Username == userNameInput)
                {
                    existingUser = true;
                }
            }
            if (existingUser)
            {
                Console.WriteLine($"User {userNameInput} already exists");
            }
            else
            {
                Array.Resize(ref userArr, userArr.Length + 1);
                userArr[userArr.Length - 1] = new User(parsedNumber, userNameInput, userPasswordInput, new string[] { });
                foreach (User user in userArr)
                {
                    Console.WriteLine($"{user.Id} {user.Username}");
                }
            }
        }

    }
}
