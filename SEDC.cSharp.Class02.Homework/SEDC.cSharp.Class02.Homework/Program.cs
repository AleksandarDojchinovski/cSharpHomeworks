using System;

namespace SEDC.cSharp.Class02.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Homework Class02==========");

            // Task 01

            // Create new console application “RealCalculator” that takes two numbers from the input
            // and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.

            // Test Data:
            // Enter the First number: 10
            // Enter the Second number: 15
            // Enter the Operation: +
            // Expected Output:
            // The result is: 25

            Console.WriteLine("---------------------------");
            Console.WriteLine("Real Calculator");
            Console.WriteLine("Enter the First number");
            bool isInputANumber = int.TryParse(Console.ReadLine(), out int firstNumber);
            if(isInputANumber)
            {
                Console.WriteLine("Enter the Second number");
                bool isSecondInputANumber = int.TryParse(Console.ReadLine(), out int secondNumber);
                if (!isSecondInputANumber)
                {
                    Console.WriteLine("Invalid input! Enter a number");
                    return;
                }
                Console.WriteLine("Enter the Operation ( +, - , * , / ) ");
                string operationInput = Console.ReadLine();

                switch (operationInput)
                {
                    case "+":
                        Console.WriteLine("The result is: " + (firstNumber + secondNumber));
                        break;
                    case "-":
                        Console.WriteLine("The result is: " + (firstNumber - secondNumber));
                        break;
                    case "*":
                        Console.WriteLine("The result is: " + (firstNumber * secondNumber));
                        break;
                    case "/":
                        Console.WriteLine("The result is: " + ((double)firstNumber / secondNumber));
                        break;
                    default:
                        Console.WriteLine("invalid input");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a number");
                return;
            }
           
            Console.WriteLine("---------------------------");

            // Task 2

            // Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

            // Test Data:
            // Enter the First number: 10
            // Enter the Second number: 15
            // Enter the third number: 20
            // Enter the four number: 30
            // Expected Output:
            // The average of 10, 15, 20 and 30 is: 18

            Console.WriteLine("Average Number Application");
            Console.WriteLine("Enter the First number");
            bool isFirstInputInt = int.TryParse(Console.ReadLine(), out int firstNum);
            Console.WriteLine("Enter the Second number");
            bool isSecondInputInt = int.TryParse(Console.ReadLine(), out int secondNum);
            Console.WriteLine("Enter the Third number");
            bool isThirdInputInt = int.TryParse(Console.ReadLine(), out int thirdNum);
            Console.WriteLine("Enter the Fourth number");
            bool isFourthInputInt = int.TryParse(Console.ReadLine(), out int fourthNum);
            if(!isFirstInputInt || !isSecondInputInt || !isThirdInputInt || !isFourthInputInt)
            {
                Console.WriteLine("Error!! All inputs must be a numbers");
            }
            else
            {
                Console.WriteLine("The average of " + firstNum+", " + secondNum+", " +
                    thirdNum+" and " + fourthNum +" is: " + (firstNum + secondNum + thirdNum + fourthNum) / 4);
            }
        }
    }
}
