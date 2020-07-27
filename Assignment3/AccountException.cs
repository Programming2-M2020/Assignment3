using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Assignment3
{
    public enum ExceptionEnum
    {
        [Description("This Account number doesn't exist")]
        ACCOUNT_DOES_NOT_EXIST,

        [Description("The credit limit has been exceeded")]
        CREDIT_LIMIT_HAS_BEEN_EXCEEDED,

        [Description("Name given is not associated with the account")]
        NAME_NOT_ASSOCIATED_WITH_ACCOUNT,

        [Description("No overdraft for this account")]
        NO_OVERDRAFT,

        [Description("Incorrect password")]
        PASSWORD_INCORRECT,

        [Description("This user doesn't exist")]
        USER_DOES_NOT_EXIST,

        [Description("User not logged in")]
        USER_NOT_LOGGED_IN
    }
    public class AccountException : Exception
    {
        public AccountException(ExceptionEnum reason) : base(reason.ToDescriptionString())
        {
        }
    }
    //this non-nested static class has a method for obtaining the description values from the enum
    public static class Extender
    {
        public static string ToDescriptionString(this ExceptionEnum errorEnum)
        {
            /*This method is called an extension method that extends the functionality of
             * the enum. Here, the GetType method gets the type which is ExceptionEnum.
             * Nextly, the GetField method obtains the name of the enum field that called
             * this method. Finally, the GetCustomAttributes obtains the value of the 
             * description attribute for the field that called this method and returns
             * an array containing the same. (in our case, only one element is present)
             */
            DescriptionAttribute[] attributes = (DescriptionAttribute[])errorEnum
              .GetType()
              .GetField(errorEnum.ToString())
              .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes[0].Description;
        }
    }
}
