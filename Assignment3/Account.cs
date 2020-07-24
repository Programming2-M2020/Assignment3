﻿using System;
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
        public Account(string type, double balance)
        {
            Number = type + LAST_NUMBER;
            ++LAST_NUMBER;
            Balance = balance;
            LowestBalance = balance;
        }
        public void Deposit(double amount, Person person)
        {
            /*public Transaction( string accountNumber, double amount, Person person, DateTime time )*/
            Balance += amount;
            LowestBalance = LowestBalance <= Balance ? LowestBalance : Balance;
            transactions.Add(new Transaction(Number, amount, person, DateTime.Now));
        }
        public void AddUser(Person person)
        {
            users.Add(person);
        }
        public bool IsUser(string name)
        {
            foreach (Person user in users)
            {
                if(user.Name == name)
                {
                    return true;
                } 
            }
            return false;
        }
        public abstract void PrepareMonthlyReport();
        public override string ToString()
        {
            string representation = "";
            foreach (Person user in users)
            {
                representation += "Account number: " + Number + "\nName: " + user.Name
                    + "\nBalance: " + Balance + "\nTransactions: \n";
                foreach(Transaction transaction in transactions)
                {
                    representation += transaction + "\n";
                }
            }
            return representation;
        }
    }
}
