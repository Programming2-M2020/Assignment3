
namespace Assignment3
{
    class CheckingAccount : Account, ITransaction
    {
        static double COST_PER_TRANSACTION = 0.05;
        static double INTEREST_RATE = 0.005;
        bool hasOverDraft;
        public CheckingAccount(double balance = 0, bool hasOverDraft = false) : base("CK-", balance)
        {
            this.hasOverDraft = hasOverDraft;
        }
        public new void Deposit(double amount, Person person)
        {
            base.Deposit(amount, person);
        }
        public void Withdraw(double amount, Person person)
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
            if (amount > Balance && !hasOverDraft)
            {
                throw new AccountException(ExceptionEnum.CREDIT_LIMIT_HAS_BEEN_EXCEEDED + " & " + ExceptionEnum.NO_OVERDRAFT);
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
    }
}
