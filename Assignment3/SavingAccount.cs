
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
        public new void Deposit(double amount, Person person)
        {
            base.Deposit(amount, person);
        }
        public void Withdraw(double amount , Person person)
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
