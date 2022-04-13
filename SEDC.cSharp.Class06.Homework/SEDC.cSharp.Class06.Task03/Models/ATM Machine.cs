using System;

namespace SEDC.cSharp.Class06.Task03.Models
{
    public class ATM_Machine
    {
        public Customer[] AtmCustomers { get; set; }

        //Check if customer exists
        public  Customer GetCustomer(long cardNumber, int pin)
        {
            foreach(Customer customer in AtmCustomers)
            {
                if(customer.CardNumber == cardNumber && customer.Pin == pin)
                {
                    return customer;
                }
            }
            return null;
        }

        //Customer balance checking
        public void BalanceChecking(Customer customer)
        {
            Console.WriteLine($"Your balance is {customer.Ballance}$ ");
        }

        //Customer Cash Withdrawal
        public int CashWithrawal(Customer customer, int customerWithdrawal)
        {
            if(customer.Ballance >= customerWithdrawal)
            {
                Console.WriteLine($"You withdrew {customerWithdrawal}$. You have {customer.Ballance - customerWithdrawal}$ left on your account");
                return customer.Ballance - customerWithdrawal;
            }
            Console.WriteLine($"Sorry, you cant withdraw {customerWithdrawal}$, your ballance is {customer.Ballance}$");
            return customer.Ballance;    
        }

        //Customer Cash Deposit
        public int CashDeposit(Customer customer, int cashDeposit)
        {
            customer.Ballance += cashDeposit;
            Console.WriteLine($"Your new ballance is {customer.Ballance}$");
            return customer.Ballance;
        }

        // Create new customer
        
       



    }
}
