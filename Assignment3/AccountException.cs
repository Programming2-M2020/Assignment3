using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    enum ExceptionEnum
    {
        ACCOUNT_DOES_NOT_EXIST,
        CREDIT_LIMIT_HAS_BEEN_EXCEEDED,
        NAME_NOT_ASSOCIATED_WITH_ACCOUNT,
        NO_OVERDRAFT,
        PASSWORD_INCORRECT,
        USER_DOES_NOT_EXIST,
        USER_NOT_LOGGED_IN

    }
    
       
        public class AccountException : Exception
        {
            public AccountException(string reason) : base(reason.ToString()) 
            {
            //switch ()
            //{
            //    case ExceptionEnum.ACCOUNT_DOES_NOT_EXIST:
            //        Console.WriteLine("Your Account number doesn't exist");
            //        break;
            //    case ExceptionEnum.CREDIT_LIMIT_HAS_BEEN_EXCEEDED:
            //        Console.WriteLine("Your credit limit has been exceeded");
            //        break;
            //    case ExceptionEnum.NAME_NOT_ASSOCIATED_WITH_ACCOUNT:
            //        Console.WriteLine("Name entered does not match with the account");
            //        break;
            //    case ExceptionEnum.NO_OVERDRAFT:
            //        Console.WriteLine("No overdraft");
            //        break;
            //    case ExceptionEnum.PASSWORD_INCORRECT:
            //        Console.WriteLine("The password entered is incorrect");                  
            //        break;
            //    case ExceptionEnum.USER_DOES_NOT_EXIST:
            //        Console.WriteLine("The user entered doesn't exist");
            //        break;
            //    case ExceptionEnum.USER_NOT_LOGGED_IN:
            //        Console.WriteLine("User not logged in");
            //        break;
            //    default:
            //        break;
            //}
        }

          
        }
        
    
}
