using System;

namespace SEDC.cSharp.Class06.Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Homework01-------");
            Console.WriteLine();

            GetNumberStats();
        }

        static void GetNumberStats()
        {
            Console.WriteLine("Enter Y to start or X to exit");
            while (true) {
                var userInput = Console.ReadLine();
                if (userInput.ToUpper() == "Y")
                {
                    StartGame();
                }
                else if(userInput.ToUpper() != "X")
                {
                    Console.WriteLine("Invalid input, press Y or X");
                }
                else 
                {
                    return;
                }
            }
        }

        public static void StartGame()
        {
            Console.Clear();
            Console.WriteLine("Enter a number");
            var userNumberInput = Console.ReadLine();
            bool isItNumber = double.TryParse(userNumberInput, out double parsedUserInput);
            if (!isItNumber)
            {
                Console.WriteLine("Invalid input, Y to try again or X to exit");
                return;
            }
            Console.WriteLine(NumberStats(parsedUserInput));
            Console.WriteLine("Press Y to try again or X to exit");
        }

        public static string NumberStats(double number)
        {
            string positiveOrNegative = number > 0 ? "Positive" : "Negative";
            string oddOrEven = number % 2 != 0 ? "Odd" : "Even";
            string integerOrDecimal = number % 1 == 0 ? "Integer" : "Decimal";
            Console.WriteLine();
            return $"Stats for number {number} : \n \n - {positiveOrNegative} \n - {integerOrDecimal} \n - {oddOrEven}\n";
        }
    }
}
