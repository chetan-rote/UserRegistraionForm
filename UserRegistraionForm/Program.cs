﻿/******************************************************************************
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
            
            ///Reads User Name from user.
            Console.WriteLine("Enter Last Name");
            string userName = Console.ReadLine();
            Console.WriteLine(pattern.ValidateUserName(userName));
            ///Reads Email address from user.
            Console.WriteLine("Enter Email Address");
            string emailAddress = Console.ReadLine();
            Console.WriteLine(pattern.ValidateEmailAddress(emailAddress));
            ///Reads Mobile number from user.
            Console.WriteLine("Enter your mobile number.");
            string mobileNumber = Console.ReadLine();
            Console.WriteLine(pattern.ValidateMobileNumber(mobileNumber));
            ///Reads passsword from user.
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();            
            Console.WriteLine(pattern.ValidatePassword(password));         
        }
    }
}
