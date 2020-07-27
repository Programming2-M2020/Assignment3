
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
            bool toVerify = false;
            foreach (Person user in Bank.GetAccount(Number).users)
            {
                if (user.SIN == person.SIN || user.Name == person.Name)
                {
                    toVerify = true;
                    break;
                }
            }
            _ = toVerify ? toVerify : throw new AccountException(ExceptionEnum.NAME_NOT_ASSOCIATED_WITH_ACCOUNT.ToDescriptionString());
            if (!(person.IsAuthenticated))
            {
                throw new AccountException(ExceptionEnum.USER_NOT_LOGGED_IN.ToDescriptionString());
            }
            if (amount > Balance && !hasOverDraft)
            {
                throw new AccountException(ExceptionEnum.CREDIT_LIMIT_HAS_BEEN_EXCEEDED.ToDescriptionString() + " & " + ExceptionEnum.NO_OVERDRAFT.ToDescriptionString());
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
