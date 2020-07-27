using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Assignment3
{
    class Transaction
    {
        public string AccountNumber {get;}
        public double Amount {get;}
        public Person Originator {get;}
        public DateTime Time {get;}

        public Transaction(string accountNumber, double amount, Person person, DateTime time)
        {
            AccountNumber = accountNumber;
            Amount = amount;
            Originator = person;
            Time = time;
        }
        public override string ToString()
        {
            return $"{Originator.Name} " + (Amount < 0d ? $"withdrew ${-Amount} from " : $"deposited ${Amount} to ") + $"Account number " +
                $"{AccountNumber} on {Time.ToShortTimeString()}";
        }


    }
}
