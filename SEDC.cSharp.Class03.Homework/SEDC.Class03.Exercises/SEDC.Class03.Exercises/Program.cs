using System;

namespace SEDC.Class03.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // LOOPS

            // EXERCISE1

            // ● Get an input number from the console
            // ● Print all numbers  from 1 to that number
            // ● Get another input number  from the console
            // ● Print all numbers  from that number to 1

            //Console.WriteLine("EXERCISE 01");
            //Console.WriteLine("Enter a number");
            //bool isValidInput = int.TryParse(Console.ReadLine(), out int validatedFirstInput);

            //if (!isValidInput)
            //{
            //    Console.WriteLine("Invalid input! Enter a number!");
            //}
            //{
            //    for (int i = 0; i < validatedFirstInput; i++)
            //    {
            //        Console.WriteLine(i + 1);
            //    }
            //}

            //Console.WriteLine("Enter another number");
            //isValidInput = int.TryParse(Console.ReadLine(), out int validatedSecondInput);

            //if (!isValidInput)
            //{
            //    Console.WriteLine("Invalid input! Enter a number!");
            //}
            //for (int i = validatedSecondInput; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            ////EXERCISE2

            //// ● Get an input number from the console
            //// ● Print all even numbers starting  from 2
            //// ● Get another input number  from the console
            //// ● Print all odd numbers  starting from 1

            //Console.WriteLine("EXERCISE 02");
            //Console.WriteLine("Enter a number");
            //isValidInput = int.TryParse(Console.ReadLine(), out int validatedFirstNumber);

            //if (!isValidInput)
            //{
            //    Console.WriteLine("Invalid input! Enter a number");
            //}
            //for (int i = 2; i <= validatedFirstNumber; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i + " is even number!");
            //    }
            //}
            //Console.WriteLine("Enter another number");

            //Console.WriteLine("Enter a number");
            //isValidInput = int.TryParse(Console.ReadLine(), out int validatedSecondNumber);

            //if (!isValidInput)
            //{
            //    Console.WriteLine("Invalid input! Enter a number");
            //}
            //for (int i = 1; i <= validatedSecondNumber; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i + " is odd number!");
            //    }
            //}

            //// EXERCISE3

            //// ● Get an input from the console
            //// ● Print all numbers  from 1 to that number
            //// ● Don’t print numbers that can be divided by 3 or 7
            //// ● If the number gets to 100 print a message:  The limit is reached and stop counting
            //Console.WriteLine("Exercise 03");
            //Console.WriteLine("Enter a number");
            //isValidInput = int.TryParse(Console.ReadLine(), out int validatedInputNumber);

            //if (!isValidInput)
            //{
            //    Console.WriteLine("Invalid input! Enter a number");
            //}

            //for (int i = 1; i <= validatedInputNumber; i++)
            //{
            //    if (i % 3 != 0 && i % 7 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    if (i == 100)
            //    {
            //        Console.WriteLine("The limit is reached");
            //        break;
            //    }
            //}

            //// ARRAYS

            //// EXERCISE4

            //// ● Declare 5 arrays with 5 elements  in them:
            //// ▹ With words
            //// ▹ With decimal  values
            //// ▹ With characters from keyboard
            //// ▹ With true/false  values
            //// ▹ With arrays, each holding 2 whole numbers

            //string[] strArr = { "Aleksandar", "Martin", "Trajan", "Vlado", "SEDC" };
            //double[] doubleArr = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            //char[] charArr = { 'A', 'M', 'T', 'V', 'S' };
            //bool[] boolArr = new bool[5];
            //boolArr[0] = true;
            //boolArr[1] = false;
            //boolArr[2] = true;
            //boolArr[3] = false;
            //boolArr[4] = true;
            ////boolArr[5] = false; error if we try to declare it.
            //int[] firstArr = { 1,2 };
            //int[] secondArr = { 5,6 };
            //Array[] arrArr =  { firstArr, new int[] {3,4 },secondArr, new int[]{ 7,8 },new int[] {9,10 }  };

            ////EXERCISE5
            //// ● Declare a new array of integers with 5 elements
            //// ● Initialize  the array elements  with values from input
            //// ● Sum all the values and print the result in the console

            //Console.WriteLine("Enter the first number");
            //isValidInput = int.TryParse(Console.ReadLine(), out int firstArrIntElement);
            //if (!isValidInput)
            //{
            //    Console.WriteLine("Invalid input! Enter a number!");
            //    return;
            //}
            //Console.WriteLine("Enter the second number");
            //isValidInput = int.TryParse(Console.ReadLine(), out int secondArrIntElement);
            //if (!isValidInput)
            //{
            //    Console.WriteLine("Invalid input! Enter a number!");
            //    return;
            //}
            //Console.WriteLine("Enter the third number");
            //isValidInput = int.TryParse(Console.ReadLine(), out int thirdArrIntElement);
            //if (!isValidInput)
            //{
            //    Console.WriteLine("Invalid input! Enter a number!");
            //    return;
            //}
            //Console.WriteLine("Enter the fourth number");
            //isValidInput = int.TryParse(Console.ReadLine(), out int fourthArrIntElement);
            //if (!isValidInput)
            //{
            //    Console.WriteLine("Invalid input! Enter a number!");
            //    return;
            //}
            //Console.WriteLine("Enter the fifth number");
            //isValidInput = int.TryParse(Console.ReadLine(), out int fifthArrIntElement);
            //if (!isValidInput)
            //{
            //    Console.WriteLine("Invalid input! Enter a number!");
            //    return;
            //}


            //int[] intArrFromInputs = { firstArrIntElement, secondArrIntElement, thirdArrIntElement, fourthArrIntElement, fifthArrIntElement };

            //int sum = 0;

            //foreach(int element in intArrFromInputs)
            //{
            //    sum += element;
            //}

            //Console.WriteLine("The sum of: {0}, {1}, {2}, {3}, {4} is {5}", firstArrIntElement, secondArrIntElement, 
            //    thirdArrIntElement, fourthArrIntElement, fifthArrIntElement, sum);


            //EXERCISE6

            // ● Create an array with names
            // ● Give an option to the user to enter a name from the keyboard
            // ● After entering the name put it in the array
            // ● Ask the user if they want to enter another name(Y / N)
            // ● Do the same process over and over until the user enters  N
            // ● Print all the names after user enters N

            string[] namesArr = new string[1];
            string askUser = "Y";
            Console.WriteLine("Enter a name");

            while (true)
            {
                if (askUser == "Y")
                {
                    string getNames = Console.ReadLine();
                    namesArr[namesArr.Length - 1] = getNames;
                }
                Console.WriteLine("Do you want to enter another name? ( Y / N )");
                askUser = Console.ReadLine();
                if (askUser == "Y")
                {
                    Array.Resize(ref namesArr, namesArr.Length + 1);
                    Console.WriteLine("Enter another name");
                }
                else if (askUser == "N")
                {
                    foreach (string element in namesArr)
                    {
                        Console.WriteLine("Input: {0}", element);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
            Console.WriteLine("Array contains {0} names", namesArr.Length);

            //string[] arrayWithStrings = new string[1];
            //string userInput;
            //string yesOrNo;
            //bool itsTrue = true;
            //Console.WriteLine("Enter a name");
            //userInput = Console.ReadLine();
            //arrayWithStrings[arrayWithStrings.Length - 1] = userInput;

            //while (itsTrue)
            //{
            //    Console.WriteLine("Do you want to enter another name? ( Y / N )");
            //    yesOrNo = Console.ReadLine();
            //    switch (yesOrNo)
            //    {
            //        case "Y":
            //            Array.Resize(ref arrayWithStrings, arrayWithStrings.Length + 1);
            //            Console.WriteLine("Enter another name");
            //            userInput = Console.ReadLine();
            //            arrayWithStrings[arrayWithStrings.Length - 1] = userInput;
            //            continue;
            //        case "N":
            //            foreach (string element in arrayWithStrings)
            //            {
            //                Console.WriteLine(element);
            //            }
            //            itsTrue = !itsTrue;
            //            break;
            //        default:
            //            Console.WriteLine("Wrong input");
            //            break;
                        
            //    }




           // }










            Console.ReadLine();
        }
    }
}

