using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.cSharp.Class06.Task03.Models
{
   public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Pin { get; private set; }
        public long CardNumber { get; set; }
        public int Ballance { get; set; }

        public Customer(string firstName, string lastName, int pin, long cardNumber, int ballance)
        {
            FirstName = firstName;
            LastName = lastName;
            Pin = pin;
            CardNumber = cardNumber;
            Ballance = ballance;
        }
    }
}
