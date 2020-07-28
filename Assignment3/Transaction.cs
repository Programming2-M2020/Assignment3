using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Assignment3
{
    class Transaction
    {
        //PROPERTIES
        public string AccountNumber {get;}
        public double Amount {get;}
        public Person Originator {get;}
        public DateTime Time {get;}

        //CONSTRUCTOR
        public Transaction(string accountNumber, double amount, Person person, DateTime time)
        {
            AccountNumber = accountNumber;
            Amount = amount;
            Originator = person;
            Time = time;
        }
        //METHODS
        public override string ToString()
        {
            return $"{Originator.Name} " + (Amount < 0d ? $"withdrew ${-Amount} from " : $"deposited ${Amount} to ") + $"Account number " +
                $"{AccountNumber} on {Time.ToShortDateString()} at {Time.ToShortTimeString()}";
        }


    }
}
