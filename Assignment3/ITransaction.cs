using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    interface ITransaction
    {
        void Withdraw(double amount, Person person);
        void Deposit(double amount, Person person);
    }
}
