using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UC2_retrievetop3records;

namespace uc2_TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        List<ProductReview> productList;
        [TestInitialize]
        public void SetUp()
        {
            productList = new List<ProductReview>();
        }
        /// <summary>
        /// UC1--->Adding a Productreview details in list and returns the count
        /// </summary>
        [TestMethod]
        public void TestMethodForAddingDetailsInList()
        {
            int expected = 25;
            int actual = ProductReviewManager.AddingProductReview(productList);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// UC2--->Retrieve Top Three Records Whose Rating is High
        /// </summary>
        [TestMethod]
        public void TestMethodForRetrieveTopThreeRecord()
        {
            int expected = 3;

            var actual = ProductReviewManager.RetrieveTopThreeRating(productList);
            Assert.AreEqual(expected, actual);
        }
    }
}