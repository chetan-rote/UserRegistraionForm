using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace UserRegistraionForm
{
    public class Pattern
    {
        ///Regex Pattern to validate User Name.
        public static string USER_NAME = "^[A-Z]{1}[a-zA-Z]{2,}";
        ///Regex Pattern to validate Email Id.
        public static string EMAIL_ADDRESS = "^[a-zA-Z0-9_+&*#$^!-]+(?:\\." +
                                             "[a-zA-Z0-9_+&*-]+)*@" +
                                             "(?:[a-zA-Z0-9-]+\\.)+[a-z" +
                                             "A-Z]{2,7}$";
        ///Regex Pattern to validate Mobile No.
        public static string MOBILE_NUMBER = "^([0]{0,1}[+]{0,1}[0-9]{0,2}[ ])?[7-9][0-9]{9}$";
        ///Regex Pattern to validate User Password.
        ///Password should have minimum 8 characters atleast 1 numberic number, 1 upper case,
        ///and exactly 1 special character.
        public static string PASSWORD = "^(?=.*[A-Z])(?=.*[0-9])(?=^[a-zA-Z0-9]*[!@#$%^&*()][a-zA-Z0-9]*$).{8,}$";


        /// <summary>
        /// Validate User Name using Lambda function
        /// </summary>
        public Func<string, string> ValidateUserName = x => (Regex.IsMatch(x, USER_NAME)) ? "User name is valid"
        : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_USER_NAME,
            "User Name is Invalid");

        /// <summary>
        /// Validate Email address using Lambda function.
        /// </summary>
        public Func<string, string> ValidateEmailAddress = x => Regex.IsMatch(x, EMAIL_ADDRESS) ? "Email Id Is Valid"
        : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_EMAIL_ADDRESS,
            "Email Id Is Invalid");

        /// <summary>
        /// Validates mobile number using Lambda function.
        /// </summary>
        public Func<string, string> ValidateMobileNumber = x => Regex.IsMatch(x, MOBILE_NUMBER) ? "Phone No Is Valid" 
        : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_MOBILE_NUMBER, 
            "Phone No Is Invalid");

        /// <summary>
        /// Validates Password using Lambda function.
        /// </summary>
        public Func<string, string> ValidatePassword = x => Regex.IsMatch(x, PASSWORD) ? "Password Is Valid" 
        : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_PASSWORD,
            "Password Is Invalid");
    }
}
