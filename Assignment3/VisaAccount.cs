using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class VisaAccount : Account, ITransaction
    {
        //field
        private double CreditLimit;
        private static double INTEREST_RATE = 0.1995;
        //constructor
        public VisaAccount(double balance = 0, double creditLimit = 1200) : base("SV-", balance) { } // I dont understand the last part
        // methods
        public void DoPayment(double amount, Person person)
        {
            base.Deposit(amount, person);
        }
        public void DoPurchase(double amount, Person person) // I copied from saving accout class
        {
            if (!(person.IsAuthenticated))
            {
                throw new AccountException(ExceptionEnum.USER_NOT_LOGGED_IN.ToDescriptionString());
            }
            if (amount > Balance)
            {
                throw new AccountException(ExceptionEnum.CREDIT_LIMIT_HAS_BEEN_EXCEEDED.ToDescriptionString());
            }
            base.Deposit(-amount, person);
        }
        public void PrepareMonthlyReport(double amount, Person person)
        {
            // nothing is mentioned in the assignement
        }
        public override void PrepareMonthlyReport()
        {
            double interest = (LowestBalance * INTEREST_RATE) / 12;
            Balance -= interest;
            transactions.Clear();

        }
        // this method is for IT transaction interface. I just try potential fixes.otherwise IT transaction showing error
        public void Withdraw(double amount, Person person)
        {
            throw new NotImplementedException();
        }
    }
}
