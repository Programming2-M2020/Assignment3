
namespace Assignment3
{
    class CheckingAccount : Account, ITransaction
    {
        //FIELDS
        static double COST_PER_TRANSACTION = 0.05;
        static double INTEREST_RATE = 0.005;
        bool hasOverDraft;
        //CONSTRUCTOR
        public CheckingAccount(double balance = 0, bool hasOverDraft = false) : base("CK-", balance)
        {
            this.hasOverDraft = hasOverDraft;
        }
        //METHODS
        public new void Deposit(double amount, Person person)
        {
            base.Deposit(amount, person);
        }
        public void Withdraw(double amount, Person person)
        {
            if (!IsUser(person.Name))
            {
                throw new AccountException(ExceptionEnum.NAME_NOT_ASSOCIATED_WITH_ACCOUNT);
            }
            if (!(person.IsAuthenticated))
            {
                throw new AccountException(ExceptionEnum.USER_NOT_LOGGED_IN);
            }
            if (amount > Balance && !hasOverDraft)
            {
                throw new AccountException(ExceptionEnum.CREDIT_LIMIT_HAS_BEEN_EXCEEDED);
                throw new AccountException(ExceptionEnum.NO_OVERDRAFT);
            }
            base.Deposit(-amount, person);
        }
        public override void PrepareMonthlyReport()
        {
            double service_charge = transactions.Count * COST_PER_TRANSACTION;
            double interest = (LowestBalance * INTEREST_RATE) / 12;
            Balance += interest - service_charge;
            transactions.Clear();
        }
        public override string ToString()
        {
            return base.ToString() + "Overdraft: " + (hasOverDraft ? "Allowed\n" : "Not allowed\n");
        }
    }
}
