using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Bank
    {
        //FIELDS
        public static readonly List<ITransaction> ACCOUNTS = new List<ITransaction>();
        public static readonly List<Person> USERS = new List<Person>();

        //CONSTRUCTOR
        static Bank()
        {
            //initialize the USERS collection
            USERS = new List<Person>(){
            new Person("Narendra", "1234-5678"),  //0
            new Person("Ilia", "2345-6789"),      //1
            new Person("Tom", "3456-7890"),       //2
            new Person("Syed", "4567-8901"),      //3
            new Person("Arben", "5678-9012"),     //4
            new Person("Patrick", "6789-0123"),   //5
            new Person("Yin", "7890-1234"),       //6
            new Person("Hao", "8901-2345"),       //7
            new Person("Jake", "9012-3456"),      //8
            new Person("Joanne", "1224-5678"),    //9
            new Person("Nicoletta", "2344-6789"), //10
            };


            //initialize the ACCOUNTS collection
            ACCOUNTS = new List<Account>{
            new VisaAccount(),              //VS-100000
            new VisaAccount(150, -500),     //VS-100001
            new SavingAccount(5000),        //SV-100002
            new SavingAccount(),            //SV-100003
            new CheckingAccount(2000),      //CK-100004
            new CheckingAccount(1500, true),//CK-100005
            new VisaAccount(50, -550),      //VS-100006
            new SavingAccount(1000),        //SV-100007
            };
            //associate users with accounts
            ACCOUNTS[0].AddUser(USERS[0]);
            ACCOUNTS[0].AddUser(USERS[1]);
            ACCOUNTS[0].AddUser(USERS[2]);

            ACCOUNTS[1].AddUser(USERS[3]);
            ACCOUNTS[1].AddUser(USERS[4]);
            ACCOUNTS[1].AddUser(USERS[5]);

            ACCOUNTS[2].AddUser(USERS[6]);
            ACCOUNTS[2].AddUser(USERS[7]);
            ACCOUNTS[2].AddUser(USERS[8]);

            ACCOUNTS[3].AddUser(USERS[9]);
            ACCOUNTS[3].AddUser(USERS[10]);

            ACCOUNTS[4].AddUser(USERS[2]);
            ACCOUNTS[4].AddUser(USERS[4]);
            ACCOUNTS[4].AddUser(USERS[6]);

            ACCOUNTS[5].AddUser(USERS[8]);
            ACCOUNTS[5].AddUser(USERS[10]);

            ACCOUNTS[6].AddUser(USERS[1]);
            ACCOUNTS[6].AddUser(USERS[3]);

            ACCOUNTS[7].AddUser(USERS[5]);
            ACCOUNTS[7].AddUser(USERS[7]);

        }
        //METHODS
        public static ITransaction GetAccount(string number)
        {

        }
        public static Person GetPerson(string name)
        {
            foreach (Person per in USERS)
            { 
                
            }
        }
        public static void PrintAccounts()
        {
            foreach (Account acco in ACCOUNTS)
            {
                Console.WriteLine(acco);
            }
        }
        public static void PrintPersons()
        {
            foreach (Person per in USERS)
            {
                Console.WriteLine(per);
            }
        }
    }
}
