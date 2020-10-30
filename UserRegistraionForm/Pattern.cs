using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistraionForm
{
    class Pattern
    {
        //Regex Pattern to validate First Name.
        public string FIRST_NAME = "^[A-Z][a-zA-Z]{3,}";
        /// <summary>
        /// Validates the first name with regex pattern
        /// First letter Capital and rest small.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <returns>True or false.</returns>
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, FIRST_NAME);
        }
    }
}
