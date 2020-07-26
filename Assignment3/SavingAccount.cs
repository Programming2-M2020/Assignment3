using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
     class SavingAccount : Account , ITransaction
    {
        //FIELDS
        private static double COST_PER_TRANSACTION = 0.05;
        private static double INTEREST_RATE =0.015;

        //CONSTRUCTOR
        public SavingAccount(double balance = 0) : base("SV-", balance){}
        //METHODS
        public void Deposit(double amount, Person person)
        {
            base.Deposit(amount, person);
        }
        public void Withdraw(double amount , Person person)
        {
            foreach (Person user in Bank.GetAccount(Number).users)
            {
                if (user.SIN != person.SIN || user.Name != person.Name)
                {
                    throw new AccountException(ExceptionEnum.NAME_NOT_ASSOCIATED_WITH_ACCOUNT.ToString());
                }
            }
            if (!(person.IsAuthenticated))
            {
                throw new AccountException(ExceptionEnum.USER_NOT_LOGGED_IN.ToString());
            }
            if (amount > Balance)
            {
                throw new AccountException(ExceptionEnum.CREDIT_LIMIT_HAS_BEEN_EXCEEDED.ToString());
            }
            base.Deposit(-amount, person);
        }
        public override void PrepareMonthlyReport()
        {
            double serviceCharge = transactions.Count * COST_PER_TRANSACTION;
            double interest = (LowestBalance * INTEREST_RATE) / 12;
            Balance += interest;
            Balance -= serviceCharge;
            transactions.Clear();
        }
    }
}
