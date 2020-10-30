using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistraionForm
{
    class Pattern
    {

        ///Regex Pattern to validate User Password.
        ///Rule 3 atleast 1 numeric number in password.
        public string PASSWORD = "^(?=.*[A-Z])(?=.*[0-9])[0-9a-zA-Z._+-@#&*$]{8,}$";
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
