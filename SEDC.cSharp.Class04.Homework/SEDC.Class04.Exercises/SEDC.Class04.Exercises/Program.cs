using System;

namespace SEDC.Class04.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 01");
            Console.WriteLine("Please select operation ( + or - )");
            string sumOrSub = Console.ReadLine();
            if (sumOrSub != "+" && sumOrSub != "-")
            {
                Console.WriteLine("Invalid option!");
                return;
            }
            Console.WriteLine("Enter the first number");
            bool userInput = int.TryParse(Console.ReadLine(), out int validatedUserFirstInput);
            if (!userInput)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            Console.WriteLine("Enter the second number");
            userInput = int.TryParse(Console.ReadLine(), out int validatedUserSecondInput);
            if (!userInput)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            if (sumOrSub == "+")
            {
                int result = Sum(validatedUserFirstInput, validatedUserSecondInput);
                Console.WriteLine($"The result is:{result}");
            }
            else if (sumOrSub == "-")
            {
                int result = Subtract(validatedUserFirstInput, validatedUserSecondInput);
                Console.WriteLine($"The result is: {result}");
            }
            else
            {
                Console.WriteLine("Error!");
            }

            // EXERCISE2
            // ● Try writing these strings in the console:
            // Check your c:\driveWe will have "fair" elections
            // The \n sign means: new line

            Console.WriteLine(@"We will have ""fair"" elections");
            Console.WriteLine(@"The \n sign means: new line");

            //int phoneNumber = 077132123;
            ////077-132-123
            //string formatedNumber = string.Format("{0:0##-###-###}", phoneNumber);
            //Console.WriteLine(formatedNumber);

            //string fullName = "       Aleksandar Dojchinovski          ";
            //Console.WriteLine(fullName);
            //fullName = fullName.Trim();
            //Console.WriteLine(fullName);
            ////Console.WriteLine(fullName.StartsWith('z')); Returns true or false
            //string fullNameAndEducation = "    Aleksandar Dojchinovski is currently learning c# in SEDC            ";
            //string splitNameEdu = fullNameAndEducation.Trim();
            //Console.WriteLine(splitNameEdu);
            //Console.WriteLine(splitNameEdu.Length);
            //Console.WriteLine(splitNameEdu.Substring(20,36));
            //string[] eduNameSplit = fullNameAndEducation.Trim().Split(' ');
            //foreach(string word in eduNameSplit)
            //{
            //    Console.WriteLine(word);
            //}



            string resultFromSubString = SubStrings();
            Console.WriteLine($"The length of the string is {resultFromSubString.Length} characters and" +
            $"the characters are {resultFromSubString}");

            // EXERCISE4
            // ● Print the date that is 3 days from now
            // ● Print the date that is one month from now
            // ● Print the date that is one month and 3 days from now
            // ● Print 1 year and 2 months ago from today
            // ● Print only the current month of today
            // ● Print only the current year of today

            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate);
            DateTime threeDaysFromNow = currentDate.AddDays(3);
            Console.WriteLine(threeDaysFromNow);
            DateTime oneMonthFromNow = currentDate.AddMonths(1);
            Console.WriteLine(oneMonthFromNow);
            DateTime oneMonthAndThreeDaysFromNow = currentDate.AddMonths(1).AddDays(3);
            Console.WriteLine(oneMonthAndThreeDaysFromNow);
            DateTime todaysDate = DateTime.Today;
            Console.WriteLine(todaysDate);
            DateTime oneYearAndTwoMonthsAgoFromToday = todaysDate.AddYears(-1).AddMonths(-2);
            Console.WriteLine(oneYearAndTwoMonthsAgoFromToday);
            Console.WriteLine(todaysDate.Month);
            Console.WriteLine(todaysDate.Year);






        }
        // EXERCISE1

        // ● Create 2 methods called Sum and Subtract
        // ● Sum will accept two numbers as parameters and return a result from summing the two numbers
        // ● Subtract will accept two numbers as parameters and return a result from subtracting the two numbers
        // ● Ask a person from the console to enter -or +
        // ● Then ask the person to enter two numbers
        // ● Call the corresponding method ( sum or subtract ) and return the result to the console

        static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
        static int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        // EXERCISE3

        // ● In the existing  Console Application create  a new method called Substrings
        // ● In that method enter the following string :"Hello from SEDC Codecademy 2021"
        // ● Ask the user to enter a number n.
        // ● Print the first n characters from that string and print the length of the new string.
        // ● Try to handle all the scenarios.

        static string SubStrings()
        {
            Console.WriteLine("Enter a number");
            string helloFromSedc = "Hello from SEDC Codecademy 2021";
            bool isValid = int.TryParse(Console.ReadLine(), out int userInput);
            if (!isValid)
            {
                Console.WriteLine("Invalid input!");
            }
            if (userInput > helloFromSedc.Length)
            {
                Console.WriteLine($"User input: {userInput} is bigger than the {helloFromSedc} length");
            }
            return helloFromSedc.Substring(0, userInput);
        }






    }

}
