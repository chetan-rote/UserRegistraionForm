using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistraionForm
{
    class Pattern
    {
        ///Regex Pattern to validate Mobile No.
        public string MOBILE_NUMBER = "^([0]{0,1}[+]{0,1}[91]{0,2})?[7-9][0-9]{9}$";
        /// <summary>
        /// Validates the mobile number with regex pattern.        
        /// </summary>
        /// <param name="mobileNumber">The Mobile Number.</param>
        /// <returns>True or false.</returns>
        public bool ValidateMobileNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, MOBILE_NUMBER);
        }
    }
}
