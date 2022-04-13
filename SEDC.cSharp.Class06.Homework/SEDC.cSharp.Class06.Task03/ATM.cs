using SEDC.cSharp.Class06.Task03.Models;
using System;

namespace SEDC.cSharp.Class06.Task03
{
    class ATM
    {
        static void Main(string[] args)
        {
            Customer aleksandar = new Customer("Aleksandar", "Dojchinovski", 1225, 1234123412341234, 1000);
            Customer aleksandar1 = new Customer("Aleksandar1", "Dojchinovski1", 5221, 4321432143214321, 2000);
            ATM_Machine atm = new ATM_Machine()
            {
                AtmCustomers = new Customer[] { aleksandar, aleksandar1 }
            };


            Console.WriteLine("Enter card number");
            bool isNumber = long.TryParse(Console.ReadLine().Replace("-", ""), out long cardNumber);
            if (!isNumber)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            Console.WriteLine("Enter your pin");
            isNumber = int.TryParse(Console.ReadLine(), out int userPin);
            if (!isNumber)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            var acko = atm.GetCustomer(cardNumber, userPin);
            if (acko != null)
            {
                Console.Clear();
                Console.WriteLine($"Welcome {acko.FirstName}");
                while (true)
                {
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine();
                    Console.WriteLine("a. Check Balance");
                    Console.WriteLine("b. Cash Withdrawl");
                    Console.WriteLine("c. Cash Deposit");
                    string input = Console.ReadLine();
                    switch (input.ToLower())
                    {
                        case "a":
                            Console.Clear();
                            atm.BalanceChecking(acko);
                            break;
                        case "b":
                            Console.Clear();
                            Console.WriteLine($"Ballance: {acko.Ballance}$");
                            Console.WriteLine("Enter ammount you want to withdraw");
                            int ammount = int.Parse(Console.ReadLine());
                            Console.Clear();
                            acko.Ballance = atm.CashWithrawal(acko, ammount);
                            break;
                        case "c":
                            Console.Clear();
                            Console.WriteLine("Enter ammount you want to deposit");
                            int ammountDeposit = int.Parse(Console.ReadLine());
                            Console.Clear();
                            acko.Ballance = atm.CashDeposit(acko, ammountDeposit);
                            break;
                        case "d":
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("Do you want to use another service? Y to use , N to exit");
                    string askUserForMore = Console.ReadLine();
                    if (askUserForMore.ToUpper() == "Y")
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (askUserForMore.ToUpper() == "N")
                    {
                        Console.WriteLine("Thank you for using the ATM app");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, Y to use , N to exit");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("The user does not exist");
                Console.WriteLine("Press Y to create new customer , or N to exit");
                string userInput = Console.ReadLine();
                if(userInput.ToUpper() == "Y")
                {
                    var arr = atm.AtmCustomers;
                    Array.Resize(ref arr, arr.Length+1);
                    atm.AtmCustomers = arr;
                    Console.WriteLine("Enter First Name");
                    string fName = Console.ReadLine();
                    Console.WriteLine("Enter Last Name");
                    string lName = Console.ReadLine();
                    Console.WriteLine("Enter pin");
                    bool isItNumber = int.TryParse(Console.ReadLine(), out int pin);
                    if (!isItNumber)
                    {
                        Console.WriteLine("Invalid input, enter a number");
                        return;
                    }
                    Console.WriteLine("Enter your card number");
                    isItNumber = long.TryParse(Console.ReadLine().Replace("-", ""), out long newCardNumber);
                    if (!isItNumber)
                    {
                        Console.WriteLine("invalid input, enter card number");
                        return;
                    }
                    Console.WriteLine("whats your balance");
                    isItNumber = int.TryParse(Console.ReadLine(), out int userBalance);
                    if (!isItNumber)
                    {
                        Console.WriteLine("Invalid input");
                        return;
                    }

                    arr[arr.Length-1] = new Customer(fName, lName, pin, newCardNumber, userBalance);
                    foreach(Customer customer in arr)
                    {
                        Console.WriteLine(customer.FirstName);
                    }
                }
                else if(userInput.ToUpper() == "N")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

            }




            Console.ReadLine();
        }
    }
}
