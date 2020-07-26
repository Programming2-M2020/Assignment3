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

        [Description("This Account number doesn't exist")]
        USER_DOES_NOT_EXIST,

        [Description("User not logged in")]
        USER_NOT_LOGGED_IN
    }
    public class AccountException : Exception
    {
        public AccountException(string reason) : base(reason.ToString())
        {
        }
    }
    //this non-nested static class has a method for obtaining the description values from the enum
    public static class Extender
    {
        public static string ToDescriptionString(this ExceptionEnum errorEnum)
        {
            //this array gets the values of descriptions in the enum for the passed in errorEnum value
            //only one for
            DescriptionAttribute[] attributes = (DescriptionAttribute[])errorEnum
              .GetType()
              .GetField(errorEnum.ToString())
              .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes[0].Description;
        }
    }
}
