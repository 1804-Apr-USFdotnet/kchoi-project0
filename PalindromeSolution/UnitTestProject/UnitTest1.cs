using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PalindromeProject;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStripString()
        {
            string testString1 = "1never Odd, or Even1.";
            string testString2 = "1neveroddoreven1";
            Assert.AreEqual(testString2, Program.StripString(testString1));
        }

        [TestMethod]
        public void TestPalindrome()
        {
            //string testString = "Racecar";    //pass
            string testString = "never Odd, or Even.";  //pass
            //string testString = "1221";   //pass
            //string testString = "1321";   //fail
            //string testString = "";   //pass
            Assert.IsTrue(Program.CheckPalindrome(testString));
        }
    }
}
