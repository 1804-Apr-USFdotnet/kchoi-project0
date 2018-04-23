using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using LibraryProject;

namespace Project0Test
{
    [TestClass]
    public class ReviewerTest
    {
        Reviewer reviewer;
        const string name = "John Doe";
        const int id = 0;

        [TestMethod]
        public void TestReviewerName()
        {
            reviewer = new Reviewer(0, name);
            Assert.AreEqual(reviewer.Name, name);
        }

        [TestMethod]
        public void TestReviewerID()
        {
            reviewer = new Reviewer(0, name);
            Assert.AreEqual(reviewer.ID, id);
        }
    }
}
