using System;

namespace SEDC.Class03.Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Homework Task 01");
            Console.WriteLine("===================================");
            // Task 01

            // Make a console application called SumOfEven.
            // Inside it create an array of 6 integers.
            // Get numbers from the input, find and print the sum of the even numbers from the array:

            int sumNums = 0;
            int[] sumOfEven = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Enter a number");
                sumOfEven[i] = int.Parse(Console.ReadLine());
            }
            foreach (int element in sumOfEven)
            {
                if (element % 2 == 0)
                {
                    sumNums += element;
                    Console.WriteLine("{0} is even number", element);
                }
                else
                {
                    Console.WriteLine("{0} is odd number", element);
                }
            }
            Console.WriteLine("The sum of the even numbers is: {0}", sumNums);

            Console.WriteLine("Homework Task 02");
            Console.WriteLine("===================================");

            // Task 2
            // Make a new console application called StudentGroup
            // Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names.
            // Get a number from the console between 1 and 2 and print the students from that group in the console.
            // Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]

            string[] studentsG1 = { "Aleksandar","Martin","Trajan","Vlatko","Maja" };
            string[] studentsG2 = { "Trajko", "Rajko", "Petko", "Stanko", "Mitko" };
              
            Console.WriteLine("Select student group ( 1 or 2 )");

            bool isValidInput = int.TryParse(Console.ReadLine(), out int validatedInput);
            if (!isValidInput)
            {
                Console.WriteLine("invalid input , enter a number between 1 and 2");
                return;
            }

            switch (validatedInput)
            {
                case 1:
                    Console.WriteLine("The Students in G1 are:");
                    foreach(string element in studentsG1)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 2:
                    Console.WriteLine("The Students in G2 are:");
                    foreach (string element in studentsG2)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
           




        }
    }
}
