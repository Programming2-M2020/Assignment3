
namespace Assignment3
{
    interface ITransaction
    {
        //METHODS TO BE IMPLEMENTED
        void Withdraw(double amount, Person person);
        void Deposit(double amount, Person person);
    }
}
