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
        public SavingAccount(double balance = 0)
        {
            
        }
        //METHODS
        public void Deposit(double amount, Person person)
        {
            
        }
        public void Withdraw(double amount , Person person)
        { 
        
        }
        public void PrepareMonthlyReport(double amount, Person person)
        { 
          
        }
    }
}
