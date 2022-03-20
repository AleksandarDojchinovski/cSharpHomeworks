using SEDC.cSharp.Class05.Homework.GuessTheNumber.Models;
using System;

namespace SEDC.cSharp.Class05.Homework.GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            GameMode game = new GameMode();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Guess The Number!!");
                Console.WriteLine();
                Console.WriteLine("Select difficulty");
                Console.WriteLine();
                Console.WriteLine("1. Easy");
                Console.WriteLine("2. Normal");
                Console.WriteLine("3. Hard");
                Console.WriteLine("4. Exit Game");

                int generatedRandomNumber = 0;
                bool userInput = int.TryParse(Console.ReadLine(), out int parsedUserInput);

                if (!userInput)
                {
                    Console.WriteLine("Invalid input, choose from 1-4");
                }

                switch (parsedUserInput)
                {
                    case 1:
                        generatedRandomNumber = game.GenerateEasyRandomNumber();
                        game.NumberOfGuesses = 9;
                        break;
                    case 2:
                        generatedRandomNumber = game.GenerateNormalRandomNumber();
                        game.NumberOfGuesses = 7;
                        break;
                    case 3:
                        generatedRandomNumber = game.GenerateHardRandomNumber();
                        game.NumberOfGuesses = 5;
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid input, choose from 1-4 ");
                        break;
                }
                while (game.NumberOfGuesses > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Enter a number, or click R to restart the game or E to exit the game");
                    var input = Console.ReadLine();
                    if (input.ToUpper().Equals("R"))
                    {
                        game.NumberOfGuesses = 0;
                        break;
                    }
                    if (input.ToUpper().Equals("E"))
                    {
                        return;
                    }
                    bool isNumber = int.TryParse(input, out int parsedNumber);
                    if (!isNumber)
                    {
                        Console.WriteLine("Invalid input");
                    }

                    if (parsedNumber > generatedRandomNumber)
                    {
                        if (parsedNumber - generatedRandomNumber >= 20)
                        {
                            Console.WriteLine($"Your guess is far too HIGH, number entered: {parsedNumber} ");
                            Console.WriteLine();
                        }
                        else if (parsedNumber - generatedRandomNumber > 0 && parsedNumber - generatedRandomNumber <= 10)
                        {
                            Console.WriteLine($"Your guess is really close but higher, number entered: {parsedNumber} ");
                            Console.WriteLine();
                        }
                        else if (parsedNumber - generatedRandomNumber >= 10 && parsedNumber - generatedRandomNumber <= 20)
                        {
                            Console.WriteLine($"Your guess is a little bit higher, number entered: {parsedNumber}");
                            Console.WriteLine();
                        }
                    }
                    else if (parsedNumber < generatedRandomNumber)
                    {
                        if (generatedRandomNumber - parsedNumber >= 20)
                        {
                            Console.WriteLine($"Your guess is far too LOW, number entered: {parsedNumber} ");
                            Console.WriteLine();
                        }
                        else if (generatedRandomNumber - parsedNumber > 0 && generatedRandomNumber - parsedNumber <= 10)
                        {
                            Console.WriteLine($"Your guess is  really close but lower , number entered: {parsedNumber} ");
                            Console.WriteLine();
                        }
                        else if (generatedRandomNumber - parsedNumber >= 10 && generatedRandomNumber - parsedNumber <= 20)
                        {
                            Console.WriteLine($"Your guess is a little bit lower, number entered: {parsedNumber}");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        if (parsedUserInput == 1 && game.NumberOfGuesses == 9 || parsedUserInput == 2 && game.NumberOfGuesses == 7 || parsedUserInput == 3 && game.NumberOfGuesses == 5)
                        {
                            Console.WriteLine("Lucky guess");
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Nailed it. number entered: {parsedNumber}");
                            Console.WriteLine();
                            break;
                        }
                    }
                    game.NumberOfGuesses--;
                    Console.WriteLine($"You have {game.NumberOfGuesses} guesses left");
                }
                Console.WriteLine("Press enter to try again");
                Console.ReadLine();
            }
        }
    }
}

