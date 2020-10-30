using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistraionForm
{
    class Pattern
    {        
        //Regex Pattern to validate Email Id.
        public string EMAIL_ADDRESS = "^[a-zA-Z0-9_+&*#$^!-]+(?:\\." +
                                      "[a-zA-Z0-9_+&*-]+)*@" +
                                      "(?:[a-zA-Z0-9-]+\\.)+[a-z" +
                                      "A-Z]{2,7}$";
        /// <summary>
        /// Validates the Email address with regex pattern.        
        /// </summary>
        /// <param name="emailAddress">The Email Address.</param>
        /// <returns>True or false.</returns>
        public bool ValidateEmailAddress(string emailAddress)
        {
            return Regex.IsMatch(emailAddress, EMAIL_ADDRESS);
        }
    }
}
