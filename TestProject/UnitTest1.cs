using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using CSharpApp_5;

namespace TestProject
{
    [TestClass]
    public class ExtendedArrayCalculatorTests
    {
        [TestMethod]
        public void ShowEven_ShouldDisplayEvenValues()
        {
            // Arrange
            int[] testArray = { 2, 5, 8, 12, 15, 18, 22, 25 };
            ExtendedArrayCalculator extendedArrayCalculator = new ExtendedArrayCalculator(testArray);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                extendedArrayCalculator.ShowEven();

                // Assert
                string expectedOutput = "Even Values:\r\n2 8 12 18 22 \r\n";
                Assert.AreEqual(expectedOutput, sw.ToString());
            }
        }

        [TestMethod]
        public void ShowOdd_ShouldDisplayOddValues()
        {
            // Arrange
            int[] testArray = { 2, 5, 8, 12, 15, 18, 22, 25 };
            ExtendedArrayCalculator extendedArrayCalculator = new ExtendedArrayCalculator(testArray);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                extendedArrayCalculator.ShowOdd();

                // Assert
                string expectedOutput = "Odd Values:\r\n5 15 25 \r\n";
                Assert.AreEqual(expectedOutput, sw.ToString());
            }
        }
    }
}