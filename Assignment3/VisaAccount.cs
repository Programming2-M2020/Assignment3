using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class VisaAccount : Account, ITransaction
    {
        //field
        double CreditLimit;
        static double INTEREST_RATE = 0.1995;
        //constructor
        public VisaAccount(double balance = 0, double creditLimit = 1200) : base("VS-", balance) //It is calling the constructor of the Account class @Nahia
        {
            CreditLimit = creditLimit;            
        }
        // methods
        public void DoPayment(double amount, Person person)
        {
            Deposit(amount, person);
        }
        public void Withdraw(double amount, Person person) { }
        public void DoPurchase(double amount, Person person) 
        {
            if (!IsUser(person.Name))
            {
                throw new AccountException(ExceptionEnum.NAME_NOT_ASSOCIATED_WITH_ACCOUNT);
            }
            if (!(person.IsAuthenticated))
            {
                throw new AccountException(ExceptionEnum.USER_NOT_LOGGED_IN);
            }
            if (amount > Balance)
            {
                throw new AccountException(ExceptionEnum.CREDIT_LIMIT_HAS_BEEN_EXCEEDED);
            }
            Deposit(-amount, person);
        }
        public override void PrepareMonthlyReport()
        {
            double interest = (LowestBalance * INTEREST_RATE) / 12;
            Balance -= interest;
            transactions.Clear();
        }
        public override string ToString()
        {
            return base.ToString() + $"Credit Limit: ${CreditLimit}\n";
        }
    }
}
