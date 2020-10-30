/******************************************************************************
 *  Purpose: User Registration System Ensures all validations are in place
 *           during User Entry.   
 *
 *  @author  Chetan
 *  @version 1.0
 *  @since   26-10-2020
 *  
 ******************************************************************************/
using System;

namespace UserRegistraionForm
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to User registration form...!");
            Pattern pattern = new Pattern();
            ///Reads passsword from user.
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();            
            Console.WriteLine(pattern.ValidatePassword(password));
        }
    }
}
