using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistraionForm;

namespace UserRegistrationMSTest
{
    [TestClass]
    public class UserRegistrationTest
    {
                /// <summary>
        /// Validates the user name should return true.
        /// </summary>
        [TestMethod]        
        //[DataRow("chetanrote",false)]
        //[DataRow("Chetan Rote",true)]
        //[DataRow("chetan", false)]
        //[DataRow("ch", false)]
        public void ValidateUserName_ShouldReturnBoolean(string userName)
        {
            ////Arrange
            userName = "Chetan Rote";
            Pattern pattern = new Pattern();
            ///Act
            var result = pattern.ValidateUserName(userName);
            ///Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Validates the email address should return boolean.
        /// </summary>
        /// <param name="emailAddress">The email address.</param>
        [TestMethod]
        [DataRow("abc@gmail.com", true)]
        [DataRow(".abc@gmail.com", false)]
        public void ValidateEmailAddress_ShouldReturnBoolean(string emailAddress)
        {
            ////Arrange
            Pattern pattern = new Pattern();
            ///Act
            var result = pattern.ValidateEmailAddress(emailAddress);
            ///Assert
            Assert.IsTrue(result);
        }
    }
}
