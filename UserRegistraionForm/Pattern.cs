using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistraionForm
{
    class Pattern
    {

        ///Regex Pattern to validate User Password.
        ///Rule 1 minimum 8 Charactres.
        public string PASSWORD = "^[0-9a-zA-Z._+-@#&*$]{8,}$";
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
