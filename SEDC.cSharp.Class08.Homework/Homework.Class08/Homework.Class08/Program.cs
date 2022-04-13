using System;
using System.Collections;
using System.Collections.Generic;

namespace Homework.Class08
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queueNum = new Queue<int>();
            Console.WriteLine("Enter a number");
            bool isNumber = int.TryParse(Console.ReadLine(), out int num);
            if (!isNumber)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                queueNum.Enqueue(num);
            }
            while (true)
            {
                Console.WriteLine("Do you want to enter another number? Y/N");
                string userInput = Console.ReadLine();
                if (userInput.ToUpper() == "Y")
                {
                    Console.WriteLine("Enter a number");
                    isNumber = int.TryParse(Console.ReadLine(), out int numb);
                    if (!isNumber)
                    {
                        Console.WriteLine("Invalid input");
                    }
                    else
                    {
                        queueNum.Enqueue(numb);
                    }
                }
                else if (userInput.ToUpper() == "N")
                {
                    while(queueNum.Count > 0)
                    {
                        Console.WriteLine(queueNum.Dequeue());
                    }
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
    
}
