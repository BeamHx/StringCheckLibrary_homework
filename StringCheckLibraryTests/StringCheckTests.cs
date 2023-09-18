using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StringCheckLibrary;

namespace StringCheckLibraryTests
{
    [TestClass]
    public class StringCheckTests
    {
        [TestMethod]
        public void CheckName_IsEmpty_ReturnedFalse()
        {
            //Arrange
            string stringName = "";
            //Act
            StringCheck obj = new StringCheck();
            bool result = obj.CheckName(stringName);
            //Asert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckName_Symbol_ReturnedFalse()
        {
            //Arrange
            string stringName = "@";
            //Act
            StringCheck obj = new StringCheck();
            bool result = obj.CheckName(stringName);
            //Asert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckName_WhiteSpace_ReturnedFalse()
        {
            //Arrange
            string stringName = " ";
            //Act
            StringCheck obj = new StringCheck();
            bool result = obj.CheckName(stringName);
            //Asert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckName_RussianLetters_ReturnedTrue()
        {
            //Arrange
            string stringName = "ффф";
            //Act
            StringCheck obj = new StringCheck();
            bool result = obj.CheckName(stringName);
            //Asert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckName_RussianLettersWithAcceptSymbol_ReturnedTrue()
        {
            //Arrange
            string stringName = "ффф-ф фф";
            //Act
            StringCheck obj = new StringCheck();
            bool result = obj.CheckName(stringName);
            //Asert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckName_BigRussianLettersString_ReturnedFalse()
        {
            //Arrange
            string stringName = "ааааааааааааааааааааааааааааааааааааааааааааааааааааа";
            //Act
            StringCheck obj = new StringCheck();
            bool result = obj.CheckName(stringName);
            //Asert
            Assert.IsFalse(result);
        }
    }
}
