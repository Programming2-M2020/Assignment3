using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    abstract class Account
    {
        public readonly List<Person> users = new List<Person>();
        public readonly List<Transaction> transactions = new List<Transaction>();
        static int LAST_NUMBER = 100000;

        public double Balance { get; protected set; }
        public double LowestBalance { get; protected set; }
        public string Number { get; }
    }
}
