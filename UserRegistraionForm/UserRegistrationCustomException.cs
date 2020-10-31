using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistraionForm
{
    public class UserRegistrationCustomException : Exception
    {
        public enum ExceptionType
        { 
            INVALID_USER_NAME,
            INVALID_EMAIL_ADDRESS,
            INVALID_MOBILE_NUMBER,
            INVALID_PASSWORD
        }
        ExceptionType type;
        public UserRegistrationCustomException(ExceptionType Type, string messgae) : base(messgae)
        {
            this.type = Type;
        }
    }
}
