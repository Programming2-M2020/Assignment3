
namespace Assignment3
{
    class Person
    {
        string password;
        public string SIN { get; }
        public bool IsAuthenticated { get; private set; }
        public string Name { get; }
        public Person(string name, string sin)
        {
            Name = name;
            SIN = sin;
            password = SIN.Substring(0, 3);
        }
        public void Login(string password)
        {
            if (this.password != password)
            {
                IsAuthenticated = false;
                throw new AccountException(AccountEnum.PASSWORD_INCORRECT);
            }
            IsAuthenticated = true;
        }
        public void Logout()
        {
            IsAuthenticated = false;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
