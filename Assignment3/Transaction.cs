using System;
using System.Collections.Generic;
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
            return $"Account number {AccountNumber}/n Name of the person {Originator}/n The amount {Amount}" +
                  $"The time of transaction {Time}"; 
        }


    }
}
