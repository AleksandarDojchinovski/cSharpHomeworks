using System;

namespace SEDC.cSharp.Class04.BonusHomework
{
    class Program
    {
        static void Main(string[] args)
        {

            string result = IsItPalindrome("RADAR");
            Console.WriteLine(result);

            int[] test = { 5, 4, 6, 12, 10 };
            Console.WriteLine(GreatestValue(test));

            Console.WriteLine(NumberOfVowels("Aleksandar"));
            Console.WriteLine(NumberOfDigits("a2ce35z"));
            string inputFromUser = Console.ReadLine();
            Console.WriteLine(UpperLower(inputFromUser));
            CheckCharacter('A');
            Console.WriteLine(CheckNumberOfRepeatSubstrings("sedcsedcsedcsedcsedc", "sedc"));
            Console.WriteLine(CalculatePower(5,3));






            Console.ReadLine();
        }
        static string IsItPalindrome(string userInput)
        {
            string helper = string.Empty;

            for (int i = userInput.Length; i > 0; i--)
            {
                helper += userInput[i - 1];
            }
            if (userInput != helper)
            {
                return $"{userInput} is not a palindrome";
            }
            else
            {
                return $"{userInput} is a palindrome";
            }
        }

        static string GreatestValue(int[] input)
        {
            int helper = int.MinValue;
            foreach (int num in input)
            {
                if (helper < num)
                {
                    helper = num;
                }
            }
            return $"{helper} is the biggest number in the array";
        }

        static int NumberOfVowels(string userInput)
        {
            int counter = 0;

            foreach (char letter in userInput.ToUpper())
            {
                if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
                {
                    counter++;
                }
            }
            return counter;
        }


        static int NumberOfDigits(string userInput)
        {
            int counter = 0;
            foreach (char number in userInput)
            {
                if (char.IsDigit(number))
                {
                    counter++;
                }
            }
            return counter;
        }

        static string UpperLower(string input)
        {
            string changedletters = string.Empty;
            foreach (char letter in input)
            {
                if (char.IsLower(letter))
                {
                    changedletters += char.ToUpper(letter);
                }
                else
                {
                    changedletters += char.ToLower(letter);
                }
            }
            return changedletters;
        }

        static string CheckCharacter(char input)
        {
            if (!char.IsLetter(input))
            {
                Console.WriteLine($"The input is {char.GetUnicodeCategory(input)}");
            }
            else if (char.IsLetter(input))
            {
                if (char.IsUpper(input))
                {
                    Console.WriteLine($"{input} is a letter and it is uppercase");
                }
                else
                {
                    Console.WriteLine($"{input} is a letter and it is lowercase");

                }
            }
            else
            {
                Console.WriteLine("Invalid input, enter a single character");
            }
            return $"The input is {char.GetUnicodeCategory(input)}";
        }

        static int CheckNumberOfRepeatSubstrings(string input, string subString)
        {
            int counter = 0;
            int helper = input.Length - subString.Length;

            for (int i = 0; i <= helper; i++)
            {
                if (input.Substring(i, subString.Length) == subString)
                {
                    counter++;
                }
            }
            return counter;
        }

        static int CalculatePower(int number, int power)
        {
            int result = number;
            for(int  i = 1; i < power; i++)
            {
                result *= number;
            }
            return result;
        }







    }
}












