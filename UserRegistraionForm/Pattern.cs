using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistraionForm
{
    class Pattern
    {
        ///Regex Pattern to validate User Name.
        public static string USER_NAME = "^[A-Z]{1}[a-zA-Z]{2,}";
        ///Regex Pattern to validate Email Id.
        public static string EMAIL_ADDRESS = "^[a-zA-Z0-9_+&*#$^!-]+(?:\\." +
                                             "[a-zA-Z0-9_+&*-]+)*@" +
                                             "(?:[a-zA-Z0-9-]+\\.)+[a-z" +
                                             "A-Z]{2,7}$";
        ///Regex Pattern to validate Mobile No.
        public static string MOBILE_NUMBER = "^([0]{0,1}[+]{0,1}[91]{0,2})?[7-9][0-9]{9}$";
        ///Regex Pattern to validate User Password.
        ///Password should have minimum 8 characters atleast 1 numberic number, 1 upper case,
        ///and exactly 1 special character.
        public static string PASSWORD = "^(?=.*[A-Z])(?=.*[0-9])(?=^[a-zA-Z0-9]*[!@#$%^&*()][a-zA-Z0-9]*$).{8,}$";

        /// <summary>
        /// Validates the user name with regex pattern
        /// First letter Capital and rest small.
        /// </summary>
        /// <param name="userName">The user name.</param>
        /// <returns>True or false.</returns>
        public bool ValidateUserName(string userName)
        {
            return Regex.IsMatch(userName, USER_NAME);
        }
        /// <summary>
        /// Validates the Email address with regex pattern.        
        /// </summary>
        /// <param name="emailAddress">The last name.</param>
        /// <returns>True or false.</returns>
        public bool ValidateEmailAddress(string emailAddress)
        {
            return Regex.IsMatch(emailAddress, EMAIL_ADDRESS);
        }
        /// <summary>
        /// Validates the mobile number with regex pattern.
        /// Indian 10 digit mobile numbers
        /// </summary>
        /// <param name="mobileNumber">The Mobile Number.</param>
        /// <returns>True or false.</returns>
        public bool ValidateMobileNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, MOBILE_NUMBER);
        }
        /// <summary>
        /// Validates the Password with regex pattern.        
        /// </summary>
        /// <param name="password">The Password.</param>
        /// <returns>True or false.</returns>
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, PASSWORD);
        }        
    }
}
