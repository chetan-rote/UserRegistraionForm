using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistraionForm;
namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Givens the correct user name should return true or false.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="expectedResult">if set to <c>true</c> [expected result].</param>
        [TestMethod]
        [DataRow("Chetan Rote", true)]
        [DataRow("chetanrote", false)]
        [DataRow("ch", false)]
        public void GivenCorrectUserName_Should_Return_TrueOrFalse(string userName, bool expectedResult)
        {           
            ///Act
            Pattern pattern = new Pattern();
            var result = pattern.ValidateUserName(userName);

            ///Assert            
            Assert.AreEqual(expectedResult, result);
        }
        /// <summary>
        /// Givens the email address should return true or false.
        /// </summary>
        /// <param name="emailAddress">The email address.</param>
        /// <param name="expectedResult">if set to <c>true</c> [expected result].</param>
        [TestMethod]
        [DataRow("abc@gmail.com", true)]
        [DataRow("abc@gmail.co.in", true)]
        [DataRow("abc.xyz@gmail.com", true)]
        [DataRow("abc.xyz.pqr@gmail.com", true)]        
        [DataRow("abc@.com", false)]
        [DataRow("abcgmail.com", false)]
        [DataRow(".abc@gmail.com", false)]
        public void GivenEmailAddress_Should_Return_TrueOrFalse(string emailAddress, bool expectedResult)
        {
            ///Act
            Pattern pattern = new Pattern();
            var result = pattern.ValidateEmailAddress(emailAddress);

            ///Assert
            Assert.AreEqual(expectedResult, result);
        }
        /// <summary>
        /// Givens the mobile number should return true or false.
        /// </summary>
        /// <param name="mobileNumber">The mobile number.</param>
        /// <param name="expectedResult">if set to <c>true</c> [expected result].</param>
        [TestMethod]
        [DataRow("+918822446699", true)]
        [DataRow("8822446699", true)]
        [DataRow("918822446699", true)]
        [DataRow("91 0876765432", false)]
        [DataRow("769876342135", false)]
        [DataRow("12 587676547", false)]
        public void GivenMobileNumber_Should_Return_TrueOrFalse(string mobileNumber, bool expectedResult)
        {
            ///Act
            Pattern pattern = new Pattern();
            var result = pattern.ValidateMobileNumber(mobileNumber);

            ///Assert
            Assert.AreEqual(expectedResult, result);
        }
        /// <summary>
        /// Givens the password should retrun true or false.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <param name="expectedResult">if set to <c>true</c> [expected result].</param>
        [TestMethod]
        [DataRow("ABCab123@", true)]
        [DataRow("abc", false)]
        [DataRow("abcdefgh", false)]
        [DataRow("ABCab@abc", false)]
        [DataRow("abc123ABC", false)]
        [DataRow("abc@ABC12#", false)]
        public void GivenPassword_Should_Retrun_TrueOrFalse(string password, bool expectedResult)
        {
            ///Act
            Pattern pattern = new Pattern();
            var result = pattern.ValidatePassword(password);

            ///Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
