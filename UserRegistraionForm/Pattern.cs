using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistraionForm
{
    class Pattern
    {
        //Regex Pattern to validate Last Name.
        public string LAST_NAME = "^[A-Z]{1,}[a-zA-Z]{2,}$";
        /// <summary>
        /// Validates the last name with regex pattern
        /// First letter Capital and rest small.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        /// <returns>True or false.</returns>
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, LAST_NAME);
        }
    }
}
