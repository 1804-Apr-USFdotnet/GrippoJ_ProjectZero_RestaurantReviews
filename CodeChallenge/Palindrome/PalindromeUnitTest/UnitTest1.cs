using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace PalindromeUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string inputStr = "Race car";
            string answer = "racecar";

            string notCaseSensitive = inputStr.ToLower();

            Stripper test = new Stripper();
            String outputStr = test.StripNonAlphaNumeric(inputStr.Replace(" ", ""));
            Pal pMoney = new Pal();
            pMoney.checkPalindrome(outputStr);
            Assert.AreEqual(pMoney.palString, notCaseSensitive);
        }
    }
}
