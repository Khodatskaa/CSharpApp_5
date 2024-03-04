using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    [TestClass]
    public class CustomArrayTests
    {
        [TestMethod]
        public void TestIMathMethods()
        {
            // Arrange
            CustomArray myCustomArray = new CustomArray(new int[] { 10, 5, 8, 15, 3 });

            // Act
            int maxValue = myCustomArray.Max();
            int minValue = myCustomArray.Min();
            float avgValue = myCustomArray.Avg();
            bool searchResultExisting = myCustomArray.Search(8);
            bool searchResultNonExisting = myCustomArray.Search(20);

            // Assert
            Assert.AreEqual(15, maxValue, "Max value should be 15");
            Assert.AreEqual(3, minValue, "Min value should be 3");
            Assert.AreEqual(8.2, avgValue, 0.1, "Average value should be 8.2 with 1 decimal point precision");
            Assert.IsTrue(searchResultExisting, "Search for existing value should return true");
            Assert.IsFalse(searchResultNonExisting, "Search for non-existing value should return false");
        }
    }
}
